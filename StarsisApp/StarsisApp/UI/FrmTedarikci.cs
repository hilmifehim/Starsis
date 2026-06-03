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
    public partial class FrmTedarikci : Form
    {
        public FrmTedarikci()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblAdres.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblFirmaAdi.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblTel.BackColor = Color.FromArgb(60, 99, 130); // RGB
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tedarikci", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTedarikci.DataSource = dt;
            }
        }

        private void picboxKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Tedarikci (FirmaAdi, Telefon, Adres) VALUES (@f, @t, @a)", con);

                cmd.Parameters.AddWithValue("@f", txtFirma.Text);
                cmd.Parameters.AddWithValue("@t", mtxtTelefon.Text);
                cmd.Parameters.AddWithValue("@a", txtAdres.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Tedarikçi eklendi");
            }
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tedarikci", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTedarikci.DataSource = dt;
            }
        }

        private void picboxListele_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tedarikci", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTedarikci.DataSource = dt;
            }
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmStokSecim frmStokSecim = new FrmStokSecim();
            frmStokSecim.Show();
            this.Hide();
        }
    }
}
