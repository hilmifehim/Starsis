using System.Data.SqlClient;

public static class DbConnection
{
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(
            @"Server=localhost;Database=StarsisDB;Trusted_Connection=True;");
    }
}