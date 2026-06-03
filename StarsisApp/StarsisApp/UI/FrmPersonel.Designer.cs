namespace StarsisApp.UI
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.picboxKaydet = new System.Windows.Forms.PictureBox();
            this.picboxGuncelle = new System.Windows.Forms.PictureBox();
            this.picboxSil = new System.Windows.Forms.PictureBox();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvPersonel.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.ReadOnly = true;
            this.dgvPersonel.RowHeadersWidth = 51;
            this.dgvPersonel.RowTemplate.Height = 24;
            this.dgvPersonel.Size = new System.Drawing.Size(961, 155);
            this.dgvPersonel.TabIndex = 17;
            this.dgvPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_CellClick);
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPozisyon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbPozisyon.FormattingEnabled = true;
            this.cmbPozisyon.Location = new System.Drawing.Point(137, 440);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(121, 24);
            this.cmbPozisyon.TabIndex = 16;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(137, 395);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartman.TabIndex = 15;
            // 
            // txtMaas
            // 
            this.txtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaas.Location = new System.Drawing.Point(137, 350);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 22);
            this.txtMaas.TabIndex = 13;
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTC.Location = new System.Drawing.Point(137, 309);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 12;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoyad.Location = new System.Drawing.Point(137, 265);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAd.Location = new System.Drawing.Point(137, 221);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 10;
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAd.Location = new System.Drawing.Point(27, 227);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(44, 16);
            this.lblAd.TabIndex = 20;
            this.lblAd.Text = "Ad :";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSoyad.Location = new System.Drawing.Point(27, 269);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(67, 16);
            this.lblSoyad.TabIndex = 21;
            this.lblSoyad.Text = "Soyad :";
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTC
            // 
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTC.Location = new System.Drawing.Point(27, 315);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(45, 16);
            this.lblTC.TabIndex = 23;
            this.lblTC.Text = "TC :";
            this.lblTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaas
            // 
            this.lblMaas.BackColor = System.Drawing.Color.Transparent;
            this.lblMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaas.Location = new System.Drawing.Point(27, 356);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(61, 16);
            this.lblMaas.TabIndex = 22;
            this.lblMaas.Text = "Maaş :";
            this.lblMaas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartman
            // 
            this.lblDepartman.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDepartman.Location = new System.Drawing.Point(27, 403);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(94, 16);
            this.lblDepartman.TabIndex = 25;
            this.lblDepartman.Text = "Departman :";
            this.lblDepartman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.BackColor = System.Drawing.Color.Transparent;
            this.lblPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPozisyon.Location = new System.Drawing.Point(27, 444);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(82, 16);
            this.lblPozisyon.TabIndex = 24;
            this.lblPozisyon.Text = "Pozisyon :";
            this.lblPozisyon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxKaydet
            // 
            this.picboxKaydet.BackColor = System.Drawing.Color.Transparent;
            this.picboxKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxKaydet.BackgroundImage")));
            this.picboxKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxKaydet.Location = new System.Drawing.Point(358, 256);
            this.picboxKaydet.Name = "picboxKaydet";
            this.picboxKaydet.Size = new System.Drawing.Size(163, 137);
            this.picboxKaydet.TabIndex = 26;
            this.picboxKaydet.TabStop = false;
            this.picboxKaydet.Click += new System.EventHandler(this.picboxKaydet_Click);
            // 
            // picboxGuncelle
            // 
            this.picboxGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.picboxGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxGuncelle.BackgroundImage")));
            this.picboxGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxGuncelle.Location = new System.Drawing.Point(545, 256);
            this.picboxGuncelle.Name = "picboxGuncelle";
            this.picboxGuncelle.Size = new System.Drawing.Size(163, 137);
            this.picboxGuncelle.TabIndex = 27;
            this.picboxGuncelle.TabStop = false;
            this.picboxGuncelle.Click += new System.EventHandler(this.picboxGuncelle_Click);
            // 
            // picboxSil
            // 
            this.picboxSil.BackColor = System.Drawing.Color.Transparent;
            this.picboxSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxSil.BackgroundImage")));
            this.picboxSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxSil.Location = new System.Drawing.Point(723, 256);
            this.picboxSil.Name = "picboxSil";
            this.picboxSil.Size = new System.Drawing.Size(163, 137);
            this.picboxSil.TabIndex = 28;
            this.picboxSil.TabStop = false;
            this.picboxSil.Click += new System.EventHandler(this.picboxSil_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(881, 406);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(92, 62);
            this.picboxAnaMenuDon.TabIndex = 29;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 480);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.picboxSil);
            this.Controls.Add(this.picboxGuncelle);
            this.Controls.Add(this.picboxKaydet);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblPozisyon);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.cmbPozisyon);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonel";
            this.Text = "Personel Yönetim";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.ComboBox cmbPozisyon;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.PictureBox picboxKaydet;
        private System.Windows.Forms.PictureBox picboxGuncelle;
        private System.Windows.Forms.PictureBox picboxSil;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
    }
}