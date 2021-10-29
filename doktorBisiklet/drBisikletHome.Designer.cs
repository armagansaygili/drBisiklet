
namespace doktorBisiklet
{
    partial class drBisikletHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drBisikletHome));
            this.bakımListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakimListesiBtn = new System.Windows.Forms.Button();
            this.teslimAlmaBtn = new System.Windows.Forms.Button();
            this.teslimEdilecekBtn = new System.Windows.Forms.Button();
            this.musteriListesiBtn = new System.Windows.Forms.Button();
            this.bakimBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bakımListesiToolStripMenuItem
            // 
            this.bakımListesiToolStripMenuItem.Name = "bakımListesiToolStripMenuItem";
            this.bakımListesiToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.bakımListesiToolStripMenuItem.Text = "Bakım Listesi";
            // 
            // bakimListesiBtn
            // 
            this.bakimListesiBtn.Location = new System.Drawing.Point(28, 178);
            this.bakimListesiBtn.Name = "bakimListesiBtn";
            this.bakimListesiBtn.Size = new System.Drawing.Size(160, 47);
            this.bakimListesiBtn.TabIndex = 0;
            this.bakimListesiBtn.Text = "Bakım Listesi";
            this.bakimListesiBtn.UseVisualStyleBackColor = true;
            this.bakimListesiBtn.Click += new System.EventHandler(this.bakimListesiBtn_Click);
            // 
            // teslimAlmaBtn
            // 
            this.teslimAlmaBtn.Location = new System.Drawing.Point(28, 231);
            this.teslimAlmaBtn.Name = "teslimAlmaBtn";
            this.teslimAlmaBtn.Size = new System.Drawing.Size(160, 47);
            this.teslimAlmaBtn.TabIndex = 1;
            this.teslimAlmaBtn.Text = "Teslim Alma";
            this.teslimAlmaBtn.UseVisualStyleBackColor = true;
            this.teslimAlmaBtn.Click += new System.EventHandler(this.teslimAlmaBtn_Click);
            // 
            // teslimEdilecekBtn
            // 
            this.teslimEdilecekBtn.Location = new System.Drawing.Point(205, 178);
            this.teslimEdilecekBtn.Name = "teslimEdilecekBtn";
            this.teslimEdilecekBtn.Size = new System.Drawing.Size(160, 47);
            this.teslimEdilecekBtn.TabIndex = 2;
            this.teslimEdilecekBtn.Text = "Teslim Edilecekler";
            this.teslimEdilecekBtn.UseVisualStyleBackColor = true;
            this.teslimEdilecekBtn.Click += new System.EventHandler(this.teslimEdilecekBtn_Click);
            // 
            // musteriListesiBtn
            // 
            this.musteriListesiBtn.Location = new System.Drawing.Point(205, 231);
            this.musteriListesiBtn.Name = "musteriListesiBtn";
            this.musteriListesiBtn.Size = new System.Drawing.Size(160, 47);
            this.musteriListesiBtn.TabIndex = 3;
            this.musteriListesiBtn.Text = "Müşteri Listesi";
            this.musteriListesiBtn.UseVisualStyleBackColor = true;
            this.musteriListesiBtn.Click += new System.EventHandler(this.musteriListesiBtn_Click);
            // 
            // bakimBtn
            // 
            this.bakimBtn.Location = new System.Drawing.Point(111, 284);
            this.bakimBtn.Name = "bakimBtn";
            this.bakimBtn.Size = new System.Drawing.Size(160, 47);
            this.bakimBtn.TabIndex = 5;
            this.bakimBtn.Text = "Bakım Ayarları";
            this.bakimBtn.UseVisualStyleBackColor = true;
            this.bakimBtn.Click += new System.EventHandler(this.bakimBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::doktorBisiklet.Properties.Resources.DR_LOGO_1;
            this.pictureBox1.Location = new System.Drawing.Point(111, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Günlük Bilgilendirmeleri İlet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // drBisikletHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(391, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bakimBtn);
            this.Controls.Add(this.musteriListesiBtn);
            this.Controls.Add(this.teslimEdilecekBtn);
            this.Controls.Add(this.teslimAlmaBtn);
            this.Controls.Add(this.bakimListesiBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "drBisikletHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dr. Bisiklet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.drBisikletHome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem bakımListesiToolStripMenuItem;
        private System.Windows.Forms.Button bakimListesiBtn;
        private System.Windows.Forms.Button teslimAlmaBtn;
        private System.Windows.Forms.Button teslimEdilecekBtn;
        private System.Windows.Forms.Button musteriListesiBtn;
        private System.Windows.Forms.Button bakimBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}