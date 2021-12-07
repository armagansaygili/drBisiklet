
namespace doktorBisiklet
{
    partial class bakim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bakim));
            this.ekleBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.silBtn = new System.Windows.Forms.Button();
            this.bakimDg = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.guncelleIslemTbx = new System.Windows.Forms.TextBox();
            this.guncelleUcretTbx = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakimDg)).BeginInit();
            this.SuspendLayout();
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(306, 293);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(62, 23);
            this.ekleBtn.TabIndex = 9;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.silBtn);
            this.panel2.Controls.Add(this.bakimDg);
            this.panel2.Controls.Add(this.ekleBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.guncelleBtn);
            this.panel2.Controls.Add(this.guncelleIslemTbx);
            this.panel2.Controls.Add(this.guncelleUcretTbx);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 334);
            this.panel2.TabIndex = 13;
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(374, 293);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(62, 23);
            this.silBtn.TabIndex = 5;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click_1);
            // 
            // bakimDg
            // 
            this.bakimDg.AllowUserToAddRows = false;
            this.bakimDg.AllowUserToDeleteRows = false;
            this.bakimDg.AllowUserToResizeColumns = false;
            this.bakimDg.AllowUserToResizeRows = false;
            this.bakimDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bakimDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bakimDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bakimDg.Location = new System.Drawing.Point(11, 14);
            this.bakimDg.MultiSelect = false;
            this.bakimDg.Name = "bakimDg";
            this.bakimDg.ReadOnly = true;
            this.bakimDg.RowHeadersVisible = false;
            this.bakimDg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bakimDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bakimDg.ShowEditingIcon = false;
            this.bakimDg.Size = new System.Drawing.Size(493, 225);
            this.bakimDg.TabIndex = 16;
            this.bakimDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bakimDg_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ücret:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "İşlem:";
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(442, 293);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(62, 23);
            this.guncelleBtn.TabIndex = 6;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // guncelleIslemTbx
            // 
            this.guncelleIslemTbx.Location = new System.Drawing.Point(11, 293);
            this.guncelleIslemTbx.Name = "guncelleIslemTbx";
            this.guncelleIslemTbx.Size = new System.Drawing.Size(122, 20);
            this.guncelleIslemTbx.TabIndex = 3;
            // 
            // guncelleUcretTbx
            // 
            this.guncelleUcretTbx.Location = new System.Drawing.Point(178, 293);
            this.guncelleUcretTbx.Name = "guncelleUcretTbx";
            this.guncelleUcretTbx.Size = new System.Drawing.Size(122, 20);
            this.guncelleUcretTbx.TabIndex = 4;
            // 
            // bakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 358);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "bakim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bakim";
            this.Load += new System.EventHandler(this.bakim_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakimDg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.TextBox guncelleIslemTbx;
        private System.Windows.Forms.TextBox guncelleUcretTbx;
        private System.Windows.Forms.DataGridView bakimDg;
        private System.Windows.Forms.Button silBtn;
    }
}