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

namespace StarsisApp.UI
{
    public partial class FrmFinansHareket : Form
    {
        public FrmFinansHareket()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblHesapAdi.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblTutar.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblTarih.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblAciklama.BackColor = Color.FromArgb(60, 99, 130); // RGB
        }

        private void FrmFinans_Load(object sender, EventArgs e)
        {
            HesapGetir();
            FinansListele();
        }
        void HesapGetir()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                "SELECT HesapID, HesapAdi FROM HesapPlani", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbHesap.DisplayMember = "HesapAdi";
                cmbHesap.ValueMember = "HesapID";
                cmbHesap.DataSource = dt;
            }
        }

        void FinansListele()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT f.FinansHareketID, h.HesapAdi, f.Tutar, f.Tarih, f.Aciklama
          FROM FinansHareket f
          JOIN HesapPlani h ON f.HesapID = h.HesapID", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFinans.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                @"INSERT INTO FinansHareket
          (HesapID, Tutar, Tarih, Aciklama)
          VALUES (@h, @t, @d, @a)", con);

                cmd.Parameters.AddWithValue("@h", cmbHesap.SelectedValue);
                cmd.Parameters.AddWithValue("@t", Convert.ToDecimal(txtTutar.Text));
                cmd.Parameters.AddWithValue("@d", dtTarih.Value);
                cmd.Parameters.AddWithValue("@a", txtAciklama.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            FinansListele();
            MessageBox.Show("Finans hareketi eklendi ✅");
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmFinansSecim frmFinansSecim = new FrmFinansSecim();
            frmFinansSecim.Show();
            this.Hide();
        }
    }
}
