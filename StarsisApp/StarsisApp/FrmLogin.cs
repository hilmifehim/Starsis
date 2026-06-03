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
using StarsisApp.UI;

namespace mssqldeneme2.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {

        }

        private void picboxGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection con = DbConnection.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"SELECT r.RolAdi 
          FROM Kullanici k
          JOIN Rol r ON k.RolID = r.RolID
          WHERE k.KullaniciAdi = @kul AND k.Sifre = @sifre",
                con);

            cmd.Parameters.AddWithValue("@kul", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string rol = dr["RolAdi"].ToString();
                this.Hide();

                FrmAnaMenu frm = new FrmAnaMenu();
                frm.KullaniciRol = rol;
                frm.Show();
            }
            else
            {
                lblHata.Text = "Kullanıcı adı veya şifre hatalı";
            }

            con.Close();
        }
    }
}
