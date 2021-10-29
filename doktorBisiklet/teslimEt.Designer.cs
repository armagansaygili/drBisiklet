
namespace doktorBisiklet
{
    partial class TeslimEt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeslimEt));
            this.teslimBtn = new System.Windows.Forms.Button();
            this.bakimListesiDg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bakimListesiDg)).BeginInit();
            this.SuspendLayout();
            // 
            // teslimBtn
            // 
            this.teslimBtn.Location = new System.Drawing.Point(761, 276);
            this.teslimBtn.Name = "teslimBtn";
            this.teslimBtn.Size = new System.Drawing.Size(141, 42);
            this.teslimBtn.TabIndex = 6;
            this.teslimBtn.Text = "Teslim Et";
            this.teslimBtn.UseVisualStyleBackColor = true;
            this.teslimBtn.Click += new System.EventHandler(this.teslimBtn_Click);
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
            this.bakimListesiDg.Location = new System.Drawing.Point(0, -1);
            this.bakimListesiDg.MultiSelect = false;
            this.bakimListesiDg.Name = "bakimListesiDg";
            this.bakimListesiDg.ReadOnly = true;
            this.bakimListesiDg.RowHeadersVisible = false;
            this.bakimListesiDg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bakimListesiDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bakimListesiDg.ShowEditingIcon = false;
            this.bakimListesiDg.Size = new System.Drawing.Size(914, 261);
            this.bakimListesiDg.TabIndex = 18;
            // 
            // teslimEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 333);
            this.Controls.Add(this.bakimListesiDg);
            this.Controls.Add(this.teslimBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "teslimEt";
            this.Text = "Dr. Bisiklet";
            this.Load += new System.EventHandler(this.teslimEt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakimListesiDg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button teslimBtn;
        private System.Windows.Forms.DataGridView bakimListesiDg;
    }
}