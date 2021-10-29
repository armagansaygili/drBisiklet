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
    public partial class musteriListesi : Form
    {
        public musteriListesi()
        {
            InitializeComponent();
        }
        Mysql.SqlConnection sqlconnection = new Mysql.SqlConnection();
        public void Datagetir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT mus_ad,mus_sad,mus_tel,mus_email,mus_id from musteri", sqlconnection.baglan());
            DataTable ds = new DataTable();

            da.Fill(ds);
            musteriListesiDg.DataSource = ds;

        }

        public void Datagrid_ayar()
        {
            musteriListesiDg.Columns[3].HeaderText = "E-posta";
            musteriListesiDg.Columns[0].HeaderText = "Ad";
            musteriListesiDg.Columns[1].HeaderText = "Soyad";
            musteriListesiDg.Columns[2].HeaderText = "Telefon";
            musteriListesiDg.Columns[4].Visible = false;
            
           



            Font HeaderCellFont = new Font("Cambria", 9, FontStyle.Bold);
            for (int i = 0; i < musteriListesiDg.ColumnCount; i++)
            {
                musteriListesiDg.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }

            musteriListesiDg.DefaultCellStyle.Font = new Font("Cambria", 9, FontStyle.Regular);
        }

        private void musteriListesi_Load(object sender, EventArgs e)
        {
            Datagetir();
            Datagrid_ayar();
        }

        private void musteriListesiDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            musAdTbx.Text = musteriListesiDg.CurrentRow.Cells["mus_ad"].Value.ToString();
            musSadTbx.Text = musteriListesiDg.CurrentRow.Cells["mus_sad"].Value.ToString();
            musTelTbx.Text = musteriListesiDg.CurrentRow.Cells["mus_tel"].Value.ToString();
            musMailTbx.Text = musteriListesiDg.CurrentRow.Cells["mus_email"].Value.ToString();

        }

        private void musEkleBtn_Click(object sender, EventArgs e)
        {
            if (musAdTbx.Text == "" || musSadTbx.Text == "" || musTelTbx.Text == "" || musMailTbx.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
            else
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Insert into musteri (mus_ad,mus_sad,mus_tel,mus_email) values ('" + musAdTbx.Text +"','" + musSadTbx.Text + "','" + musTelTbx.Text + "','" + musMailTbx.Text + "')",sqlconnection.baglan());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            }
            Datagetir();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32(musteriListesiDg.CurrentRow.Cells["mus_id"].Value);

            MySqlCommand mySqlCommand = new MySqlCommand("Update musteri set  mus_ad='" + musAdTbx.Text+"',mus_sad='"+musSadTbx.Text+"',mus_tel='"+musTelTbx.Text+"',mus_email='"+musMailTbx.Text+"' where mus_id="+r_id,sqlconnection.baglan());
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            Datagetir();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32(musteriListesiDg.CurrentRow.Cells["mus_id"].Value);
            MySqlCommand mySqlCommand = new MySqlCommand("Delete from musteri where mus_id=" + r_id, sqlconnection.baglan());
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            Datagetir();
        }
    }
}
