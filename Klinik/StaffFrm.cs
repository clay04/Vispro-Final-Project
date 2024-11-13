using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Klinik
{
    public partial class StaffFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private Form1 form1;


        public StaffFrm(Form1 form1)
        {
            alamat = "server=localhost; database=db_klinik; username=root; password=; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();

            panelPendaftaran.Visible = false;

            this.form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPendaftaran_Click(object sender, EventArgs e)
        {
            panelPendaftaran.Visible=true;
        }

        private void btnDaftarPasien_Click(object sender, EventArgs e)
        {
            panelPendaftaran.Visible=!panelPendaftaran.Visible;
        }

        private void btnDataRekamMedis_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelPendaftaran_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelDaftarPasien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtIDPasien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamaPasien_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBJenisKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTglLhirPasien_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void staffFrm_Load(object sender, EventArgs e)
        {
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            LoadDokter();

            // Array untuk metode pembayaran
            string[] metodePembayaran = { "tunai", "kartu", "transfer" };
            cbMetodePembayaran.DataSource = metodePembayaran;

            // Array untuk status pembayaran
            string[] statusPembayaran = { "belum_dibayar", "sudah_dibayar", "menunggu_konfirmasi" };
            cbStatusPembayaran.DataSource = statusPembayaran;
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRiwayatPenyakit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomorTelepon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNamaPasien.Text != "" && dateTglLhirPasien.Text != "" && txtAlamat.Text != "" &&
                    txtNomorTelepon.Text != "" && CBJenisKelamin.Text != "" && dateTglDaftar.Text != "" &&
                    txtRiwayatPenyakit.Text != "" && cbNamaDokter.SelectedItem != null)
                {
                    // Ambil id_dokter dari ComboBox
                    var selectedDokter = (ComboBoxItem)cbNamaDokter.SelectedItem;
                    int idDokter = Convert.ToInt32(selectedDokter.Value);

                    // Lanjutkan proses insert data ke database menggunakan idDokter ini
                    string tglLahir = dateTglLhirPasien.Value.ToString("yyyy-MM-dd");
                    string tglDaftar = dateTglDaftar.Value.ToString("yyyy-MM-dd");

                    koneksi.Open();

                    // 1. Insert ke tabel `tbl_pasien`
                    string queryPasien = "INSERT INTO tbl_pasien (nama_pasien, tanggal_lahir, alamat, no_telepon, gender, riwayat_penyakit) " +
                                         "VALUES (@nama_pasien, @tanggal_lahir, @alamat, @no_telepon, @gender, @riwayat_penyakit);";
                    long idPasien;

                    using (MySqlCommand perintahPasien = new MySqlCommand(queryPasien, koneksi))
                    {
                        perintahPasien.Parameters.AddWithValue("@nama_pasien", txtNamaPasien.Text);
                        perintahPasien.Parameters.AddWithValue("@tanggal_lahir", tglLahir);
                        perintahPasien.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                        perintahPasien.Parameters.AddWithValue("@no_telepon", txtNomorTelepon.Text);
                        perintahPasien.Parameters.AddWithValue("@gender", CBJenisKelamin.Text);
                        perintahPasien.Parameters.AddWithValue("@riwayat_penyakit", txtRiwayatPenyakit.Text);

                        int resPasien = perintahPasien.ExecuteNonQuery();
                        if (resPasien != 1)
                        {
                            MessageBox.Show("Gagal Insert Data Pasien.");
                            koneksi.Close();
                            return;
                        }

                        idPasien = perintahPasien.LastInsertedId;
                    }

                    // 2. Insert ke tabel `tbl_pendaftaran` dengan `id_pasien` dan `id_dokter`
                    string queryPendaftaran = "INSERT INTO tbl_pendaftaran (id_pasien, id_dokter, tanggal_daftar, status) " +
                                              "VALUES (@id_pasien, @id_dokter, @tanggal_daftar, 'terdaftar');";
                    using (MySqlCommand perintahPendaftaran = new MySqlCommand(queryPendaftaran, koneksi))
                    {
                        perintahPendaftaran.Parameters.AddWithValue("@id_pasien", idPasien);
                        perintahPendaftaran.Parameters.AddWithValue("@id_dokter", idDokter);
                        perintahPendaftaran.Parameters.AddWithValue("@tanggal_daftar", tglDaftar);

                        int resPendaftaran = perintahPendaftaran.ExecuteNonQuery();
                        if (resPendaftaran == 1)
                        {
                            MessageBox.Show("Pendaftaran Sukses.");
                            staffFrm_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Gagal Insert Data Pendaftaran.");
                        }
                    }

                    koneksi.Close();
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        private void cbNamaDokter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadDokter()
        {
            try
            {
                koneksi.Open();
                string queryDokter = "SELECT id_dokter, nama_dokter FROM tbl_dokter";
                using (MySqlCommand cmd = new MySqlCommand(queryDokter, koneksi))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cbNamaDokter.Items.Clear(); // Bersihkan ComboBox sebelum mengisi

                        while (reader.Read())
                        {
                            // Buat item ComboBox dengan text nama_dokter dan simpan id_dokter di Tag
                            var item = new ComboBoxItem
                            {
                                Text = reader["nama_dokter"].ToString(),
                                Value = reader["id_dokter"]
                            };
                            cbNamaDokter.Items.Add(item);
                        }
                    }
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dokter: " + ex.Message);
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        // Kelas untuk menyimpan id_dokter dan nama_dokter di ComboBox
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text; // Menampilkan nama_dokter di ComboBox
            }
        }


        private void dateTglDaftar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchPasienPembayaran_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDPasienPembayaran.Text != "" || txtNamaPasienPembayaran.Text != "")
                {
                    string query = "";

                    if (txtIDPasienPembayaran.Text != "")
                    {
                        query = string.Format(
                            "SELECT tbl_pasien.id_pasien, tbl_pasien.nama_pasien, tbl_pendaftaran.id_pendaftaran " +
                            "FROM tbl_pasien " +
                            "LEFT JOIN tbl_pendaftaran ON tbl_pasien.id_pasien = tbl_pendaftaran.id_pasien " +
                            "WHERE tbl_pasien.id_pasien = '{0}'",
                            txtIDPasienPembayaran.Text);
                    }
                    else if (txtNamaPasienPembayaran.Text != "")
                    {
                        query = string.Format(
                            "SELECT tbl_pasien.id_pasien, tbl_pasien.nama_pasien, tbl_pendaftaran.id_pendaftaran " +
                            "FROM tbl_pasien " +
                            "LEFT JOIN tbl_pendaftaran ON tbl_pasien.id_pasien = tbl_pendaftaran.id_pasien " +
                            "WHERE tbl_pasien.nama_pasien LIKE '%{0}%'",
                            txtNamaPasienPembayaran.Text);
                    }

                    koneksi.Open();
                    MySqlCommand perintah = new MySqlCommand(query, koneksi);
                    MySqlDataReader reader = perintah.ExecuteReader();

                    if (reader.Read())
                    {
                        txtIDPasienPembayaran.Text = reader["id_pasien"].ToString();
                        txtNamaPasienPembayaran.Text = reader["nama_pasien"].ToString();
                        txtIDPendaftaranPembayaran.Text = reader["id_pendaftaran"] != DBNull.Value
                            ? reader["id_pendaftaran"].ToString()
                            : "Belum Terdaftar";

                        reader.Close();

                        // Set harga pemeriksaan
                        decimal hargaPemeriksaan = 100000;

                        // Hitung total harga obat
                        decimal totalHargaObat = HitungTotalHargaObat(int.Parse(txtIDPendaftaranPembayaran.Text));

                        // Debug: Tampilkan harga pemeriksaan dan total harga obat
                        MessageBox.Show($"Harga Pemeriksaan: {hargaPemeriksaan}, Total Harga Obat: {totalHargaObat}");

                        // Hitung total jumlah
                        decimal totalJumlah = hargaPemeriksaan + totalHargaObat;

                        // Debug: Tampilkan total jumlah
                        MessageBox.Show($"Total Jumlah yang Harus Dibayar: {totalJumlah}");

                        // Tampilkan di TextBox
                        txtJumlahPembayaran.Text = totalJumlah.ToString("N0");
                    }
                    else
                    {
                        MessageBox.Show("Data pasien tidak ditemukan.");
                    }
                }
                else
                {
                    MessageBox.Show("Masukkan ID Pasien atau Nama Pasien terlebih dahulu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        private decimal HitungTotalHargaObat(int idPendaftaran)
        {
            decimal totalHargaObat = 0;

            try
            {
                if (koneksi.State != ConnectionState.Open)
                {
                    koneksi.Open();
                }

                string query = @"
            SELECT ro.jumlah, o.harga_obat 
            FROM resep_obat ro 
            JOIN tbl_pendaftaran p ON ro.id_pasien = p.id_pasien
            JOIN tbl_obat o ON ro.id_obat = o.id_obat
            WHERE p.id_pendaftaran = @id_pendaftaran";

                using (MySqlCommand command = new MySqlCommand(query, koneksi))
                {
                    command.Parameters.AddWithValue("@id_pendaftaran", idPendaftaran);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int jumlahObat = reader.GetInt32("jumlah");
                            decimal hargaObat = reader.GetDecimal("harga_obat");

                            // Debugging: tampilkan jumlah dan harga obat
                            MessageBox.Show($"Jumlah: {jumlahObat}, Harga Obat: {hargaObat}");

                            totalHargaObat += jumlahObat * hargaObat;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghitung harga obat: " + ex.Message);
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }

            // Debugging: tampilkan total harga obat
            MessageBox.Show($"Total Harga Obat: {totalHargaObat}");
            return totalHargaObat;
        }




        private void btnSavePembayaran_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan nilai total sudah dihitung dan ditampilkan di txtJumlahPembayaran
                if (string.IsNullOrEmpty(txtJumlahPembayaran.Text))
                {
                    MessageBox.Show("Jumlah pembayaran belum dihitung. Silakan cari pasien terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPendaftaran = int.Parse(txtIDPendaftaranPembayaran.Text);
                string tanggalPembayaran = dateTanggalPembayaran.Value.ToString("yyyy-MM-dd");
                decimal jumlah = decimal.Parse(txtJumlahPembayaran.Text.Replace(",", "")); // Pastikan nilai jumlah diambil dari TextBox
                string metodePembayaran = cbMetodePembayaran.SelectedItem.ToString();
                string statusPembayaran = cbStatusPembayaran.SelectedItem.ToString();

                koneksi.Open();

                string query = "INSERT INTO tbl_pembayaran (id_pendaftaran, tanggal_pembayaran, jumlah, metode_pembayaran, status_pembayaran) " +
                               "VALUES (@id_pendaftaran, @tanggal_pembayaran, @jumlah, @metode_pembayaran, @status_pembayaran)";

                using (MySqlCommand command = new MySqlCommand(query, koneksi))
                {
                    command.Parameters.AddWithValue("@id_pendaftaran", idPendaftaran);
                    command.Parameters.AddWithValue("@tanggal_pembayaran", tanggalPembayaran);
                    command.Parameters.AddWithValue("@jumlah", jumlah);
                    command.Parameters.AddWithValue("@metode_pembayaran", metodePembayaran);
                    command.Parameters.AddWithValue("@status_pembayaran", statusPembayaran);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        // Fungsi untuk menghitung total harga obat dari resep berdasarkan ID pendaftaran pasien



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Radius untuk sudut panel
            int radius = 25;
            // Buat objek GraphicsPath untuk menggambar panel dengan sudut membulat
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel1.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel1.Width - radius, panel1.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel1.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            // Set bentuk panel sesuai dengan path
            panel1.Region = new Region(path);

            // Gambar border (opsional)
            //Pen pen = new Pen(Color.Black, 1);
            //e.Graphics.DrawPath(pen, path);
        }
    }
}
