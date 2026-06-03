using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mssqldeneme2.DAL;
using mssqldeneme2.Entitiy;

namespace StarsisApp.UI
{
    public partial class FrmPozisyon : Form
    {
        public FrmPozisyon()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblPozisyonAdi.BackColor = Color.FromArgb(60, 99, 130); // RGB
        }

        private void FrmPozisyon_Load(object sender, EventArgs e)
        {
            PozisyonDAL dal = new PozisyonDAL();
            dgvPozisyon.DataSource = dal.PozisyonListele();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPozisyonAdi.Text))
            {
                MessageBox.Show("Pozisyon adı boş olamaz");
                return;
            }

            Pozisyon p = new Pozisyon()
            {
                PozisyonAdi = txtPozisyonAdi.Text.Trim()
            };

            PozisyonDAL dal = new PozisyonDAL();
            dal.PozisyonEkle(p);

            dgvPozisyon.DataSource = dal.PozisyonListele();
            txtPozisyonAdi.Clear();

            MessageBox.Show("Pozisyon eklendi ✔");
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmIKSecim frmIKSecim = new FrmIKSecim();
            frmIKSecim.Show();
            this.Hide();
        }
    }
}
