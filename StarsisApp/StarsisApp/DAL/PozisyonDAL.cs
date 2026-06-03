using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mssqldeneme2.Entitiy;

namespace mssqldeneme2.DAL
{
    internal class PozisyonDAL
    {
        public void PozisyonEkle(Pozisyon p)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Pozisyon (PozisyonAdi) VALUES (@ad)", conn);

                cmd.Parameters.AddWithValue("@ad", p.PozisyonAdi);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable PozisyonListele()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT PozisyonID, PozisyonAdi FROM Pozisyon", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
