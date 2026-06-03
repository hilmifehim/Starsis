namespace StarsisApp.UI
{
    partial class FrmFinansHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinansHareket));
            this.dgvFinans = new System.Windows.Forms.DataGridView();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lblHesapAdi = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.cmbHesap = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFinans
            // 
            this.dgvFinans.AllowUserToAddRows = false;
            this.dgvFinans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinans.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvFinans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFinans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinans.Location = new System.Drawing.Point(30, 217);
            this.dgvFinans.Name = "dgvFinans";
            this.dgvFinans.ReadOnly = true;
            this.dgvFinans.RowHeadersWidth = 51;
            this.dgvFinans.RowTemplate.Height = 24;
            this.dgvFinans.Size = new System.Drawing.Size(670, 150);
            this.dgvFinans.TabIndex = 19;
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(240, 115);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(125, 22);
            this.dtTarih.TabIndex = 16;
            // 
            // lblHesapAdi
            // 
            this.lblHesapAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHesapAdi.Location = new System.Drawing.Point(77, 26);
            this.lblHesapAdi.Name = "lblHesapAdi";
            this.lblHesapAdi.Size = new System.Drawing.Size(122, 29);
            this.lblHesapAdi.TabIndex = 23;
            this.lblHesapAdi.Text = "Hesap Adı :";
            this.lblHesapAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTutar
            // 
            this.lblTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTutar.Location = new System.Drawing.Point(77, 66);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(122, 29);
            this.lblTutar.TabIndex = 24;
            this.lblTutar.Text = "Tutar :";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTarih.Location = new System.Drawing.Point(77, 108);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(122, 29);
            this.lblTarih.TabIndex = 25;
            this.lblTarih.Text = "Tarih :";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAciklama
            // 
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAciklama.Location = new System.Drawing.Point(77, 157);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(122, 29);
            this.lblAciklama.TabIndex = 26;
            this.lblAciklama.Text = "Açıklama :";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbHesap
            // 
            this.cmbHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHesap.FormattingEnabled = true;
            this.cmbHesap.Location = new System.Drawing.Point(240, 29);
            this.cmbHesap.Name = "cmbHesap";
            this.cmbHesap.Size = new System.Drawing.Size(121, 24);
            this.cmbHesap.TabIndex = 27;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTutar.Location = new System.Drawing.Point(240, 69);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(125, 29);
            this.txtTutar.TabIndex = 28;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAciklama.Location = new System.Drawing.Point(240, 160);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(125, 51);
            this.txtAciklama.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(402, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 97);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(706, 319);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(82, 62);
            this.picboxAnaMenuDon.TabIndex = 31;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // FrmFinansHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cmbHesap);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblHesapAdi);
            this.Controls.Add(this.dgvFinans);
            this.Controls.Add(this.dtTarih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFinansHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finans Hareket";
            this.Load += new System.EventHandler(this.FrmFinans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFinans;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label lblHesapAdi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.ComboBox cmbHesap;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
    }
}