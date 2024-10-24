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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDataRekamMedis = new System.Windows.Forms.Button();
            this.btnDaftarPasien = new System.Windows.Forms.Button();
            this.btnDaftarObat = new System.Windows.Forms.Button();
            this.PanelDaftarPasien = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPasien = new System.Windows.Forms.TextBox();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.txtAlamatPasien = new System.Windows.Forms.TextBox();
            this.dateTanggalLahirPasien = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PanelDaftarPasien.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnDaftarPasien);
            this.splitContainer1.Panel1.Controls.Add(this.btnDaftarObat);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PanelDaftarPasien);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1650, 892);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnDataRekamMedis
            // 
            this.btnDataRekamMedis.BackColor = System.Drawing.Color.Transparent;
            this.btnDataRekamMedis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataRekamMedis.Location = new System.Drawing.Point(9, 321);
            this.btnDataRekamMedis.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataRekamMedis.Name = "btnDataRekamMedis";
            this.btnDataRekamMedis.Size = new System.Drawing.Size(353, 38);
            this.btnDataRekamMedis.TabIndex = 8;
            this.btnDataRekamMedis.Text = "Data Rekam Medis";
            this.btnDataRekamMedis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataRekamMedis.UseVisualStyleBackColor = false;
            // 
            // btnDaftarPasien
            // 
            this.btnDaftarPasien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarPasien.Location = new System.Drawing.Point(9, 240);
            this.btnDaftarPasien.Name = "btnDaftarPasien";
            this.btnDaftarPasien.Size = new System.Drawing.Size(353, 38);
            this.btnDaftarPasien.TabIndex = 7;
            this.btnDaftarPasien.Text = "Daftar Pasien";
            this.btnDaftarPasien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaftarPasien.UseVisualStyleBackColor = true;
            this.btnDaftarPasien.Click += new System.EventHandler(this.btnDaftarPasien_Click);
            // 
            // btnDaftarObat
            // 
            this.btnDaftarObat.BackColor = System.Drawing.Color.Transparent;
            this.btnDaftarObat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarObat.Location = new System.Drawing.Point(9, 281);
            this.btnDaftarObat.Margin = new System.Windows.Forms.Padding(0);
            this.btnDaftarObat.Name = "btnDaftarObat";
            this.btnDaftarObat.Size = new System.Drawing.Size(353, 38);
            this.btnDaftarObat.TabIndex = 6;
            this.btnDaftarObat.Text = "Daftar Obat";
            this.btnDaftarObat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaftarObat.UseVisualStyleBackColor = false;
            // 
            // PanelDaftarPasien
            // 
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dateTanggalLahirPasien);
            this.panel1.Controls.Add(this.txtAlamatPasien);
            this.panel1.Controls.Add(this.txtNamaPasien);
            this.panel1.Controls.Add(this.txtIDPasien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(30, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 360);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Pasien";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tanggal Lahir";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Daftar Pasien";
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
            // 
            // txtIDPasien
            // 
            this.txtIDPasien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPasien.Location = new System.Drawing.Point(221, 23);
            this.txtIDPasien.Name = "txtIDPasien";
            this.txtIDPasien.Size = new System.Drawing.Size(522, 34);
            this.txtIDPasien.TabIndex = 6;
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPasien.Location = new System.Drawing.Point(221, 67);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(522, 34);
            this.txtNamaPasien.TabIndex = 7;
            // 
            // txtAlamatPasien
            // 
            this.txtAlamatPasien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamatPasien.Location = new System.Drawing.Point(221, 156);
            this.txtAlamatPasien.Multiline = true;
            this.txtAlamatPasien.Name = "txtAlamatPasien";
            this.txtAlamatPasien.Size = new System.Drawing.Size(522, 105);
            this.txtAlamatPasien.TabIndex = 8;
            // 
            // dateTanggalLahirPasien
            // 
            this.dateTanggalLahirPasien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTanggalLahirPasien.Location = new System.Drawing.Point(221, 111);
            this.dateTanggalLahirPasien.Name = "dateTanggalLahirPasien";
            this.dateTanggalLahirPasien.Size = new System.Drawing.Size(522, 34);
            this.dateTanggalLahirPasien.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(36, 288);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 43);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(171, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 43);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(312, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 43);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PanelDaftarPasien.ResumeLayout(false);
            this.PanelDaftarPasien.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDaftarObat;
        private System.Windows.Forms.Button btnDaftarPasien;
        private System.Windows.Forms.Button btnDataRekamMedis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelDaftarPasien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTanggalLahirPasien;
        private System.Windows.Forms.TextBox txtAlamatPasien;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.TextBox txtIDPasien;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
    }
}