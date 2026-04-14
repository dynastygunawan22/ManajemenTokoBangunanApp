using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManajemenTokoBangunanApp
{
    public partial class FormDashboard : Form
    {
        private BarangService barangService = new BarangService();
        private TransaksiService transaksiService = new TransaksiService();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            // cek koneksi dulu waktu pertama buka
            if (!DatabaseHelper.CekKoneksi())
            {
                MessageBox.Show(
                    "Tidak bisa konek ke database!\n\nCara perbaiki:\n1. Buka XAMPP\n2. Klik START pada MySQL\n3. Buka aplikasi lagi",
                    "Koneksi Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Application.Exit();
                return;
            }

            MuatData();
        }

        private void MuatData()
        {
            try
            {
                List<Barang> semuaBarang = barangService.GetSemuaBarang();

                int totalBarang = semuaBarang.Count;
                int stokHabis = 0;
                int stokMenipis = 0;

                foreach (Barang b in semuaBarang)
                {
                    if (b.GetStatusStok() == StatusStok.Habis)
                        stokHabis++;
                    else if (b.GetStatusStok() == StatusStok.Menipis)
                        stokMenipis++;
                }

                // hitung nilai stok pakai rekursif
                decimal nilaiStok = barangService.HitungTotalNilaiStok(semuaBarang);

                var (masukHariIni, keluarHariIni) = transaksiService.GetStatistikHariIni();

                // update kartu statistik
                lblTotalBarang.Text = totalBarang.ToString();
                lblStokHabis.Text = stokHabis.ToString();
                lblStokMenipis.Text = stokMenipis.ToString();
                lblNilaiStok.Text = "Rp " + nilaiStok.ToString("N0");
                lblMasukHariIni.Text = masukHariIni.ToString();
                lblKeluarHariIni.Text = keluarHariIni.ToString();

                // update peringatan stok
                if (stokHabis > 0)
                {
                    pnlPeringatan.BackColor = Color.FromArgb(254, 226, 226);
                    lblPeringatan.ForeColor = Color.FromArgb(185, 28, 28);
                    lblPeringatan.Text = "⚠  Ada " + stokHabis + " barang stok HABIS dan " + stokMenipis + " barang MENIPIS!";
                }
                else if (stokMenipis > 0)
                {
                    pnlPeringatan.BackColor = Color.FromArgb(255, 243, 205);
                    lblPeringatan.ForeColor = Color.FromArgb(133, 77, 14);
                    lblPeringatan.Text = "⚠  Ada " + stokMenipis + " barang yang stoknya mulai menipis";
                }
                else
                {
                    pnlPeringatan.BackColor = Color.FromArgb(220, 252, 231);
                    lblPeringatan.ForeColor = Color.FromArgb(21, 128, 61);
                    lblPeringatan.Text = "✓  Semua stok aman";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            FormBarang frm = new FormBarang();
            frm.ShowDialog();
            MuatData();
        }

        private void btnBarangMasuk_Click(object sender, EventArgs e)
        {
            FormBarangMasuk frm = new FormBarangMasuk();
            frm.ShowDialog();
            MuatData();
        }

        private void btnBarangKeluar_Click(object sender, EventArgs e)
        {
            FormBarangKeluar frm = new FormBarangKeluar();
            frm.ShowDialog();
            MuatData();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan frm = new FormLaporan();
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MuatData();
        }
    }
}
