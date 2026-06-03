namespace mssqldeneme2.UI
{
    partial class FrmLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblHata = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxGirisYap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGirisYap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.BackColor = System.Drawing.Color.Transparent;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(222, 53);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 31);
            this.lblHata.TabIndex = 11;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(426, 365);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 9;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(426, 319);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(207, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 65);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifreniz :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(159, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 65);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı Adınız :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxGirisYap
            // 
            this.picboxGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.picboxGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxGirisYap.BackgroundImage")));
            this.picboxGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxGirisYap.Location = new System.Drawing.Point(235, 393);
            this.picboxGirisYap.Name = "picboxGirisYap";
            this.picboxGirisYap.Size = new System.Drawing.Size(312, 123);
            this.picboxGirisYap.TabIndex = 19;
            this.picboxGirisYap.TabStop = false;
            this.picboxGirisYap.Click += new System.EventHandler(this.picboxGirisYap_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.picboxGirisYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STARSİS";
            ((System.ComponentModel.ISupportInitialize)(this.picboxGirisYap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxGirisYap;
    }
}

