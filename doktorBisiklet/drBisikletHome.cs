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

    public partial class drBisikletHome : Form
    {
        public drBisikletHome()
        {
            InitializeComponent();
        }

        private void drBisikletHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bakimListesiBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["bakimListesi"] == null)
            {
                bakimListesi bakimListesi = new bakimListesi();
                bakimListesi.Show();
            }
        }

        private void teslimEdilecekBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["teslimEt"] == null)
            {
                TeslimEt teslimEt = new TeslimEt();
                teslimEt.Show();
            }
        }

        private void bakimBtn_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["bakim"] == null)
            {
                bakim bakim = new bakim();
                bakim.Show();
            }
        }

        private void musteriListesiBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["musteriListesi"] == null)
            {
                musteriListesi musteriListesi = new musteriListesi();
                musteriListesi.Show();
            }
        }

        private void teslimAlmaBtn_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["teslimAlma"] == null)
            {
                teslimAlma teslimAlma = new teslimAlma();
                teslimAlma.Show();


            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            bayramMail bayramMail = new bayramMail();
            bayramMail.bayramMailGonder();
            Console.WriteLine("Basıldı.");
            label1.Enabled = false;


        }
    }
}
