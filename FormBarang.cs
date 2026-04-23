using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManajemenTokoBangunanApp
{
    public partial class FormBarang : Form
    {
        private BarangService barangService = new BarangService();
        private KategoriService kategoriService = new KategoriService();
        private int idBarangDipilih = -1;

        public FormBarang()
        {
            InitializeComponent();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            // isi dropdown kategori dari database
            List<Kategori> daftarKategori = kategoriService.GetSemuaKategori();
            cmbKategori.DataSource = daftarKategori;
            cmbKategori.DisplayMember = "NamaKategori";
            cmbKategori.ValueMember = "IdKategori";

            TampilkanDataBarang();
        }

        private void TampilkanDataBarang(string keyword = "")
        {
            dgvBarang.Rows.Clear();
            List<Barang> daftarBarang = barangService.GetSemuaBarang(keyword);

            foreach (Barang b in daftarBarang)
            {
                int baris = dgvBarang.Rows.Add(
                    b.IdBarang,
                    b.KodeBarang,
                    b.NamaBarang,
                    b.NamaKategori,
                    b.Stok + " " + b.Satuan,
                    "Rp " + b.HargaBeli.ToString("N0"),
                    "Rp " + b.HargaJual.ToString("N0"),
                    b.GetLabelStatus()
                );

                // warnai baris sesuai kondisi stok
                if (b.GetStatusStok() == StatusStok.Habis)
                    dgvBarang.Rows[baris].DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226);
                else if (b.GetStatusStok() == StatusStok.Menipis)
                    dgvBarang.Rows[baris].DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
            }

            lblJumlahData.Text = daftarBarang.Count + " barang ditemukan";
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            TampilkanDataBarang(txtCari.Text);
        }

        private void dgvBarang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBarang.SelectedRows.Count == 0) return;

            DataGridViewRow baris = dgvBarang.SelectedRows[0];
            idBarangDipilih = Convert.ToInt32(baris.Cells[0].Value);

            Barang b = barangService.GetBarangById(idBarangDipilih);
            if (b == null) return;

            txtKode.Text = b.KodeBarang;
            txtNama.Text = b.NamaBarang;
            numStokMin.Value = b.StokMinimum;
            numHargaBeli.Value = b.HargaBeli;
            numHargaJual.Value = b.HargaJual;

            // set dropdown ke kategori yang sesuai
            for (int i = 0; i < cmbKategori.Items.Count; i++)
            {
                Kategori k = (Kategori)cmbKategori.Items[i];
                if (k.IdKategori == b.IdKategori)
                {
                    cmbKategori.SelectedIndex = i;
                    break;
                }
            }

            txtKode.ReadOnly = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            Kategori katDipilih = (Kategori)cmbKategori.SelectedItem;

            Barang barangBaru = new Barang();
            barangBaru.KodeBarang = txtKode.Text.Trim();
            barangBaru.NamaBarang = txtNama.Text.Trim();
            barangBaru.IdKategori = katDipilih.IdKategori;
            barangBaru.StokMinimum = (int)numStokMin.Value;
            barangBaru.HargaBeli = numHargaBeli.Value;
            barangBaru.HargaJual = numHargaJual.Value;

            string hasil = barangService.TambahBarang(barangBaru);

            if (hasil == "OK")
            {
                MessageBox.Show("Barang berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                TampilkanDataBarang();
            }
            else
            {
                MessageBox.Show(hasil, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idBarangDipilih == -1)
            {
                MessageBox.Show("Pilih barang yang ingin diedit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidasiInput()) return;

            Kategori katDipilih = (Kategori)cmbKategori.SelectedItem;

            Barang b = new Barang();
            b.IdBarang = idBarangDipilih;
            b.NamaBarang = txtNama.Text.Trim();
            b.IdKategori = katDipilih.IdKategori;
            b.StokMinimum = (int)numStokMin.Value;
            b.HargaBeli = numHargaBeli.Value;
            b.HargaJual = numHargaJual.Value;

            string hasil = barangService.EditBarang(b);

            if (hasil == "OK")
            {
                MessageBox.Show("Data barang berhasil diupdate!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                TampilkanDataBarang();
            }
            else
            {
                MessageBox.Show(hasil, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idBarangDipilih == -1)
            {
                MessageBox.Show("Pilih barang yang ingin dihapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult konfirm = MessageBox.Show(
                "Yakin mau hapus barang ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirm == DialogResult.No) return;

            string hasil = barangService.HapusBarang(idBarangDipilih);

            if (hasil == "OK")
            {
                MessageBox.Show("Barang berhasil dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                TampilkanDataBarang();
            }
            else
            {
                MessageBox.Show(hasil, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtKode.Text))
            {
                MessageBox.Show("Kode barang harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama barang harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return false;
            }
            if (cmbKategori.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih kategori dulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numHargaJual.Value < numHargaBeli.Value)
            {
                MessageBox.Show("Harga jual tidak boleh lebih kecil dari harga beli!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BersihkanForm()
        {
            txtKode.Clear();
            txtNama.Clear();
            txtKode.ReadOnly = false;
            numStokMin.Value = 5;
            numHargaBeli.Value = 0;
            numHargaJual.Value = 0;
            cmbKategori.SelectedIndex = -1;
            idBarangDipilih = -1;
            dgvBarang.ClearSelection();
        }
    }
}
