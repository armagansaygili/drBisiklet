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
    public partial class bakim : Form
    {
        public bakim()
        {
            InitializeComponent();
        }
        Mysql.SqlConnection sqlconnection = new Mysql.SqlConnection();
        public void Datagetir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT bakim,ucret,bakim_fiyat_id from bakim_fiyat_listesi", sqlconnection.baglan());
            DataTable ds = new DataTable();

            da.Fill(ds);
            bakimDg.DataSource = ds;

        }

        private void bakim_Load(object sender, EventArgs e)
        {
            Datagetir();
            Datagrid_ayar();
        }

        public void Datagrid_ayar()
        {

            bakimDg.Columns[0].HeaderText = "Bakım";
            bakimDg.Columns[1].HeaderText = "Ücret";
            bakimDg.Columns[2].Visible = false;


            Font HeaderCellFont = new Font("Cambria", 9, FontStyle.Bold);
            for (int i = 0; i < bakimDg.ColumnCount; i++)
            {
                bakimDg.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }

            bakimDg.DefaultCellStyle.Font = new Font("Cambria", 9, FontStyle.Regular);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            Datagetir();
            Datagrid_ayar();
        }

        private void bakimDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guncelleIslemTbx.Text = bakimDg.CurrentRow.Cells["bakim"].Value.ToString();
            guncelleUcretTbx.Text = bakimDg.CurrentRow.Cells["ucret"].Value.ToString();

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32(bakimDg.CurrentRow.Cells["bakim_fiyat_id"].Value);
            MySqlCommand mySqlCommand = new MySqlCommand("Update bakim_fiyat_listesi set bakim='" + guncelleIslemTbx.Text + "',ucret=" + guncelleUcretTbx.Text +" where bakim_fiyat_id=" + r_id, sqlconnection.baglan());
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            Datagetir();
            Datagrid_ayar();

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if (guncelleIslemTbx.Text != "" && guncelleUcretTbx.Text != ""){
                MySqlCommand mySqlCommand = new MySqlCommand("Insert into bakim_fiyat_listesi(bakim,ucret) Values ('" + guncelleIslemTbx.Text + "'," + guncelleUcretTbx.Text + ")", sqlconnection.baglan());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                Datagetir();
                Datagrid_ayar();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!");
            }
            

        }

        private void silBtn_Click_1(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32(bakimDg.CurrentRow.Cells["bakim_fiyat_id"].Value);
            MySqlCommand mySqlCommand = new MySqlCommand("Delete from bakim_fiyat_listesi where bakim_fiyat_id=" + r_id, sqlconnection.baglan());
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            Datagetir();
            Datagrid_ayar();

        }
    }
}
