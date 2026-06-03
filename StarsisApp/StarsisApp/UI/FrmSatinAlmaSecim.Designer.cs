namespace StarsisApp.UI
{
    partial class FrmSatinAlmaSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatinAlmaSecim));
            this.lblSatinAlmaDetay = new System.Windows.Forms.Label();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            this.lblStokDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSatinAlmaDetay
            // 
            this.lblSatinAlmaDetay.BackColor = System.Drawing.Color.Transparent;
            this.lblSatinAlmaDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatinAlmaDetay.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSatinAlmaDetay.Location = new System.Drawing.Point(211, 300);
            this.lblSatinAlmaDetay.Name = "lblSatinAlmaDetay";
            this.lblSatinAlmaDetay.Size = new System.Drawing.Size(173, 65);
            this.lblSatinAlmaDetay.TabIndex = 28;
            this.lblSatinAlmaDetay.Text = "Satın Alma Detay";
            this.lblSatinAlmaDetay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSatinAlmaDetay.Click += new System.EventHandler(this.lblSatinAlmaDetay_Click);
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(722, 401);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(66, 37);
            this.picboxAnaMenuDon.TabIndex = 30;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // lblStokDurum
            // 
            this.lblStokDurum.BackColor = System.Drawing.Color.Transparent;
            this.lblStokDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokDurum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStokDurum.Location = new System.Drawing.Point(405, 300);
            this.lblStokDurum.Name = "lblStokDurum";
            this.lblStokDurum.Size = new System.Drawing.Size(173, 65);
            this.lblStokDurum.TabIndex = 31;
            this.lblStokDurum.Text = "Stok  Durum";
            this.lblStokDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStokDurum.Click += new System.EventHandler(this.lblStokDurum_Click);
            // 
            // FrmSatinAlmaSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStokDurum);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.lblSatinAlmaDetay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSatinAlmaSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satın Alma Seçim";
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSatinAlmaDetay;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
        private System.Windows.Forms.Label lblStokDurum;
    }
}