namespace StarsisApp.UI
{
    partial class FrmHesapPlani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHesapPlani));
            this.dgvHesapPlani = new System.Windows.Forms.DataGridView();
            this.cmbHesapTuru = new System.Windows.Forms.ComboBox();
            this.txtHesapAdi = new System.Windows.Forms.TextBox();
            this.lblHesapAdi = new System.Windows.Forms.Label();
            this.lblHesapTuru = new System.Windows.Forms.Label();
            this.picboxEkle = new System.Windows.Forms.PictureBox();
            this.picboxListele = new System.Windows.Forms.PictureBox();
            this.picboxSil = new System.Windows.Forms.PictureBox();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesapPlani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHesapPlani
            // 
            this.dgvHesapPlani.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHesapPlani.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvHesapPlani.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHesapPlani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHesapPlani.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvHesapPlani.Location = new System.Drawing.Point(341, 30);
            this.dgvHesapPlani.Name = "dgvHesapPlani";
            this.dgvHesapPlani.ReadOnly = true;
            this.dgvHesapPlani.RowHeadersWidth = 51;
            this.dgvHesapPlani.RowTemplate.Height = 24;
            this.dgvHesapPlani.Size = new System.Drawing.Size(321, 209);
            this.dgvHesapPlani.TabIndex = 3;
            this.dgvHesapPlani.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHesapPlani_CellClick);
            // 
            // cmbHesapTuru
            // 
            this.cmbHesapTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHesapTuru.FormattingEnabled = true;
            this.cmbHesapTuru.Location = new System.Drawing.Point(171, 90);
            this.cmbHesapTuru.Name = "cmbHesapTuru";
            this.cmbHesapTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbHesapTuru.TabIndex = 2;
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHesapAdi.Location = new System.Drawing.Point(171, 39);
            this.txtHesapAdi.Multiline = true;
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(125, 29);
            this.txtHesapAdi.TabIndex = 1;
            // 
            // lblHesapAdi
            // 
            this.lblHesapAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHesapAdi.Location = new System.Drawing.Point(28, 39);
            this.lblHesapAdi.Name = "lblHesapAdi";
            this.lblHesapAdi.Size = new System.Drawing.Size(122, 29);
            this.lblHesapAdi.TabIndex = 17;
            this.lblHesapAdi.Text = "Hesap Adı :";
            this.lblHesapAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHesapTuru
            // 
            this.lblHesapTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapTuru.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHesapTuru.Location = new System.Drawing.Point(28, 90);
            this.lblHesapTuru.Name = "lblHesapTuru";
            this.lblHesapTuru.Size = new System.Drawing.Size(122, 29);
            this.lblHesapTuru.TabIndex = 18;
            this.lblHesapTuru.Text = "Hesap Türü :";
            this.lblHesapTuru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxEkle
            // 
            this.picboxEkle.BackColor = System.Drawing.Color.Transparent;
            this.picboxEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxEkle.BackgroundImage")));
            this.picboxEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxEkle.Location = new System.Drawing.Point(94, 140);
            this.picboxEkle.Name = "picboxEkle";
            this.picboxEkle.Size = new System.Drawing.Size(158, 89);
            this.picboxEkle.TabIndex = 19;
            this.picboxEkle.TabStop = false;
            this.picboxEkle.Click += new System.EventHandler(this.picboxEkle_Click);
            // 
            // picboxListele
            // 
            this.picboxListele.BackColor = System.Drawing.Color.Transparent;
            this.picboxListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxListele.BackgroundImage")));
            this.picboxListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxListele.Location = new System.Drawing.Point(341, 245);
            this.picboxListele.Name = "picboxListele";
            this.picboxListele.Size = new System.Drawing.Size(158, 91);
            this.picboxListele.TabIndex = 20;
            this.picboxListele.TabStop = false;
            this.picboxListele.Click += new System.EventHandler(this.picboxListele_Click);
            // 
            // picboxSil
            // 
            this.picboxSil.BackColor = System.Drawing.Color.Transparent;
            this.picboxSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxSil.BackgroundImage")));
            this.picboxSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxSil.Location = new System.Drawing.Point(505, 245);
            this.picboxSil.Name = "picboxSil";
            this.picboxSil.Size = new System.Drawing.Size(158, 91);
            this.picboxSil.TabIndex = 21;
            this.picboxSil.TabStop = false;
            this.picboxSil.Click += new System.EventHandler(this.picboxSil_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(12, 285);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(80, 51);
            this.picboxAnaMenuDon.TabIndex = 33;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // FrmHesapPlani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 348);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.picboxSil);
            this.Controls.Add(this.picboxListele);
            this.Controls.Add(this.picboxEkle);
            this.Controls.Add(this.lblHesapTuru);
            this.Controls.Add(this.lblHesapAdi);
            this.Controls.Add(this.txtHesapAdi);
            this.Controls.Add(this.dgvHesapPlani);
            this.Controls.Add(this.cmbHesapTuru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHesapPlani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Planı";
            this.Load += new System.EventHandler(this.FrmHesapPlani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesapPlani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHesapPlani;
        private System.Windows.Forms.ComboBox cmbHesapTuru;
        private System.Windows.Forms.TextBox txtHesapAdi;
        private System.Windows.Forms.Label lblHesapAdi;
        private System.Windows.Forms.Label lblHesapTuru;
        private System.Windows.Forms.PictureBox picboxEkle;
        private System.Windows.Forms.PictureBox picboxListele;
        private System.Windows.Forms.PictureBox picboxSil;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
    }
}