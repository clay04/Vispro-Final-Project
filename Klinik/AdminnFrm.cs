using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Klinik
{
    public partial class AdminnFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private DataSet dsR = new DataSet();
        private DataSet dsPasien = new DataSet();
        private string alamat, query;

        private Form1 form1;

        public AdminnFrm(Form1 form1)
        {
            InitializeComponent();

            alamat = "server=localhost; database=db_klinik; username=root; password=; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            koneksi = new MySqlConnection(alamat);



            PanelDaftarPasien.Visible = false;
            panelDaftarObat.Visible = false;
            panelDataRekamMedis.Visible = false;
            panelTenagaKerja.Visible = false;
            //panelTengaKerja.Visible = false;

            TampilkanJumlahTenagaKerja();
            TampilkanJumlahPasien();
            TampilkanJumlahObat();
            this.form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelDaftarPasien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDaftarPasien_Click(object sender, EventArgs e)
        {
            PanelDaftarPasien.Visible = true;
            panelDaftarObat.Visible = false;
            panelDataRekamMedis.Visible = false;
            panelTenagaKerja.Visible = false;
            //panelTengaKerja.Visible=false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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


        private void btnTenagaKerja_Click(object sender, EventArgs e)
        {
            PanelDaftarPasien.Visible = false;
            //panelTengaKerja.Visible = true;
        }

        private void panelTengaKerja_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDataRekamMedis_Click(object sender, EventArgs e)
        {
            PanelDaftarPasien.Visible = false;
            panelDaftarObat.Visible = false;
            panelDataRekamMedis.Visible = true;
            panelTenagaKerja.Visible = false;
        }

        private void txtNamaPasien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamatPasien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dateTanggalLahirPasien_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIDPasien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDaftarObat_Click(object sender, EventArgs e)
        {
            PanelDaftarPasien.Visible = false;
            panelDaftarObat.Visible = true;
            panelDataRekamMedis.Visible = false;
            panelTenagaKerja.Visible = false;
        }

        private void label4_Click_1(object sender, EventArgs e)

        {

        }


        //Obat

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveObat_Click(object sender, EventArgs e)
        {
            try
            {
                // Cek apakah form rekam medis sudah diisi
                if (txtIDObat.Text != "" && txtNamaObat.Text != "" && txtKategoriObat.Text != "" && dateTanggalKadaluarsaObat.Text != "" && txtHargaObat.Text != "" && txtJumlahObat.Text != "" && txtJenisObat.Text != "")
                {
                    // Query untuk insert data ke rekam medis
                    string insertQuery = string.Format(
                        "INSERT INTO tbl_obat (id_obat, nama_obat, kategori, tanggal_kadaluarsa, harga_obat, jumlah, jenis_obat) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                        txtIDObat.Text,
                        txtNamaObat.Text,
                        txtKategoriObat.Text,
                        dateTanggalKadaluarsaObat.Value.ToString("yyyy-MM-dd"),
                        txtHargaObat.Text,
                        txtJumlahObat.Text,
                        txtJenisObat.Text);

                    koneksi.Open();
                    perintah = new MySqlCommand(insertQuery, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Data rekam medis berhasil disimpan!");
                        ClearForm(); // Method untuk mengosongkan input form
                        LoadData();
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
            }

            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }

        private void LoadData()
        {
            try
            {
                string selectQuery = "SELECT * FROM tbl_obat";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, koneksi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message);
            }
        }

        private void LoadDataPasien()
        {
            try
            {
                // Pastikan koneksi terbuka
                koneksi.Open();

                // Query untuk mendapatkan data pasien
                string selectQuery = @"SELECT p.id_pasien, p.nama_pasien, DATE_FORMAT(p.tanggal_lahir, '%Y-%m-%d') AS tanggal_lahir, 
                               p.alamat, p.no_telepon, p.gender, p.riwayat_penyakit, 
                               DATE_FORMAT(d.tanggal_daftar, '%Y-%m-%d') AS tanggal_daftar, d.status
                               FROM tbl_pasien p
                               LEFT JOIN tbl_pendaftaran d ON p.id_pasien = d.id_pasien";

                // Gunakan MySqlDataAdapter untuk mengisi DataTable
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, koneksi))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Tampilkan data pada DataGridView
                    dataGridView1.DataSource = dt;

                    // Atur tampilan DataGridView (opsional)
                    //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //dataGridView1.RowHeadersVisible = false;
                    FormatDataGridView(dataGridView1, new string[] { "ID Pasien", "Nama Pasien", "Tanggal Lahir", "Alamat", "Nomor Telepon", "Jenis Kelamin", "Riwayat Penyakit", "Tanggal Daftar", "Status" });
                }
            }
            catch (Exception ex)
            {
                // Tampilkan pesan kesalahan jika terjadi
                MessageBox.Show("Terjadi kesalahan saat memuat data pasien: " + ex.Message);
            }
            finally
            {
                // Pastikan koneksi selalu ditutup
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }


        private void ClearForm()
        {
            txtIDObat.Clear();
            txtNamaObat.Clear();
            txtKategoriObat.Clear();
            dateTanggalKadaluarsaObat.Value = DateTime.Now;
            txtHargaObat.Clear();
            txtJumlahObat.Clear();
            txtJenisObat.Clear();
        }

        private void btnSeacrhObat_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM tbl_obat WHERE nama_obat = @namaObat";
                ds.Clear();

                koneksi.Open();
                MySqlCommand perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@namaObat", txtNamaObat.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        txtIDObat.Text = kolom["id_obat"].ToString();
                        txtNamaObat.Text = kolom["nama_obat"].ToString();
                        txtKategoriObat.Text = kolom["kategori"].ToString();
                        DateTime tanggalKadaluarsa;
                        if (DateTime.TryParse(kolom["tanggal_kadaluarsa"].ToString(), out tanggalKadaluarsa))
                        {
                            dateTanggalKadaluarsaObat.Value = tanggalKadaluarsa;
                        }
                        else
                        {
                            MessageBox.Show("Format tanggal tidak valid di database.");
                        }
                        txtHargaObat.Text = kolom["harga_obat"].ToString();
                        txtJumlahObat.Text = kolom["jumlah"].ToString();
                        txtJenisObat.Text = kolom["jenis_obat"].ToString();
                    }
                    dataGridView2.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Tidak ada data obat dengan nama tersebut.");
                    AdminnFrm_Load(null, null); // Reload form jika data tidak ditemukan
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



        private void btnUpdateObat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNamaObat.Text != "" && txtKategoriObat.Text != "" && dateTanggalKadaluarsaObat.Text != "" && txtHargaObat.Text != "" && txtJumlahObat.Text != "" && txtJenisObat.Text != "")
                {
                    string query = "UPDATE tbl_obat SET nama_obat = @nama_obat, kategori = @kategori, tanggal_kadaluarsa = @tanggal_kadaluarsa, harga_obat = @harga_obat, jumlah = @jumlah, jenis_obat = @jenis_obat WHERE id_Obat = @id";

                    koneksi.Open();
                    MySqlCommand perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_obat", txtNamaObat.Text);
                    perintah.Parameters.AddWithValue("@kategori", txtKategoriObat.Text);
                    perintah.Parameters.AddWithValue("@tanggal_kadaluarsa", dateTanggalKadaluarsaObat.Value.ToString("yyyy-MM-dd"));
                    perintah.Parameters.AddWithValue("@harga_obat", txtHargaObat.Text);
                    perintah.Parameters.AddWithValue("@jumlah", txtJumlahObat.Text);
                    perintah.Parameters.AddWithValue("@jenis_obat", txtJenisObat.Text);
                    perintah.Parameters.AddWithValue("@id", txtIDObat.Text);

                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Sukses ...");
                        AdminnFrm_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data ...");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }

        private void btnDeleteObat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDObat.Text != "")
                {
                    if (MessageBox.Show("Anda Yakin Menghapus Data Ini ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("Delete from tbl_obat where id_obat = '{0}'", txtIDObat.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Suksess ...");
                        }
                        else
                        {
                            MessageBox.Show("Gagal Delete data");
                        }
                    }
                    AdminnFrm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }


        //Rekam Medis

        private void panelDataRekamMedis_Paint(object sender, PaintEventArgs e)
        {

        }


        //Tenaga Kerja

        private void AdminnFrm_Load(object sender, EventArgs e)
        {
            // Attach Paint event handlers
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            panel2.Paint += new PaintEventHandler(panel2_Paint);

            try
            {
                koneksi.Open();

                // Load Pasien Data
                string queryPasien = @"SELECT p.id_pasien, p.nama_pasien, DATE_FORMAT(p.tanggal_lahir, '%Y-%m-%d') AS tanggal_lahir, 
                               p.alamat, p.no_telepon, p.gender, p.riwayat_penyakit, 
                               DATE_FORMAT(d.tanggal_daftar, '%Y-%m-%d') AS tanggal_daftar, d.status
                               FROM tbl_pasien p
                               LEFT JOIN tbl_pendaftaran d ON p.id_pasien = d.id_pasien";

                MySqlCommand perintahPasien = new MySqlCommand(queryPasien, koneksi);
                MySqlDataAdapter adapterPasien = new MySqlDataAdapter(perintahPasien);
                DataSet dsPasien = new DataSet();
                adapterPasien.Fill(dsPasien);

                dataGridView1.DataSource = dsPasien.Tables[0];
                FormatDataGridView(dataGridView1, new string[] { "ID Pasien", "Nama Pasien", "Tanggal Lahir", "Alamat", "Nomor Telepon", "Jenis Kelamin", "Riwayat Penyakit", "Tanggal Daftar", "Status" });

                // Load Obat Data
                string queryObat = @"SELECT id_obat, nama_obat, kategori, DATE_FORMAT(tanggal_kadaluarsa, '%Y-%m-%d') AS tanggal_kadaluarsa, harga_obat, jumlah, jenis_obat 
                             FROM tbl_obat";

                MySqlCommand perintahObat = new MySqlCommand(queryObat, koneksi);
                MySqlDataAdapter adapterObat = new MySqlDataAdapter(perintahObat);
                DataSet dsObat = new DataSet();
                adapterObat.Fill(dsObat);

                dataGridView2.DataSource = dsObat.Tables[0];
                FormatDataGridView(dataGridView2, new string[] { "ID Obat", "Nama Obat", "Kategori", "Tanggal Kadaluarsa", "Harga Obat", "Jumlah", "Jenis Obat" });

                // Load Rekam Medis Data
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
                dataGridView3.DataSource = ds.Tables[0];

                // Set kolom DataGridView
                dataGridView3.Columns[0].HeaderText = "ID Rekam Medis";
                dataGridView3.Columns[1].HeaderText = "ID Pasien";
                dataGridView3.Columns[2].HeaderText = "Nama Pasien";
                dataGridView3.Columns[3].HeaderText = "Tanggal Periksa";
                dataGridView3.Columns[4].HeaderText = "Diagnosa";
                dataGridView3.Columns[5].HeaderText = "Catatan Tambahan";
                dataGridView3.Columns[6].HeaderText = "ID Resep";
                dataGridView3.Columns[7].HeaderText = "ID Obat";
                dataGridView3.Columns[8].HeaderText = "Nama Obat";
                dataGridView3.Columns[9].HeaderText = "Dosis";
                dataGridView3.Columns[10].HeaderText = "Cara Pakai";
                dataGridView3.Columns[11].HeaderText = "Jumlah";
                dataGridView3.Columns[12].HeaderText = "Keterangan";

                // Atur lebar kolom sesuai kebutuhan
                dataGridView3.Columns[0].Width = 120; // ID Rekam Medis
                dataGridView3.Columns[1].Width = 100; // ID Pasien
                dataGridView3.Columns[2].Width = 150; // Nama Pasien
                dataGridView3.Columns[3].Width = 120; // Tanggal Periksa
                dataGridView3.Columns[4].Width = 200; // Diagnosa
                dataGridView3.Columns[5].Width = 200; // Catatan Tambahan
                dataGridView3.Columns[6].Width = 100; // ID Resep
                dataGridView3.Columns[7].Width = 100; // ID Obat
                dataGridView3.Columns[8].Width = 150; // Nama Obat
                dataGridView3.Columns[9].Width = 150; // Dosis
                dataGridView3.Columns[10].Width = 150; // Cara Pakai
                dataGridView3.Columns[11].Width = 100; // Jumlah
                dataGridView3.Columns[12].Width = 200; // Keterangan

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

        // Method to format DataGridView columns
        private void FormatDataGridView(DataGridView dgv, string[] columnHeaders)
        {
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            for (int i = 0; i < columnHeaders.Length; i++)
            {
                dgv.Columns[i].HeaderText = columnHeaders[i];
                dgv.Columns[i].Width = 120;
            }

            dgv.Columns[0].Width = 100; // Adjust specific column widths if needed
            dgv.Columns[dgv.Columns.Count - 1].Width = 250; // Adjust last column width for long text
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PanelDaftarPasien.Visible = false;
            panelDaftarObat.Visible = false;
            panelDataRekamMedis.Visible = false;
            panelTenagaKerja.Visible = true;
        }

        private void lblJumlahTenagaKerja_Click(object sender, EventArgs e)
        {
            TampilkanJumlahTenagaKerja();
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            DaftarDokteFrm daftarDokteFrm = new DaftarDokteFrm(); // atau pass form lain jika diperlukan
            daftarDokteFrm.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void lblJumlahPasien_Click(object sender, EventArgs e)
        {
            TampilkanJumlahPasien();
        }

        private void TampilkanJumlahPasien()
        {
            try
            {
                koneksi.Open();

                string queryPasien = "SELECT COUNT(*) FROM tbl_pasien";

                MySqlCommand perintahPasien = new MySqlCommand(queryPasien, koneksi);
                int jumlahPasien = Convert.ToInt32(perintahPasien.ExecuteScalar());

                lblJumlahPasien.Text = $"{jumlahPasien}";
                lblTotalPasienDash.Text = $"{jumlahPasien}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }

        private void TampilkanJumlahObat()
        {
            try
            {
                koneksi.Open();

                string queryPasien = "SELECT COUNT(*) FROM tbl_obat";

                MySqlCommand perintahPasien = new MySqlCommand(queryPasien, koneksi);
                int jumlahObat = Convert.ToInt32(perintahPasien.ExecuteScalar());

                lblTotalObat.Text = $"{jumlahObat}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            DaftarStaffFrm daftarStaffFrm = new DaftarStaffFrm(); // atau pass form lain jika diperlukan
            daftarStaffFrm.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "SELECT tbl_pasien.id_pasien, tbl_pasien.nama_pasien, tbl_pasien.alamat, tbl_pasien.tanggal_lahir, tbl_pasien.no_telepon, tbl_pasien.gender, tbl_pasien.riwayat_penyakit, " +
                    "tbl_pendaftaran.tanggal_daftar, tbl_pendaftaran.status " +
                    "FROM tbl_pasien " +
                    "LEFT JOIN tbl_pendaftaran ON tbl_pasien.id_pasien = tbl_pendaftaran.id_pasien " +
                    "WHERE tbl_pasien.nama_pasien = '{0}'", txtNamaPasien.Text);

                ds.Clear();
                koneksi.Open();

                MySqlCommand perintah = new MySqlCommand(query, koneksi);
                MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(dsPasien);

                koneksi.Close();

                if (dsPasien.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in dsPasien.Tables[0].Rows)
                    {
                        txtIDPasien.Text = kolom["id_pasien"].ToString();
                        txtAlamatPasien.Text = kolom["alamat"].ToString();
                        dateTanggalLahirPasien.Text = kolom["tanggal_lahir"].ToString();
                        txtNomorTelepon.Text = kolom["no_telepon"].ToString();
                        CBJenisKelamin.Text = kolom["gender"].ToString();
                        txtRiwayatPenyakit.Text = kolom["riwayat_penyakit"].ToString();

                        // Menampilkan tanggal pendaftaran dan status dari tbl_pendaftaran
                        dateTimePicker1.Text = kolom["tanggal_daftar"].ToString();
                        cbStatus.Text = kolom["status"].ToString();
                    }
                    dataGridView1.DataSource = dsPasien.Tables[0];
                }
                else
                {
                    MessageBox.Show("Tidak ada Data");
                    AdminnFrm_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(txtNamaPasien.Text) ||
                    string.IsNullOrWhiteSpace(dateTanggalLahirPasien.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamatPasien.Text) ||
                    string.IsNullOrWhiteSpace(txtIDPasien.Text) ||
                    string.IsNullOrWhiteSpace(cbStatus.Text) ||
                    string.IsNullOrWhiteSpace(CBJenisKelamin.Text) ||
                    string.IsNullOrWhiteSpace(txtNomorTelepon.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePicker1.Text))
                {
                    MessageBox.Show("Data Tidak Lengkap!!");
                    return;
                }

                koneksi.Open();

                // Update tbl_pasien
                string queryPasien = @"UPDATE tbl_pasien 
                               SET nama_pasien = @nama, 
                                   tanggal_lahir = @tanggalLahir, 
                                   alamat = @alamat, 
                                   no_telepon = @telepon, 
                                   gender = @jenisKelamin, 
                                   riwayat_penyakit = @riwayatPenyakit 
                               WHERE id_pasien = @id";
                using (MySqlCommand perintah = new MySqlCommand(queryPasien, koneksi))
                {
                    perintah.Parameters.AddWithValue("@nama", txtNamaPasien.Text);
                    perintah.Parameters.AddWithValue("@tanggalLahir", dateTanggalLahirPasien.Value.ToString("yyyy-MM-dd"));
                    perintah.Parameters.AddWithValue("@alamat", txtAlamatPasien.Text);
                    perintah.Parameters.AddWithValue("@id", txtIDPasien.Text);
                    perintah.Parameters.AddWithValue("@telepon", txtNomorTelepon.Text);
                    perintah.Parameters.AddWithValue("@jenisKelamin", CBJenisKelamin.Text);
                    perintah.Parameters.AddWithValue("@riwayatPenyakit", txtRiwayatPenyakit.Text);

                    int resPasien = perintah.ExecuteNonQuery();

                    if (resPasien == 1)
                    {
                        // Update tbl_pendaftaran
                        string queryPendaftaran = @"UPDATE tbl_pendaftaran 
                                            SET tanggal_daftar = @TanggalDaftar, 
                                                status = @status 
                                            WHERE id_pasien = @idPasien";
                        using (MySqlCommand perintahPendaftaran = new MySqlCommand(queryPendaftaran, koneksi))
                        {
                            perintahPendaftaran.Parameters.AddWithValue("@TanggalDaftar", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                            perintahPendaftaran.Parameters.AddWithValue("@status", cbStatus.Text);
                            perintahPendaftaran.Parameters.AddWithValue("@idPasien", txtIDPasien.Text);

                            int resPendaftaran = perintahPendaftaran.ExecuteNonQuery();

                            if (resPendaftaran == 1)
                            {
                                MessageBox.Show("Update Data dan Status Pendaftaran Sukses ...");
                                AdminnFrm_Load(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Gagal Update Status Pendaftaran ...");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data ...");
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
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtIDPasien.Text != "")
                {
                    if (MessageBox.Show("Anda Yakin Menghapus Data Ini ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("Delete from tbl_pasien where id_pasien = '{0}'", txtIDPasien.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Suksess ...");
                        }
                        else
                        {
                            MessageBox.Show("Gagal Delete data");
                        }
                    }
                    AdminnFrm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrintDaftarPasien_Click(object sender, EventArgs e)
        {
            ResportDaftarPasien resportDaftarPasien = new ResportDaftarPasien();
            resportDaftarPasien.Show();
        }

        private void btnPrintDataPasien_Click(object sender, EventArgs e)
        {
            ReportDataPasien reportDataPasien = new ReportDataPasien();
            reportDataPasien.Show();
        }

        private void btnPrintDaftarRekamMedis_Click(object sender, EventArgs e)
        {
            FrmDaftarRekamMedis frmDaftarRekamMedis = new FrmDaftarRekamMedis();
            frmDaftarRekamMedis.Show();
        }

        private void btnPrintDaftarObat_Click(object sender, EventArgs e)
        {
            FrmDaftarObat frmDaftarObat = new FrmDaftarObat();
            frmDaftarObat.Show();
        }

        private void saveRekam_Click(object sender, EventArgs e)
        {
            try
            {

                if (idpRekam.Text != "" && diagnosaRekam.Text != "" && tglRekam.Text != "" && textBox5.Text != "")
                {

                    koneksi.Open();
                    string insertQuery = string.Format(
                        "INSERT INTO tbl_rekam_medis (id_pasien, tanggal_periksa, diagnosa, catatan_tambahan) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}');",
                        idpRekam.Text,
                        tglRekam.Value.ToString("yyyy-MM-dd"),
                        diagnosaRekam.Text,
                        textBox5.Text);

                    perintah = new MySqlCommand(insertQuery, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Data rekam medis berhasil disimpan!");
                        ClearForm(); // Method untuk mengosongkan input form
                        LoadData_2();
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
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }

        private void TampilkanJumlahTenagaKerja()
        {
            try
            {
                // Buka koneksi ke database
                koneksi.Open();

                // Query untuk menghitung jumlah dokter dan staff
                string queryDokter = "SELECT COUNT(*) FROM tbl_dokter";
                string queryStaff = "SELECT COUNT(*) FROM tbl_staff";

                // Hitung jumlah dokter
                MySqlCommand perintahDokter = new MySqlCommand(queryDokter, koneksi);
                int jumlahDokter = Convert.ToInt32(perintahDokter.ExecuteScalar());

                // Hitung jumlah staff
                MySqlCommand perintahStaff = new MySqlCommand(queryStaff, koneksi);
                int jumlahStaff = Convert.ToInt32(perintahStaff.ExecuteScalar());

                // Hitung total tenaga kerja
                int jumlahTenagaKerja = jumlahDokter + jumlahStaff;

                // Tampilkan hasil di label
                lblJumlahTenagaKerja.Text = $"{jumlahTenagaKerja}";
                lblTotalTenagaKerjaDash.Text = $"{jumlahTenagaKerja}";

                // Tutup koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                    koneksi.Close();
            }
        }

        private void searchRekam_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM tbl_rekam_medis 
                         WHERE id_rekam_medis = @id_rekam_medis"
                ;

                LoadData_2();
                dsR.Clear();

                koneksi.Open();
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                // Menambahkan semua parameter yang mungkin digunakan
                perintah.Parameters.AddWithValue("@id_rekam_medis", idRekam.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(dsR);

                if (dsR.Tables[0].Rows.Count > 0)
                {
                    // Menampilkan data pada grid dan mengisi TextBox
                    dataGridView3.DataSource = dsR.Tables[0];

                    // Mengisi data TextBox dari baris pertama
                    DataRow kolom = dsR.Tables[0].Rows[0];
                    idRekam.Text = kolom["id_rekam_medis"].ToString();


                }
                else
                {
                    MessageBox.Show("Tidak ditemukan.");
                    LoadData_2();
                }
            }

            finally
            {
                if (koneksi.State == ConnectionState.Open)
                koneksi.Close();
            }
        }

        private void updateRekam_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                string query = @"UPDATE tbl_rekam_medis SET 
                        id_pasien = @id_pasien,
                        tanggal_periksa = @tanggal,
                        diagnosa = @diagnosa,
                        catatan_tambahan = @catatan
                        WHERE id_rekam_medis = @id";

                MySqlCommand cmd = new MySqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@id", idRekam.Text);
                cmd.Parameters.AddWithValue("@id_pasien", idpRekam.Text);
                cmd.Parameters.AddWithValue("@tanggal", tglRekam.Value.Date);
                cmd.Parameters.AddWithValue("@diagnosa", diagnosaRekam.Text);
                cmd.Parameters.AddWithValue("@catatan", textBox5.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil diupdate!");
            }
            finally
            {
                koneksi.Close();
                LoadData_2();
            }
        }

        private void deleteRekam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idRekam.Text))
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!");
                return;
            }

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    koneksi.Open();
                    string query = "DELETE FROM tbl_rekam_medis WHERE id_Rekam_medis = @id";
                    MySqlCommand cmd = new MySqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@id", idRekam.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus!");
                    ClearForm(); // Membersihkan form
                }
                finally
                {
                    koneksi.Close();
                    LoadData_2();
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadData_2();
        }

        private void DataRekamMedis(object sender, EventArgs e)
        {
            idRekam.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();

            if (dataGridView3.CurrentRow.Cells[2].Value != null && dataGridView3.CurrentRow.Cells[2].Value != DBNull.Value)
            {
                if (dataGridView3.CurrentRow.Cells[2].Value is DateTime)
                {
                    tglRekam.Value = (DateTime)dataGridView3.CurrentRow.Cells[2].Value;
                }
                else
                {
                    string dateStr = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                    DateTime tanggal;

                    if (DateTime.TryParseExact(dateStr,
                        new[] { "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy", "dd-MM-yyyy" },
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out tanggal))
                    {
                        tglRekam.Value = tanggal;
                    }
                    else
                    {
                        MessageBox.Show("Tidak dapat mengkonversi tanggal: " + dateStr);
                    }
                }
            }

            idpRekam.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            diagnosaRekam.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridViewObat(object sender, EventArgs e)
        {
            txtIDObat.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            if (dataGridView2.CurrentRow.Cells[3].Value != null && dataGridView2.CurrentRow.Cells[2].Value != DBNull.Value)
            {
                if (dataGridView2.CurrentRow.Cells[3].Value is DateTime)
                {
                    dateTanggalKadaluarsaObat.Value = (DateTime)dataGridView2.CurrentRow.Cells[3].Value;
                }
                else
                {
                    string dateStr = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                    DateTime tanggal;

                    if (DateTime.TryParseExact(dateStr,
                        new[] { "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy", "dd-MM-yyyy" },
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out tanggal))
                    {
                        dateTanggalKadaluarsaObat.Value = tanggal;
                    }
                    else
                    {
                        MessageBox.Show("Tidak dapat mengkonversi tanggal: " + dateStr);
                    }
                }
            }


            txtNamaObat.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtKategoriObat.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtHargaObat.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtJumlahObat.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtJenisObat.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }

        private void DataGridViewPasien(object sender, EventArgs e)
        {
            txtIDPasien.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[2].Value != null && dataGridView1.CurrentRow.Cells[2].Value != DBNull.Value)
            {
                if (dataGridView1.CurrentRow.Cells[2].Value is DateTime)
                {
                    dateTanggalLahirPasien.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
                }
                else
                {
                    string dateStr = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    DateTime tanggal;

                    if (DateTime.TryParseExact(dateStr,
                        new[] { "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy", "dd-MM-yyyy" },
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out tanggal))
                    {
                        dateTanggalLahirPasien.Value = tanggal;
                    }
                    else
                    {
                        MessageBox.Show("Tidak dapat mengkonversi tanggal: " + dateStr);
                    }
                }
            }

            if (dataGridView1.CurrentRow.Cells[7].Value != null && dataGridView1.CurrentRow.Cells[6].Value != DBNull.Value)
            {
                if (dataGridView1.CurrentRow.Cells[7].Value is DateTime)
                {
                    dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[6].Value;
                }
                else
                {
                    string dateStr = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    DateTime tanggall;

                    if (DateTime.TryParseExact(dateStr,
                        new[] { "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy", "dd-MM-yyyy" },
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out tanggall))
                    {
                        dateTimePicker1.Value = tanggall;
                    }
                    else
                    {
                        MessageBox.Show("Tidak dapat mengkonversi tanggal: " + dateStr);
                    }
                }
            }

            txtNamaPasien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAlamatPasien.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CBJenisKelamin.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtNomorTelepon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRiwayatPenyakit.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbStatus.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void txtRiwayatPenyakit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {

        }

        private void btnDash_Click_1(object sender, EventArgs e)
        {
            PanelDaftarPasien.Visible = false;
            panelDaftarObat.Visible = false;
            panelDataRekamMedis.Visible = false;
            panelTenagaKerja.Visible = false;
        }

        private void lblTotalPasienDash_Click(object sender, EventArgs e)
        {
            TampilkanJumlahPasien();
        }

        private void lblTotalObat_Click(object sender, EventArgs e)
        {
            TampilkanJumlahObat();
        }

        private void lblTotalTenagaKerjaDash_Click(object sender, EventArgs e)
        {
            TampilkanJumlahTenagaKerja();
        }

        private void LoadData_2()
        {
            if (panelDataRekamMedis.Visible)
            {
                try
                {
                    koneksi.Open();
                    string query = "SELECT * FROM tbl_rekam_medis";
                    using (MySqlCommand command = new MySqlCommand(query, koneksi))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Configure the DataGridView
                        dataGridView3.DataSource = dataTable;
                        dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dataGridView3.RowHeadersVisible = false;
                        dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                        dataGridView3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dataGridView3.EnableHeadersVisualStyles = false;
                        dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
                        dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridView3.GridColor = Color.FromArgb(192, 192, 192);
                        dataGridView3.BorderStyle = BorderStyle.None;
                        dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

                        // Adjust column widths
                        dataGridView3.Columns[0].Width = 80; // id_rekam_medis
                        dataGridView3.Columns[1].Width = 100; // id_pasien
                        dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // tanggal_periksa
                        dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // diagnosa
                        dataGridView3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // catatan_tambahan
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
        }

    }
}


