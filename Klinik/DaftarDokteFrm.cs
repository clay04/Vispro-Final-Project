using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace Klinik
{
    public partial class DaftarDokteFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public DaftarDokteFrm()
        {
            InitializeComponent();

            alamat = "server=localhost; database=db_klinik; username=root; password=; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            koneksi = new MySqlConnection(alamat);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

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

        private void DaftarDokteFrm_Load(object sender, EventArgs e)
        {
            panel1.Paint += new PaintEventHandler(panel1_Paint);

            try
            {
                ds.Clear();
                string query = "SELECT * FROM tbl_dokter";
                koneksi.Open();
                MySqlCommand perintah = new MySqlCommand(query, koneksi);
                MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns["id_dokter"].HeaderText = "ID Dokter";
                dataGridView1.Columns["username_dokter"].HeaderText = "Username";
                dataGridView1.Columns["nama_dokter"].HeaderText = "Nama Dokter";
                dataGridView1.Columns["alamat"].HeaderText = "Alamat";
                dataGridView1.Columns["tanggal_bekerja"].HeaderText = "Tanggal Bekerja";
                dataGridView1.Columns["no_telepon"].HeaderText = "Nomor Telepon";
                dataGridView1.Columns["email"].HeaderText = "Email";
                dataGridView1.Columns["password"].HeaderText = "Password";

                dataGridView1.Columns["id_dokter"].Width = 80;
                dataGridView1.Columns["username_dokter"].Width = 120;
                dataGridView1.Columns["nama_dokter"].Width = 150;
                dataGridView1.Columns["alamat"].Width = 200;
                dataGridView1.Columns["tanggal_bekerja"].Width = 120;
                dataGridView1.Columns["no_telepon"].Width = 100;
                dataGridView1.Columns["email"].Width = 150;
                dataGridView1.Columns["password"].Width = 100;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDDokter.Text != "" && txtUsernameDokter.Text != "" && txtNamaDokter.Text != "" && txtAlamatDokter.Text != "" && dateTanggalBekerjaDokter.Text != "" && txtNomorTeleponDokter.Text != "" && txtEmailDokter.Text != "" && txtPasswordDokter.Text != "")
                {
                    string insertQuery = string.Format(
                        "INSERT INTO tbl_dokter (id_dokter, username_dokter, nama_dokter, alamat, tanggal_bekerja, no_telepon, email, password)" +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                        txtIDDokter.Text,
                        txtUsernameDokter.Text,
                        txtNamaDokter.Text,
                        txtAlamatDokter.Text,
                        dateTanggalBekerjaDokter.Value.ToString("yyyy-MM-dd"),
                        txtNomorTeleponDokter.Text,
                        txtEmailDokter.Text,
                        txtPasswordDokter.Text);

                    koneksi.Open();
                    perintah = new MySqlCommand(insertQuery, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Data Dokter berhasil disimpan!");
                        ClearForm(); 
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data Dokter.");
                    }
                }
                else
                {
                    MessageBox.Show("Form Dokter tidak lengkap.");
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



        private void LoadData()
        {
            try
            {
                string selectQuery = "SELECT * FROM tbl_dokter";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, koneksi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM tbl_dokter WHERE 1=1"; // Base query
                bool hasParameter = false;

                // Check each field and add to the query if it has input
                if (!string.IsNullOrWhiteSpace(txtIDDokter.Text))
                {
                    query += " AND id_dokter = @idDokter";
                    hasParameter = true;
                }
                if (!string.IsNullOrWhiteSpace(txtUsernameDokter.Text))
                {
                    query += " AND username_dokter = @usernameDokter";
                    hasParameter = true;
                }
                if (!string.IsNullOrWhiteSpace(txtNamaDokter.Text))
                {
                    query += " AND nama_dokter = @namaDokter";
                    hasParameter = true;
                }

                // Check if at least one search parameter is provided
                if (!hasParameter)
                {
                    MessageBox.Show("Masukkan ID, Username, atau Nama Dokter untuk mencari.");
                    return;
                }

                ds.Clear();
                koneksi.Open();
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                // Add parameters based on user input
                if (!string.IsNullOrWhiteSpace(txtIDDokter.Text))
                {
                    perintah.Parameters.AddWithValue("@idDokter", txtIDDokter.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtUsernameDokter.Text))
                {
                    perintah.Parameters.AddWithValue("@usernameDokter", txtUsernameDokter.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtNamaDokter.Text))
                {
                    perintah.Parameters.AddWithValue("@namaDokter", txtNamaDokter.Text);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        txtIDDokter.Text = kolom["id_dokter"].ToString();
                        txtUsernameDokter.Text = kolom["username_dokter"].ToString();
                        txtNamaDokter.Text = kolom["nama_dokter"].ToString();
                        txtAlamatDokter.Text = kolom["alamat"].ToString();

                        DateTime tanggalBekerja;
                        if (DateTime.TryParse(kolom["tanggal_bekerja"].ToString(), out tanggalBekerja))
                        {
                            dateTanggalBekerjaDokter.Value = tanggalBekerja;
                        }
                        else
                        {
                            MessageBox.Show("Format tanggal tidak valid di database.");
                        }
                        txtNomorTeleponDokter.Text = kolom["no_telepon"].ToString();
                        txtEmailDokter.Text = kolom["email"].ToString();
                        txtPasswordDokter.Text = kolom["password"].ToString();
                    }
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Data dokter tidak ditemukan.");
                    DaftarDokteFrm_Load(null, null); // Reload form if no data is found
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIDDokter.Text))
                {
                    MessageBox.Show("ID Dokter harus diisi untuk melakukan update.");
                    return;
                }

                string query = "UPDATE tbl_dokter SET " +
                               "username_dokter = @usernameDokter, " +
                               "nama_dokter = @namaDokter, " +
                               "alamat = @alamat, " +
                               "tanggal_bekerja = @tanggalBekerja, " +
                               "no_telepon = @noTelepon, " +
                               "email = @email, " +
                               "password = @password " +
                               "WHERE id_dokter = @idDokter";

                koneksi.Open();
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                // Assign parameters from textboxes
                perintah.Parameters.AddWithValue("@idDokter", txtIDDokter.Text);
                perintah.Parameters.AddWithValue("@usernameDokter", txtUsernameDokter.Text);
                perintah.Parameters.AddWithValue("@namaDokter", txtNamaDokter.Text);
                perintah.Parameters.AddWithValue("@alamat", txtAlamatDokter.Text);

                // Parse and add date parameter
                DateTime tanggalBekerja;
                if (DateTime.TryParse(dateTanggalBekerjaDokter.Text, out tanggalBekerja))
                {
                    perintah.Parameters.AddWithValue("@tanggalBekerja", tanggalBekerja.ToString("yyyy-MM-dd"));
                }
                else
                {
                    MessageBox.Show("Format tanggal tidak valid.");
                    koneksi.Close();
                    return;
                }

                perintah.Parameters.AddWithValue("@noTelepon", txtNomorTeleponDokter.Text);
                perintah.Parameters.AddWithValue("@email", txtEmailDokter.Text);
                perintah.Parameters.AddWithValue("@password", txtPasswordDokter.Text);

                // Execute the update command
                int rowsAffected = perintah.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil diperbarui.");
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Data gagal diperbarui atau tidak ditemukan.");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if ID Dokter is provided
                if (string.IsNullOrWhiteSpace(txtIDDokter.Text))
                {
                    MessageBox.Show("ID Dokter harus diisi untuk menghapus data.");
                    return;
                }

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                            "Konfirmasi Hapus",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                // SQL Delete Query
                string query = "DELETE FROM tbl_dokter WHERE id_dokter = @idDokter";
                koneksi.Open();
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                // Add the parameter
                perintah.Parameters.AddWithValue("@idDokter", txtIDDokter.Text);

                // Execute the delete command
                int rowsAffected = perintah.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil dihapus.");
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan atau gagal dihapus.");
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

        private void ClearForm()
        {
            txtIDDokter.Clear();
            txtUsernameDokter.Clear();
            txtNamaDokter.Clear();
            txtAlamatDokter.Clear();
            dateTanggalBekerjaDokter.Value = DateTime.Now;
            txtNomorTeleponDokter.Clear();
            txtEmailDokter.Clear();
            txtPasswordDokter.Clear();
        }
    }
}
