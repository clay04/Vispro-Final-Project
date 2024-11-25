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
    public partial class CRResepObat : Form
    {
        public CRResepObat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResepObat1.SetParameterValue("ResepObat", textBox1.Text);
            crystalReportViewer1.ReportSource = ResepObat1;
            crystalReportViewer1.Refresh();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
