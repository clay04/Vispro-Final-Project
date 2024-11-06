using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                string queryRekamMedis = @"SELECT rm.id_rekam_medis, rm.id_pasien, p.nama_pasien, rm.tanggal_periksa, 
                                   rm.diagnosa, rm.pengobatan, rm.resep_obat, rm.catatan_tambahan 
                                   FROM tbl_rekam_medis rm 
                                   INNER JOIN tbl_pasien p ON rm.id_pasien = p.id_pasien";

                MySqlCommand perintahRekamMedis = new MySqlCommand(queryRekamMedis, koneksi);
                MySqlDataAdapter adapterRekamMedis = new MySqlDataAdapter(perintahRekamMedis);
                DataSet dsRekamMedis = new DataSet();
                adapterRekamMedis.Fill(dsRekamMedis);

                dataGridView3.DataSource = dsRekamMedis.Tables[0];
                FormatDataGridView(dataGridView3, new string[] { "ID Rekam Medis", "ID Pasien", "Nama Pasien", "Tanggal Periksa", "Diagnosa", "Pengobatan", "Resep Obat", "Catatan Tambahan" });
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

                lblJumlahPasien.Text = $"Jumlah Pasien : {jumlahPasien}";
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
                string query = string.Format("SELECT * FROM tbl_pasien WHERE nama_pasien = '{0}'", txtNamaPasien.Text);
                ds.Clear();
                koneksi.Open();

                MySqlCommand perintah = new MySqlCommand(query, koneksi);
                MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(ds);

                koneksi.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        txtIDPasien.Text = kolom["id_pasien"].ToString();
                        txtAlamatPasien.Text = kolom["alamat"].ToString();
                        dateTanggalLahirPasien.Text = kolom["tanggal_lahir"].ToString();
                    }
                    dataGridView1.DataSource = ds.Tables[0];
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
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNamaPasien.Text != "" && dateTanggalLahirPasien.Text != "" && txtAlamatPasien.Text != "" && txtIDPasien.Text != "")
                {
                    string query = "UPDATE tbl_pasien SET nama_pasien = @nama, tanggal_lahir = @tanggalLahir, alamat = @alamat WHERE id_pasien = @id";

                    koneksi.Open();
                    MySqlCommand perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama", txtNamaPasien.Text);

                    // Format tanggal lahir ke format yang sesuai untuk MySQL
                    perintah.Parameters.AddWithValue("@tanggalLahir", dateTanggalLahirPasien.Value.ToString("yyyy-MM-dd"));

                    perintah.Parameters.AddWithValue("@alamat", txtAlamatPasien.Text);
                    perintah.Parameters.AddWithValue("@id", txtIDPasien.Text);

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
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
