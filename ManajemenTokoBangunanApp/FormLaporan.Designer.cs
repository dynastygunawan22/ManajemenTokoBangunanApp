namespace ManajemenTokoBangunanApp
{
    partial class FormLaporan
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblDari = new System.Windows.Forms.Label();
            this.dtpDari = new System.Windows.Forms.DateTimePicker();
            this.lblSampai = new System.Windows.Forms.Label();
            this.dtpSampai = new System.Windows.Forms.DateTimePicker();
            this.lblJenis = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.lblTotalData = new System.Windows.Forms.Label();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTotalKeluar = new System.Windows.Forms.Label();
            this.lblTotalMasuk = new System.Windows.Forms.Label();
            this.lblLegMasuk = new System.Windows.Forms.Label();
            this.lblLegKeluar = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // header ungu
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.pnlHeader.Controls.Add(this.lblJudul);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 52;

            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(14, 13);
            this.lblJudul.Text = "Laporan Transaksi";

            // panel filter
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblTotalData);
            this.pnlFilter.Controls.Add(this.btnTampilkan);
            this.pnlFilter.Controls.Add(this.cmbJenis);
            this.pnlFilter.Controls.Add(this.lblJenis);
            this.pnlFilter.Controls.Add(this.dtpSampai);
            this.pnlFilter.Controls.Add(this.lblSampai);
            this.pnlFilter.Controls.Add(this.dtpDari);
            this.pnlFilter.Controls.Add(this.lblDari);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Height = 52;
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(12, 10, 12, 0);

            this.lblDari.AutoSize = true;
            this.lblDari.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDari.Location = new System.Drawing.Point(12, 13);
            this.lblDari.Text = "Dari:";

            this.dtpDari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDari.Location = new System.Drawing.Point(46, 10);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.Size = new System.Drawing.Size(110, 25);

            this.lblSampai.AutoSize = true;
            this.lblSampai.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSampai.Location = new System.Drawing.Point(166, 13);
            this.lblSampai.Text = "s/d:";

            this.dtpSampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSampai.Location = new System.Drawing.Point(196, 10);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.Size = new System.Drawing.Size(110, 25);

            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblJenis.Location = new System.Drawing.Point(316, 13);
            this.lblJenis.Text = "Jenis:";

            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbJenis.Location = new System.Drawing.Point(352, 10);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(110, 24);

            this.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnTampilkan.FlatAppearance.BorderSize = 0;
            this.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampilkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilkan.ForeColor = System.Drawing.Color.White;
            this.btnTampilkan.Location = new System.Drawing.Point(474, 9);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(120, 28);
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);

            this.lblTotalData.AutoSize = true;
            this.lblTotalData.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalData.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalData.Location = new System.Drawing.Point(608, 13);
            this.lblTotalData.Text = "";

            // tabel laporan
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLaporan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaporan.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.dgvLaporan.MultiSelect = false;
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersVisible = false;
            this.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvLaporan.Columns.Add("colTanggal", "Tanggal");
            this.dgvLaporan.Columns.Add("colNoTrx", "No. Transaksi");
            this.dgvLaporan.Columns.Add("colJenis", "Jenis");
            this.dgvLaporan.Columns.Add("colNama", "Nama Barang");
            this.dgvLaporan.Columns.Add("colJumlah", "Jumlah");
            this.dgvLaporan.Columns.Add("colHarga", "Harga");
            this.dgvLaporan.Columns.Add("colTotal", "Total");
            this.dgvLaporan.Columns.Add("colKet", "Keterangan");

            // footer
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.lblLegKeluar);
            this.pnlFooter.Controls.Add(this.lblLegMasuk);
            this.pnlFooter.Controls.Add(this.lblTotalKeluar);
            this.pnlFooter.Controls.Add(this.lblTotalMasuk);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 40;
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(12, 8, 12, 0);

            this.lblLegMasuk.AutoSize = true;
            this.lblLegMasuk.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegMasuk.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.lblLegMasuk.Location = new System.Drawing.Point(12, 10);
            this.lblLegMasuk.Text = "■ Masuk";

            this.lblLegKeluar.AutoSize = true;
            this.lblLegKeluar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegKeluar.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblLegKeluar.Location = new System.Drawing.Point(80, 10);
            this.lblLegKeluar.Text = "■ Keluar";

            this.lblTotalMasuk.AutoSize = true;
            this.lblTotalMasuk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalMasuk.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.lblTotalMasuk.Location = new System.Drawing.Point(250, 10);
            this.lblTotalMasuk.Text = "Total Masuk: Rp 0";

            this.lblTotalKeluar.AutoSize = true;
            this.lblTotalKeluar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalKeluar.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblTotalKeluar.Location = new System.Drawing.Point(500, 10);
            this.lblTotalKeluar.Text = "Total Keluar: Rp 0";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Transaksi";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Label lblTotalData;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblLegMasuk;
        private System.Windows.Forms.Label lblLegKeluar;
        private System.Windows.Forms.Label lblTotalMasuk;
        private System.Windows.Forms.Label lblTotalKeluar;
    }
}
