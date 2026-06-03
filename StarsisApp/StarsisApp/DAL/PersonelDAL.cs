using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mssqldeneme2.Entitiy;

namespace mssqldeneme2.DAL
{
    internal class PersonelDAL
    {
        public void PersonelEkle(Personel p)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_PersonelEkle", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ad", p.Ad);
                cmd.Parameters.AddWithValue("@Soyad", p.Soyad);
                cmd.Parameters.AddWithValue("@TCNo", p.TCNo);
                cmd.Parameters.AddWithValue("@DogumTarihi", System.DateTime.Now);
                cmd.Parameters.AddWithValue("@Maas", p.Maas);
                cmd.Parameters.AddWithValue("@IseGirisTarihi", System.DateTime.Now);
                cmd.Parameters.AddWithValue("@DepartmanID", p.DepartmanID);
                cmd.Parameters.AddWithValue("@PozisyonID", p.PozisyonID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void PersonelSil(int personelID)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Personel WHERE PersonelID=@id", conn);

                cmd.Parameters.AddWithValue("@id", personelID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable PersonelListele()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM vw_PersonelListesi", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void PersonelGuncelle(Personel p)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Personel SET 
              Ad=@Ad,
              Soyad=@Soyad,
              Maas=@Maas,
              DepartmanID=@DepID,
              PozisyonID=@PozID
              WHERE PersonelID=@ID", conn);

                cmd.Parameters.AddWithValue("@Ad", p.Ad);
                cmd.Parameters.AddWithValue("@Soyad", p.Soyad);
                cmd.Parameters.AddWithValue("@Maas", p.Maas);
                cmd.Parameters.AddWithValue("@DepID", p.DepartmanID);
                cmd.Parameters.AddWithValue("@PozID", p.PozisyonID);
                cmd.Parameters.AddWithValue("@ID", p.PersonelID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}


