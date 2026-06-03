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
    public partial class FrmAnaMenu : Form
    {
        
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        public string RolAdi;

        public string KullaniciRol { get; set; }


        bool YetkiliMi(params string[] roller)
        {
            return roller.Contains(KullaniciRol);
        }

        void FormAc(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void picboxIk_Click(object sender, EventArgs e)
        {
            if (!YetkiliMi("Admin", "IK"))
            {
                MessageBox.Show("Bu alana erişim yetkiniz yok");
                return;
            }
            FormAc(new FrmIKSecim());
            this.Hide();
        }

        private void picboxSatınAlma_Click(object sender, EventArgs e)
        {
            if (!YetkiliMi("Admin", "SatinAlma"))
            {
                MessageBox.Show("Bu alana erişim yetkiniz yok");
                return;
            }
            FormAc(new FrmSatinAlmaSecim());
            this.Hide();
        }

        private void picboxStok_Click(object sender, EventArgs e)
        {
            if (!YetkiliMi("Admin", "Stok"))
            {
                MessageBox.Show("Bu alana erişim yetkiniz yok");
                return;
            }
            FormAc(new FrmStokSecim());
            this.Hide();
        }

        private void picboxFinans_Click(object sender, EventArgs e)
        {
            if (!YetkiliMi("Admin", "Finans"))
            {
                MessageBox.Show("Bu alana erişim yetkiniz yok");
                return;
            }
            FormAc(new FrmFinansSecim());
            this.Hide();
        }

        private void picboxCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
