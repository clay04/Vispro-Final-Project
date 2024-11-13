using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Drawing.Drawing2D;

namespace Klinik
{
    public partial class DokterFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private Form1 form1;

        public DokterFrm(Form1 form1)
        {
            alamat = "server=localhost; database=db_klinik; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();

            this.form1 = form1;

            panelRekamMedis.Visible = false;
            panelRiwayatRekamMedis.Visible = false;
            this.form1 = form1;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Cek apakah input ID Pasien atau Nama Pasien tidak kosong
                if (txtIDPasien.Text != "" || txtNamaPasien.Text != "")
                {
                    string query = "";

                    // Jika ID Pasien diisi, cari berdasarkan ID Pasien
                    if (txtIDPasien.Text != "")
                    {
                        query = string.Format(
                            "SELECT id_pasien, nama_pasien, riwayat_penyakit FROM tbl_pasien WHERE id_pasien = '{0}'",
                            txtIDPasien.Text);
                    }
                    // Jika Nama Pasien diisi, cari berdasarkan Nama Pasien
                    else if (txtNamaPasien.Text != "")
                    {
                        query = string.Format(
                            "SELECT id_pasien, nama_pasien, riwayat_penyakit FROM tbl_pasien WHERE nama_pasien LIKE '%{0}%'",
                            txtNamaPasien.Text);
                    }

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    MySqlDataReader reader = perintah.ExecuteReader();

                    if (reader.Read())
                    {
                        // Jika data ditemukan, tampilkan Nama Pasien, ID Pasien, dan Riwayat Penyakit
                        txtIDPasien.Text = reader["id_pasien"].ToString();
                        txtNamaPasien.Text = reader["nama_pasien"].ToString();
                        txtRiwayatPenyakit.Text = reader["riwayat_penyakit"].ToString();
                    }
                    else
                    {
                        // Jika data tidak ditemukan
                        MessageBox.Show("Data pasien tidak ditemukan.");
                    }
                    reader.Close();
                    koneksi.Close();
                }
                else
                {
                    MessageBox.Show("Masukkan ID Pasien atau Nama Pasien terlebih dahulu.");
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

        private void panelRekamMedis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DokterFrm_Load(object sender, EventArgs e)
        {
            LoadNamaObat();
            cardRekamMedis.Paint += new PaintEventHandler(cardRekamMedis_Paint);

            try
            {
                // Membuka koneksi
                koneksi.Open();

                // Query untuk mengambil data dari tabel tbl_rekam_medis, tbl_pasien, resep_obat, dan tbl_obat
                query = "SELECT rm.id_rekam_medis, rm.id_pasien, p.nama_pasien, rm.tanggal_periksa, " +
                        "rm.diagnosa, rm.catatan_tambahan, ro.id_resep, ro.id_obat, o.nama_obat, ro.dosis, ro.cara_pakai, ro.jumlah, ro.keterangan " +
                        "FROM tbl_rekam_medis rm " +
                        "INNER JOIN tbl_pasien p ON rm.id_pasien = p.id_pasien " +
                        "LEFT JOIN resep_obat ro ON rm.id_pasien = ro.id_pasien " +
                        "LEFT JOIN tbl_obat o ON ro.id_obat = o.id_obat";

                // Menjalankan query
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                // Clear dataset jika sudah ada data sebelumnya
                ds.Clear();

                // Isi dataset dengan hasil query
                adapter.Fill(ds);

                // Tampilkan data ke dalam DataGridView
                dataGridView1.DataSource = ds.Tables[0];

                // Set kolom DataGridView
                dataGridView1.Columns[0].HeaderText = "ID Rekam Medis";
                dataGridView1.Columns[1].HeaderText = "ID Pasien";
                dataGridView1.Columns[2].HeaderText = "Nama Pasien";
                dataGridView1.Columns[3].HeaderText = "Tanggal Periksa";
                dataGridView1.Columns[4].HeaderText = "Diagnosa";
                dataGridView1.Columns[5].HeaderText = "Catatan Tambahan";
                dataGridView1.Columns[6].HeaderText = "ID Resep";
                dataGridView1.Columns[7].HeaderText = "ID Obat";
                dataGridView1.Columns[8].HeaderText = "Nama Obat";
                dataGridView1.Columns[9].HeaderText = "Dosis";
                dataGridView1.Columns[10].HeaderText = "Cara Pakai";
                dataGridView1.Columns[11].HeaderText = "Jumlah";
                dataGridView1.Columns[12].HeaderText = "Keterangan";

                // Atur lebar kolom sesuai kebutuhan
                dataGridView1.Columns[0].Width = 120; // ID Rekam Medis
                dataGridView1.Columns[1].Width = 100; // ID Pasien
                dataGridView1.Columns[2].Width = 150; // Nama Pasien
                dataGridView1.Columns[3].Width = 120; // Tanggal Periksa
                dataGridView1.Columns[4].Width = 200; // Diagnosa
                dataGridView1.Columns[5].Width = 200; // Catatan Tambahan
                dataGridView1.Columns[6].Width = 100; // ID Resep
                dataGridView1.Columns[7].Width = 100; // ID Obat
                dataGridView1.Columns[8].Width = 150; // Nama Obat
                dataGridView1.Columns[9].Width = 150; // Dosis
                dataGridView1.Columns[10].Width = 150; // Cara Pakai
                dataGridView1.Columns[11].Width = 100; // Jumlah
                dataGridView1.Columns[12].Width = 200; // Keterangan

                // Tutup koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        private void cardRekamMedis_Paint(object sender, PaintEventArgs e)
        {
            int radius = 25;
            // Buat objek GraphicsPath untuk menggambar panel dengan sudut membulat
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(cardRekamMedis.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(cardRekamMedis.Width - radius, cardRekamMedis.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, cardRekamMedis.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            // Set bentuk panel sesuai dengan path
            cardRekamMedis.Region = new Region(path);

            // Gambar border (opsional)
            //Pen pen = new Pen(Color.Black, 1);
            //e.Graphics.DrawPath(pen, path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDPasien.Text != "" && txtNamaPasien.Text != "" && txtRiwayatPenyakit.Text != "" &&
                    txtIDRekamMedis.Text != "" && dateTanggalPeriksa.Text != "" && txtDiagnosa.Text != "" &&
                    txtCatatanTambahan.Text != "" && txtIDResepObat.Text != "" && txtIDObat.Text != "" &&
                    cbNamaObat.Text != "" && txtDosis.Text != "" && txtCaraPakai.Text != "" &&
                    txtJumlah.Text != "" && txtKeterangan.Text != "")
                {
                    if (!ValidateData())
                    {
                        return;
                    }

                    koneksi.Open();

                    // 1. Insert ke tabel rekam_medis
                    string queryRekamMedis = @"INSERT INTO tbl_rekam_medis 
                (id_pasien, tanggal_periksa, diagnosa, catatan_tambahan) 
                VALUES (@id_pasien, @tanggal_periksa, @diagnosa, @catatan_tambahan)";

                    using (MySqlCommand perintahRekamMedis = new MySqlCommand(queryRekamMedis, koneksi))
                    {
                        perintahRekamMedis.Parameters.AddWithValue("@id_pasien", txtIDPasien.Text);
                        perintahRekamMedis.Parameters.AddWithValue("@tanggal_periksa", dateTanggalPeriksa.Value);
                        perintahRekamMedis.Parameters.AddWithValue("@diagnosa", txtDiagnosa.Text);
                        perintahRekamMedis.Parameters.AddWithValue("@catatan_tambahan", txtCatatanTambahan.Text);

                        int resRekamMedis = perintahRekamMedis.ExecuteNonQuery();
                        if (resRekamMedis != 1)
                        {
                            MessageBox.Show("Gagal Insert Data Rekam Medis.");
                            koneksi.Close();
                            return;
                        }
                    }

                    // 2. Insert ke tabel resep_obat
                    string queryResepObat = @"INSERT INTO resep_obat 
                (id_obat, id_pasien, dosis, cara_pakai, jumlah, keterangan) 
                VALUES (@id_obat, @id_pasien, @dosis, @cara_pakai, @jumlah, @keterangan)";

                    using (MySqlCommand perintahResepObat = new MySqlCommand(queryResepObat, koneksi))
                    {
                        perintahResepObat.Parameters.AddWithValue("@id_obat", txtIDObat.Text);
                        perintahResepObat.Parameters.AddWithValue("@id_pasien", txtIDPasien.Text);
                        perintahResepObat.Parameters.AddWithValue("@dosis", txtDosis.Text);
                        perintahResepObat.Parameters.AddWithValue("@cara_pakai", txtCaraPakai.Text);
                        perintahResepObat.Parameters.AddWithValue("@jumlah", txtJumlah.Text);
                        perintahResepObat.Parameters.AddWithValue("@keterangan", txtKeterangan.Text);

                        int resResepObat = perintahResepObat.ExecuteNonQuery();
                        if (resResepObat == 1)
                        {
                            MessageBox.Show("Data berhasil disimpan.");
                            DokterFrm_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Gagal Insert Data Resep Obat.");
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

        // Tambahkan method ini
        private bool ValidateData()
        {
            try
            {
                using (MySqlCommand cmd = koneksi.CreateCommand())
                {
                    // Cek apakah ID Pasien ada
                    cmd.CommandText = "SELECT COUNT(*) FROM tbl_pasien WHERE id_pasien = @id_pasien";
                    cmd.Parameters.AddWithValue("@id_pasien", txtIDPasien.Text);
                    koneksi.Open();
                    int pasienCount = Convert.ToInt32(cmd.ExecuteScalar());
                    koneksi.Close();

                    if (pasienCount == 0)
                    {
                        MessageBox.Show("ID Pasien tidak ditemukan!");
                        return false;
                    }

                    // Cek apakah ID Obat ada
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT COUNT(*) FROM tbl_obat WHERE id_obat = @id_obat";
                    cmd.Parameters.AddWithValue("@id_obat", txtIDObat.Text);
                    koneksi.Open();
                    int obatCount = Convert.ToInt32(cmd.ExecuteScalar());
                    koneksi.Close();

                    if (obatCount == 0)
                    {
                        MessageBox.Show("ID Obat tidak ditemukan!");
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validasi: " + ex.Message);
                return false;
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }

        private void LoadNamaObat()
        {
            try
            {
                MessageBox.Show("Memulai pengisian ComboBox...");
                string query = "SELECT nama_obat FROM tbl_obat";
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                koneksi.Open();
                MySqlDataReader reader = perintah.ExecuteReader();

                while (reader.Read())
                {
                    cbNamaObat.Items.Add(reader["nama_obat"].ToString());
                }

                koneksi.Close();
                MessageBox.Show("Pengisian ComboBox selesai.");
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

        // Panggil metode ini di event Form_Load atau saat form diinisialisasi
        private void Form_Load(object sender, EventArgs e)
        {
            LoadNamaObat();
        }


        private void ClearForm()
        {
            txtIDPasien.Clear();
            txtNamaPasien.Clear();
            txtRiwayatPenyakit.Clear();
            dateTanggalPeriksa.Value = DateTime.Now;
            txtDiagnosa.Clear();
            txtCatatanTambahan.Clear();
        }

        private void btnRiwayatRekamMedis_Click(object sender, EventArgs e)
        {
            panelRiwayatRekamMedis.Visible = true;
            panelRekamMedis.Visible = false;
        }

        private void panelRiwayatRekamMedis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void txtRiwayatPenyakit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRekamMedis_Click(object sender, EventArgs e)
        {
            panelRekamMedis.Visible = true;
            panelRiwayatRekamMedis.Visible = false;
        }
    }
}
