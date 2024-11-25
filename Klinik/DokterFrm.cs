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
using System.Text.RegularExpressions;

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

            LoadObatToComboBox();
            cbObat.SelectedIndexChanged -= cbObat_SelectedIndexChanged;
            cbObat.SelectedIndexChanged += cbObat_SelectedIndexChanged;

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
                            "SELECT id_pasien, nama_pasien, riwayat_penyakit, keluhan FROM tbl_pasien WHERE id_pasien = '{0}'",
                            txtIDPasien.Text);
                    }
                    // Jika Nama Pasien diisi, cari berdasarkan Nama Pasien
                    else if (txtNamaPasien.Text != "")
                    {
                        query = string.Format(
                            "SELECT id_pasien, nama_pasien, riwayat_penyakit, keluhan FROM tbl_pasien WHERE nama_pasien LIKE '%{0}%'",
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
                        txtKeluhan.Text = reader["keluhan"].ToString();
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
            finally
            {
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
            finally
            {
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

        public class Resep
        {
            public string IdPasien { get; set; }
            public string IdObat { get; set; }
            public string Dosis { get; set; }
            public string CaraPakai { get; set; }
            public string Jumlah { get; set; }
            public string Keterangan { get; set; }
            public string IdRekamMedis { get; set; }
        }


        List<Resep> listResepObat = new List<Resep>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(txtIDPasien.Text) ||
                    string.IsNullOrWhiteSpace(txtIDObat.Text) ||
                    string.IsNullOrWhiteSpace(txtDosis.Text) ||
                    string.IsNullOrWhiteSpace(txtCaraPakai.Text) ||
                    string.IsNullOrWhiteSpace(txtJumlah.Text) ||
                    string.IsNullOrWhiteSpace(txtKeterangan.Text) ||
                    string.IsNullOrWhiteSpace(txtIDRekamMedis.Text))
                {
                    MessageBox.Show("Data Resep Obat Tidak Lengkap!");
                    return;
                }

                // Tambahkan resep obat ke list
                listResepObat.Add(new Resep
                {
                    IdPasien = txtIDPasien.Text,
                    IdObat = txtIDObat.Text,
                    Dosis = txtDosis.Text,
                    CaraPakai = txtCaraPakai.Text,
                    Jumlah = txtJumlah.Text,
                    Keterangan = txtKeterangan.Text,
                    IdRekamMedis = txtIDRekamMedis.Text
                });

                MessageBox.Show("Resep obat berhasil ditambahkan ke list sementara.");
                ClearResepObatForm(); // Bersihkan form input
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void ClearResepObatForm()
        {
            txtIDResepObat.Clear();
            txtDosis.Clear();
            txtCaraPakai.Clear();
            txtJumlah.Clear();
            txtKeterangan.Clear();
        }


        // Tambahkan method ini

        // Panggil metode ini di event Form_Load atau saat form diinisialisasi
        private void Form_Load(object sender, EventArgs e)
        {

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

        private void btnDash_Click(object sender, EventArgs e)
        {
            panelRekamMedis.Visible = false;
            panelRiwayatRekamMedis.Visible = false;
        }

        private void btnSaveRekam_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(txtIDPasien.Text) ||
                    string.IsNullOrWhiteSpace(dateTanggalPeriksa.Text) ||
                    string.IsNullOrWhiteSpace(txtDiagnosa.Text) ||
                    string.IsNullOrWhiteSpace(txtCatatanTambahan.Text))
                {
                    MessageBox.Show("Data Rekam Medis Tidak Lengkap!");
                    return;
                }

                koneksi.Open();

                string queryRekamMedis = @"INSERT INTO tbl_rekam_medis 
        (id_pasien, tanggal_periksa, diagnosa, catatan_tambahan) 
        VALUES (@id_pasien, @tanggal_periksa, @diagnosa, @catatan_tambahan)";

                using (MySqlCommand cmd = new MySqlCommand(queryRekamMedis, koneksi))
                {
                    cmd.Parameters.AddWithValue("@id_pasien", txtIDPasien.Text);
                    cmd.Parameters.AddWithValue("@tanggal_periksa", dateTanggalPeriksa.Value);
                    cmd.Parameters.AddWithValue("@diagnosa", txtDiagnosa.Text);
                    cmd.Parameters.AddWithValue("@catatan_tambahan", txtCatatanTambahan.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Rekam Medis Berhasil Disimpan.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal Menyimpan Data Rekam Medis.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex.Message);
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        private void btnSaveResep_Click(object sender, EventArgs e)
        {
            // Periksa apakah list kosong
            if (listResepObat.Count == 0)
            {
                MessageBox.Show("Tidak ada data resep obat untuk disimpan.");
                return;
            }

            try
            {
                // Buka koneksi
                koneksi.Open();

                // Iterasi melalui listResepObat untuk menyimpan setiap resep
                foreach (var resep in listResepObat)
                {
                    string queryResepObat = @"INSERT INTO resep_obat 
                (id_obat, id_pasien, dosis, cara_pakai, jumlah, keterangan, id_rekam_medis) 
                VALUES (@id_obat, @id_pasien, @dosis, @cara_pakai, @jumlah, @keterangan, @id_rekam_medis)";

                    using (MySqlCommand cmd = new MySqlCommand(queryResepObat, koneksi))
                    {
                        // Tambahkan parameter
                        cmd.Parameters.AddWithValue("@id_obat", resep.IdObat);
                        cmd.Parameters.AddWithValue("@id_pasien", resep.IdPasien);
                        cmd.Parameters.AddWithValue("@dosis", resep.Dosis);
                        cmd.Parameters.AddWithValue("@cara_pakai", resep.CaraPakai);
                        cmd.Parameters.AddWithValue("@jumlah", resep.Jumlah);
                        cmd.Parameters.AddWithValue("@keterangan", resep.Keterangan);
                        cmd.Parameters.AddWithValue("@id_rekam_medis", resep.IdRekamMedis);

                        // Eksekusi perintah
                        cmd.ExecuteNonQuery();
                    }
                }

                // Jika berhasil
                MessageBox.Show("Semua resep obat berhasil disimpan ke database.");

                // Bersihkan list setelah data tersimpan
                listResepObat.Clear();
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error
                MessageBox.Show("Terjadi kesalahan saat menyimpan: " + ex.Message);
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
            finally
            {
                // Pastikan koneksi tertutup
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        private void cbObat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbObat.SelectedItem != null)
                {
                    // Ambil item yang dipilih dari ComboBox
                    dynamic selectedItem = cbObat.SelectedItem;

                    // Tampilkan id_obat di txtIDObat
                    txtIDObat.Text = selectedItem.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memilih obat: " + ex.Message);
            }
        }

        private void btnRekamMedis_Click(object sender, EventArgs e)
        {
            panelRekamMedis.Visible = true;
            panelRiwayatRekamMedis.Visible = false;
        }

        private void txtIDObat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchRiw_Click(object sender, EventArgs e)
        {
            try
            {
                // Cek apakah input ID Pasien atau Nama Pasien tidak kosong
                if (!string.IsNullOrWhiteSpace(txtIDPasienRiw.Text) || !string.IsNullOrWhiteSpace(txtNamaPasienRiw.Text))
                {
                    // Koneksi ke database
                    koneksi.Open();

                    // Query pencarian
                    string query = "SELECT rm.id_rekam_medis, rm.id_pasien, p.nama_pasien, rm.tanggal_periksa, " +
                                   "rm.diagnosa, rm.catatan_tambahan, ro.id_resep, ro.id_obat, o.nama_obat, " +
                                   "ro.dosis, ro.cara_pakai, ro.jumlah, ro.keterangan " +
                                   "FROM tbl_rekam_medis rm " +
                                   "INNER JOIN tbl_pasien p ON rm.id_pasien = p.id_pasien " +
                                   "LEFT JOIN resep_obat ro ON rm.id_pasien = ro.id_pasien " +
                                   "LEFT JOIN tbl_obat o ON ro.id_obat = o.id_obat " +
                                   "WHERE (p.id_pasien LIKE @idPasien OR p.nama_pasien LIKE @namaPasien)";

                    // Membuat perintah dengan parameter
                    perintah = new MySqlCommand(query, koneksi);

                    // Menambahkan parameter
                    perintah.Parameters.AddWithValue("@idPasien", "%" + txtIDPasienRiw.Text.Trim() + "%");
                    perintah.Parameters.AddWithValue("@namaPasien", "%" + txtNamaPasienRiw.Text.Trim() + "%");

                    // Membuat DataTable untuk menampung hasil query
                    DataTable dt = new DataTable();

                    // Eksekusi query dan isi DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(perintah))
                    {
                        adapter.Fill(dt);
                    }

                    // Tampilkan hasil ke DataGridView
                    dataGridView1.DataSource = dt;

                    // Tampilkan detail data pada form jika ditemukan satu hasil
                    if (dt.Rows.Count > 0)
                    {
                        // Jika hanya ada satu baris data, tampilkan detail di TextBox
                        DataRow row = dt.Rows[0];
                        txtIDRekamMedisRiw.Text = row["id_rekam_medis"].ToString();
                        txtIDPasienRiw.Text = row["id_pasien"].ToString();
                        txtNamaPasienRiw.Text = row["nama_pasien"].ToString();
                        dateTanggalPeriksaRiw.Text = row["tanggal_periksa"].ToString();
                        txtDiagnosaRiw.Text = row["diagnosa"].ToString();
                        txtCatatanTambahanRiw.Text = row["catatan_tambahan"].ToString();
                        txtIDResepRiw.Text = row["id_resep"].ToString();
                        txtIDObatRiw.Text = row["id_obat"].ToString();
                        txtNamaObatRiw.Text = row["nama_obat"].ToString();
                        txtDosisRiw.Text = row["dosis"].ToString();
                        txtCaraPakaiRiw.Text = row["cara_pakai"].ToString();
                        txtJumlahRiw.Text = row["jumlah"].ToString();
                        txtKeteranganRiw.Text = row["keterangan"].ToString();
                    }
                    else
                    {
                        // Jika tidak ada data, beri pesan
                        MessageBox.Show("Data pasien tidak ditemukan.");
                    }
                }
                else
                {
                    // Pesan jika input kosong
                    MessageBox.Show("Masukkan ID Pasien atau Nama Pasien terlebih dahulu.");
                }
            }
            catch (Exception ex)
            {
                // Penanganan error
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Tutup koneksi jika masih terbuka
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        private void btnUpdateRiw_Click(object sender, EventArgs e)
        {
            try
            {
                // Cek apakah semua input sudah terisi
                if (string.IsNullOrWhiteSpace(txtIDRekamMedisRiw.Text) ||
                    string.IsNullOrWhiteSpace(txtDiagnosaRiw.Text) ||
                    string.IsNullOrWhiteSpace(txtCatatanTambahanRiw.Text))
                {
                    MessageBox.Show("Pastikan semua data rekam medis terisi dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Koneksi ke database
                koneksi.Open();

                // Query untuk memperbarui data rekam medis
                string queryRekamMedis = "UPDATE tbl_rekam_medis SET " +
                                         "diagnosa = @diagnosa, " +
                                         "catatan_tambahan = @catatan " +
                                         "WHERE id_rekam_medis = @idRekamMedis";

                MySqlCommand cmdRekamMedis = new MySqlCommand(queryRekamMedis, koneksi);
                cmdRekamMedis.Parameters.AddWithValue("@diagnosa", txtDiagnosaRiw.Text.Trim());
                cmdRekamMedis.Parameters.AddWithValue("@catatan", txtCatatanTambahanRiw.Text.Trim());
                cmdRekamMedis.Parameters.AddWithValue("@idRekamMedis", txtIDRekamMedisRiw.Text.Trim());

                // Eksekusi query untuk update rekam medis
                cmdRekamMedis.ExecuteNonQuery();

                // Jika ada data resep yang ingin diperbarui
                if (!string.IsNullOrWhiteSpace(txtIDResepRiw.Text))
                {
                    string queryResepObat = "UPDATE resep_obat SET " +
                                            "id_obat = @idObat, " +
                                            "dosis = @dosis, " +
                                            "cara_pakai = @caraPakai, " +
                                            "jumlah = @jumlah, " +
                                            "keterangan = @keterangan " +
                                            "WHERE id_resep = @idResep";

                    MySqlCommand cmdResepObat = new MySqlCommand(queryResepObat, koneksi);
                    cmdResepObat.Parameters.AddWithValue("@idObat", txtIDObatRiw.Text.Trim());
                    cmdResepObat.Parameters.AddWithValue("@dosis", txtDosisRiw.Text.Trim());
                    cmdResepObat.Parameters.AddWithValue("@caraPakai", txtCaraPakaiRiw.Text.Trim());
                    cmdResepObat.Parameters.AddWithValue("@jumlah", txtJumlahRiw.Text.Trim());
                    cmdResepObat.Parameters.AddWithValue("@keterangan", txtKeteranganRiw.Text.Trim());
                    cmdResepObat.Parameters.AddWithValue("@idResep", txtIDResepRiw.Text.Trim());

                    // Eksekusi query untuk update resep obat
                    cmdResepObat.ExecuteNonQuery();
                }

                // Tampilkan pesan berhasil
                MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Perbarui tampilan data pada DataGridView
                btnSearchRiw.PerformClick();
            }
            catch (Exception ex)
            {
                // Penanganan error
                MessageBox.Show("Terjadi kesalahan saat memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Tutup koneksi jika masih terbuka
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        private void LoadObatToComboBox()
        {
            try
            {
                string query = "SELECT id_obat, nama_obat FROM tbl_obat";
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                koneksi.Open();
                MySqlDataReader reader = perintah.ExecuteReader();

                // Bersihkan ComboBox sebelum menambahkan item
                cbObat.Items.Clear();

                // Tambahkan item ke ComboBox
                while (reader.Read())
                {
                    cbObat.Items.Add(new
                    {
                        Text = reader["nama_obat"].ToString(),
                        Value = reader["id_obat"].ToString()
                    });
                }

                cbObat.DisplayMember = "Text";
                cbObat.ValueMember = "Value";

                reader.Close();
                koneksi.Close();

                // Event handler untuk perubahan pilihan
                cbObat.SelectedIndexChanged += cbObat_SelectedIndexChanged;
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

        }
}
