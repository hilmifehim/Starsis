using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mssqldeneme2.DAL;
using mssqldeneme2.Entitiy;

namespace StarsisApp.UI
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblAd.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblSoyad.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblTC.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblMaas.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblDepartman.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblPozisyon.BackColor = Color.FromArgb(60, 99, 130); // RGB
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da1 = new SqlDataAdapter(
                    "SELECT DepartmanID, DepartmanAdi FROM Departman", conn);
                System.Data.DataTable dt1 = new System.Data.DataTable();
                da1.Fill(dt1);

                cmbDepartman.DisplayMember = "DepartmanAdi";
                cmbDepartman.ValueMember = "DepartmanID";
                cmbDepartman.DataSource = dt1;

                SqlDataAdapter da2 = new SqlDataAdapter(
                    "SELECT PozisyonID, PozisyonAdi FROM Pozisyon", conn);
                System.Data.DataTable dt2 = new System.Data.DataTable();
                da2.Fill(dt2);

                cmbPozisyon.DisplayMember = "PozisyonAdi";
                cmbPozisyon.ValueMember = "PozisyonID";
                cmbPozisyon.DataSource = dt2;
            }

            PersonelDAL personelDAL = new PersonelDAL();
            dgvPersonel.DataSource = personelDAL.PersonelListele();

        }


        int secilenID = 0;
        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dgvPersonel.Rows[e.RowIndex].Cells["PersonelID"].Value);

            txtAd.Text = dgvPersonel.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
            txtSoyad.Text = dgvPersonel.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
            txtMaas.Text = dgvPersonel.Rows[e.RowIndex].Cells["Maas"].Value.ToString();
        }

        private void picboxKaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TCNo = txtTC.Text,
                Maas = decimal.Parse(txtMaas.Text),
                DepartmanID = (int)cmbDepartman.SelectedValue,
                PozisyonID = (int)cmbPozisyon.SelectedValue
            };

            PersonelDAL dal = new PersonelDAL();
            dal.PersonelEkle(p);

            MessageBox.Show("Personel eklendi ✔");
            PersonelDAL personelDAL = new PersonelDAL();
            dgvPersonel.DataSource = personelDAL.PersonelListele();

            txtAd.Text = null;
            txtSoyad.Text = null;
            txtMaas.Text = null;
            txtTC.Text = null;
            cmbDepartman.SelectedIndex = 0;
            cmbPozisyon .SelectedIndex = 0;
        }

        private void picboxGuncelle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel()
            {
                PersonelID = secilenID,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Maas = decimal.Parse(txtMaas.Text),
                DepartmanID = (int)cmbDepartman.SelectedValue,
                PozisyonID = (int)cmbPozisyon.SelectedValue
            };

            PersonelDAL dal = new PersonelDAL();
            dal.PersonelGuncelle(p);

            dgvPersonel.DataSource = dal.PersonelListele();
            MessageBox.Show("Güncellendi ✔");

            PersonelDAL personelDAL = new PersonelDAL();
            dgvPersonel.DataSource = personelDAL.PersonelListele();
        }

        private void picboxSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0) return;

            DialogResult dr = MessageBox.Show(
                "Silmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                PersonelDAL dal = new PersonelDAL();
                dal.PersonelSil(secilenID);

                dgvPersonel.DataSource = dal.PersonelListele();
                MessageBox.Show("Silindi ✔");

                PersonelDAL personelDAL = new PersonelDAL();
                dgvPersonel.DataSource = personelDAL.PersonelListele();
            }
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmIKSecim frmIKSecim = new FrmIKSecim();
            frmIKSecim.Show();
            this.Hide();
        }
    }
}
