using System;
using System.Windows.Forms;

namespace ManajemenTokoBangunanApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // cek koneksi dulu sebelum buka form
            if (!DatabaseHelper.CekKoneksi())
            {
                MessageBox.Show(
                    "Tidak bisa konek ke database MySQL!\n\n" +
                    "Pastikan:\n" +
                    "1. XAMPP sudah dibuka\n" +
                    "2. MySQL sudah di-START\n" +
                    "3. Database db_tokoBangunan sudah dibuat",
                    "Koneksi Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Application.Run(new FormDashboard());
        }
    }
}
