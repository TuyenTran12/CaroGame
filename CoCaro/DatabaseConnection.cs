using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CoCaro
{
    public class DatabaseConnection
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["GameCaroDB"].ConnectionString;

        public SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("Kết nối tới SQL Server thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi mở kết nối tới SQL Server: " + ex.Message);
                throw; 
            }
            return conn;
        }

        public void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("Kết nối tới SQL Server đã được đóng.");
            }
        }
    }
}
