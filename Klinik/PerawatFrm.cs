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
using System.Data.SqlClient;

namespace Klinik
{
    public partial class PerawatFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private Form1 form1;
        public PerawatFrm(Form1 form1)
        {

            alamat = "server=localhost; database=db_klinik; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();

            this.form1 = form1;

            LoadDataPasien();

            panelPemeriksaanAwal.Visible = false;
            PanelRiwayatPemeriksaanAwal.Visible = false;
        }

        private void PerawatFrm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = "SELECT id_pasien, nama_pasien, riwayat_penyakit, keluhan FROM tbl_pasien";

                MySqlCommand perintahPasien = new MySqlCommand(query, koneksi);
                MySqlDataAdapter adapterPasien = new MySqlDataAdapter(perintahPasien);
                DataSet ds = new DataSet();
                adapterPasien.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                FormatDataGridView(dataGridView1, new string[] { "ID Pasien", "Nama Pasien", "Keluhan", "Riwayat Penyakit"});
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void FormatDataGridView(DataGridView dgv, string[] columnHeaders)
        {
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            for (int i = 0; i < columnHeaders.Length; i++)
            {
                dgv.Columns[i].HeaderText = columnHeaders[i];
                dgv.Columns[i].Width = 180;
            }

            dgv.Columns[0].Width = 150; // Adjust specific column widths if needed
            dgv.Columns[dgv.Columns.Count - 1].Width = 350; // Adjust last column width for long text
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Cek apakah input ID Pasien atau Nama Pasien tidak kosong
                if (txtIDPasienRiw.Text != "" || txtNamaPasienRiw.Text != "")
                {
                    string query = "";

                    // Jika ID Pasien diisi, cari berdasarkan ID Pasien
                    if (txtIDPasienRiw.Text != "")
                    {
                        query = string.Format(
                            "SELECT id_pasien, nama_pasien, riwayat_penyakit, keluhan FROM tbl_pasien WHERE id_pasien = '{0}'",
                            txtIDPasienRiw.Text);
                    }
                    // Jika Nama Pasien diisi, cari berdasarkan Nama Pasien
                    else if (txtNamaPasienRiw.Text != "")
                    {
                        query = string.Format(
                            "SELECT id_pasien, nama_pasien, riwayat_penyakit, keluhan FROM tbl_pasien WHERE nama_pasien LIKE '%{0}%'",
                            txtNamaPasienRiw.Text);
                    }

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    MySqlDataReader reader = perintah.ExecuteReader();

                    if (reader.Read())
                    {
                        // Jika data ditemukan, tampilkan Nama Pasien, ID Pasien, dan Riwayat Penyakit
                        txtIDPasienRiw.Text = reader["id_pasien"].ToString();
                        txtNamaPasienRiw.Text = reader["nama_pasien"].ToString();
                        txtRiwayatPenyakitRiw.Text = reader["riwayat_penyakit"].ToString();
                        txtKeluhanRiw.Text = reader["keluhan"].ToString();
                        
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDPasienRiw.Text) ||
                string.IsNullOrWhiteSpace(txtKeluhanRiw.Text) ||
                string.IsNullOrWhiteSpace(txtRiwayatPenyakitRiw.Text))
            {
                MessageBox.Show("Pastikan semua data terisi.");
                return;
            }

            try
            {
                // Buka koneksi
                koneksi.Open();

                // Cek apakah ID pasien sudah ada di database
                string queryCheck = "SELECT COUNT(*) FROM tbl_pasien WHERE id_pasien = @id_pasien";
                using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, koneksi))
                {
                    cmdCheck.Parameters.AddWithValue("@id_pasien", txtIDPasienRiw.Text);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    string query;
                    // Jika ID pasien sudah ada, lakukan UPDATE
                    query = @"UPDATE tbl_pasien 
                          SET keluhan = @keluhan, riwayat_penyakit = @riwayat_penyakit 
                          WHERE id_pasien = @id_pasien";


                    // Eksekusi query UPDATE atau INSERT
                    using (MySqlCommand cmd = new MySqlCommand(query, koneksi))
                    {
                        cmd.Parameters.AddWithValue("@id_pasien", txtIDPasienRiw.Text);
                        cmd.Parameters.AddWithValue("@keluhan", txtKeluhanRiw.Text);
                        cmd.Parameters.AddWithValue("@riwayat_penyakit", txtRiwayatPenyakitRiw.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil disimpan.");
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                // Tutup koneksi
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedID = txtIDPasienRiw.Text.Trim();

            // Validasi apakah ID sudah diisi
            if (string.IsNullOrEmpty(selectedID))
            {
                MessageBox.Show("Masukkan ID pasien terlebih dahulu.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi penghapusan
            DialogResult dialogResult = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data di kolom 'Keluhan' dan 'Riwayat Penyakit'?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = null;
                try
                {
                    // Koneksi ke database
                    string connectionString = "your_connection_string_here"; // Ganti dengan string koneksi Anda
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    // Query UPDATE untuk menghapus data di kolom "keluhan" dan "riwayat_penyakit"
                    string query = "UPDATE your_table_name SET riwayat_penyakit = NULL, keluhan = NULL WHERE id_pasien = @ID"; // Ganti 'your_table_name' dengan nama tabel Anda
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Tambahkan parameter
                        command.Parameters.AddWithValue("@ID", selectedID);

                        // Eksekusi query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Berikan notifikasi
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data di kolom 'Keluhan' dan 'Riwayat Penyakit' berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Opsional: Reset TextBox setelah penghapusan
                            txtIDPasienRiw.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan atau gagal dihapus.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    LoadDataPasien();
                }
                catch (Exception ex)
                {
                    // Tangani error
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Tutup koneksi jika terbuka
                    if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
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

        private void btnPemeriksaanAwal_Click(object sender, EventArgs e)
        {
            panelPemeriksaanAwal.Visible = true;
            PanelRiwayatPemeriksaanAwal.Visible =false;
        }

        private void btnRiwayatPemeriksaanAwal_Click(object sender, EventArgs e)
        {
            panelPemeriksaanAwal.Visible = false;
            PanelRiwayatPemeriksaanAwal.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(txtIDPasien.Text) ||
                string.IsNullOrWhiteSpace(txtKeluhanPasien.Text) ||
                string.IsNullOrWhiteSpace(txtRiwayatPenyakitPasien.Text))
            {
                MessageBox.Show("Pastikan semua data terisi.");
                return;
            }

            try
            {
                // Buka koneksi
                koneksi.Open();

                // Cek apakah ID pasien sudah ada di database
                string queryCheck = "SELECT COUNT(*) FROM tbl_pasien WHERE id_pasien = @id_pasien";
                using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, koneksi))
                {
                    cmdCheck.Parameters.AddWithValue("@id_pasien", txtIDPasien.Text);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    string query;
                        // Jika ID pasien sudah ada, lakukan UPDATE
                    query = @"UPDATE tbl_pasien 
                          SET keluhan = @keluhan, riwayat_penyakit = @riwayat_penyakit 
                          WHERE id_pasien = @id_pasien";
                    

                    // Eksekusi query UPDATE atau INSERT
                    using (MySqlCommand cmd = new MySqlCommand(query, koneksi))
                    {
                        cmd.Parameters.AddWithValue("@id_pasien", txtIDPasien.Text);
                        cmd.Parameters.AddWithValue("@keluhan", txtKeluhanPasien.Text);
                        cmd.Parameters.AddWithValue("@riwayat_penyakit", txtRiwayatPenyakitPasien.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil disimpan.");
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan data.");
                        }
                    }
                }
                LoadDataPasien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                // Tutup koneksi
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }

        }

        private void LoadDataPasien()
        {
            try
            {
                koneksi.Open();
                query = "SELECT id_pasien, nama_pasien, riwayat_penyakit, keluhan FROM tbl_pasien";
                MySqlDataAdapter adapterPasien = new MySqlDataAdapter(query, koneksi);
                DataSet ds = new DataSet();
                adapterPasien.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
            finally
            {
                koneksi.Close();
            }
        }

    }
}
