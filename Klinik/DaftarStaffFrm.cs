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
    public partial class DaftarStaffFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public DaftarStaffFrm()
        {
            InitializeComponent();

            alamat = "server=localhost; database=db_klinik; username=root; password=; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            koneksi = new MySqlConnection(alamat);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void DaftarStaffFrm_Load(object sender, EventArgs e)
        {
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDStaff.Text != "" && txtUsernameStaff.Text != "" && txtNamaStaff.Text != "" && txtAlamatStaff.Text != "" && dateTanggalBekerjaStaff.Text != "" && txtNomorTeleponStaff.Text != "" && txtEmailStaff.Text != "" && txtPasswordStaff.Text != "")
                {
                    string insertQuery = string.Format(
                        "INSERT INTO tbl_dokter (id_dokter, username_dokter, nama_dokter, alamat, tanggal_bekerja, no_telepon, email, password)" +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                        txtIDStaff.Text,
                        txtUsernameStaff.Text,
                        txtNamaStaff.Text,
                        txtAlamatStaff.Text,
                        dateTanggalBekerjaStaff.Value.ToString("yyyy-MM-dd"),
                        txtNomorTeleponStaff.Text,
                        txtEmailStaff.Text,
                        txtPasswordStaff.Text);

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
                string selectQuery = "SELECT * FROM tbl_staff";
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
                string query = "SELECT * FROM tbl_staff WHERE 1=1"; // Base query
                bool hasParameter = false;

                // Check each field and add to the query if it has input
                if (!string.IsNullOrWhiteSpace(txtIDStaff.Text))
                {
                    query += " AND id_staff = @idStaff";
                    hasParameter = true;
                }
                if (!string.IsNullOrWhiteSpace(txtUsernameStaff.Text))
                {
                    query += " AND username_staff = @usernameStaff";
                    hasParameter = true;
                }
                if (!string.IsNullOrWhiteSpace(txtNamaStaff.Text))
                {
                    query += " AND nama_staff = @namaStaff";
                    hasParameter = true;
                }

                // Check if at least one search parameter is provided
                if (!hasParameter)
                {
                    MessageBox.Show("Masukkan ID, Username, atau Nama Staff untuk mencari.");
                    return;
                }

                ds.Clear();
                koneksi.Open();
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                // Add parameters based on user input
                if (!string.IsNullOrWhiteSpace(txtIDStaff.Text))
                {
                    perintah.Parameters.AddWithValue("@idStaff", txtIDStaff.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtUsernameStaff.Text))
                {
                    perintah.Parameters.AddWithValue("@usernameStaff", txtUsernameStaff.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtNamaStaff.Text))
                {
                    perintah.Parameters.AddWithValue("@namaStaff", txtNamaStaff.Text);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        txtIDStaff.Text = kolom["id_staff"].ToString();
                        txtUsernameStaff.Text = kolom["username_staff"].ToString();
                        txtNamaStaff.Text = kolom["nama_staff"].ToString();
                        txtAlamatStaff.Text = kolom["alamat"].ToString();

                        DateTime tanggalBekerja;
                        if (DateTime.TryParse(kolom["tanggal_bekerja"].ToString(), out tanggalBekerja))
                        {
                            dateTanggalBekerjaStaff.Value = tanggalBekerja;
                        }
                        else
                        {
                            MessageBox.Show("Format tanggal tidak valid di database.");
                        }
                        txtNomorTeleponStaff.Text = kolom["no_telepon"].ToString();
                        txtEmailStaff.Text = kolom["email"].ToString();
                        txtPasswordStaff.Text = kolom["password"].ToString();
                    }
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Data dokter tidak ditemukan.");
                    DaftarStaffFrm_Load(null, null); // Reload form if no data is found
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
                if (string.IsNullOrWhiteSpace(txtIDStaff.Text))
                {
                    MessageBox.Show("ID Staff harus diisi untuk melakukan update.");
                    return;
                }

                string query = "UPDATE tbl_staff SET " +
                               "username_staff = @usernameStaff, " +
                               "nama_staff = @namaStaff, " +
                               "alamat = @alamat, " +
                               "tanggal_bekerja = @tanggalBekerja, " +
                               "no_telepon = @noTelepon, " +
                               "email = @email, " +
                               "password = @password " +
                               "WHERE id_dokter = @idDokter";

                koneksi.Open();
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                // Assign parameters from textboxes
                perintah.Parameters.AddWithValue("@idDokter", txtIDStaff.Text);
                perintah.Parameters.AddWithValue("@usernameDokter", txtUsernameStaff.Text);
                perintah.Parameters.AddWithValue("@namaDokter", txtNamaStaff.Text);
                perintah.Parameters.AddWithValue("@alamat", txtAlamatStaff.Text);

                // Parse and add date parameter
                DateTime tanggalBekerja;
                if (DateTime.TryParse(dateTanggalBekerjaStaff.Text, out tanggalBekerja))
                {
                    perintah.Parameters.AddWithValue("@tanggalBekerja", tanggalBekerja.ToString("yyyy-MM-dd"));
                }
                else
                {
                    MessageBox.Show("Format tanggal tidak valid.");
                    koneksi.Close();
                    return;
                }

                perintah.Parameters.AddWithValue("@noTelepon", txtNomorTeleponStaff.Text);
                perintah.Parameters.AddWithValue("@email", txtEmailStaff.Text);
                perintah.Parameters.AddWithValue("@password", txtPasswordStaff.Text);

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

        private void ClearForm()
        {
            txtIDStaff.Clear();
            txtUsernameStaff.Clear();
            txtNamaStaff.Clear();
            txtAlamatStaff.Clear();
            dateTanggalBekerjaStaff.Value = DateTime.Now;
            txtNomorTeleponStaff.Clear();
            txtEmailStaff.Clear();
            txtPasswordStaff.Clear();
        }
    }
}
