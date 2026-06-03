using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarsisApp.UI
{
    public partial class FrmIKSecim : Form
    {
        public FrmIKSecim()
        {
            InitializeComponent();
        }

        void FormAc(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void lblDepartmanEkle_Click(object sender, EventArgs e)
        {
            FormAc(new FrmDepartman()); 
            this.Hide();
        }

        private void lblPozisyonEkle_Click(object sender, EventArgs e)
        {
            FormAc(new FrmPozisyon());
            this.Hide();
        }

        private void lblPersonelEkle_Click(object sender, EventArgs e)
        {
            FormAc(new FrmPersonel());
            this.Hide();
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FormAc(new FrmAnaMenu());
            this.Hide();
        }
    }
}
