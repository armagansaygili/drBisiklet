using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;


namespace doktorBisiklet
{
    public partial class bakimListesi : Form
    {
        public bakimListesi()
        {
            InitializeComponent();
        }
        Mysql.SqlConnection sqlconnection = new Mysql.SqlConnection();

        public void Datagetir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT bakim_id,mus_ad,mus_sad,urun_marka,urun_model,islemler,ucret,mus_tel,talma_tarih,urun_durum,mus_email,avans FROM musteri INNER JOIN bakim_listesi ON musteri.mus_id = bakim_listesi.mus_id where urun_durum=0", sqlconnection.baglan());
            DataTable ds = new DataTable();

            da.Fill(ds);
            bakimListesiDg.DataSource = ds;

        }

        public void Datagrid_ayar()
        {
            bakimListesiDg.Columns[0].HeaderText = "Bakım Numarası";
            bakimListesiDg.Columns[1].HeaderText = "Ad";
            bakimListesiDg.Columns[2].HeaderText = "Soyad";
            bakimListesiDg.Columns[3].HeaderText = "Marka";
            bakimListesiDg.Columns[4].HeaderText = "Model";
            bakimListesiDg.Columns[5].HeaderText = "İşlemler";
            bakimListesiDg.Columns[6].HeaderText = "Ücret";
            bakimListesiDg.Columns[7].HeaderText = "Telefon";
            bakimListesiDg.Columns[8].HeaderText = "Teslim alma tarihi";
            bakimListesiDg.Columns[9].Visible = false;
            bakimListesiDg.Columns[10].Visible = false;
            bakimListesiDg.Columns[11].Visible = false;





            Font HeaderCellFont = new Font("Cambria", 9, FontStyle.Bold);
            for (int i = 0; i < bakimListesiDg.ColumnCount; i++)
            {
                bakimListesiDg.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }

            bakimListesiDg.DefaultCellStyle.Font = new Font("Cambria", 9, FontStyle.Regular);
        }


        private void bakimListesi_Load(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("Select bakim from bakim_fiyat_listesi", sqlconnection.baglan());
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                islemListbox.Items.Add(dataReader["bakim"]);
            }

