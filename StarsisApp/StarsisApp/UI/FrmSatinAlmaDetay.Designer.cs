namespace StarsisApp.UI
{
    partial class FrmSatinAlmaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatinAlmaDetay));
            this.dgvDetay = new System.Windows.Forms.DataGridView();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblTedarikciAdi = new System.Windows.Forms.Label();
            this.lblHammaddeCinsi = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.cmbHammadde = new System.Windows.Forms.ComboBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.picboxSiparisDetayEkle = new System.Windows.Forms.PictureBox();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            this.dtSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSiparisDetayEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetay
            // 
            this.dgvDetay.AllowUserToAddRows = false;
            this.dgvDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetay.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvDetay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetay.Location = new System.Drawing.Point(30, 253);
            this.dgvDetay.Name = "dgvDetay";
            this.dgvDetay.ReadOnly = true;
            this.dgvDetay.RowHeadersWidth = 51;
            this.dgvDetay.RowTemplate.Height = 24;
            this.dgvDetay.Size = new System.Drawing.Size(646, 150);
            this.dgvDetay.TabIndex = 18;
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(171, 131);
            this.nudMiktar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(120, 22);
            this.nudMiktar.TabIndex = 15;
            this.nudMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTedarikciAdi
            // 
            this.lblTedarikciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblTedarikciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedarikciAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTedarikciAdi.Location = new System.Drawing.Point(27, 17);
            this.lblTedarikciAdi.Name = "lblTedarikciAdi";
            this.lblTedarikciAdi.Size = new System.Drawing.Size(122, 29);
            this.lblTedarikciAdi.TabIndex = 24;
            this.lblTedarikciAdi.Text = "Firma Adı :";
            this.lblTedarikciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHammaddeCinsi
            // 
            this.lblHammaddeCinsi.BackColor = System.Drawing.Color.Transparent;
            this.lblHammaddeCinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHammaddeCinsi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHammaddeCinsi.Location = new System.Drawing.Point(27, 96);
            this.lblHammaddeCinsi.Name = "lblHammaddeCinsi";
            this.lblHammaddeCinsi.Size = new System.Drawing.Size(122, 29);
            this.lblHammaddeCinsi.TabIndex = 25;
            this.lblHammaddeCinsi.Text = "Hammadde :";
            this.lblHammaddeCinsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiktar
            // 
            this.lblMiktar.BackColor = System.Drawing.Color.Transparent;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMiktar.Location = new System.Drawing.Point(27, 135);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(122, 29);
            this.lblMiktar.TabIndex = 26;
            this.lblMiktar.Text = "Miktar :";
            this.lblMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimFiyat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBirimFiyat.Location = new System.Drawing.Point(27, 178);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(122, 29);
            this.lblBirimFiyat.TabIndex = 27;
            this.lblBirimFiyat.Text = "Birim Fiyat :";
            this.lblBirimFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(171, 22);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(121, 24);
            this.cmbTedarikci.TabIndex = 28;
            // 
            // cmbHammadde
            // 
            this.cmbHammadde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHammadde.FormattingEnabled = true;
            this.cmbHammadde.Location = new System.Drawing.Point(171, 96);
            this.cmbHammadde.Name = "cmbHammadde";
            this.cmbHammadde.Size = new System.Drawing.Size(121, 24);
            this.cmbHammadde.TabIndex = 29;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBirimFiyat.Location = new System.Drawing.Point(171, 178);
            this.txtBirimFiyat.Multiline = true;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(125, 25);
            this.txtBirimFiyat.TabIndex = 30;
            // 
            // picboxSiparisDetayEkle
            // 
            this.picboxSiparisDetayEkle.BackColor = System.Drawing.Color.Transparent;
            this.picboxSiparisDetayEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxSiparisDetayEkle.BackgroundImage")));
            this.picboxSiparisDetayEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxSiparisDetayEkle.Location = new System.Drawing.Point(423, 68);
            this.picboxSiparisDetayEkle.Name = "picboxSiparisDetayEkle";
            this.picboxSiparisDetayEkle.Size = new System.Drawing.Size(167, 120);
            this.picboxSiparisDetayEkle.TabIndex = 31;
            this.picboxSiparisDetayEkle.TabStop = false;
            this.picboxSiparisDetayEkle.Click += new System.EventHandler(this.picboxSiparisDetayEkle_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(674, 434);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(60, 52);
            this.picboxAnaMenuDon.TabIndex = 38;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // dtSiparisTarihi
            // 
            this.dtSiparisTarihi.Location = new System.Drawing.Point(171, 68);
            this.dtSiparisTarihi.Name = "dtSiparisTarihi";
            this.dtSiparisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtSiparisTarihi.TabIndex = 39;
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTarih.Location = new System.Drawing.Point(27, 61);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(122, 29);
            this.lblTarih.TabIndex = 40;
            this.lblTarih.Text = "Tarih :";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(171, 434);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(137, 22);
            this.txtToplam.TabIndex = 41;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToplamTutar.Location = new System.Drawing.Point(31, 427);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(122, 29);
            this.lblToplamTutar.TabIndex = 42;
            this.lblToplamTutar.Text = "ToplamTutar :";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSatinAlmaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 498);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dtSiparisTarihi);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.picboxSiparisDetayEkle);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.cmbHammadde);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblHammaddeCinsi);
            this.Controls.Add(this.lblTedarikciAdi);
            this.Controls.Add(this.dgvDetay);
            this.Controls.Add(this.nudMiktar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSatinAlmaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satın Alma Detay";
            this.Load += new System.EventHandler(this.FrmSatinAlmaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSiparisDetayEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetay;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label lblTedarikciAdi;
        private System.Windows.Forms.Label lblHammaddeCinsi;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.ComboBox cmbHammadde;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.PictureBox picboxSiparisDetayEkle;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
        private System.Windows.Forms.DateTimePicker dtSiparisTarihi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}