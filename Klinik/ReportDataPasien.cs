using System;
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
    public partial class ReportDataPasien : Form
    {
        public ReportDataPasien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataPasien1.SetParameterValue("data_pasien", txtNamaPasien.Text);
            crystalReportViewer1.ReportSource = DataPasien1;
            crystalReportViewer1.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
