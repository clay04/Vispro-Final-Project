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
        public DokterFrm()
        {
            alamat = "server=localhost; database=db_klinik; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();

            panelRekamMedis.Visible = false;
            panelRiwayatRekamMedis.Visible = false;
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
            cardRekamMedis.Paint += new PaintEventHandler(cardRekamMedis_Paint);

            try
            {
                // Membuka koneksi
                koneksi.Open();

                // Query untuk mengambil data dari tabel tbl_rekam_medis dan tbl_pasien
                query = "SELECT rm.id_rekam_medis, rm.id_pasien, p.nama_pasien, rm.tanggal_periksa, " +
                        "rm.diagnosa, rm.pengobatan, rm.resep_obat, rm.catatan_tambahan " +
                        "FROM tbl_rekam_medis rm " +
                        "INNER JOIN tbl_pasien p ON rm.id_pasien = p.id_pasien";

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
                dataGridView1.Columns[5].HeaderText = "Pengobatan";
                dataGridView1.Columns[6].HeaderText = "Resep Obat";
                dataGridView1.Columns[7].HeaderText = "Catatan Tambahan";

                // Atur lebar kolom sesuai kebutuhan
                dataGridView1.Columns[0].Width = 120; // ID Rekam Medis
                dataGridView1.Columns[1].Width = 100; // ID Pasien
                dataGridView1.Columns[2].Width = 150; // Nama Pasien
                dataGridView1.Columns[3].Width = 120; // Tanggal Periksa
                dataGridView1.Columns[4].Width = 200; // Diagnosa
                dataGridView1.Columns[5].Width = 200; // Pengobatan
                dataGridView1.Columns[6].Width = 200; // Resep Obat
                dataGridView1.Columns[7].Width = 250; // Catatan Tambahan

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
                // Cek apakah form rekam medis sudah diisi
                if (txtIDPasien.Text != "" && txtNamaPasien.Text != "" && dateTanggalPeriksa.Text != "" && txtDiagnosa.Text != "" && txtPengobatan.Text != "" && txtResepObat.Text != "")
                {
                    // Query untuk insert data ke rekam medis
                    string insertQuery = string.Format(
                        "INSERT INTO tbl_rekam_medis (id_pasien, tanggal_periksa, diagnosa, pengobatan, resep_obat, catatan_tambahan) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                        txtIDPasien.Text,
                        dateTanggalPeriksa.Value.ToString("yyyy-MM-dd"),
                        txtDiagnosa.Text,
                        txtPengobatan.Text,
                        txtResepObat.Text,
                        txtCatatanTambahan.Text);

                    koneksi.Open();
                    perintah = new MySqlCommand(insertQuery, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Data rekam medis berhasil disimpan!");
                        ClearForm(); // Method untuk mengosongkan input form
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data rekam medis.");
                    }
                }
                else
                {
                    MessageBox.Show("Form rekam medis tidak lengkap.");
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

        private void ClearForm()
        {
            txtIDPasien.Clear();
            txtNamaPasien.Clear();
            txtRiwayatPenyakit.Clear();
            dateTanggalPeriksa.Value = DateTime.Now;
            txtDiagnosa.Clear();
            txtPengobatan.Clear();
            txtResepObat.Clear();
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

        private void btnRekamMedis_Click(object sender, EventArgs e)
        {
            panelRekamMedis.Visible = true;
            panelRiwayatRekamMedis.Visible = false;
        }
    }
}
