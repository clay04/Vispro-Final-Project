using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System.IO;

namespace Klinik
{


    public partial class AdminnFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private DataSet dsO = new DataSet();
        private DataSet dsR = new DataSet();
        private string alamat, query;

        public AdminnFrm()
        {
            InitializeComponent();

            alamat = "server=localhost; database=db_klinik; username=root; password=; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            koneksi = new MySqlConnection(alamat);


            PanelDaftarPasien.Visible = false;
            PanelObat.Visible = false;
            PanelRekam.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelDaftarPasien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDaftarPasien_Click(object sender, EventArgs e)
        {
            PanelRekam.Visible = false;
            PanelObat.Visible = false;
            PanelDaftarPasien.Visible = true;

            if (PanelDaftarPasien.Visible)
            {
                try
                {
                    koneksi.Open();
                    query = "SELECT * FROM tbl_rekam_medis";
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    ds.Clear();
                    adapter.Fill(ds);
                    koneksi.Close();

                    dataGridView4.DataSource = ds.Tables[0];

                    dataGridView4.Columns[4].Width = 150;
                    dataGridView4.Columns[5].Width = 100;
                    dataGridView4.Columns[6].Width = 152;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 25;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel1.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel1.Width - radius, panel1.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel1.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            panel1.Region = new Region(path);

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
            PanelRekam.Visible = true;
            PanelObat.Visible = false;

            if (PanelRekam.Visible)
            {
                try
                {
                    koneksi.Open();
                    query = "SELECT * FROM tbl_rekam_medis";
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    dsR.Clear();
                    adapter.Fill(dsR);
                    koneksi.Close();

                    dataGridView3.DataSource = dsR.Tables[0];

                    dataGridView3.Columns[0].Width = 100;
                    dataGridView3.Columns[1].Width = 150;
                    dataGridView3.Columns[2].Width = 120;
                    dataGridView3.Columns[3].Width = 120;
                    dataGridView3.Columns[4].Width = 120;
                    dataGridView3.Columns[5].Width = 120;
                    dataGridView3.Columns[6].Width = 120;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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
            PanelRekam.Visible = false;
            PanelObat.Visible = true;

            if (PanelObat.Visible)
            {
                try
                {

                    koneksi.Open();
                    query = "SELECT * FROM tbl_obat";
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    dsO.Clear();
                    adapter.Fill(dsO);
                    koneksi.Close();

                    dataGridView2.DataSource = dsO.Tables[0];

                    dataGridView2.Columns[0].Width = 100;
                    dataGridView2.Columns[1].Width = 150;
                    dataGridView2.Columns[2].Width = 150;
                    dataGridView2.Columns[3].Width = 150;
                    dataGridView2.Columns[4].Width = 250;

                    dataGridView2.Columns[0].Width = 100;
                    dataGridView2.Columns[1].Width = 150;
                    dataGridView2.Columns[2].Width = 150;
                    dataGridView2.Columns[3].Width = 150;
                    dataGridView2.Columns[4].Width = 250;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                // Reset auto increment jika diperlukan
                string resetQuery = "ALTER TABLE tbl_rekam_medis AUTO_INCREMENT = 1";
                MySqlCommand resetCmd = new MySqlCommand(resetQuery, koneksi);
                resetCmd.ExecuteNonQuery();

                // Query insert seperti biasa
                string query = @"INSERT INTO tbl_rekam_medis 
                (tanggal_periksa, diagnosa, pengobatan, resep_obat, catatan_tambahan) 
                VALUES 
                (@tanggal, @diagnosa, @pengobatan, @resep, @catatan)";

                MySqlCommand cmd = new MySqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@tanggal", tglperiksa.Value.Date);
                cmd.Parameters.AddWithValue("@diagnosa", Diagnosa.Text);
                cmd.Parameters.AddWithValue("@pengobatan", PengObatan.Text);
                cmd.Parameters.AddWithValue("@resep", Resobat.Text);
                cmd.Parameters.AddWithValue("@catatan", CatatanT.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan!");
            }
            finally
            {
                koneksi.Close();
            }
            PanelRekam.Visible = false;
            PanelRekam.Visible = true;
        }

        private void LoadData()
        {
            try
            {
                koneksi.Open();
                string query = "SELECT * FROM rekam_medis";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, koneksi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
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

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void namaT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {

            IDmedis.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();

            if (dataGridView4.CurrentRow.Cells[2].Value != null && dataGridView4.CurrentRow.Cells[2].Value != DBNull.Value)
            {
                if (dataGridView4.CurrentRow.Cells[2].Value is DateTime)
                {
                    // Jika nilai sudah dalam bentuk DateTime
                    tglperiksa.Value = (DateTime)dataGridView4.CurrentRow.Cells[2].Value;
                }
                else
                {
                    // Jika nilai dalam bentuk string, coba parse dengan format spesifik
                    string dateStr = dataGridView4.CurrentRow.Cells[2].Value.ToString();
                    DateTime tanggal;

                    if (DateTime.TryParseExact(dateStr,
                        new[] { "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy", "dd-MM-yyyy" },
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out tanggal))
                    {
                        tglperiksa.Value = tanggal;
                    }
                    else
                    {
                        MessageBox.Show("Tidak dapat mengkonversi tanggal: " + dateStr);
                    }
                }
            }

            Diagnosa.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            PengObatan.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            Resobat.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
            CatatanT.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();
        }

        private void ClearForm()
        {
            IDmedis.Clear();
            tglperiksa.Value = DateTime.Now;
            Diagnosa.Clear();
            PengObatan.Clear();
            Resobat.Clear();
            CatatanT.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                string query = @"UPDATE tbl_rekam_medis SET 
                        tanggal_periksa = @tanggal,
                        diagnosa = @diagnosa,
                        pengobatan = @pengobatan,
                        resep_obat = @resep,
                        catatan_tambahan = @catatan
                        WHERE id_Rekam_medis = @id";

                MySqlCommand cmd = new MySqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@id", IDmedis.Text);
                cmd.Parameters.AddWithValue("@tanggal", tglperiksa.Value.Date);
                cmd.Parameters.AddWithValue("@diagnosa", Diagnosa.Text);
                cmd.Parameters.AddWithValue("@pengobatan", PengObatan.Text);
                cmd.Parameters.AddWithValue("@resep", Resobat.Text);
                cmd.Parameters.AddWithValue("@catatan", CatatanT.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate!");
                LoadData(); // Refresh GridView
                ClearForm(); // Membersihkan form
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDmedis.Text))
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
                    cmd.Parameters.AddWithValue("@id", IDmedis.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus!");
                    LoadData(); // Refresh GridView
                    ClearForm(); // Membersihkan form
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
        }

        private void AdminnFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
