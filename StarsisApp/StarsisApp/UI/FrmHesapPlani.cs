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
    public partial class FrmHesapPlani : Form
    {
        public FrmHesapPlani()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblHesapAdi.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblHesapTuru.BackColor = Color.FromArgb(60, 99, 130); // RGB
        }

        private void FrmHesapPlani_Load(object sender, EventArgs e)
        {
            cmbHesapTuru.Items.Clear();
            cmbHesapTuru.Items.Add("Gelir");
            cmbHesapTuru.Items.Add("Gider");
            cmbHesapTuru.SelectedIndex = 0;
            Listele();
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM HesapPlani",
                DbConnection.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHesapPlani.DataSource = dt;
        }

        private void dgvHesapPlani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHesapAdi.Text = dgvHesapPlani.CurrentRow.Cells["HesapAdi"].Value.ToString();

            cmbHesapTuru.Text = dgvHesapPlani.CurrentRow.Cells["HesapTuru"].Value.ToString();
        }

        private void picboxEkle_Click(object sender, EventArgs e)
        {
            if (txtHesapAdi.Text == "" || cmbHesapTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm alanları doldurun");
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO HesapPlani (HesapAdi, HesapTuru) VALUES (@adi, @tur)",
                DbConnection.GetConnection());

            cmd.Parameters.AddWithValue("@adi", txtHesapAdi.Text);
            cmd.Parameters.AddWithValue("@tur", cmbHesapTuru.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("Hesap planı eklendi");
            Listele();
        }

        private void picboxListele_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT HesapID, HesapAdi, HesapTuru FROM HesapPlani", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHesapPlani.DataSource = dt;
            }
        }

        private void picboxSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvHesapPlani.CurrentRow.Cells["HesapID"].Value);

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM HesapPlani WHERE HesapID=@id",
                DbConnection.GetConnection());

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("Silindi");
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmFinansSecim frmFinansSecim = new FrmFinansSecim();
            frmFinansSecim.Show();
            this.Hide();
        }
    }
}
