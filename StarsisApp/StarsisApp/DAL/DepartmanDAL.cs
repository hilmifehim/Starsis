using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mssqldeneme2.Entitiy;

namespace mssqldeneme2.DAL
{
    internal class DepartmanDAL
    {
        public void DepartmanEkle(Departman d)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Departman (DepartmanAdi) VALUES (@ad)", conn);

                cmd.Parameters.AddWithValue("@ad", d.DepartmanAdi);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable DepartmanListele()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DepartmanID, DepartmanAdi FROM Departman", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
