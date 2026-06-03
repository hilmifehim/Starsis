namespace StarsisApp.UI
{
    partial class FrmDepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartman));
            this.dgvDepartman = new System.Windows.Forms.DataGridView();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDepartmanAdi = new System.Windows.Forms.TextBox();
            this.picboxAnaMenuDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepartman
            // 
            this.dgvDepartman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartman.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvDepartman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDepartman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartman.Location = new System.Drawing.Point(23, 12);
            this.dgvDepartman.MultiSelect = false;
            this.dgvDepartman.Name = "dgvDepartman";
            this.dgvDepartman.ReadOnly = true;
            this.dgvDepartman.RowHeadersWidth = 51;
            this.dgvDepartman.RowTemplate.Height = 24;
            this.dgvDepartman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartman.Size = new System.Drawing.Size(714, 249);
            this.dgvDepartman.TabIndex = 3;
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDepartmanAdi.Location = new System.Drawing.Point(189, 293);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(150, 41);
            this.lblDepartmanAdi.TabIndex = 7;
            this.lblDepartmanAdi.Text = "Departman Adı :";
            this.lblDepartmanAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(284, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 87);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtDepartmanAdi
            // 
            this.txtDepartmanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartmanAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDepartmanAdi.Location = new System.Drawing.Point(331, 302);
            this.txtDepartmanAdi.Multiline = true;
            this.txtDepartmanAdi.Name = "txtDepartmanAdi";
            this.txtDepartmanAdi.Size = new System.Drawing.Size(125, 29);
            this.txtDepartmanAdi.TabIndex = 12;
            // 
            // picboxAnaMenuDon
            // 
            this.picboxAnaMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.picboxAnaMenuDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxAnaMenuDon.BackgroundImage")));
            this.picboxAnaMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxAnaMenuDon.Location = new System.Drawing.Point(660, 367);
            this.picboxAnaMenuDon.Name = "picboxAnaMenuDon";
            this.picboxAnaMenuDon.Size = new System.Drawing.Size(92, 62);
            this.picboxAnaMenuDon.TabIndex = 13;
            this.picboxAnaMenuDon.TabStop = false;
            this.picboxAnaMenuDon.Click += new System.EventHandler(this.picboxAnaMenuDon_Click);
            // 
            // FrmDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(764, 446);
            this.Controls.Add(this.picboxAnaMenuDon);
            this.Controls.Add(this.txtDepartmanAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDepartmanAdi);
            this.Controls.Add(this.dgvDepartman);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDepartman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Ekle";
            this.Load += new System.EventHandler(this.FrmDepartman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnaMenuDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDepartman;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDepartmanAdi;
        private System.Windows.Forms.PictureBox picboxAnaMenuDon;
    }
}