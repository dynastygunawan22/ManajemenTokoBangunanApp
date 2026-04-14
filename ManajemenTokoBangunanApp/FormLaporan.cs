using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManajemenTokoBangunanApp
{
    public partial class FormLaporan : Form
    {
        private TransaksiService transaksiService = new TransaksiService();

        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            dtpDari.Value = DateTime.Today.AddMonths(-1);
            dtpSampai.Value = DateTime.Today;

            cmbJenis.Items.Add("Semua");
            cmbJenis.Items.Add("MASUK");
            cmbJenis.Items.Add("KELUAR");
            cmbJenis.SelectedIndex = 0;

            TampilkanData();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void TampilkanData()
        {
            try
            {
                string jenis = cmbJenis.SelectedItem.ToString() == "Semua" ? "" : cmbJenis.SelectedItem.ToString();

                List<Transaksi> daftarTransaksi = transaksiService.GetRiwayat(jenis, dtpDari.Value, dtpSampai.Value);

                dgvLaporan.Rows.Clear();

                decimal totalMasuk = 0;
                decimal totalKeluar = 0;

                foreach (Transaksi t in daftarTransaksi)
                {
                    string jenisText = t.Jenis == JenisTransaksi.MASUK ? "MASUK" : "KELUAR";

                    int baris = dgvLaporan.Rows.Add(
                        t.Tanggal.ToString("dd/MM/yyyy HH:mm"),
                        t.NoTransaksi,
                        jenisText,
                        t.NamaBarang,
                        t.Jumlah + " " + t.Satuan,
                        "Rp " + t.HargaSatuan.ToString("N0"),
                        "Rp " + t.Total.ToString("N0"),
                        t.Keterangan
                    );

                    // warna berbeda untuk masuk dan keluar
                    if (t.Jenis == JenisTransaksi.MASUK)
                    {
                        dgvLaporan.Rows[baris].DefaultCellStyle.BackColor = Color.FromArgb(240, 253, 244);
                        totalMasuk += t.Total;
                    }
                    else
                    {
                        dgvLaporan.Rows[baris].DefaultCellStyle.BackColor = Color.FromArgb(255, 241, 242);
                        totalKeluar += t.Total;
                    }
                }

                lblTotalData.Text = daftarTransaksi.Count + " transaksi ditemukan";
                lblTotalMasuk.Text = "Total Masuk: Rp " + totalMasuk.ToString("N0");
                lblTotalKeluar.Text = "Total Keluar: Rp " + totalKeluar.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
