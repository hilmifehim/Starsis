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
using mssqldeneme2.UI;

namespace StarsisApp.UI
{
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblDepartmanAdi.BackColor = Color.FromArgb(60, 99, 130); // RGB
        }


        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            DepartmanDAL dal = new DepartmanDAL();
            dgvDepartman.DataSource = dal.DepartmanListele();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Departman d = new Departman()
            {
                DepartmanAdi = txtDepartmanAdi.Text
            };

            DepartmanDAL dal = new DepartmanDAL();
            dal.DepartmanEkle(d);

            dgvDepartman.DataSource = dal.DepartmanListele();
            txtDepartmanAdi.Clear();

            MessageBox.Show("Departman eklendi ✔");
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmIKSecim frmIKSecim = new FrmIKSecim();
            frmIKSecim.Show();
            this.Hide();
        }
    }
}
