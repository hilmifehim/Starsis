namespace StarsisApp.UI
{
    partial class FrmTedarikci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTedarikci));
            this.dgvTedarikci = new System.Windows.Forms.DataGridView();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.picboxKaydet = new System.Windows.Forms.PictureBox();
            this.picboxListele = new System.Windows.Forms.PictureBox();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTedarikci
            // 
            this.dgvTedarikci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTedarikci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTedarikci.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvTedarikci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTedarikci.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvTedarikci.Location = new System.Drawing.Point(326, 33);
            this.dgvTedarikci.Name = "dgvTedarikci";
            this.dgvTedarikci.ReadOnly = true;
            this.dgvTedarikci.RowHeadersWidth = 51;
            this.dgvTedarikci.RowTemplate.Height = 24;
            this.dgvTedarikci.Size = new System.Drawing.Size(462, 204);
            this.dgvTedarikci.TabIndex = 17;
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAdres.Location = new System.Drawing.Point(133, 146);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(122, 51);
            this.txtAdres.TabIndex = 14;
            // 
            // lblAdres
            // 
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdres.Location = new System.Drawing.Point(27, 158);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(68, 16);
            this.lblAdres.TabIndex = 13;
            this.lblAdres.Text = "Adres :";
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtxtTelefon.Location = new System.Drawing.Point(133, 105);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(122, 15);
            this.mtxtTelefon.TabIndex = 12;
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTel.Location = new System.Drawing.Point(27, 109);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(78, 16);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Telefon :";
            // 
            // txtFirma
            // 
            this.txtFirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFirma.Location = new System.Drawing.Point(133, 54);
            this.txtFirma.Multiline = true;
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(142, 22);
            this.txtFirma.TabIndex = 10;
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirmaAdi.Location = new System.Drawing.Point(23, 58);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(92, 16);
            this.lblFirmaAdi.TabIndex = 9;
            this.lblFirmaAdi.Text = "Firma Adı :";
            // 
            // picboxKaydet
            // 
            this.picboxKaydet.BackColor = System.Drawing.Color.Transparent;
            this.picboxKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxKaydet.BackgroundImage")));
            this.picboxKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxKaydet.Location = new System.Drawing.Point(81, 207);
            this.picboxKaydet.Name = "picboxKaydet";
            this.picboxKaydet.Size = new System.Drawing.Size(163, 137);
            this.picboxKaydet.TabIndex = 20;
            this.picboxKaydet.TabStop = false;
            this.picboxKaydet.Click += new System.EventHandler(this.picboxKaydet_Click);
            // 
            // picboxListele
            // 
            this.picboxListele.BackColor = System.Drawing.Color.Transparent;
            this.picboxListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxListele.BackgroundImage")));
            this.picboxListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxListele.Location = new System.Drawing.Point(482, 243);
            this.picboxListele.Name = "picboxListele";
            this.picboxListele.Size = new System.Drawing.Size(163, 137);
            this.picboxListele.TabIndex = 21;
            this.picboxListele.TabStop = false;
            this.picboxListele.Click += new System.EventHandler(this.picboxListele_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(696, 301);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(92, 62);
            this.picboxAnaMenuDon.TabIndex = 31;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // FrmTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.picboxListele);
            this.Controls.Add(this.picboxKaydet);
            this.Controls.Add(this.dgvTedarikci);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.lblFirmaAdi);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTedarikci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikci";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTedarikci;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.PictureBox picboxKaydet;
        private System.Windows.Forms.PictureBox picboxListele;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
    }
}