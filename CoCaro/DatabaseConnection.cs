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
        //phương thức update
        public void UpdateScore(string username, int score)
        {
            using (SqlConnection conn = OpenConnection())
            {
                string query = "UPDATE Login SET score = score + @score WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int GetScore(string username)
        {
            int score = 0;
            using (SqlConnection conn = OpenConnection())
            {
                string query = "SELECT score FROM Login WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        score = reader.GetInt32(0);
                    }
                }
            }
            return score;
        }
    }
}
