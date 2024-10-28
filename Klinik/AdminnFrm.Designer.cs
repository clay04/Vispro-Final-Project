namespace Klinik
{
    partial class AdminnFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.PanelDaftarPasien = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDaftarObat = new System.Windows.Forms.Button();
            this.btnDaftarPasien = new System.Windows.Forms.Button();
            this.btnDataRekamMedis = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlamatPasien = new System.Windows.Forms.TextBox();
            this.dateTanggalLahirPasien = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelDaftarPasien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hello Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PanelDaftarPasien
            // 
            this.PanelDaftarPasien.Controls.Add(this.label4);
            this.PanelDaftarPasien.Controls.Add(this.dataGridView2);
            this.PanelDaftarPasien.Controls.Add(this.panel1);
            this.PanelDaftarPasien.Controls.Add(this.dataGridView1);
            this.PanelDaftarPasien.Controls.Add(this.label3);
            this.PanelDaftarPasien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDaftarPasien.Location = new System.Drawing.Point(0, 0);
            this.PanelDaftarPasien.Name = "PanelDaftarPasien";
            this.PanelDaftarPasien.Size = new System.Drawing.Size(1181, 892);
            this.PanelDaftarPasien.TabIndex = 10;
            this.PanelDaftarPasien.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDaftarPasien_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inventory obat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 400);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dateTanggalLahirPasien);
            this.panel1.Controls.Add(this.txtAlamatPasien);
            this.panel1.Controls.Add(this.txtNamaPasien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(30, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 324);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPasien.Location = new System.Drawing.Point(216, 21);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(522, 34);
            this.txtNamaPasien.TabIndex = 7;
            this.txtNamaPasien.TextChanged += new System.EventHandler(this.txtNamaPasien_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(31, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 43);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(166, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 43);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(307, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 43);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDaftarObat
            // 
            this.btnDaftarObat.BackColor = System.Drawing.Color.Transparent;
            this.btnDaftarObat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarObat.Location = new System.Drawing.Point(29, 256);
            this.btnDaftarObat.Margin = new System.Windows.Forms.Padding(0);
            this.btnDaftarObat.Name = "btnDaftarObat";
            this.btnDaftarObat.Size = new System.Drawing.Size(353, 38);
            this.btnDaftarObat.TabIndex = 6;
            this.btnDaftarObat.Text = "Daftar Obat";
            this.btnDaftarObat.UseVisualStyleBackColor = false;
            this.btnDaftarObat.Click += new System.EventHandler(this.btnDaftarObat_Click);
            // 
            // btnDaftarPasien
            // 
            this.btnDaftarPasien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarPasien.Location = new System.Drawing.Point(29, 215);
            this.btnDaftarPasien.Name = "btnDaftarPasien";
            this.btnDaftarPasien.Size = new System.Drawing.Size(353, 38);
            this.btnDaftarPasien.TabIndex = 7;
            this.btnDaftarPasien.Text = "Daftar Pasien";
            this.btnDaftarPasien.UseVisualStyleBackColor = true;
            this.btnDaftarPasien.Click += new System.EventHandler(this.btnDaftarPasien_Click);
            // 
            // btnDataRekamMedis
            // 
            this.btnDataRekamMedis.BackColor = System.Drawing.Color.Transparent;
            this.btnDataRekamMedis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataRekamMedis.Location = new System.Drawing.Point(29, 296);
            this.btnDataRekamMedis.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataRekamMedis.Name = "btnDataRekamMedis";
            this.btnDataRekamMedis.Size = new System.Drawing.Size(353, 38);
            this.btnDataRekamMedis.TabIndex = 8;
            this.btnDataRekamMedis.Text = "Data Rekam Medis";
            this.btnDataRekamMedis.UseVisualStyleBackColor = false;
            this.btnDataRekamMedis.Click += new System.EventHandler(this.btnDataRekamMedis_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.btnDataRekamMedis);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDaftarPasien);
            this.splitContainer1.Panel1.Controls.Add(this.btnDaftarObat);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PanelDaftarPasien);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1650, 892);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tanggal restock";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Deskripsi obat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtAlamatPasien
            // 
            this.txtAlamatPasien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamatPasien.Location = new System.Drawing.Point(216, 110);
            this.txtAlamatPasien.Multiline = true;
            this.txtAlamatPasien.Name = "txtAlamatPasien";
            this.txtAlamatPasien.Size = new System.Drawing.Size(522, 105);
            this.txtAlamatPasien.TabIndex = 8;
            this.txtAlamatPasien.TextChanged += new System.EventHandler(this.txtAlamatPasien_TextChanged);
            // 
            // dateTanggalLahirPasien
            // 
            this.dateTanggalLahirPasien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTanggalLahirPasien.Location = new System.Drawing.Point(216, 65);
            this.dateTanggalLahirPasien.Name = "dateTanggalLahirPasien";
            this.dateTanggalLahirPasien.Size = new System.Drawing.Size(522, 34);
            this.dateTanggalLahirPasien.TabIndex = 9;
            this.dateTanggalLahirPasien.ValueChanged += new System.EventHandler(this.dateTanggalLahirPasien_ValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(839, 524);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(307, 303);
            this.dataGridView2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(903, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Obat mendatang";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // AdminnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 892);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminnFrm";
            this.Text = "AdminnFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminnFrm_Load);
            this.PanelDaftarPasien.ResumeLayout(false);
            this.PanelDaftarPasien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelDaftarPasien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDaftarObat;
        private System.Windows.Forms.Button btnDaftarPasien;
        private System.Windows.Forms.Button btnDataRekamMedis;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTanggalLahirPasien;
        private System.Windows.Forms.TextBox txtAlamatPasien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}