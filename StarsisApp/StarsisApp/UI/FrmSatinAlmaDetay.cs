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
    public partial class FrmSatinAlmaDetay : Form
    {
        public FrmSatinAlmaDetay()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblTedarikciAdi.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblTarih.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblHammaddeCinsi.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblMiktar.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblBirimFiyat.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblToplamTutar.BackColor = Color.FromArgb(60, 99, 130); // RGB
            nudMiktar.ValueChanged += (s, e) => ToplamHesapla();
            txtBirimFiyat.TextChanged += (s, e) => ToplamHesapla();
        }
        int aktifSiparisID;
        private void FrmSatinAlmaDetay_Load(object sender, EventArgs e)
        {
            HammaddeGetir();
            DetaylariGetir();
            TedarikciGetir();
            // 🧮 Olay bağlama (toplam otomatik hesaplansın)
            nudMiktar.ValueChanged += (s, ev) => ToplamHesapla();
            txtBirimFiyat.TextChanged += (s, ev) => ToplamHesapla();
            aktifSiparisID = 1;
        }

        void HammaddeGetir()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT HammaddeID, HammaddeAdi FROM Hammadde", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbHammadde.DisplayMember = "HammaddeAdi";
                cmbHammadde.ValueMember = "HammaddeID";
                cmbHammadde.DataSource = dt;
            }
        }

        void DetaylariGetir()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT d.SiparisID, h.HammaddeAdi, d.Miktar, d.BirimFiyat
                  FROM SatinAlmaSiparisDetay d
                  JOIN Hammadde h ON d.HammaddeID = h.HammaddeID", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDetay.DataSource = dt;
            }
        }
        void TedarikciGetir()
        {

            using (SqlConnection con = DbConnection.GetConnection())
            {
                // Tedarikçi
                SqlDataAdapter da1 = new SqlDataAdapter(
                "SELECT TedarikciID, FirmaAdi FROM Tedarikci", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                cmbTedarikci.DisplayMember = "FirmaAdi";
                cmbTedarikci.ValueMember = "TedarikciID";
                cmbTedarikci.DataSource = dt1;
            }
        }

        private void picboxSiparisDetayEkle_Click(object sender, EventArgs e)
        {
            if (cmbTedarikci.SelectedValue == null)
            {
                MessageBox.Show("Sipariş seçiniz");
                return;
            }

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                @"INSERT INTO SatinAlmaSiparisDetay
                  (SiparisID, HammaddeID, Miktar, BirimFiyat)
                  VALUES (@s,@h,@m,@b)", con);

                cmd.Parameters.AddWithValue("@s", aktifSiparisID);
                cmd.Parameters.AddWithValue("@h", cmbHammadde.SelectedValue);
                cmd.Parameters.AddWithValue("@m", nudMiktar.Value);
                cmd.Parameters.AddWithValue("@b", Convert.ToDecimal(txtBirimFiyat.Text));

                con.Open();
                cmd.ExecuteNonQuery();
            }

            DetaylariGetir();
            MessageBox.Show("Sipariş detayı eklendi ✅");
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmSatinAlmaSecim frmSatinAlmaSecim = new FrmSatinAlmaSecim();
            frmSatinAlmaSecim.Show();
            this.Hide();
        }

        void ToplamHesapla()
        {
            if (nudMiktar.Value > 0 && decimal.TryParse(txtBirimFiyat.Text, out decimal fiyat))
            {
                txtToplam.Text = (nudMiktar.Value * fiyat).ToString("0.00");
            }
            else
            {
                txtToplam.Text = "0";
            }
        }
    }
}
