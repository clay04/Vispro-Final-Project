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

namespace Klinik
{



    public partial class AdminnFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private MySqlCommand command;
        private MySqlDataReader mdr;

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
            PanelDaftarPasien.Visible=true;

            if (PanelDaftarPasien.Visible)
            {
                try
                {
                    koneksi.Open();
                    query = "SELECT id_pasien, nama_pasien, DATE_FORMAT(tanggal_lahir, '%Y-%m-%d') AS tanggal_lahir, Alamat, no_telepon, gender, DATE_FORMAT(tanggal_daftar, '%Y-%m-%d') AS tanggal_daftar, riwayat_penyakit FROM tbl_pasien";
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    ds.Clear();
                    adapter.Fill(ds);
                    koneksi.Close();

                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[0].Width = 100;
                    dataGridView1.Columns[0].HeaderText = "ID Pasien";
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[1].HeaderText = "Nama Pasien";
                    dataGridView1.Columns[2].Width = 120;
                    dataGridView1.Columns[2].HeaderText = "Tanggal Lahir";
                    dataGridView1.Columns[3].Width = 120;
                    dataGridView1.Columns[3].HeaderText = "Alamat";
                    dataGridView1.Columns[4].Width = 120;
                    dataGridView1.Columns[4].HeaderText = "Nomor Telepon";
                    dataGridView1.Columns[5].Width = 120;
                    dataGridView1.Columns[5].HeaderText = "Jenis Kelamin";
                    dataGridView1.Columns[6].Width = 120;
                    dataGridView1.Columns[6].HeaderText = "Tanggal Daftar";
                    dataGridView1.Columns[7].Width = 120;
                    dataGridView1.Columns[7].HeaderText = "Riwayat Penyakit";

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
            koneksi.Open();
            string cek = "SELECT * FROM tbl_pasien WHERE nama_pasien = '" + txtNamaPasien.Text + "' AND alamat = '" + dateTanggalLahirPasien.Text + "' AND alamat ='" + alamattxt.Text + "' AND no_telepon = '" + NoTelpTxt.Text + "' AND gender ='" + genertxt.Text + "' AND tanggal_daftar= '" + tgl_daftar.Text + "';";
            string check_if_exist = "SELECT * FROM tbl_users WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "';";
            command = new MySqlCommand(check_if_exist, koneksi);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show(
                     "User already exist!",
                     "",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                                                                  );
                koneksi.Close();

            }else{
                koneksi.Close();
                koneksi.Open();
                string Insert_query = "Insert into tbl_pasien (Nama_pasien, tanggal_lahir, alamat, no_telepon, gender, tanggal_daftar, riwayat_penyakit) values ('" + txtNamaPasien.Text + "','" + dateTanggalLahirPasien.Text + "','"+ alamattxt.Text + "','"+ NoTelpTxt.Text + "','"+ genertxt.Text + "','"+ tgl_daftar.Text + "')";
                command = new MySqlCommand(Insert_query, koneksi);
                mdr = command.ExecuteReader();
                MessageBox.Show("successfully Added New Record!");
                koneksi.Close();
            }
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

        private void AdminnFrm_Load(object sender, EventArgs e)
        {

                
            
            
        }
    }
}
