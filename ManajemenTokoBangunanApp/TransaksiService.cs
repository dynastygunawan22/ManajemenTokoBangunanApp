using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ManajemenTokoBangunanApp
{
    public class TransaksiService
    {
        private string BuatNomorTransaksi(string jenis)
        {
            return jenis + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
        }

        public string ProsesBarangMasuk(int idBarang, int jumlah, decimal harga, string keterangan)
        {
            if (jumlah <= 0)
                return "Jumlah harus lebih dari 0!";
            if (harga < 0)
                return "Harga tidak boleh minus!";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    MySqlTransaction trx = conn.BeginTransaction();

                    try
                    {
                        string noTrx = BuatNomorTransaksi("MSK");
                        decimal total = jumlah * harga;

                        // simpan ke tabel transaksi
                        string q1 = @"INSERT INTO transaksi (no_transaksi, jenis_transaksi, id_barang,
                                                              jumlah, harga_satuan, total, keterangan)
                                      VALUES (@no, 'MASUK', @idbarang, @jml, @harga, @total, @ket)";

                        MySqlCommand cmd1 = new MySqlCommand(q1, conn, trx);
                        cmd1.Parameters.AddWithValue("@no", noTrx);
                        cmd1.Parameters.AddWithValue("@idbarang", idBarang);
                        cmd1.Parameters.AddWithValue("@jml", jumlah);
                        cmd1.Parameters.AddWithValue("@harga", harga);
                        cmd1.Parameters.AddWithValue("@total", total);
                        cmd1.Parameters.AddWithValue("@ket", keterangan ?? "");
                        cmd1.ExecuteNonQuery();

                        // tambah stok di tabel barang
                        string q2 = "UPDATE barang SET stok = stok + @jml WHERE id_barang = @id";
                        MySqlCommand cmd2 = new MySqlCommand(q2, conn, trx);
                        cmd2.Parameters.AddWithValue("@jml", jumlah);
                        cmd2.Parameters.AddWithValue("@id", idBarang);
                        cmd2.ExecuteNonQuery();

                        trx.Commit();
                        return "OK:" + noTrx;
                    }
                    catch
                    {
                        trx.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string ProsesBarangKeluar(int idBarang, int jumlah, decimal harga, string keterangan)
        {
            if (jumlah <= 0)
                return "Jumlah harus lebih dari 0!";
            if (harga < 0)
                return "Harga tidak boleh minus!";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // cek stok dulu sebelum proses
                    string cekQuery = "SELECT stok, nama_barang FROM barang WHERE id_barang = @id";
                    MySqlCommand cekCmd = new MySqlCommand(cekQuery, conn);
                    cekCmd.Parameters.AddWithValue("@id", idBarang);

                    int stokSekarang = 0;
                    string namaBarang = "";

                    using (MySqlDataReader r = cekCmd.ExecuteReader())
                    {
                        if (!r.Read()) return "Barang tidak ditemukan!";
                        stokSekarang = r.GetInt32("stok");
                        namaBarang = r.GetString("nama_barang");
                    }

                    if (stokSekarang == 0)
                        return "Stok " + namaBarang + " sudah habis!";

                    if (jumlah > stokSekarang)
                        return "Stok tidak cukup!\nStok tersedia: " + stokSekarang;

                    MySqlTransaction trx = conn.BeginTransaction();

                    try
                    {
                        string noTrx = BuatNomorTransaksi("KLR");
                        decimal total = jumlah * harga;

                        string q1 = @"INSERT INTO transaksi (no_transaksi, jenis_transaksi, id_barang,
                                                              jumlah, harga_satuan, total, keterangan)
                                      VALUES (@no, 'KELUAR', @idbarang, @jml, @harga, @total, @ket)";

                        MySqlCommand cmd1 = new MySqlCommand(q1, conn, trx);
                        cmd1.Parameters.AddWithValue("@no", noTrx);
                        cmd1.Parameters.AddWithValue("@idbarang", idBarang);
                        cmd1.Parameters.AddWithValue("@jml", jumlah);
                        cmd1.Parameters.AddWithValue("@harga", harga);
                        cmd1.Parameters.AddWithValue("@total", total);
                        cmd1.Parameters.AddWithValue("@ket", keterangan ?? "");
                        cmd1.ExecuteNonQuery();

                        // kurangi stok
                        string q2 = "UPDATE barang SET stok = stok - @jml WHERE id_barang = @id";
                        MySqlCommand cmd2 = new MySqlCommand(q2, conn, trx);
                        cmd2.Parameters.AddWithValue("@jml", jumlah);
                        cmd2.Parameters.AddWithValue("@id", idBarang);
                        cmd2.ExecuteNonQuery();

                        trx.Commit();
                        return "OK:" + noTrx;
                    }
                    catch
                    {
                        trx.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public List<Transaksi> GetRiwayat(string jenis = "", DateTime? dari = null, DateTime? sampai = null)
        {
            List<Transaksi> list = new List<Transaksi>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT t.*, b.nama_barang, k.satuan
                                 FROM transaksi t
                                 JOIN barang b ON t.id_barang = b.id_barang
                                 JOIN kategori k ON b.id_kategori = k.id_kategori
                                 WHERE 1=1";

                if (!string.IsNullOrEmpty(jenis))
                    query += " AND t.jenis_transaksi = @jenis";
                if (dari != null)
                    query += " AND DATE(t.tanggal) >= @dari";
                if (sampai != null)
                    query += " AND DATE(t.tanggal) <= @sampai";

                query += " ORDER BY t.tanggal DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrEmpty(jenis))
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                if (dari != null)
                    cmd.Parameters.AddWithValue("@dari", dari.Value.Date);
                if (sampai != null)
                    cmd.Parameters.AddWithValue("@sampai", sampai.Value.Date);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Transaksi t = new Transaksi();
                        t.IdTransaksi = reader.GetInt32("id_transaksi");
                        t.NoTransaksi = reader.GetString("no_transaksi");
                        t.Jenis = reader.GetString("jenis_transaksi") == "MASUK"
                                  ? JenisTransaksi.MASUK : JenisTransaksi.KELUAR;
                        t.IdBarang = reader.GetInt32("id_barang");
                        t.NamaBarang = reader.GetString("nama_barang");
                        t.Satuan = reader.GetString("satuan");
                        t.Jumlah = reader.GetInt32("jumlah");
                        t.HargaSatuan = reader.GetDecimal("harga_satuan");
                        t.Total = reader.GetDecimal("total");
                        t.Keterangan = reader.IsDBNull(reader.GetOrdinal("keterangan")) ? "" : reader.GetString("keterangan");
                        t.Tanggal = reader.GetDateTime("tanggal");
                        list.Add(t);
                    }
                }
            }

            return list;
        }

        public (int masuk, int keluar) GetStatistikHariIni()
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT
                    SUM(CASE WHEN jenis_transaksi = 'MASUK' THEN jumlah ELSE 0 END) as masuk,
                    SUM(CASE WHEN jenis_transaksi = 'KELUAR' THEN jumlah ELSE 0 END) as keluar
                    FROM transaksi WHERE DATE(tanggal) = CURDATE()";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        int masuk = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                        int keluar = r.IsDBNull(1) ? 0 : r.GetInt32(1);
                        return (masuk, keluar);
                    }
                }
            }
            return (0, 0);
        }
    }
}
