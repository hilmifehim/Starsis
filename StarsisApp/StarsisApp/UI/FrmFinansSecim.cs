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
    public partial class FrmFinansSecim : Form
    {
        public FrmFinansSecim()
        {
            InitializeComponent();
        }
        void FormAc(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void lblFinansHareket_Click(object sender, EventArgs e)
        {
            FormAc(new FrmFinansHareket());
            this.Hide();
        }

        private void lblFinansRaporu_Click(object sender, EventArgs e)
        {
            FormAc(new FrmFinansRapor());
            this.Hide();
        }

        private void lblHesapPlani_Click(object sender, EventArgs e)
        {
            FormAc(new FrmHesapPlani());
            this.Hide();
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FormAc(new FrmAnaMenu());
            this.Hide();
        }
    }
}
