namespace Klinik
{
    partial class DokterFrm
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
            this.btnRiwayatRekamMedis = new System.Windows.Forms.Button();
            this.btnRekamMedis = new System.Windows.Forms.Button();
            this.panelRiwayatRekamMedis = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelRekamMedis = new System.Windows.Forms.Panel();
            this.cardRekamMedis = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTanggalPeriksa = new System.Windows.Forms.DateTimePicker();
            this.txtCatatanTambahan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResepObat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPengobatan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiagnosa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDRekamMedis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRiwayatPenyakit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPasien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelRiwayatRekamMedis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelRekamMedis.SuspendLayout();
            this.cardRekamMedis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Dokter";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnRiwayatRekamMedis);
            this.splitContainer1.Panel1.Controls.Add(this.btnRekamMedis);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelRiwayatRekamMedis);
            this.splitContainer1.Panel2.Controls.Add(this.panelRekamMedis);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1867, 833);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnRiwayatRekamMedis
            // 
            this.btnRiwayatRekamMedis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayatRekamMedis.Location = new System.Drawing.Point(12, 344);
            this.btnRiwayatRekamMedis.Name = "btnRiwayatRekamMedis";
            this.btnRiwayatRekamMedis.Size = new System.Drawing.Size(286, 38);
            this.btnRiwayatRekamMedis.TabIndex = 2;
            this.btnRiwayatRekamMedis.Text = "Riwayat rekam medis";
            this.btnRiwayatRekamMedis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayatRekamMedis.UseVisualStyleBackColor = true;
            this.btnRiwayatRekamMedis.Click += new System.EventHandler(this.btnRiwayatRekamMedis_Click);
            // 
            // btnRekamMedis
            // 
            this.btnRekamMedis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRekamMedis.Location = new System.Drawing.Point(12, 300);
            this.btnRekamMedis.Name = "btnRekamMedis";
            this.btnRekamMedis.Size = new System.Drawing.Size(286, 38);
            this.btnRekamMedis.TabIndex = 1;
            this.btnRekamMedis.Text = "Rekam Medis\r\n";
            this.btnRekamMedis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRekamMedis.UseVisualStyleBackColor = true;
            this.btnRekamMedis.Click += new System.EventHandler(this.btnRekamMedis_Click);
            // 
            // panelRiwayatRekamMedis
            // 
            this.panelRiwayatRekamMedis.Controls.Add(this.label13);
            this.panelRiwayatRekamMedis.Controls.Add(this.dataGridView1);
            this.panelRiwayatRekamMedis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRiwayatRekamMedis.Location = new System.Drawing.Point(0, 0);
            this.panelRiwayatRekamMedis.Name = "panelRiwayatRekamMedis";
            this.panelRiwayatRekamMedis.Size = new System.Drawing.Size(1513, 833);
            this.panelRiwayatRekamMedis.TabIndex = 1;
            this.panelRiwayatRekamMedis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRiwayatRekamMedis_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(305, 38);
            this.label13.TabIndex = 1;
            this.label13.Text = "Riwayat Rekam Medis";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1445, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelRekamMedis
            // 
            this.panelRekamMedis.Controls.Add(this.cardRekamMedis);
            this.panelRekamMedis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRekamMedis.Location = new System.Drawing.Point(0, 0);
            this.panelRekamMedis.Name = "panelRekamMedis";
            this.panelRekamMedis.Size = new System.Drawing.Size(1513, 833);
            this.panelRekamMedis.TabIndex = 0;
            this.panelRekamMedis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRekamMedis_Paint);
            // 
            // cardRekamMedis
            // 
            this.cardRekamMedis.BackColor = System.Drawing.Color.White;
            this.cardRekamMedis.Controls.Add(this.btnSave);
            this.cardRekamMedis.Controls.Add(this.dateTanggalPeriksa);
            this.cardRekamMedis.Controls.Add(this.txtCatatanTambahan);
            this.cardRekamMedis.Controls.Add(this.label12);
            this.cardRekamMedis.Controls.Add(this.txtResepObat);
            this.cardRekamMedis.Controls.Add(this.label11);
            this.cardRekamMedis.Controls.Add(this.txtPengobatan);
            this.cardRekamMedis.Controls.Add(this.label10);
            this.cardRekamMedis.Controls.Add(this.txtDiagnosa);
            this.cardRekamMedis.Controls.Add(this.label9);
            this.cardRekamMedis.Controls.Add(this.label7);
            this.cardRekamMedis.Controls.Add(this.label6);
            this.cardRekamMedis.Controls.Add(this.label5);
            this.cardRekamMedis.Controls.Add(this.txtIDRekamMedis);
            this.cardRekamMedis.Controls.Add(this.label4);
            this.cardRekamMedis.Controls.Add(this.txtRiwayatPenyakit);
            this.cardRekamMedis.Controls.Add(this.label3);
            this.cardRekamMedis.Controls.Add(this.btnSearch);
            this.cardRekamMedis.Controls.Add(this.txtNamaPasien);
            this.cardRekamMedis.Controls.Add(this.label2);
            this.cardRekamMedis.Controls.Add(this.txtIDPasien);
            this.cardRekamMedis.Controls.Add(this.label8);
            this.cardRekamMedis.Location = new System.Drawing.Point(45, 110);
            this.cardRekamMedis.Name = "cardRekamMedis";
            this.cardRekamMedis.Size = new System.Drawing.Size(1001, 636);
            this.cardRekamMedis.TabIndex = 0;
            this.cardRekamMedis.Paint += new System.Windows.Forms.PaintEventHandler(this.cardRekamMedis_Paint);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(35, 549);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 38);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTanggalPeriksa
            // 
            this.dateTanggalPeriksa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTanggalPeriksa.Location = new System.Drawing.Point(238, 351);
            this.dateTanggalPeriksa.Name = "dateTanggalPeriksa";
            this.dateTanggalPeriksa.Size = new System.Drawing.Size(732, 34);
            this.dateTanggalPeriksa.TabIndex = 31;
            // 
            // txtCatatanTambahan
            // 
            this.txtCatatanTambahan.BackColor = System.Drawing.SystemColors.Window;
            this.txtCatatanTambahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatatanTambahan.Location = new System.Drawing.Point(238, 498);
            this.txtCatatanTambahan.Name = "txtCatatanTambahan";
            this.txtCatatanTambahan.Size = new System.Drawing.Size(732, 30);
            this.txtCatatanTambahan.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(30, 498);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 28);
            this.label12.TabIndex = 29;
            this.label12.Text = "Catatan Tambahan";
            // 
            // txtResepObat
            // 
            this.txtResepObat.BackColor = System.Drawing.SystemColors.Window;
            this.txtResepObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResepObat.Location = new System.Drawing.Point(238, 462);
            this.txtResepObat.Name = "txtResepObat";
            this.txtResepObat.Size = new System.Drawing.Size(732, 30);
            this.txtResepObat.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(30, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 28);
            this.label11.TabIndex = 27;
            this.label11.Text = "Resep Obat";
            // 
            // txtPengobatan
            // 
            this.txtPengobatan.BackColor = System.Drawing.SystemColors.Window;
            this.txtPengobatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPengobatan.Location = new System.Drawing.Point(238, 426);
            this.txtPengobatan.Name = "txtPengobatan";
            this.txtPengobatan.Size = new System.Drawing.Size(732, 30);
            this.txtPengobatan.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(30, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 28);
            this.label10.TabIndex = 25;
            this.label10.Text = "Pengobatan";
            // 
            // txtDiagnosa
            // 
            this.txtDiagnosa.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiagnosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosa.Location = new System.Drawing.Point(238, 390);
            this.txtDiagnosa.Name = "txtDiagnosa";
            this.txtDiagnosa.Size = new System.Drawing.Size(732, 30);
            this.txtDiagnosa.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(30, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dignosa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(30, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tanggal Peeriksa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(30, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pasien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(30, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rekam Medis";
            // 
            // txtIDRekamMedis
            // 
            this.txtIDRekamMedis.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDRekamMedis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDRekamMedis.Location = new System.Drawing.Point(238, 316);
            this.txtIDRekamMedis.Name = "txtIDRekamMedis";
            this.txtIDRekamMedis.Size = new System.Drawing.Size(732, 30);
            this.txtIDRekamMedis.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(30, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID Rekam Medis";
            // 
            // txtRiwayatPenyakit
            // 
            this.txtRiwayatPenyakit.BackColor = System.Drawing.SystemColors.Window;
            this.txtRiwayatPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiwayatPenyakit.Location = new System.Drawing.Point(238, 151);
            this.txtRiwayatPenyakit.Name = "txtRiwayatPenyakit";
            this.txtRiwayatPenyakit.Size = new System.Drawing.Size(732, 30);
            this.txtRiwayatPenyakit.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(30, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Riwayat Penyakit";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(35, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPasien.Location = new System.Drawing.Point(238, 109);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(732, 30);
            this.txtNamaPasien.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Pasien";
            // 
            // txtIDPasien
            // 
            this.txtIDPasien.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPasien.Location = new System.Drawing.Point(238, 69);
            this.txtIDPasien.Name = "txtIDPasien";
            this.txtIDPasien.Size = new System.Drawing.Size(732, 30);
            this.txtIDPasien.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(30, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID Pasien";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rekam Medis\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DokterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 833);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DokterFrm";
            this.Text = "DokterFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DokterFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelRiwayatRekamMedis.ResumeLayout(false);
            this.panelRiwayatRekamMedis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelRekamMedis.ResumeLayout(false);
            this.cardRekamMedis.ResumeLayout(false);
            this.cardRekamMedis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRekamMedis;
        private System.Windows.Forms.Panel panelRekamMedis;
        private System.Windows.Forms.Panel cardRekamMedis;
        private System.Windows.Forms.TextBox txtIDPasien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRiwayatPenyakit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDRekamMedis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiagnosa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCatatanTambahan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtResepObat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPengobatan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTanggalPeriksa;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRiwayatRekamMedis;
        private System.Windows.Forms.Panel panelRiwayatRekamMedis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}