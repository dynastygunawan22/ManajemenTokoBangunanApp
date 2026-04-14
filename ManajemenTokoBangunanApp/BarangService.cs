using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ManajemenTokoBangunanApp
{
    public class BarangService
    {
        // ambil semua barang, bisa difilter pakai keyword
        public List<Barang> GetSemuaBarang(string keyword = "")
        {
            List<Barang> list = new List<Barang>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT b.id_barang, b.kode_barang, b.nama_barang,
                                        b.id_kategori, k.nama_kategori, k.satuan,
                                        b.stok, b.stok_minimum, b.harga_beli, b.harga_jual
                                 FROM barang b
                                 JOIN kategori k ON b.id_kategori = k.id_kategori
                                 WHERE b.nama_barang LIKE @keyword
                                    OR b.kode_barang LIKE @keyword
                                 ORDER BY b.nama_barang";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Barang b = new Barang();
                        b.IdBarang = reader.GetInt32("id_barang");
                        b.KodeBarang = reader.GetString("kode_barang");
                        b.NamaBarang = reader.GetString("nama_barang");
                        b.IdKategori = reader.GetInt32("id_kategori");
                        b.NamaKategori = reader.GetString("nama_kategori");
                        b.Satuan = reader.GetString("satuan");
                        b.Stok = reader.GetInt32("stok");
                        b.StokMinimum = reader.GetInt32("stok_minimum");
                        b.HargaBeli = reader.GetDecimal("harga_beli");
                        b.HargaJual = reader.GetDecimal("harga_jual");
                        list.Add(b);
                    }
                }
            }

            return list;
        }

        public Barang GetBarangById(int id)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT b.id_barang, b.kode_barang, b.nama_barang,
                                        b.id_kategori, k.nama_kategori, k.satuan,
                                        b.stok, b.stok_minimum, b.harga_beli, b.harga_jual
                                 FROM barang b
                                 JOIN kategori k ON b.id_kategori = k.id_kategori
                                 WHERE b.id_barang = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Barang b = new Barang();
                        b.IdBarang = reader.GetInt32("id_barang");
                        b.KodeBarang = reader.GetString("kode_barang");
                        b.NamaBarang = reader.GetString("nama_barang");
                        b.IdKategori = reader.GetInt32("id_kategori");
                        b.NamaKategori = reader.GetString("nama_kategori");
                        b.Satuan = reader.GetString("satuan");
                        b.Stok = reader.GetInt32("stok");
                        b.StokMinimum = reader.GetInt32("stok_minimum");
                        b.HargaBeli = reader.GetDecimal("harga_beli");
                        b.HargaJual = reader.GetDecimal("harga_jual");
                        return b;
                    }
                }
            }
            return null;
        }

        public string TambahBarang(Barang b)
        {
            // validasi dulu sebelum simpan
            if (string.IsNullOrWhiteSpace(b.KodeBarang))
                return "Kode barang harus diisi!";
            if (string.IsNullOrWhiteSpace(b.NamaBarang))
                return "Nama barang harus diisi!";
            if (b.HargaJual < b.HargaBeli)
                return "Harga jual tidak boleh lebih kecil dari harga beli!";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO barang (kode_barang, nama_barang, id_kategori,
                                                         stok, stok_minimum, harga_beli, harga_jual)
                                     VALUES (@kode, @nama, @idkat, 0, @min, @beli, @jual)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kode", b.KodeBarang.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("@nama", b.NamaBarang.Trim());
                    cmd.Parameters.AddWithValue("@idkat", b.IdKategori);
                    cmd.Parameters.AddWithValue("@min", b.StokMinimum);
                    cmd.Parameters.AddWithValue("@beli", b.HargaBeli);
                    cmd.Parameters.AddWithValue("@jual", b.HargaJual);
                    cmd.ExecuteNonQuery();
                }
                return "OK";
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    return "Kode barang sudah dipakai!";
                return "Error: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string EditBarang(Barang b)
        {
            if (string.IsNullOrWhiteSpace(b.NamaBarang))
                return "Nama barang harus diisi!";
            if (b.HargaJual < b.HargaBeli)
                return "Harga jual tidak boleh lebih kecil dari harga beli!";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"UPDATE barang
                                     SET nama_barang = @nama,
                                         id_kategori = @idkat,
                                         stok_minimum = @min,
                                         harga_beli = @beli,
                                         harga_jual = @jual
                                     WHERE id_barang = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", b.NamaBarang.Trim());
                    cmd.Parameters.AddWithValue("@idkat", b.IdKategori);
                    cmd.Parameters.AddWithValue("@min", b.StokMinimum);
                    cmd.Parameters.AddWithValue("@beli", b.HargaBeli);
                    cmd.Parameters.AddWithValue("@jual", b.HargaJual);
                    cmd.Parameters.AddWithValue("@id", b.IdBarang);
                    cmd.ExecuteNonQuery();
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string HapusBarang(int idBarang)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // cek dulu ada transaksinya atau tidak
                    string cek = "SELECT COUNT(*) FROM transaksi WHERE id_barang = @id";
                    MySqlCommand cmdCek = new MySqlCommand(cek, conn);
                    cmdCek.Parameters.AddWithValue("@id", idBarang);
                    int jumlah = Convert.ToInt32(cmdCek.ExecuteScalar());

                    if (jumlah > 0)
                        return "Barang tidak bisa dihapus karena sudah ada transaksinya!";

                    string query = "DELETE FROM barang WHERE id_barang = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idBarang);
                    cmd.ExecuteNonQuery();
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // hitung total nilai stok pakai rekursif
        public decimal HitungTotalNilaiStok(List<Barang> daftar, int index = 0)
        {
            if (index >= daftar.Count)
                return 0;

            decimal nilaiBarangIni = daftar[index].Stok * daftar[index].HargaBeli;
            return nilaiBarangIni + HitungTotalNilaiStok(daftar, index + 1);
        }
    }
}
