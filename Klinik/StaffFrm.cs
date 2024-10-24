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
                if (txtNamaPasien.Text != "" && dateTglLhirPasien.Text != "" && txtAlamat.Text != "" && txtNomorTelepon.Text != "" && CBJenisKelamin.Text != "" && dateTglDaftar.Text != "" && txtRiwayatPenyakit.Text != "")
                {
                    string tglLahir = dateTglLhirPasien.Value.ToString("yyyy-MM-dd");
                    string tglDaftar = dateTglDaftar.Value.ToString("yyyy-MM-dd");

                    query = string.Format("insert into tbl_pasien values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", txtIDPasien.Text, txtNamaPasien.Text, tglLahir, txtAlamat.Text, txtNomorTelepon.Text, CBJenisKelamin.Text, tglDaftar, txtRiwayatPenyakit.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        staffFrm_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
