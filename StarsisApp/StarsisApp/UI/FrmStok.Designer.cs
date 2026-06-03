namespace StarsisApp.UI
{
    partial class FrmStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStok));
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.lblGuncelStokDurumu = new System.Windows.Forms.Label();
            this.picboxGuncelle = new System.Windows.Forms.PictureBox();
            this.picboxExceleAktar = new System.Windows.Forms.PictureBox();
            this.picboxPdfeDonustur = new System.Windows.Forms.PictureBox();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExceleAktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPdfeDonustur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStok
            // 
            this.dgvStok.AllowUserToAddRows = false;
            this.dgvStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStok.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvStok.Location = new System.Drawing.Point(16, 90);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.ReadOnly = true;
            this.dgvStok.RowHeadersWidth = 51;
            this.dgvStok.RowTemplate.Height = 24;
            this.dgvStok.Size = new System.Drawing.Size(542, 179);
            this.dgvStok.TabIndex = 3;
            // 
            // lblGuncelStokDurumu
            // 
            this.lblGuncelStokDurumu.BackColor = System.Drawing.Color.Transparent;
            this.lblGuncelStokDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.22F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelStokDurumu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGuncelStokDurumu.Location = new System.Drawing.Point(12, 9);
            this.lblGuncelStokDurumu.Name = "lblGuncelStokDurumu";
            this.lblGuncelStokDurumu.Size = new System.Drawing.Size(546, 78);
            this.lblGuncelStokDurumu.TabIndex = 21;
            this.lblGuncelStokDurumu.Text = "Güncel Stok Durumu";
            this.lblGuncelStokDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxGuncelle
            // 
            this.picboxGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.picboxGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxGuncelle.BackgroundImage")));
            this.picboxGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxGuncelle.Location = new System.Drawing.Point(48, 275);
            this.picboxGuncelle.Name = "picboxGuncelle";
            this.picboxGuncelle.Size = new System.Drawing.Size(209, 141);
            this.picboxGuncelle.TabIndex = 22;
            this.picboxGuncelle.TabStop = false;
            this.picboxGuncelle.Click += new System.EventHandler(this.picboxGuncelle_Click);
            // 
            // picboxExceleAktar
            // 
            this.picboxExceleAktar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxExceleAktar.BackgroundImage")));
            this.picboxExceleAktar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxExceleAktar.Location = new System.Drawing.Point(287, 289);
            this.picboxExceleAktar.Name = "picboxExceleAktar";
            this.picboxExceleAktar.Size = new System.Drawing.Size(100, 110);
            this.picboxExceleAktar.TabIndex = 23;
            this.picboxExceleAktar.TabStop = false;
            this.picboxExceleAktar.Click += new System.EventHandler(this.picboxExceleAktar_Click);
            // 
            // picboxPdfeDonustur
            // 
            this.picboxPdfeDonustur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxPdfeDonustur.BackgroundImage")));
            this.picboxPdfeDonustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPdfeDonustur.Location = new System.Drawing.Point(424, 289);
            this.picboxPdfeDonustur.Name = "picboxPdfeDonustur";
            this.picboxPdfeDonustur.Size = new System.Drawing.Size(99, 110);
            this.picboxPdfeDonustur.TabIndex = 24;
            this.picboxPdfeDonustur.TabStop = false;
            this.picboxPdfeDonustur.Click += new System.EventHandler(this.picboxPdfeDonustur_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(529, 396);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(60, 52);
            this.picboxAnaMenuDon.TabIndex = 33;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 451);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.picboxPdfeDonustur);
            this.Controls.Add(this.picboxExceleAktar);
            this.Controls.Add(this.picboxGuncelle);
            this.Controls.Add(this.lblGuncelStokDurumu);
            this.Controls.Add(this.dgvStok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Durumu";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExceleAktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPdfeDonustur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.Label lblGuncelStokDurumu;
        private System.Windows.Forms.PictureBox picboxGuncelle;
        private System.Windows.Forms.PictureBox picboxExceleAktar;
        private System.Windows.Forms.PictureBox picboxPdfeDonustur;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
    }
}