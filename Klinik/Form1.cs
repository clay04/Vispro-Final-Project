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
using MySql.Data.MySqlClient;


namespace Klinik
{
    public partial class Form1 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form1()
        {
            alamat = "server=localhost; database=db_klinik; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CBUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBUser.SelectedItem == null)
                {
                    MessageBox.Show("Pilih tipe pengguna terlebih dahulu");
                    return;
                }

                string query = string.Empty;

                if (CBUser.SelectedItem.ToString() == "Staff")
                {
                    query = "SELECT * FROM tbl_staff WHERE username = @username";
                }
                else if (CBUser.SelectedItem.ToString() == "Dokter")
                {
                    query = "SELECT * FROM tbl_dokter WHERE username_dokter = @username";
                }
                else if (CBUser.SelectedItem.ToString() == "admin")
                {
                    query = "SELECT * FROM tbl_user WHERE username = @username";
                }

                ds.Clear();

                // Check if connection is already open
                if (koneksi.State == ConnectionState.Closed)
                {
                    koneksi.Open();
                }

                using (MySqlCommand perintah = new MySqlCommand(query, koneksi))
                {
                    perintah.Parameters.AddWithValue("@username", txtUsername.Text);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(perintah))
                    {
                        adapter.Fill(ds);
                    }
                }

                koneksi.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi = kolom["password"].ToString();
                        if (sandi == txtPassword.Text)
                        {
                            if (CBUser.SelectedItem.ToString() == "Staff")
                            {
                                StaffFrm frmStaff = new StaffFrm(this); // Kirim instance Form1 ke AdminFrm
                                frmStaff.Show();
                                this.Hide();
                            }
                            else if (CBUser.SelectedItem.ToString() == "Dokter")
                            {
                                DokterFrm frmDoctor = new DokterFrm();
                                frmDoctor.Show();
                            }
                            else if (CBUser.SelectedItem.ToString() == "admin")
                            {
                                AdminnFrm frmAdminn = new AdminnFrm();
                                frmAdminn.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
