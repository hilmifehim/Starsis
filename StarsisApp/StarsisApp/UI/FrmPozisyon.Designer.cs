namespace StarsisApp.UI
{
    partial class FrmPozisyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPozisyon));
            this.dgvPozisyon = new System.Windows.Forms.DataGridView();
            this.lblPozisyonAdi = new System.Windows.Forms.Label();
            this.txtPozisyonAdi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozisyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPozisyon
            // 
            this.dgvPozisyon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPozisyon.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPozisyon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPozisyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPozisyon.Location = new System.Drawing.Point(12, 12);
            this.dgvPozisyon.MultiSelect = false;
            this.dgvPozisyon.Name = "dgvPozisyon";
            this.dgvPozisyon.ReadOnly = true;
            this.dgvPozisyon.RowHeadersWidth = 51;
            this.dgvPozisyon.RowTemplate.Height = 24;
            this.dgvPozisyon.Size = new System.Drawing.Size(381, 345);
            this.dgvPozisyon.TabIndex = 5;
            // 
            // lblPozisyonAdi
            // 
            this.lblPozisyonAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblPozisyonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyonAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPozisyonAdi.Location = new System.Drawing.Point(423, 119);
            this.lblPozisyonAdi.Name = "lblPozisyonAdi";
            this.lblPozisyonAdi.Size = new System.Drawing.Size(122, 51);
            this.lblPozisyonAdi.TabIndex = 6;
            this.lblPozisyonAdi.Text = "Poziyon Adı : ";
            this.lblPozisyonAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPozisyonAdi
            // 
            this.txtPozisyonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozisyonAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPozisyonAdi.Location = new System.Drawing.Point(551, 130);
            this.txtPozisyonAdi.Multiline = true;
            this.txtPozisyonAdi.Name = "txtPozisyonAdi";
            this.txtPozisyonAdi.Size = new System.Drawing.Size(125, 29);
            this.txtPozisyonAdi.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(507, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 71);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(607, 309);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(92, 62);
            this.picboxAnaMenuDon.TabIndex = 30;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // FrmPozisyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 383);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPozisyonAdi);
            this.Controls.Add(this.lblPozisyonAdi);
            this.Controls.Add(this.dgvPozisyon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPozisyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pozisyon Ekle";
            this.Load += new System.EventHandler(this.FrmPozisyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozisyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPozisyon;
        private System.Windows.Forms.Label lblPozisyonAdi;
        private System.Windows.Forms.TextBox txtPozisyonAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
    }
}