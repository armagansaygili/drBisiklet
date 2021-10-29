
namespace doktorBisiklet
{
    partial class musteriListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriListesi));
            this.musAdTbx = new System.Windows.Forms.TextBox();
            this.musMailTbx = new System.Windows.Forms.TextBox();
            this.musSadTbx = new System.Windows.Forms.TextBox();
            this.musTelTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.musEkleBtn = new System.Windows.Forms.Button();
            this.musteriListesiDg = new System.Windows.Forms.DataGridView();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musteriListesiDg)).BeginInit();
            this.SuspendLayout();
            // 
            // musAdTbx
            // 
            this.musAdTbx.Location = new System.Drawing.Point(131, 323);
            this.musAdTbx.Name = "musAdTbx";
            this.musAdTbx.Size = new System.Drawing.Size(100, 20);
            this.musAdTbx.TabIndex = 0;
            // 
            // musMailTbx
            // 
            this.musMailTbx.Location = new System.Drawing.Point(544, 323);
            this.musMailTbx.Name = "musMailTbx";
            this.musMailTbx.Size = new System.Drawing.Size(100, 20);
            this.musMailTbx.TabIndex = 3;
            // 
            // musSadTbx
            // 
            this.musSadTbx.Location = new System.Drawing.Point(272, 323);
            this.musSadTbx.Name = "musSadTbx";
            this.musSadTbx.Size = new System.Drawing.Size(100, 20);
            this.musSadTbx.TabIndex = 1;
            // 
            // musTelTbx
            // 
            this.musTelTbx.Location = new System.Drawing.Point(413, 323);
            this.musTelTbx.Name = "musTelTbx";
            this.musTelTbx.Size = new System.Drawing.Size(100, 20);
            this.musTelTbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-posta:";
            // 
            // musEkleBtn
            // 
            this.musEkleBtn.Location = new System.Drawing.Point(230, 369);
            this.musEkleBtn.Name = "musEkleBtn";
            this.musEkleBtn.Size = new System.Drawing.Size(75, 23);
            this.musEkleBtn.TabIndex = 4;
            this.musEkleBtn.Text = "Ekle";
            this.musEkleBtn.UseVisualStyleBackColor = true;
            this.musEkleBtn.Click += new System.EventHandler(this.musEkleBtn_Click);
            // 
            // musteriListesiDg
            // 
            this.musteriListesiDg.AllowUserToAddRows = false;
            this.musteriListesiDg.AllowUserToDeleteRows = false;
            this.musteriListesiDg.AllowUserToResizeColumns = false;
            this.musteriListesiDg.AllowUserToResizeRows = false;
            this.musteriListesiDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.musteriListesiDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.musteriListesiDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriListesiDg.Location = new System.Drawing.Point(0, 0);
            this.musteriListesiDg.MultiSelect = false;
            this.musteriListesiDg.Name = "musteriListesiDg";
            this.musteriListesiDg.ReadOnly = true;
            this.musteriListesiDg.RowHeadersVisible = false;
            this.musteriListesiDg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.musteriListesiDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.musteriListesiDg.ShowEditingIcon = false;
            this.musteriListesiDg.Size = new System.Drawing.Size(800, 261);
            this.musteriListesiDg.TabIndex = 18;
            this.musteriListesiDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriListesiDg_CellClick);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(354, 369);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(75, 23);
            this.guncelleBtn.TabIndex = 5;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(473, 369);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(75, 23);
            this.silBtn.TabIndex = 6;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // musteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.musteriListesiDg);
            this.Controls.Add(this.musEkleBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musTelTbx);
            this.Controls.Add(this.musSadTbx);
            this.Controls.Add(this.musMailTbx);
            this.Controls.Add(this.musAdTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "musteriListesi";
            this.Text = "Dr. Bisiklet";
            this.Load += new System.EventHandler(this.musteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriListesiDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox musAdTbx;
        private System.Windows.Forms.TextBox musMailTbx;
        private System.Windows.Forms.TextBox musSadTbx;
        private System.Windows.Forms.TextBox musTelTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button musEkleBtn;
        private System.Windows.Forms.DataGridView musteriListesiDg;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button silBtn;
    }
}