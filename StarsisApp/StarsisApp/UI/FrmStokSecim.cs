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
    public partial class FrmStokSecim : Form
    {
        public FrmStokSecim()
        {
            InitializeComponent();
        }

        void FormAc(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
        private void lblStokDurumu_Click(object sender, EventArgs e)
        {
            FormAc(new FrmStok());
            this.Hide();
        }

        private void lblTedarikciEkle_Click(object sender, EventArgs e)
        {
            FormAc(new FrmTedarikci());
            this.Hide();
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FormAc(new FrmAnaMenu());
            this.Hide();
        }
    }
}
