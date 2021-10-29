using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doktorBisiklet
{
    public partial class teslimAlma : Form
    {
        public teslimAlma()
        {
            InitializeComponent();
        }


        Mysql.SqlConnection sqlconnection = new Mysql.SqlConnection();
        public void Datagetir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT mus_ad,mus_sad,mus_id,mus_tel from musteri", sqlconnection.baglan());
            DataTable ds = new DataTable();

            da.Fill(ds);
            musteriListesiDg.DataSource = ds;

        }

        public void Datagrid_ayar()
        {
            musteriListesiDg.Columns[0].HeaderText = "Ad";
            musteriListesiDg.Columns[1].HeaderText = "Soyad";
            musteriListesiDg.Columns[2].Visible = false;
            musteriListesiDg.Columns[3].Visible = false;


            Font HeaderCellFont = new Font("Cambria", 9, FontStyle.Bold);
            for (int i = 0; i < musteriListesiDg.ColumnCount; i++)
            {
                musteriListesiDg.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }

            musteriListesiDg.DefaultCellStyle.Font = new Font("Cambria", 9, FontStyle.Regular);
        }

        private void teslimAlma_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (musAdTbx.Text != "" && musSadTbx.Text != "")
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT mus_ad,mus_sad,mus_id from musteri where  mus_ad like '" + musAdTbx.Text + "%' and mus_sad like '" + musSadTbx.Text + "%'", sqlconnection.baglan());
                MySqlDataAdapter da = mySqlDataAdapter;
                DataTable ds = new DataTable();
                da.Fill(ds);
                musteriListesiDg.DataSource = ds;
            }
            else if (musAdTbx.Text != "" && musSadTbx.Text == "")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT mus_ad,mus_sad,mus_id from musteri where mus_ad like '" + musAdTbx.Text + "%'", sqlconnection.baglan());
                DataTable ds = new DataTable();
                da.Fill(ds);
                musteriListesiDg.DataSource = ds;
            }
            else if (musAdTbx.Text == "" && musSadTbx.Text != "")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT mus_ad,mus_sad,mus_id from musteri where mus_Sad like '" + musSadTbx.Text + "%'", sqlconnection.baglan());
                DataTable ds = new DataTable();
                da.Fill(ds);
                musteriListesiDg.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Arama kriteri giriniz!");
            }
        }
        string topla ="";
        private void bakimEkleBtn_Click(object sender, EventArgs e)
        {
            if (markaTbx.Text != "" && modelTbx.Text != "")
            {
                int r_id = Convert.ToInt32(musteriListesiDg.CurrentRow.Cells["mus_id"].Value);

                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string tarih = dateTime.ToString("d");


                for (int i = 0; i < islemListbox.CheckedItems.Count; i++)
                {
                    
                    if (topla == "")
                    {
                        topla = islemListbox.CheckedItems[i].ToString();
                    }
                    else
                    {
                        topla = topla + "," + islemListbox.CheckedItems[i].ToString();
                    }
                }

                if (ucretTbx.Text != "")
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("Insert into bakim_listesi (mus_id,urun_marka,urun_model,islemler,ucret,talma_tarih,urun_durum) values (" + r_id + ",'" + markaTbx.Text + "','" + modelTbx.Text + "','" + topla + "','" + ucretTbx.Text + "','" + tarih + "',0)", sqlconnection.baglan());
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                }
                else
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("Insert into bakim_listesi (mus_id,urun_marka,urun_model,islemler,talma_tarih,urun_durum) values (" + r_id + ",'" + markaTbx.Text + "','" + modelTbx.Text + "','" + topla +  "','" + tarih + "',0)", sqlconnection.baglan());
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                }

                printPreviewDialog.Document = printDocument;
                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
                markaTbx.Text = "";
                modelTbx.Text = "";
                ucretTbx.Text = "";

                          
            }
            else
            {
                MessageBox.Show("Marka,model ve teslim alan kısımlarından herhangi biri boş olamaz!");
            }
            

        }

            private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string m_ad = musteriListesiDg.CurrentRow.Cells["mus_ad"].Value.ToString();
            string m_sad = musteriListesiDg.CurrentRow.Cells["mus_sad"].Value.ToString();
            string m_tel = musteriListesiDg.CurrentRow.Cells["mus_tel"].Value.ToString();
            try
            {

                for (int i=0; i<2; i++)
                {
                    int islemAdet = islemListbox.CheckedItems.Count;
                    int kaydirma = islemAdet * 20;
                    int kaydir = 0;
                    if (i == 0)
                    {
                        kaydir = 0;
                    }
                    if (i == 1)
                    {
                        kaydir = 400 + kaydirma;
                    }

                    //font,kalem,firca ayarlari
                    Font font = new Font("Arial", 12);
                    Font fontBaslik = new Font("Arial", 12, FontStyle.Bold);
                    Font fontBaslikDrBis = new Font("Arial", 18, FontStyle.Bold);
                    SolidBrush firca = new SolidBrush(Color.Black);
                    SolidBrush fircaImza = new SolidBrush(Color.LightSlateGray);
                    Pen pen = new Pen(Color.Black);

                    //baslik tablo cizimleri
                    e.Graphics.DrawLine(pen, 10, 15 + kaydir, 817, 15 + kaydir);
                    e.Graphics.DrawLine(pen, 10, 15 + kaydir, 10, 145 + kaydir);
                    e.Graphics.DrawLine(pen, 817, 15 + kaydir, 817, 145 + kaydir);
                    e.Graphics.DrawLine(pen, 10, 145 + kaydir, 817, 145 + kaydir);
                    System.Drawing.Image img = System.Drawing.Image.FromFile("C:\\Users\\armsa\\Desktop\\Taner\\doktorBisiklet\\doktorBisiklet\\images\\drbisiklet.jpg"); //baslik logosu
                    e.Graphics.DrawImage(img, 25, 30 + kaydir, img.Width, img.Height);

                    //baslik icerigi
                    e.Graphics.DrawString("DR. BİSİKLET", fontBaslikDrBis, firca, 125, 35 + kaydir);
                    e.Graphics.DrawString("Esentepe Mh. Okul Cd. No:5/A Nilüfer/BURSA", font, firca, 125, 60 + kaydir);
                    e.Graphics.DrawString("Tel", font, firca, 125, 75 + kaydir);
                    e.Graphics.DrawString(": 0224 245 80 89", font, firca, 175, 75 + kaydir);
                    e.Graphics.DrawString("Gsm", font, firca, 125, 90 + kaydir);
                    e.Graphics.DrawString(": 553 395 03 56", font, firca, 175, 90 + kaydir);
                    e.Graphics.DrawString("e-mail", font, firca, 125, 105 + kaydir);
                    e.Graphics.DrawString(": dr.ramazan16@hotmail.com", font, firca, 175, 105 + kaydir);

                    //bilgi tablosu cizimi
                    e.Graphics.DrawLine(pen, 10, 160 + kaydir, 817, 160 + kaydir);
                    e.Graphics.DrawLine(pen, 410, 160 + kaydir, 410, 325 + kaydir);
                    e.Graphics.DrawLine(pen, 10, 325 + kaydir, 817, 325 + kaydir);
                    e.Graphics.DrawLine(pen, 10, 160 + kaydir, 10, 325 + kaydir);
                    e.Graphics.DrawLine(pen, 817, 160 + kaydir, 817, 325 + kaydir);
                    e.Graphics.DrawLine(pen, 410, 240 + kaydir, 817, 240 + kaydir);

                    //bilgi tablo icerigi
                    e.Graphics.DrawString("Adı Soyadı", fontBaslik, firca, 80, 175 + kaydir);
                    e.Graphics.DrawString($": {m_ad + " " + m_sad}", font, firca, 200, 175 + kaydir);

                    e.Graphics.DrawString("Telefon", fontBaslik, firca, 80, 200 + kaydir);
                    e.Graphics.DrawString($": {m_tel}", font, firca, 200, 200 + kaydir);

                    e.Graphics.DrawString("Aracın Kimliği", fontBaslik, firca, 80, 225 + kaydir);
                    e.Graphics.DrawString($": {markaTbx.Text + " " + modelTbx.Text}", font, firca, 200, 225 + kaydir);

                  
                    if (ucretTbx.Text != "")
                    {
                        e.Graphics.DrawString("Tutarı", fontBaslik, firca, 80, 275 + kaydir);
                        e.Graphics.DrawString($": {ucretTbx.Text}₺", font, firca, 200, 275 + kaydir);
                    }
                    else
                    {
                        e.Graphics.DrawString("Tutarı", fontBaslik, firca, 80, 275 + kaydir);
                        e.Graphics.DrawString(":", font, firca, 200, 275 + kaydir);
                    }

                    if (avansTbx.Text != "")
                    {
                        e.Graphics.DrawString("A. Avans", fontBaslik, firca, 80, 300 + kaydir);
                        e.Graphics.DrawString($": {avansTbx.Text}₺", font, firca, 200, 300 + kaydir);
                    }
                    else
                    {
                        e.Graphics.DrawString("A. Avans", fontBaslik, firca, 80, 300 + kaydir);
                        e.Graphics.DrawString($":", font, firca, 200, 300 + kaydir);
                    }
                    


                    e.Graphics.DrawString("Geliş Tarihi", fontBaslik, firca, 515, 175 + kaydir);
                    e.Graphics.DrawString($": {DateTime.Now.ToString("dd.MM.yyyy")}", font, firca, 615, 175 + kaydir);

                    e.Graphics.DrawString("Teslim Tarihi", fontBaslik, firca, 515, 200 + kaydir);
                    e.Graphics.DrawString($": ...../...../20...", font, firca, 615, 200 + kaydir);



                    e.Graphics.DrawString("Teslim Alan", fontBaslik, firca, 450, 255 + kaydir);
                    e.Graphics.DrawString("İmza", font, fircaImza, 475, 275 + kaydir);

                    e.Graphics.DrawString("Teslim Eden", fontBaslik, firca, 670, 255 + kaydir);
                    e.Graphics.DrawString("İmza", font, fircaImza, 695, 275 + kaydir);

                    ///////////////////ilk kisim son///////////////////

                    for(int j=0; j < islemListbox.CheckedItems.Count; j++)
                    {
                        int ek = 20*j;
                        int toplam = kaydir + ek;
                        e.Graphics.DrawLine(pen, 10, 340 + toplam, 817, 340 + toplam);
                        e.Graphics.DrawLine(pen, 10, 360 + toplam, 817, 360 + toplam);
                        e.Graphics.DrawLine(pen, 10, 340 + toplam, 10, 360 + toplam);
                        e.Graphics.DrawLine(pen, 817, 340 + toplam, 817, 360 + toplam);
                        e.Graphics.DrawLine(pen, 700, 340 + toplam, 700, 360 + toplam);

                    }

                    for (int j = 0; j < islemListbox.CheckedItems.Count; j++)
                    {
                        int ek = 20 * j;
                        int toplam = kaydir + ek;
                        string islem = islemListbox.CheckedItems[j].ToString();
                        e.Graphics.DrawString(islem,font,firca, 80, 340 + toplam);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Yazdırmayla ilgili hata var.");
            }

        }
    }
}
