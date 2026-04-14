using System;

namespace ManajemenTokoBangunanApp
{
    public class Barang
    {
        public int IdBarang { get; set; }
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public int IdKategori { get; set; }
        public string NamaKategori { get; set; }
        public string Satuan { get; set; }
        public int Stok { get; set; }
        public int StokMinimum { get; set; }
        public decimal HargaBeli { get; set; }
        public decimal HargaJual { get; set; }

        // cek kondisi stok sekarang
        public StatusStok GetStatusStok()
        {
            if (Stok == 0) return StatusStok.Habis;
            if (Stok <= StokMinimum) return StatusStok.Menipis;
            return StatusStok.Normal;
        }

        public string GetLabelStatus()
        {
            if (Stok == 0) return "HABIS";
            if (Stok <= StokMinimum) return "MENIPIS";
            return "NORMAL";
        }

        public override string ToString()
        {
            return NamaBarang;
        }
    }

    public class Transaksi
    {
        public int IdTransaksi { get; set; }
        public string NoTransaksi { get; set; }
        public JenisTransaksi Jenis { get; set; }
        public int IdBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Satuan { get; set; }
        public int Jumlah { get; set; }
        public decimal HargaSatuan { get; set; }
        public decimal Total { get; set; }
        public string Keterangan { get; set; }
        public DateTime Tanggal { get; set; }
    }

    public class Kategori
    {
        public int IdKategori { get; set; }
        public string NamaKategori { get; set; }
        public string Satuan { get; set; }

        public override string ToString()
        {
            return NamaKategori;
        }
    }
}
