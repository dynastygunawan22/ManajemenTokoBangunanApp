namespace ManajemenTokoBangunanApp
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSubjudul = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlPeringatan = new System.Windows.Forms.Panel();
            this.lblPeringatan = new System.Windows.Forms.Label();
            this.pnlKartu = new System.Windows.Forms.Panel();
            this.pnlKartu1 = new System.Windows.Forms.Panel();
            this.lblTitleKartu1 = new System.Windows.Forms.Label();
            this.lblTotalBarang = new System.Windows.Forms.Label();
            this.pnlKartu2 = new System.Windows.Forms.Panel();
            this.lblTitleKartu2 = new System.Windows.Forms.Label();
            this.lblStokHabis = new System.Windows.Forms.Label();
            this.pnlKartu3 = new System.Windows.Forms.Panel();
            this.lblTitleKartu3 = new System.Windows.Forms.Label();
            this.lblStokMenipis = new System.Windows.Forms.Label();
            this.pnlKartu4 = new System.Windows.Forms.Panel();
            this.lblTitleKartu4 = new System.Windows.Forms.Label();
            this.lblNilaiStok = new System.Windows.Forms.Label();
            this.pnlKartu5 = new System.Windows.Forms.Panel();
            this.lblTitleKartu5 = new System.Windows.Forms.Label();
            this.lblMasukHariIni = new System.Windows.Forms.Label();
            this.pnlKartu6 = new System.Windows.Forms.Panel();
            this.lblTitleKartu6 = new System.Windows.Forms.Label();
            this.lblKeluarHariIni = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnDataBarang = new System.Windows.Forms.Button();
            this.btnBarangMasuk = new System.Windows.Forms.Button();
            this.btnBarangKeluar = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlPeringatan.SuspendLayout();
            this.pnlKartu.SuspendLayout();
            this.pnlKartu1.SuspendLayout();
            this.pnlKartu2.SuspendLayout();
            this.pnlKartu3.SuspendLayout();
            this.pnlKartu4.SuspendLayout();
            this.pnlKartu5.SuspendLayout();
            this.pnlKartu6.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblSubjudul);
            this.pnlHeader.Controls.Add(this.lblJudul);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 70);
            this.pnlHeader.TabIndex = 0;

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(16, 10);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Text = "TOKO BANGUNAN";

            // lblSubjudul
            this.lblSubjudul.AutoSize = true;
            this.lblSubjudul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubjudul.ForeColor = System.Drawing.Color.FromArgb(147, 197, 253);
            this.lblSubjudul.Location = new System.Drawing.Point(18, 46);
            this.lblSubjudul.Name = "lblSubjudul";
            this.lblSubjudul.Text = "Sistem Manajemen Barang Masuk & Keluar";

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(808, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Text = "↺ Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // pnlPeringatan
            this.pnlPeringatan.Controls.Add(this.lblPeringatan);
            this.pnlPeringatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPeringatan.Location = new System.Drawing.Point(0, 70);
            this.pnlPeringatan.Name = "pnlPeringatan";
            this.pnlPeringatan.Size = new System.Drawing.Size(900, 36);

            // lblPeringatan
            this.lblPeringatan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeringatan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPeringatan.Location = new System.Drawing.Point(0, 0);
            this.lblPeringatan.Name = "lblPeringatan";
            this.lblPeringatan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblPeringatan.Size = new System.Drawing.Size(900, 36);
            this.lblPeringatan.Text = "Memuat data...";
            this.lblPeringatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // pnlKartu
            this.pnlKartu.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.pnlKartu.Controls.Add(this.pnlKartu6);
            this.pnlKartu.Controls.Add(this.pnlKartu5);
            this.pnlKartu.Controls.Add(this.pnlKartu4);
            this.pnlKartu.Controls.Add(this.pnlKartu3);
            this.pnlKartu.Controls.Add(this.pnlKartu2);
            this.pnlKartu.Controls.Add(this.pnlKartu1);
            this.pnlKartu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKartu.Location = new System.Drawing.Point(0, 106);
            this.pnlKartu.Name = "pnlKartu";
            this.pnlKartu.Padding = new System.Windows.Forms.Padding(12, 10, 12, 0);
            this.pnlKartu.Size = new System.Drawing.Size(900, 110);

            // helper kartu - kartu 1 (Total Barang)
            this.pnlKartu1.BackColor = System.Drawing.Color.White;
            this.pnlKartu1.Controls.Add(this.lblTotalBarang);
            this.pnlKartu1.Controls.Add(this.lblTitleKartu1);
            this.pnlKartu1.Location = new System.Drawing.Point(12, 10);
            this.pnlKartu1.Name = "pnlKartu1";
            this.pnlKartu1.Size = new System.Drawing.Size(136, 88);

            this.lblTitleKartu1.AutoSize = true;
            this.lblTitleKartu1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleKartu1.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleKartu1.Location = new System.Drawing.Point(8, 8);
            this.lblTitleKartu1.Text = "Total Barang";

            this.lblTotalBarang.AutoSize = true;
            this.lblTotalBarang.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTotalBarang.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalBarang.Location = new System.Drawing.Point(6, 28);
            this.lblTotalBarang.Text = "0";

            // kartu 2 (Stok Habis)
            this.pnlKartu2.BackColor = System.Drawing.Color.White;
            this.pnlKartu2.Controls.Add(this.lblStokHabis);
            this.pnlKartu2.Controls.Add(this.lblTitleKartu2);
            this.pnlKartu2.Location = new System.Drawing.Point(156, 10);
            this.pnlKartu2.Name = "pnlKartu2";
            this.pnlKartu2.Size = new System.Drawing.Size(136, 88);

            this.lblTitleKartu2.AutoSize = true;
            this.lblTitleKartu2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleKartu2.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleKartu2.Location = new System.Drawing.Point(8, 8);
            this.lblTitleKartu2.Text = "Stok Habis";

            this.lblStokHabis.AutoSize = true;
            this.lblStokHabis.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblStokHabis.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblStokHabis.Location = new System.Drawing.Point(6, 28);
            this.lblStokHabis.Text = "0";

            // kartu 3 (Stok Menipis)
            this.pnlKartu3.BackColor = System.Drawing.Color.White;
            this.pnlKartu3.Controls.Add(this.lblStokMenipis);
            this.pnlKartu3.Controls.Add(this.lblTitleKartu3);
            this.pnlKartu3.Location = new System.Drawing.Point(300, 10);
            this.pnlKartu3.Name = "pnlKartu3";
            this.pnlKartu3.Size = new System.Drawing.Size(136, 88);

            this.lblTitleKartu3.AutoSize = true;
            this.lblTitleKartu3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleKartu3.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleKartu3.Location = new System.Drawing.Point(8, 8);
            this.lblTitleKartu3.Text = "Stok Menipis";

            this.lblStokMenipis.AutoSize = true;
            this.lblStokMenipis.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblStokMenipis.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.lblStokMenipis.Location = new System.Drawing.Point(6, 28);
            this.lblStokMenipis.Text = "0";

            // kartu 4 (Nilai Stok)
            this.pnlKartu4.BackColor = System.Drawing.Color.White;
            this.pnlKartu4.Controls.Add(this.lblNilaiStok);
            this.pnlKartu4.Controls.Add(this.lblTitleKartu4);
            this.pnlKartu4.Location = new System.Drawing.Point(444, 10);
            this.pnlKartu4.Name = "pnlKartu4";
            this.pnlKartu4.Size = new System.Drawing.Size(136, 88);

            this.lblTitleKartu4.AutoSize = true;
            this.lblTitleKartu4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleKartu4.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleKartu4.Location = new System.Drawing.Point(8, 8);
            this.lblTitleKartu4.Text = "Nilai Stok";

            this.lblNilaiStok.AutoSize = true;
            this.lblNilaiStok.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNilaiStok.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.lblNilaiStok.Location = new System.Drawing.Point(6, 30);
            this.lblNilaiStok.Text = "Rp 0";

            // kartu 5 (Masuk Hari Ini)
            this.pnlKartu5.BackColor = System.Drawing.Color.White;
            this.pnlKartu5.Controls.Add(this.lblMasukHariIni);
            this.pnlKartu5.Controls.Add(this.lblTitleKartu5);
            this.pnlKartu5.Location = new System.Drawing.Point(588, 10);
            this.pnlKartu5.Name = "pnlKartu5";
            this.pnlKartu5.Size = new System.Drawing.Size(136, 88);

            this.lblTitleKartu5.AutoSize = true;
            this.lblTitleKartu5.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleKartu5.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleKartu5.Location = new System.Drawing.Point(8, 8);
            this.lblTitleKartu5.Text = "Masuk Hari Ini";

            this.lblMasukHariIni.AutoSize = true;
            this.lblMasukHariIni.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblMasukHariIni.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.lblMasukHariIni.Location = new System.Drawing.Point(6, 28);
            this.lblMasukHariIni.Text = "0";

            // kartu 6 (Keluar Hari Ini)
            this.pnlKartu6.BackColor = System.Drawing.Color.White;
            this.pnlKartu6.Controls.Add(this.lblKeluarHariIni);
            this.pnlKartu6.Controls.Add(this.lblTitleKartu6);
            this.pnlKartu6.Location = new System.Drawing.Point(732, 10);
            this.pnlKartu6.Name = "pnlKartu6";
            this.pnlKartu6.Size = new System.Drawing.Size(136, 88);

            this.lblTitleKartu6.AutoSize = true;
            this.lblTitleKartu6.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleKartu6.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleKartu6.Location = new System.Drawing.Point(8, 8);
            this.lblTitleKartu6.Text = "Keluar Hari Ini";

            this.lblKeluarHariIni.AutoSize = true;
            this.lblKeluarHariIni.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblKeluarHariIni.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblKeluarHariIni.Location = new System.Drawing.Point(6, 28);
            this.lblKeluarHariIni.Text = "0";

            // pnlMenu
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnLaporan);
            this.pnlMenu.Controls.Add(this.btnBarangKeluar);
            this.pnlMenu.Controls.Add(this.btnBarangMasuk);
            this.pnlMenu.Controls.Add(this.btnDataBarang);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 216);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(16);

            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblMenuTitle.Location = new System.Drawing.Point(16, 16);
            this.lblMenuTitle.Text = "MENU UTAMA";

            // btnDataBarang
            this.btnDataBarang.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnDataBarang.FlatAppearance.BorderSize = 0;
            this.btnDataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBarang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDataBarang.ForeColor = System.Drawing.Color.White;
            this.btnDataBarang.Location = new System.Drawing.Point(16, 40);
            this.btnDataBarang.Name = "btnDataBarang";
            this.btnDataBarang.Size = new System.Drawing.Size(196, 100);
            this.btnDataBarang.Text = "📦\r\nData Barang";
            this.btnDataBarang.UseVisualStyleBackColor = false;
            this.btnDataBarang.Click += new System.EventHandler(this.btnDataBarang_Click);

            // btnBarangMasuk
            this.btnBarangMasuk.BackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnBarangMasuk.FlatAppearance.BorderSize = 0;
            this.btnBarangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarangMasuk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBarangMasuk.ForeColor = System.Drawing.Color.White;
            this.btnBarangMasuk.Location = new System.Drawing.Point(224, 40);
            this.btnBarangMasuk.Name = "btnBarangMasuk";
            this.btnBarangMasuk.Size = new System.Drawing.Size(196, 100);
            this.btnBarangMasuk.Text = "📥\r\nBarang Masuk";
            this.btnBarangMasuk.UseVisualStyleBackColor = false;
            this.btnBarangMasuk.Click += new System.EventHandler(this.btnBarangMasuk_Click);

            // btnBarangKeluar
            this.btnBarangKeluar.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnBarangKeluar.FlatAppearance.BorderSize = 0;
            this.btnBarangKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarangKeluar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBarangKeluar.ForeColor = System.Drawing.Color.White;
            this.btnBarangKeluar.Location = new System.Drawing.Point(432, 40);
            this.btnBarangKeluar.Name = "btnBarangKeluar";
            this.btnBarangKeluar.Size = new System.Drawing.Size(196, 100);
            this.btnBarangKeluar.Text = "📤\r\nBarang Keluar";
            this.btnBarangKeluar.UseVisualStyleBackColor = false;
            this.btnBarangKeluar.Click += new System.EventHandler(this.btnBarangKeluar_Click);

            // btnLaporan
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(640, 40);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(196, 100);
            this.btnLaporan.Text = "📋\r\nLaporan";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);

            // FormDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlKartu);
            this.Controls.Add(this.pnlPeringatan);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(916, 558);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Manajemen Toko Bangunan";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlPeringatan.ResumeLayout(false);
            this.pnlKartu.ResumeLayout(false);
            this.pnlKartu1.ResumeLayout(false);
            this.pnlKartu1.PerformLayout();
            this.pnlKartu2.ResumeLayout(false);
            this.pnlKartu2.PerformLayout();
            this.pnlKartu3.ResumeLayout(false);
            this.pnlKartu3.PerformLayout();
            this.pnlKartu4.ResumeLayout(false);
            this.pnlKartu4.PerformLayout();
            this.pnlKartu5.ResumeLayout(false);
            this.pnlKartu5.PerformLayout();
            this.pnlKartu6.ResumeLayout(false);
            this.pnlKartu6.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubjudul;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlPeringatan;
        private System.Windows.Forms.Label lblPeringatan;
        private System.Windows.Forms.Panel pnlKartu;
        private System.Windows.Forms.Panel pnlKartu1;
        private System.Windows.Forms.Label lblTitleKartu1;
        private System.Windows.Forms.Label lblTotalBarang;
        private System.Windows.Forms.Panel pnlKartu2;
        private System.Windows.Forms.Label lblTitleKartu2;
        private System.Windows.Forms.Label lblStokHabis;
        private System.Windows.Forms.Panel pnlKartu3;
        private System.Windows.Forms.Label lblTitleKartu3;
        private System.Windows.Forms.Label lblStokMenipis;
        private System.Windows.Forms.Panel pnlKartu4;
        private System.Windows.Forms.Label lblTitleKartu4;
        private System.Windows.Forms.Label lblNilaiStok;
        private System.Windows.Forms.Panel pnlKartu5;
        private System.Windows.Forms.Label lblTitleKartu5;
        private System.Windows.Forms.Label lblMasukHariIni;
        private System.Windows.Forms.Panel pnlKartu6;
        private System.Windows.Forms.Label lblTitleKartu6;
        private System.Windows.Forms.Label lblKeluarHariIni;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnDataBarang;
        private System.Windows.Forms.Button btnBarangMasuk;
        private System.Windows.Forms.Button btnBarangKeluar;
        private System.Windows.Forms.Button btnLaporan;
    }
}
