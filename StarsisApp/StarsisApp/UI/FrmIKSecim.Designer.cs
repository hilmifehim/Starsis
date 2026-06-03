namespace StarsisApp.UI
{
    partial class FrmIKSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIKSecim));
            this.lblDepartmanEkle = new System.Windows.Forms.Label();
            this.lblPozisyonEkle = new System.Windows.Forms.Label();
            this.lblPersonelEkle = new System.Windows.Forms.Label();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmanEkle
            // 
            this.lblDepartmanEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDepartmanEkle.Location = new System.Drawing.Point(109, 326);
            this.lblDepartmanEkle.Name = "lblDepartmanEkle";
            this.lblDepartmanEkle.Size = new System.Drawing.Size(173, 65);
            this.lblDepartmanEkle.TabIndex = 15;
            this.lblDepartmanEkle.Text = "Departman Ekle";
            this.lblDepartmanEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDepartmanEkle.Click += new System.EventHandler(this.lblDepartmanEkle_Click);
            // 
            // lblPozisyonEkle
            // 
            this.lblPozisyonEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblPozisyonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyonEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPozisyonEkle.Location = new System.Drawing.Point(283, 326);
            this.lblPozisyonEkle.Name = "lblPozisyonEkle";
            this.lblPozisyonEkle.Size = new System.Drawing.Size(173, 65);
            this.lblPozisyonEkle.TabIndex = 16;
            this.lblPozisyonEkle.Text = "Pozisyon Ekle";
            this.lblPozisyonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPozisyonEkle.Click += new System.EventHandler(this.lblPozisyonEkle_Click);
            // 
            // lblPersonelEkle
            // 
            this.lblPersonelEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPersonelEkle.Location = new System.Drawing.Point(477, 326);
            this.lblPersonelEkle.Name = "lblPersonelEkle";
            this.lblPersonelEkle.Size = new System.Drawing.Size(173, 65);
            this.lblPersonelEkle.TabIndex = 17;
            this.lblPersonelEkle.Text = "Personel Ekle";
            this.lblPersonelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersonelEkle.Click += new System.EventHandler(this.lblPersonelEkle_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(722, 401);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(66, 37);
            this.picboxAnaMenuDon.TabIndex = 18;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // FrmIKSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.lblPersonelEkle);
            this.Controls.Add(this.lblPozisyonEkle);
            this.Controls.Add(this.lblDepartmanEkle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIKSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IK Seçim";
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmanEkle;
        private System.Windows.Forms.Label lblPozisyonEkle;
        private System.Windows.Forms.Label lblPersonelEkle;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
    }
}