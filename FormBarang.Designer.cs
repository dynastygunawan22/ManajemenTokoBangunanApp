namespace ManajemenTokoBangunanApp
{
    partial class FormBarang
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlFormInput = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblStokMin = new System.Windows.Forms.Label();
            this.numStokMin = new System.Windows.Forms.NumericUpDown();
            this.lblHargaBeli = new System.Windows.Forms.Label();
            this.numHargaBeli = new System.Windows.Forms.NumericUpDown();
            this.lblHargaJual = new System.Windows.Forms.Label();
            this.numHargaJual = new System.Windows.Forms.NumericUpDown();
            this.pnlTombol = new System.Windows.Forms.Panel();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBersih = new System.Windows.Forms.Button();
            this.pnlKanan = new System.Windows.Forms.Panel();
            this.pnlCari = new System.Windows.Forms.Panel();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblJumlahData = new System.Windows.Forms.Label();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblLegNormal = new System.Windows.Forms.Label();
            this.lblLegMenipis = new System.Windows.Forms.Label();
            this.lblLegHabis = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlFormInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStokMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaBeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaJual)).BeginInit();
            this.pnlTombol.SuspendLayout();
            this.pnlKanan.SuspendLayout();
            this.pnlCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.pnlLegend.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlHeader.Controls.Add(this.lblJudul);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1050, 50);

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(14, 12);
            this.lblJudul.Text = "Data Barang";

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 50);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1MinSize = 280;
            this.splitContainer.Size = new System.Drawing.Size(1050, 590);
            this.splitContainer.SplitterDistance = 290;

            // Panel kiri - form input
            this.splitContainer.Panel1.Controls.Add(this.pnlTombol);
            this.splitContainer.Panel1.Controls.Add(this.pnlFormInput);
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.White;

            // pnlFormInput
            this.pnlFormInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormInput.Controls.Add(this.numHargaJual);
            this.pnlFormInput.Controls.Add(this.lblHargaJual);
            this.pnlFormInput.Controls.Add(this.numHargaBeli);
            this.pnlFormInput.Controls.Add(this.lblHargaBeli);
            this.pnlFormInput.Controls.Add(this.numStokMin);
            this.pnlFormInput.Controls.Add(this.lblStokMin);
            this.pnlFormInput.Controls.Add(this.cmbKategori);
            this.pnlFormInput.Controls.Add(this.lblKategori);
            this.pnlFormInput.Controls.Add(this.txtNama);
            this.pnlFormInput.Controls.Add(this.lblNama);
            this.pnlFormInput.Controls.Add(this.txtKode);
            this.pnlFormInput.Controls.Add(this.lblKode);
            this.pnlFormInput.Controls.Add(this.lblFormTitle);
            this.pnlFormInput.Padding = new System.Windows.Forms.Padding(14, 10, 14, 0);
            this.pnlFormInput.Name = "pnlFormInput";

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblFormTitle.Location = new System.Drawing.Point(14, 12);
            this.lblFormTitle.Text = "FORM INPUT BARANG";

            // field kode
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblKode.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblKode.Location = new System.Drawing.Point(14, 36);
            this.lblKode.Text = "Kode Barang *";

            this.txtKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKode.Location = new System.Drawing.Point(14, 54);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(258, 25);

            // field nama
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblNama.Location = new System.Drawing.Point(14, 86);
            this.lblNama.Text = "Nama Barang *";

            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNama.Location = new System.Drawing.Point(14, 104);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(258, 25);

            // field kategori
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblKategori.Location = new System.Drawing.Point(14, 136);
            this.lblKategori.Text = "Kategori *";

            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbKategori.Location = new System.Drawing.Point(14, 154);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(258, 24);

            // stok minimum
            this.lblStokMin.AutoSize = true;
            this.lblStokMin.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStokMin.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblStokMin.Location = new System.Drawing.Point(14, 186);
            this.lblStokMin.Text = "Stok Minimum";

            this.numStokMin.Location = new System.Drawing.Point(14, 204);
            this.numStokMin.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numStokMin.Name = "numStokMin";
            this.numStokMin.Size = new System.Drawing.Size(258, 23);
            this.numStokMin.Value = new decimal(new int[] { 5, 0, 0, 0 });

            // harga beli
            this.lblHargaBeli.AutoSize = true;
            this.lblHargaBeli.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHargaBeli.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblHargaBeli.Location = new System.Drawing.Point(14, 234);
            this.lblHargaBeli.Text = "Harga Beli (Rp)";

            this.numHargaBeli.Location = new System.Drawing.Point(14, 252);
            this.numHargaBeli.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.numHargaBeli.Name = "numHargaBeli";
            this.numHargaBeli.Size = new System.Drawing.Size(258, 23);
            this.numHargaBeli.ThousandsSeparator = true;

            // harga jual
            this.lblHargaJual.AutoSize = true;
            this.lblHargaJual.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHargaJual.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblHargaJual.Location = new System.Drawing.Point(14, 282);
            this.lblHargaJual.Text = "Harga Jual (Rp)";

            this.numHargaJual.Location = new System.Drawing.Point(14, 300);
            this.numHargaJual.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.numHargaJual.Name = "numHargaJual";
            this.numHargaJual.Size = new System.Drawing.Size(258, 23);
            this.numHargaJual.ThousandsSeparator = true;

            // panel tombol
            this.pnlTombol.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlTombol.Controls.Add(this.btnBersih);
            this.pnlTombol.Controls.Add(this.btnHapus);
            this.pnlTombol.Controls.Add(this.btnEdit);
            this.pnlTombol.Controls.Add(this.btnTambah);
            this.pnlTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTombol.Name = "pnlTombol";
            this.pnlTombol.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTombol.Size = new System.Drawing.Size(290, 100);

            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(12, 12);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(126, 34);
            this.btnTambah.Text = "+ Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(148, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 34);
            this.btnEdit.Text = "✎ Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(12, 54);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(126, 34);
            this.btnHapus.Text = "🗑 Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            this.btnBersih.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnBersih.FlatAppearance.BorderSize = 0;
            this.btnBersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBersih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBersih.ForeColor = System.Drawing.Color.White;
            this.btnBersih.Location = new System.Drawing.Point(148, 54);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.Size = new System.Drawing.Size(126, 34);
            this.btnBersih.Text = "↺ Reset";
            this.btnBersih.UseVisualStyleBackColor = false;
            this.btnBersih.Click += new System.EventHandler(this.btnBersih_Click);

            // Panel kanan - tabel
            this.splitContainer.Panel2.Controls.Add(this.pnlKanan);

            this.pnlKanan.Controls.Add(this.dgvBarang);
            this.pnlKanan.Controls.Add(this.pnlLegend);
            this.pnlKanan.Controls.Add(this.pnlCari);
            this.pnlKanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKanan.Name = "pnlKanan";
            this.pnlKanan.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            // panel cari
            this.pnlCari.Controls.Add(this.lblJumlahData);
            this.pnlCari.Controls.Add(this.txtCari);
            this.pnlCari.Controls.Add(this.lblCari);
            this.pnlCari.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCari.Height = 46;
            this.pnlCari.Name = "pnlCari";
            this.pnlCari.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);

            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCari.Location = new System.Drawing.Point(0, 12);
            this.lblCari.Text = "🔍";

            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCari.Location = new System.Drawing.Point(24, 9);
            this.txtCari.Name = "txtCari";
            this.txtCari.PlaceholderText = "Cari kode atau nama barang...";
            this.txtCari.Size = new System.Drawing.Size(260, 25);
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);

            this.lblJumlahData.AutoSize = true;
            this.lblJumlahData.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblJumlahData.ForeColor = System.Drawing.Color.Gray;
            this.lblJumlahData.Location = new System.Drawing.Point(298, 12);
            this.lblJumlahData.Text = "";

            // datagridview
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarang.BackgroundColor = System.Drawing.Color.White;
            this.dgvBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBarang.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.dgvBarang.MultiSelect = false;
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.RowHeadersVisible = false;
            this.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarang.SelectionChanged += new System.EventHandler(this.dgvBarang_SelectionChanged);

            // kolom-kolom tabel
            this.dgvBarang.Columns.Add("colId", "ID");
            this.dgvBarang.Columns.Add("colKode", "Kode");
            this.dgvBarang.Columns.Add("colNama", "Nama Barang");
            this.dgvBarang.Columns.Add("colKategori", "Kategori");
            this.dgvBarang.Columns.Add("colStok", "Stok");
            this.dgvBarang.Columns.Add("colHargaBeli", "Harga Beli");
            this.dgvBarang.Columns.Add("colHargaJual", "Harga Jual");
            this.dgvBarang.Columns.Add("colStatus", "Status");
            this.dgvBarang.Columns["colId"].Visible = false;

            // legend warna
            this.pnlLegend.BackColor = System.Drawing.Color.White;
            this.pnlLegend.Controls.Add(this.lblLegHabis);
            this.pnlLegend.Controls.Add(this.lblLegMenipis);
            this.pnlLegend.Controls.Add(this.lblLegNormal);
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLegend.Height = 30;
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);

            this.lblLegNormal.AutoSize = true;
            this.lblLegNormal.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegNormal.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.lblLegNormal.Location = new System.Drawing.Point(8, 6);
            this.lblLegNormal.Text = "■ Normal";

            this.lblLegMenipis.AutoSize = true;
            this.lblLegMenipis.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegMenipis.ForeColor = System.Drawing.Color.FromArgb(133, 77, 14);
            this.lblLegMenipis.Location = new System.Drawing.Point(80, 6);
            this.lblLegMenipis.Text = "■ Menipis";

            this.lblLegHabis.AutoSize = true;
            this.lblLegHabis.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegHabis.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.lblLegHabis.Location = new System.Drawing.Point(158, 6);
            this.lblLegHabis.Text = "■ Habis";

            // FormBarang
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Barang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlFormInput.ResumeLayout(false);
            this.pnlFormInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStokMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaBeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaJual)).EndInit();
            this.pnlTombol.ResumeLayout(false);
            this.pnlKanan.ResumeLayout(false);
            this.pnlCari.ResumeLayout(false);
            this.pnlCari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlFormInput;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblStokMin;
        private System.Windows.Forms.NumericUpDown numStokMin;
        private System.Windows.Forms.Label lblHargaBeli;
        private System.Windows.Forms.NumericUpDown numHargaBeli;
        private System.Windows.Forms.Label lblHargaJual;
        private System.Windows.Forms.NumericUpDown numHargaJual;
        private System.Windows.Forms.Panel pnlTombol;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersih;
        private System.Windows.Forms.Panel pnlKanan;
        private System.Windows.Forms.Panel pnlCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblJumlahData;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblLegNormal;
        private System.Windows.Forms.Label lblLegMenipis;
        private System.Windows.Forms.Label lblLegHabis;
    }
}
