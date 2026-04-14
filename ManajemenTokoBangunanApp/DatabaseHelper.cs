using System;
using MySql.Data.MySqlClient;

namespace ManajemenTokoBangunanApp
{
    public static class DatabaseHelper
    {
        // setting koneksi ke database lokal
        private static string server = "localhost";
        private static string database = "db_tokoBangunan";
        private static string uid = "root";
        private static string password = "";

        private static string ConnectionString
        {
            get
            {
                return $"server={server};database={database};uid={uid};password={password};Convert Zero Datetime=True;SslMode=none;";
            }
        }

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Koneksi database gagal!\nPastikan XAMPP sudah dijalankan.\n\nError: " + ex.Message);
            }
        }

        // cek apakah bisa konek atau tidak
        public static bool CekKoneksi()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
