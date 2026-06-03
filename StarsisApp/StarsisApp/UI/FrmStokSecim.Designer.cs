namespace StarsisApp.UI
{
    partial class FrmStokSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokSecim));
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            this.lblTedarikciEkle = new System.Windows.Forms.Label();
            this.lblStokDurumu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(722, 401);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(66, 37);
            this.picboxAnaMenuDon.TabIndex = 22;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // lblTedarikciEkle
            // 
            this.lblTedarikciEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblTedarikciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedarikciEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTedarikciEkle.Location = new System.Drawing.Point(411, 329);
            this.lblTedarikciEkle.Name = "lblTedarikciEkle";
            this.lblTedarikciEkle.Size = new System.Drawing.Size(173, 65);
            this.lblTedarikciEkle.TabIndex = 20;
            this.lblTedarikciEkle.Text = "Tedarikçi Ekle";
            this.lblTedarikciEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTedarikciEkle.Click += new System.EventHandler(this.lblTedarikciEkle_Click);
            // 
            // lblStokDurumu
            // 
            this.lblStokDurumu.BackColor = System.Drawing.Color.Transparent;
            this.lblStokDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokDurumu.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStokDurumu.Location = new System.Drawing.Point(194, 329);
            this.lblStokDurumu.Name = "lblStokDurumu";
            this.lblStokDurumu.Size = new System.Drawing.Size(173, 65);
            this.lblStokDurumu.TabIndex = 19;
            this.lblStokDurumu.Text = "Stok Durumu";
            this.lblStokDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStokDurumu.Click += new System.EventHandler(this.lblStokDurumu_Click);
            // 
            // FrmStokSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.lblTedarikciEkle);
            this.Controls.Add(this.lblStokDurumu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStokSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Seçim";
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
        private System.Windows.Forms.Label lblTedarikciEkle;
        private System.Windows.Forms.Label lblStokDurumu;
    }
}