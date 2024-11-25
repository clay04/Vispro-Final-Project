using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinik
{
    
    public partial class ApotekerFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private Form1 Form1;
        public ApotekerFrm(Form1 form1)
        {
            alamat = "server=localhost; database=db_klinik; username=root; password=; Convert Zero Datetime=True; Allow Zero Datetime=True;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
            
            Form1 = form1;
        }

        private void ApotekerFrm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT * FROM resep_obat";

                MySqlCommand perintahPasien = new MySqlCommand(query, koneksi);
                MySqlDataAdapter adapterPasien = new MySqlDataAdapter(perintahPasien);
                DataSet ds = new DataSet();
                adapterPasien.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                FormatDataGridView(dataGridView1, new string[] { "ID Resep Obat", "ID Obat", "ID Pasien", "Dosis Obat", "Cara Pakai", "Jumlah", "Keterangan", "ID Rekam Medis" });
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRResepObat cRResepObat = new CRResepObat();
            cRResepObat.Show();
        }
    }
}