            Datagetir();
            Datagrid_ayar();

        }

        private void bakimBitirTbx_Click(object sender, EventArgs e)
        {

            if (bakimListesiDg.CurrentRow != null)
            {
                int r_id = Convert.ToInt32(bakimListesiDg.CurrentRow.Cells["bakim_id"].Value);
                string ucret = Convert.ToString(bakimListesiDg.CurrentRow.Cells["ucret"].Value);
                string email = bakimListesiDg.CurrentRow.Cells["mus_email"].Value.ToString();

                if (ucret != "")
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("Update bakim_listesi set urun_durum=1 where bakim_id=" + r_id, sqlconnection.baglan());
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    Datagetir();

                    sendMail sendMail = new sendMail();
                    sendMail.mailGonder(email, "Bisikletiniz Hazır!", "Servisimize bırakmış olduğunuz bisikletinizin bakım işlemi tamamlanmıştır. İşlem ücreti " + ucret + "₺'dir.");
                }
                else
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("Update bakim_listesi set urun_durum=1 where bakim_id=" + r_id, sqlconnection.baglan());
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    Datagetir();

                    sendMail sendMail = new sendMail();
                    sendMail.mailGonder(email, "Bisikletiniz Hazır!", "Servisimize bırakmış olduğunuz bisikletinizin bakım işlemi tamamlanmıştır.");
                }

            }



        }

        private void bakimIptalTbx_Click(object sender, EventArgs e)
        {
            if (bakimListesiDg.CurrentRow != null)
            {
                int r_id = Convert.ToInt32(bakimListesiDg.CurrentRow.Cells["bakim_id"].Value);
                MySqlCommand mySqlCommand = new MySqlCommand("Delete from bakim_listesi where bakim_id=" + r_id, sqlconnection.baglan());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Datagetir();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (musAdTbx.Text != "" && musSadTbx.Text != "")
            {

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT bakim_id, mus_ad, mus_sad, urun_marka, urun_model, islemler, ucret, mus_tel, teslim_alan, talma_tarih, urun_durum FROM musteri INNER JOIN bakim_listesi ON musteri.mus_id = bakim_listesi.mus_id where urun_durum = 0 and mus_ad like '" + musAdTbx.Text + "%' and mus_sad like '" + musSadTbx.Text + "%'", sqlconnection.baglan());
                MySqlDataAdapter da = mySqlDataAdapter;
                DataTable ds = new DataTable();
                da.Fill(ds);
                bakimListesiDg.DataSource = ds;
            }
            else if (musAdTbx.Text != "" && musSadTbx.Text == "")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT bakim_id, mus_ad, mus_sad, urun_marka, urun_model, islemler, ucret, mus_tel, talma_tarih, urun_durum FROM musteri INNER JOIN bakim_listesi ON musteri.mus_id = bakim_listesi.mus_id where urun_durum = 0 and mus_ad like '" + musAdTbx.Text + "%'", sqlconnection.baglan());
                DataTable ds = new DataTable();
                da.Fill(ds);
                bakimListesiDg.DataSource = ds;
            }
            else if (musAdTbx.Text == "" && musSadTbx.Text != "")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT bakim_id, mus_ad, mus_sad, urun_marka, urun_model, islemler, ucret, mus_tel, teslim_alan, talma_tarih, urun_durum FROM musteri INNER JOIN bakim_listesi ON musteri.mus_id = bakim_listesi.mus_id where urun_durum = 0 and mus_Sad like '" + musSadTbx.Text + "%'", sqlconnection.baglan());
                DataTable ds = new DataTable();
                da.Fill(ds);
                bakimListesiDg.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Arama kriteri giriniz!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32(bakimListesiDg.CurrentRow.Cells["bakim_id"].Value);
            string islem = bakimListesiDg.CurrentRow.Cells["islemler"].Value.ToString();

            if (ucretEkle.Text != "")
            {

                for (int i = 0; i < islemListbox.CheckedItems.Count; i++)
                {

                    if (islem == "")
                    {
                        islem = islemListbox.CheckedItems[i].ToString();
                    }
                    else
                    {
                        islem = islem + "," + islemListbox.CheckedItems[i].ToString();
                    }
                    
                }
                MySqlCommand mySqlCommand = new MySqlCommand("Update bakim_listesi set ucret=" + ucretEkle.Text + ",islemler='" + islem + "' where bakim_id=" + r_id, sqlconnection.baglan());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Datagetir();
            }
            else
            {
                for (int i = 0; i < islemListbox.CheckedItems.Count; i++)
                {

                    if (islem == "")
                    {
                        islem = islemListbox.CheckedItems[i].ToString();
                    }
                    else
                    {
                        islem = islem + "," + islemListbox.CheckedItems[i].ToString();
                    }
                    
                }
                MySqlCommand mySqlCommand = new MySqlCommand("Update bakim_listesi set islemler='" + islem + "' where bakim_id=" + r_id, sqlconnection.baglan());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Datagetir();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string m_ad = bakimListesiDg.CurrentRow.Cells["mus_ad"].Value.ToString();
            string m_sad = bakimListesiDg.CurrentRow.Cells["mus_sad"].Value.ToString();
            string m_tel = bakimListesiDg.CurrentRow.Cells["mus_tel"].Value.ToString();
            string marka = bakimListesiDg.CurrentRow.Cells["urun_marka"].Value.ToString();
            string model = bakimListesiDg.CurrentRow.Cells["urun_model"].Value.ToString();
            string kimlik = marka + " " + model;
            string ucret = bakimListesiDg.CurrentRow.Cells["ucret"].Value.ToString();
            string avans = bakimListesiDg.CurrentRow.Cells["avans"].Value.ToString();


            int kaydir = 0;
            //font,kalem,firca ayarlari
            Font font = new Font("Arial", 12);
            Font fontBaslik = new Font("Arial", 12, FontStyle.Bold);
            Font fontBaslikDrBis = new Font("Arial", 18, FontStyle.Bold);
            SolidBrush firca = new SolidBrush(Color.Black);
            SolidBrush fircaImza = new SolidBrush(Color.LightSlateGray);
            Pen pen = new Pen(Color.Black);
            try
            {

                for (int i = 0; i < 2; i++)
                {
                    int islemAdet = islemListbox.CheckedItems.Count;
                    //int kaydirma = islemAdet * 20;
                    if (i == 0)
                    {
                        kaydir = 0;
                    }
                    if (i == 1)
                    {
                        kaydir = 570;
                    }

                    //baslik tablo cizimleri
                    e.Graphics.DrawLine(pen, 30, 15 + kaydir, 797, 15 + kaydir);
                    e.Graphics.DrawLine(pen, 30, 15 + kaydir, 30, 145 + kaydir);
                    e.Graphics.DrawLine(pen, 797, 15 + kaydir, 797, 145 + kaydir);
                    e.Graphics.DrawLine(pen, 30, 145 + kaydir, 797, 145 + kaydir);
                    System.Drawing.Image img = System.Drawing.Image.FromFile("C:\\Program Files (x86)\\Armsaygili\\drBisikletSetup\\drbisiklet.jpg"); //baslik logosu
                    e.Graphics.DrawImage(img, 45, 30 + kaydir, img.Width, img.Height);

                    //baslik icerigi
                    e.Graphics.DrawString("DR. BİSİKLET", fontBaslikDrBis, firca, 145, 35 + kaydir);
                    e.Graphics.DrawString("Esentepe Mh. Okul Cd. No:5/A Nilüfer/BURSA", font, firca, 145, 60 + kaydir);
                    e.Graphics.DrawString("Tel", font, firca, 145, 75 + kaydir);
                    e.Graphics.DrawString(": 0224 245 80 89", font, firca, 195, 75 + kaydir);
                    e.Graphics.DrawString("Gsm", font, firca, 145, 90 + kaydir);
                    e.Graphics.DrawString(": 553 395 03 56", font, firca, 195, 90 + kaydir);
                    e.Graphics.DrawString("e-mail", font, firca, 145, 105 + kaydir);
                    e.Graphics.DrawString(": dr.ramazan@hotmail.com", font, firca, 195, 105 + kaydir);

                    //bilgi tablosu cizimi
                    e.Graphics.DrawLine(pen, 30, 160 + kaydir, 797, 160 + kaydir);
                    e.Graphics.DrawLine(pen, 410, 160 + kaydir, 410, 325 + kaydir);
                    e.Graphics.DrawLine(pen, 30, 325 + kaydir, 797, 325 + kaydir);
                    e.Graphics.DrawLine(pen, 30, 160 + kaydir, 30, 325 + kaydir);
                    e.Graphics.DrawLine(pen, 797, 160 + kaydir, 797, 325 + kaydir);
                    e.Graphics.DrawLine(pen, 410, 240 + kaydir, 797, 240 + kaydir);


                    //bilgi tablo icerigi
                    e.Graphics.DrawString("Adı Soyadı", fontBaslik, firca, 80, 175 + kaydir);
                    e.Graphics.DrawString($": {m_ad + " " + m_sad}", font, firca, 200, 175 + kaydir);

                    e.Graphics.DrawString("Telefon", fontBaslik, firca, 80, 200 + kaydir);
                    e.Graphics.DrawString($": {m_tel}", font, firca, 200, 200 + kaydir);

                    e.Graphics.DrawString("Aracın Kimliği", fontBaslik, firca, 80, 225 + kaydir);
                    e.Graphics.DrawString($": {kimlik}", font, firca, 200, 225 + kaydir);
                    if (ucret != "")
                    {
                        e.Graphics.DrawString("Tutarı", fontBaslik, firca, 450, 255 + kaydir);
                        e.Graphics.DrawString($"{ucret}₺", font, firca, 460, 275 + kaydir);
                    }
                    else
                    {
                        e.Graphics.DrawString("Tutarı", fontBaslik, firca, 450, 255 + kaydir);
                    }

                    if (avans != "")
                    {
                        e.Graphics.DrawString("A. Avans", fontBaslik, firca, 670, 255 + kaydir);
                        e.Graphics.DrawString($"{avans}₺", font, firca, 690, 275 + kaydir);
                    }
                    else
                    {
                        e.Graphics.DrawString("A. Avans", fontBaslik, firca, 670, 255 + kaydir);
                    }



                    e.Graphics.DrawString("Geliş Tarihi", fontBaslik, firca, 515, 175 + kaydir);
                    e.Graphics.DrawString($": {DateTime.Now.ToString("dd.MM.yyyy")}", font, firca, 615, 175 + kaydir);

                    e.Graphics.DrawString("Teslim Tarihi", fontBaslik, firca, 515, 200 + kaydir);
                    e.Graphics.DrawString($": ...../...../20...", font, firca, 615, 200 + kaydir);



                    //e.Graphics.DrawString("Teslim Alan", fontBaslik, firca, 450, 255 + kaydir);
                    //e.Graphics.DrawString("İmza", font, fircaImza, 475, 275 + kaydir);

                    //e.Graphics.DrawString("Teslim Eden", fontBaslik, firca, 670, 255 + kaydir);
                    //e.Graphics.DrawString("İmza", font, fircaImza, 695, 275 + kaydir);

                    ///////////////////ilk kisim son///////////////////

                }

                e.Graphics.DrawString("1- Bu fişle gelen herkese mamul teslim edilir. ", font, firca, 45, 340);
                e.Graphics.DrawString("2- Kaybolduğunda sadece ismi yazılı kişiye hüviyet göstermek suretiyle teslim alındığına dair imza", font, firca, 45, 365);
                e.Graphics.DrawString("karşılığı teslim edilir.", font, firca, 65, 390);
                e.Graphics.DrawString("3- 45 gün içerisinde alınmayan maldan mesuliyet kabul olunmaz.", font, firca, 45, 415);
                e.Graphics.DrawString("4- Mamülün garantisi devam ediyorsa garanti belgesi (eksiksiz doldurulmuş şekilde) mutlaka ", font, firca, 45, 440);
                e.Graphics.DrawString("edilmesi gerekir.", font, firca, 65, 465);
                e.Graphics.DrawString("5- Mamülünü teslim eden yukarıda yazılı bulunan kuralları kabul etmiş sayılır.", font, firca, 45, 490);
                e.Graphics.DrawString("6- Bakım işlemi tamamlandığında E-posta ile bilgilendirme yapılacaktır. Sistemimize kayıt", font, firca, 45, 515);
                e.Graphics.DrawString("ettirdiğiniz E-posta adresinizi kontrol etmeyi unutmayınız.", font, firca, 65, 540);





                for (int j = 0; j < islemListbox.CheckedItems.Count; j++)
                {
                    int ek = 20 * j;
                    int toplam = kaydir + ek;
                    e.Graphics.DrawLine(pen, 30, 340 + toplam, 797, 340 + toplam);
                    e.Graphics.DrawLine(pen, 30, 360 + toplam, 797, 360 + toplam);
                    e.Graphics.DrawLine(pen, 30, 340 + toplam, 30, 360 + toplam);
                    e.Graphics.DrawLine(pen, 797, 340 + toplam, 797, 360 + toplam);
                    e.Graphics.DrawLine(pen, 700, 340 + toplam, 700, 360 + toplam);

                }

                for (int j = 0; j < islemListbox.CheckedItems.Count; j++)
                {
                    int ek = 20 * j;
                    int toplam = kaydir + ek;
                    string islem = islemListbox.CheckedItems[j].ToString();
                    e.Graphics.DrawString(islem, font, firca, 80, 340 + toplam);
                }
            }
            catch
            {
                MessageBox.Show("Yazdırmayla ilgili hata var.");
            }

        }
    }
}
