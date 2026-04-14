using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ManajemenTokoBangunanApp
{
    public class KategoriService
    {
        public List<Kategori> GetSemuaKategori()
        {
            List<Kategori> list = new List<Kategori>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM kategori ORDER BY nama_kategori";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kategori k = new Kategori();
                        k.IdKategori = reader.GetInt32("id_kategori");
                        k.NamaKategori = reader.GetString("nama_kategori");
                        k.Satuan = reader.GetString("satuan");
                        list.Add(k);
                    }
                }
            }

            return list;
        }
    }
}
