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
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT bakim_id,mus_ad,mus_sad,urun_marka,urun_model,islemler,ucret,mus_tel,talma_tarih,urun_durum FROM musteri INNER JOIN bakim_listesi ON musteri.mus_id = bakim_listesi.mus_id where urun_durum=0", sqlconnection.baglan());
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



            Font HeaderCellFont = new Font("Cambria", 9, FontStyle.Bold);
            for (int i = 0; i < bakimListesiDg.ColumnCount; i++)
            {
                bakimListesiDg.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }

            bakimListesiDg.DefaultCellStyle.Font = new Font("Cambria", 9, FontStyle.Regular);
        }


        private void bakimListesi_Load(object sender, EventArgs e)
        {
            Datagetir();
            Datagrid_ayar();
        }

        private void bakimBitirTbx_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32(bakimListesiDg.CurrentRow.Cells["bakim_id"].Value);
            MySqlCommand mySqlCommand = new MySqlCommand("Update bakim_listesi set urun_durum=1 where bakim_id=" + r_id, sqlconnection.baglan());
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            Datagetir();

            sendMail sendMail = new sendMail();
            sendMail.mailGonder("armagan.saygili@decathlon.com", "Bisikletiniz Hazır!","Bisikletiniz hazırdır.");

        }

        private void bakimIptalTbx_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32(bakimListesiDg.CurrentRow.Cells["bakim_id"].Value);
            MySqlCommand mySqlCommand = new MySqlCommand("Delete from bakim_listesi where bakim_id=" + r_id, sqlconnection.baglan());
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            Datagetir();
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
            }else if(musAdTbx.Text != "" && musSadTbx.Text == "")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT bakim_id, mus_ad, mus_sad, urun_marka, urun_model, islemler, ucret, mus_tel, talma_tarih, urun_durum FROM musteri INNER JOIN bakim_listesi ON musteri.mus_id = bakim_listesi.mus_id where urun_durum = 0 and mus_ad like '" + musAdTbx.Text + "%'", sqlconnection.baglan());
                DataTable ds = new DataTable();
                da.Fill(ds);
                bakimListesiDg.DataSource = ds;
            }
            else if(musAdTbx.Text == "" && musSadTbx.Text != "")
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
    }
}
