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
    public partial class FrmSatinAlmaSecim : Form
    {
        public FrmSatinAlmaSecim()
        {
            InitializeComponent();
        }
        void FormAc(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void lblSatinAlmaDetay_Click(object sender, EventArgs e)
        {
            FormAc(new FrmSatinAlmaDetay());
            this.Hide();
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FormAc(new FrmAnaMenu());
            this.Hide();
        }

        private void lblStokDurum_Click(object sender, EventArgs e)
        {
            FormAc(new FrmStok());
            this.Hide();
        }
    }
}
