
namespace doktorBisiklet
{
    partial class bakimListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bakimListesi));
            this.bakimBitirTbx = new System.Windows.Forms.Button();
            this.bakimIptalTbx = new System.Windows.Forms.Button();
            this.bakimListesiDg = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.musAdTbx = new System.Windows.Forms.TextBox();
            this.musSadTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ucretEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.islemListbox = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.bakimListesiDg)).BeginInit();
            this.SuspendLayout();
            // 
            // bakimBitirTbx
            // 
            this.bakimBitirTbx.Location = new System.Drawing.Point(761, 276);
            this.bakimBitirTbx.Name = "bakimBitirTbx";
            this.bakimBitirTbx.Size = new System.Drawing.Size(141, 42);
            this.bakimBitirTbx.TabIndex = 4;
            this.bakimBitirTbx.Text = "Bakım Bitir";
            this.bakimBitirTbx.UseVisualStyleBackColor = true;
            this.bakimBitirTbx.Click += new System.EventHandler(this.bakimBitirTbx_Click);
            // 
            // bakimIptalTbx
            // 
            this.bakimIptalTbx.Location = new System.Drawing.Point(761, 334);
            this.bakimIptalTbx.Name = "bakimIptalTbx";
            this.bakimIptalTbx.Size = new System.Drawing.Size(141, 42);
            this.bakimIptalTbx.TabIndex = 3;
            this.bakimIptalTbx.Text = "Bakım İptal Et";
            this.bakimIptalTbx.UseVisualStyleBackColor = true;
            this.bakimIptalTbx.Click += new System.EventHandler(this.bakimIptalTbx_Click);
            // 
            // bakimListesiDg
            // 
            this.bakimListesiDg.AllowUserToAddRows = false;
            this.bakimListesiDg.AllowUserToDeleteRows = false;
            this.bakimListesiDg.AllowUserToResizeColumns = false;
            this.bakimListesiDg.AllowUserToResizeRows = false;
            this.bakimListesiDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bakimListesiDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bakimListesiDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bakimListesiDg.Location = new System.Drawing.Point(0, 0);
            this.bakimListesiDg.MultiSelect = false;
            this.bakimListesiDg.Name = "bakimListesiDg";
            this.bakimListesiDg.ReadOnly = true;
            this.bakimListesiDg.RowHeadersVisible = false;
            this.bakimListesiDg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bakimListesiDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bakimListesiDg.ShowEditingIcon = false;
            this.bakimListesiDg.Size = new System.Drawing.Size(914, 261);
            this.bakimListesiDg.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Müşteri Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Soyad:";
            // 
            // musAdTbx
            // 
            this.musAdTbx.Location = new System.Drawing.Point(12, 288);
            this.musAdTbx.Name = "musAdTbx";
            this.musAdTbx.Size = new System.Drawing.Size(122, 20);
            this.musAdTbx.TabIndex = 0;
            // 
            // musSadTbx
            // 
            this.musSadTbx.Location = new System.Drawing.Point(15, 330);
            this.musSadTbx.Name = "musSadTbx";
            this.musSadTbx.Size = new System.Drawing.Size(122, 20);
            this.musSadTbx.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ad:";
            // 
            // ucretEkle
            // 
            this.ucretEkle.Location = new System.Drawing.Point(514, 296);
            this.ucretEkle.Name = "ucretEkle";
            this.ucretEkle.Size = new System.Drawing.Size(122, 20);
            this.ucretEkle.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ücret Ekle:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 57);
            this.button2.TabIndex = 24;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // islemListbox
            // 
            this.islemListbox.FormattingEnabled = true;
            this.islemListbox.Location = new System.Drawing.Point(353, 296);
            this.islemListbox.Name = "islemListbox";
            this.islemListbox.Size = new System.Drawing.Size(155, 79);
            this.islemListbox.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "İşlemler:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 57);
            this.button3.TabIndex = 43;
            this.button3.Text = "Yazdır";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Text = "Baskı önizleme";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // bakimListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 400);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.islemListbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucretEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.musAdTbx);
            this.Controls.Add(this.musSadTbx);
            this.Controls.Add(this.bakimListesiDg);
            this.Controls.Add(this.bakimIptalTbx);
            this.Controls.Add(this.bakimBitirTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "bakimListesi";
            this.Text = "Dr. Bisiklet";
            this.Load += new System.EventHandler(this.bakimListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakimListesiDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bakimBitirTbx;
        private System.Windows.Forms.Button bakimIptalTbx;
        private System.Windows.Forms.DataGridView bakimListesiDg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox musAdTbx;
        private System.Windows.Forms.TextBox musSadTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ucretEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox islemListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}