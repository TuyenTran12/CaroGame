using System;
using System.Configuration;
using System.Data.SQLite;

namespace CoCaro
{
    public class DatabaseConnection
    {
        private string _connectionString = $"Data Source={AppDomain.CurrentDomain.BaseDirectory}GameCaro.db;Version=3;";

        public SQLiteConnection OpenConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(_connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("Kết nối thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi mở kết nối: " + ex.Message);
            }
            return conn;
        }

        // Hàm đóng kết nối
        public void CloseConnection(SQLiteConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("Kết nối đã được đóng.");
            }
        }
    }
}
