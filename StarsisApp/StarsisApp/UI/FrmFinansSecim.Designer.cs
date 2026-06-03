namespace StarsisApp.UI
{
    partial class FrmFinansSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinansSecim));
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            this.lblFinansRaporu = new System.Windows.Forms.Label();
            this.lblFinansHareket = new System.Windows.Forms.Label();
            this.lblHesapPlani = new System.Windows.Forms.Label();
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
            this.picboxAnaMenuDon.TabIndex = 25;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // lblFinansRaporu
            // 
            this.lblFinansRaporu.BackColor = System.Drawing.Color.Transparent;
            this.lblFinansRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinansRaporu.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFinansRaporu.Location = new System.Drawing.Point(295, 326);
            this.lblFinansRaporu.Name = "lblFinansRaporu";
            this.lblFinansRaporu.Size = new System.Drawing.Size(173, 65);
            this.lblFinansRaporu.TabIndex = 24;
            this.lblFinansRaporu.Text = "Finans Raporu";
            this.lblFinansRaporu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinansRaporu.Click += new System.EventHandler(this.lblFinansRaporu_Click);
            // 
            // lblFinansHareket
            // 
            this.lblFinansHareket.BackColor = System.Drawing.Color.Transparent;
            this.lblFinansHareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinansHareket.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFinansHareket.Location = new System.Drawing.Point(121, 326);
            this.lblFinansHareket.Name = "lblFinansHareket";
            this.lblFinansHareket.Size = new System.Drawing.Size(173, 65);
            this.lblFinansHareket.TabIndex = 23;
            this.lblFinansHareket.Text = "Finans Hareket";
            this.lblFinansHareket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinansHareket.Click += new System.EventHandler(this.lblFinansHareket_Click);
            // 
            // lblHesapPlani
            // 
            this.lblHesapPlani.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapPlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapPlani.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHesapPlani.Location = new System.Drawing.Point(489, 326);
            this.lblHesapPlani.Name = "lblHesapPlani";
            this.lblHesapPlani.Size = new System.Drawing.Size(173, 65);
            this.lblHesapPlani.TabIndex = 26;
            this.lblHesapPlani.Text = "Hesap Planı";
            this.lblHesapPlani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHesapPlani.Click += new System.EventHandler(this.lblHesapPlani_Click);
            // 
            // FrmFinansSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHesapPlani);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.lblFinansRaporu);
            this.Controls.Add(this.lblFinansHareket);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFinansSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finans Seçim";
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
        private System.Windows.Forms.Label lblFinansRaporu;
        private System.Windows.Forms.Label lblFinansHareket;
        private System.Windows.Forms.Label lblHesapPlani;
    }
}