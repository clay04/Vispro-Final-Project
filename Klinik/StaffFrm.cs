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
                    txtRiwayatPenyakit.Text != "")
                {
                    // Format tanggal
                    string tglLahir = dateTglLhirPasien.Value.ToString("yyyy-MM-dd");
                    string tglDaftar = dateTglDaftar.Value.ToString("yyyy-MM-dd");

                    koneksi.Open();

                    // 1. Insert ke tabel `tbl_pasien`
                    string queryPasien = "INSERT INTO tbl_pasien (nama_pasien, tanggal_lahir, alamat, no_telepon, gender, riwayat_penyakit) " +
                                         "VALUES (@nama_pasien, @tanggal_lahir, @alamat, @no_telepon, @gender, @riwayat_penyakit);";
                    long idPasien; // Variabel untuk menyimpan id pasien yang baru

                    using (MySqlCommand perintahPasien = new MySqlCommand(queryPasien, koneksi))
                    {
                        //parameter untuk tbl_pasien
                        perintahPasien.Parameters.AddWithValue("@nama_pasien", txtNamaPasien.Text);
                        perintahPasien.Parameters.AddWithValue("@tanggal_lahir", tglLahir);
                        perintahPasien.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                        perintahPasien.Parameters.AddWithValue("@no_telepon", txtNomorTelepon.Text);
                        perintahPasien.Parameters.AddWithValue("@gender", CBJenisKelamin.Text);
                        perintahPasien.Parameters.AddWithValue("@riwayat_penyakit", txtRiwayatPenyakit.Text);

                        // Eksekusi query untuk `tbl_pasien` dan ambil `LastInsertedId`
                        int resPasien = perintahPasien.ExecuteNonQuery();
                        if (resPasien != 1)
                        {
                            MessageBox.Show("Gagal Insert Data Pasien.");
                            koneksi.Close();
                            return;
                        }

                        // Ambil id_pasien terakhir yang baru dimasukkan
                        idPasien = perintahPasien.LastInsertedId;
                    }

                    // 2. Insert ke tabel `tbl_pendaftaran` menggunakan `id_pasien` baru
                    string queryPendaftaran = "INSERT INTO tbl_pendaftaran (id_pasien, tanggal_daftar, status) " +
                                              "VALUES (@id_pasien, @tanggal_daftar, 'terdaftar');";
                    using (MySqlCommand perintahPendaftaran = new MySqlCommand(queryPendaftaran, koneksi))
                    {
                        // Tambahkan parameter untuk tbl_pendaftaran
                        perintahPendaftaran.Parameters.AddWithValue("@id_pasien", idPasien);
                        perintahPendaftaran.Parameters.AddWithValue("@tanggal_daftar", tglDaftar);

                        // Eksekusi query untuk `tbl_pendaftaran`
                        int resPendaftaran = perintahPendaftaran.ExecuteNonQuery();
                        if (resPendaftaran == 1)
                        {
                            MessageBox.Show("Pendaftaran Sukses.");
                            staffFrm_Load(null, null); // Refresh form jika diperlukan
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
