using System;
using System.Configuration;
using System.Data.SQLite;
using System.IO;

namespace CoCaro
{
    public class DatabaseConnection
    {
        private string oneDrivePath; 
        private string dbPath; 
        private string _connectionString;

        public DatabaseConnection()
        {
            oneDrivePath = Environment.GetEnvironmentVariable("OneDrive");
            dbPath = Path.Combine(oneDrivePath, "GameCaro.db");

            _connectionString = $"Data Source={dbPath};Version=3;";
        }


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
