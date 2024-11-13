namespace Klinik
{
    partial class StaffFrm
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
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPendaftaran = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSavePembayaran = new System.Windows.Forms.Button();
            this.cbStatusPembayaran = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtJumlahPembayaran = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTanggalPembayaran = new System.Windows.Forms.DateTimePicker();
            this.btnSearchPasienPembayaran = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIDPendaftaranPembayaran = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIDPasienPembayaran = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNamaPasienPembayaran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPendaftaran = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNamaDokter = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTglDaftar = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRiwayatPenyakit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomorTelepon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDPasien = new System.Windows.Forms.TextBox();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.dateTglLhirPasien = new System.Windows.Forms.DateTimePicker();
            this.CBJenisKelamin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelPendaftaran.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btnPembayaran);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnPendaftaran);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panelPendaftaran);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1828, 1000);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembayaran.Location = new System.Drawing.Point(12, 387);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Size = new System.Drawing.Size(353, 38);
            this.btnPembayaran.TabIndex = 5;
            this.btnPembayaran.Text = "Pembayaran";
            this.btnPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPembayaran.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(12, 876);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(353, 52);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klinik.Properties.Resources.logo_klinik;
            this.pictureBox1.Location = new System.Drawing.Point(26, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnPendaftaran
            // 
            this.btnPendaftaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendaftaran.Location = new System.Drawing.Point(12, 339);
            this.btnPendaftaran.Name = "btnPendaftaran";
            this.btnPendaftaran.Size = new System.Drawing.Size(353, 38);
            this.btnPendaftaran.TabIndex = 0;
            this.btnPendaftaran.Text = "Pendaftaran";
            this.btnPendaftaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendaftaran.UseVisualStyleBackColor = true;
            this.btnPendaftaran.Click += new System.EventHandler(this.btnPendaftaran_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1471, 1000);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnSavePembayaran);
            this.panel3.Controls.Add(this.cbStatusPembayaran);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.cbMetodePembayaran);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtJumlahPembayaran);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.dateTanggalPembayaran);
            this.panel3.Controls.Add(this.btnSearchPasienPembayaran);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtIDPendaftaranPembayaran);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtIDPasienPembayaran);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtNamaPasienPembayaran);
            this.panel3.Location = new System.Drawing.Point(85, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 623);
            this.panel3.TabIndex = 1;
            // 
            // btnSavePembayaran
            // 
            this.btnSavePembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePembayaran.Location = new System.Drawing.Point(51, 420);
            this.btnSavePembayaran.Name = "btnSavePembayaran";
            this.btnSavePembayaran.Size = new System.Drawing.Size(152, 38);
            this.btnSavePembayaran.TabIndex = 17;
            this.btnSavePembayaran.Text = "Save";
            this.btnSavePembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePembayaran.UseVisualStyleBackColor = true;
            this.btnSavePembayaran.Click += new System.EventHandler(this.btnSavePembayaran_Click);
            // 
            // cbStatusPembayaran
            // 
            this.cbStatusPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusPembayaran.FormattingEnabled = true;
            this.cbStatusPembayaran.Location = new System.Drawing.Point(264, 366);
            this.cbStatusPembayaran.Name = "cbStatusPembayaran";
            this.cbStatusPembayaran.Size = new System.Drawing.Size(590, 36);
            this.cbStatusPembayaran.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(46, 369);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 28);
            this.label19.TabIndex = 15;
            this.label19.Text = "Status Pembayaran";
            // 
            // cbMetodePembayaran
            // 
            this.cbMetodePembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodePembayaran.FormattingEnabled = true;
            this.cbMetodePembayaran.Location = new System.Drawing.Point(264, 323);
            this.cbMetodePembayaran.Name = "cbMetodePembayaran";
            this.cbMetodePembayaran.Size = new System.Drawing.Size(590, 36);
            this.cbMetodePembayaran.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(46, 327);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(193, 28);
            this.label18.TabIndex = 12;
            this.label18.Text = "Metode Pembayaran";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(46, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 28);
            this.label17.TabIndex = 10;
            this.label17.Text = "Jumlah Pembayaran";
            // 
            // txtJumlahPembayaran
            // 
            this.txtJumlahPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahPembayaran.Location = new System.Drawing.Point(264, 280);
            this.txtJumlahPembayaran.Name = "txtJumlahPembayaran";
            this.txtJumlahPembayaran.Size = new System.Drawing.Size(598, 34);
            this.txtJumlahPembayaran.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(46, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 28);
            this.label16.TabIndex = 8;
            this.label16.Text = "Tanggal Pembayaran";
            // 
            // dateTanggalPembayaran
            // 
            this.dateTanggalPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTanggalPembayaran.Location = new System.Drawing.Point(264, 240);
            this.dateTanggalPembayaran.Name = "dateTanggalPembayaran";
            this.dateTanggalPembayaran.Size = new System.Drawing.Size(598, 34);
            this.dateTanggalPembayaran.TabIndex = 7;
            // 
            // btnSearchPasienPembayaran
            // 
            this.btnSearchPasienPembayaran.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPasienPembayaran.Location = new System.Drawing.Point(51, 176);
            this.btnSearchPasienPembayaran.Name = "btnSearchPasienPembayaran";
            this.btnSearchPasienPembayaran.Size = new System.Drawing.Size(152, 38);
            this.btnSearchPasienPembayaran.TabIndex = 6;
            this.btnSearchPasienPembayaran.Text = "Search";
            this.btnSearchPasienPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPasienPembayaran.UseVisualStyleBackColor = true;
            this.btnSearchPasienPembayaran.Click += new System.EventHandler(this.btnSearchPasienPembayaran_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 28);
            this.label15.TabIndex = 5;
            this.label15.Text = "ID Pendaftaran";
            // 
            // txtIDPendaftaranPembayaran
            // 
            this.txtIDPendaftaranPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPendaftaranPembayaran.Location = new System.Drawing.Point(264, 116);
            this.txtIDPendaftaranPembayaran.Name = "txtIDPendaftaranPembayaran";
            this.txtIDPendaftaranPembayaran.Size = new System.Drawing.Size(598, 34);
            this.txtIDPendaftaranPembayaran.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 28);
            this.label14.TabIndex = 3;
            this.label14.Text = "ID Pasien";
            // 
            // txtIDPasienPembayaran
            // 
            this.txtIDPasienPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPasienPembayaran.Location = new System.Drawing.Point(264, 36);
            this.txtIDPasienPembayaran.Name = "txtIDPasienPembayaran";
            this.txtIDPasienPembayaran.Size = new System.Drawing.Size(598, 34);
            this.txtIDPasienPembayaran.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nama Pasien";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtNamaPasienPembayaran
            // 
            this.txtNamaPasienPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPasienPembayaran.Location = new System.Drawing.Point(264, 76);
            this.txtNamaPasienPembayaran.Name = "txtNamaPasienPembayaran";
            this.txtNamaPasienPembayaran.Size = new System.Drawing.Size(598, 34);
            this.txtNamaPasienPembayaran.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pembayaran";
            // 
            // panelPendaftaran
            // 
            this.panelPendaftaran.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPendaftaran.Controls.Add(this.label3);
            this.panelPendaftaran.Controls.Add(this.panel1);
            this.panelPendaftaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPendaftaran.Location = new System.Drawing.Point(0, 0);
            this.panelPendaftaran.Name = "panelPendaftaran";
            this.panelPendaftaran.Size = new System.Drawing.Size(1471, 1000);
            this.panelPendaftaran.TabIndex = 3;
            this.panelPendaftaran.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPendaftaran_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pendaftaran";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.cbNamaDokter);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dateTglDaftar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtRiwayatPenyakit);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtAlamat);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNomorTelepon);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtIDPasien);
            this.panel1.Controls.Add(this.txtNamaPasien);
            this.panel1.Controls.Add(this.dateTglLhirPasien);
            this.panel1.Controls.Add(this.CBJenisKelamin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(14, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 846);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbNamaDokter
            // 
            this.cbNamaDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamaDokter.FormattingEnabled = true;
            this.cbNamaDokter.Location = new System.Drawing.Point(212, 551);
            this.cbNamaDokter.Name = "cbNamaDokter";
            this.cbNamaDokter.Size = new System.Drawing.Size(651, 33);
            this.cbNamaDokter.TabIndex = 21;
            this.cbNamaDokter.SelectedIndexChanged += new System.EventHandler(this.cbNamaDokter_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(4, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nama Dokter";
            // 
            // dateTglDaftar
            // 
            this.dateTglDaftar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTglDaftar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTglDaftar.Location = new System.Drawing.Point(212, 508);
            this.dateTglDaftar.Margin = new System.Windows.Forms.Padding(5);
            this.dateTglDaftar.Name = "dateTglDaftar";
            this.dateTglDaftar.Size = new System.Drawing.Size(732, 34);
            this.dateTglDaftar.TabIndex = 17;
            this.dateTglDaftar.UseWaitCursor = true;
            this.dateTglDaftar.ValueChanged += new System.EventHandler(this.dateTglDaftar_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(3, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 28);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tanggal Daftar";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(8, 780);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 39);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtRiwayatPenyakit
            // 
            this.txtRiwayatPenyakit.BackColor = System.Drawing.SystemColors.Window;
            this.txtRiwayatPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiwayatPenyakit.Location = new System.Drawing.Point(212, 398);
            this.txtRiwayatPenyakit.Multiline = true;
            this.txtRiwayatPenyakit.Name = "txtRiwayatPenyakit";
            this.txtRiwayatPenyakit.Size = new System.Drawing.Size(732, 92);
            this.txtRiwayatPenyakit.TabIndex = 14;
            this.txtRiwayatPenyakit.TextChanged += new System.EventHandler(this.txtRiwayatPenyakit_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(4, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 28);
            this.label10.TabIndex = 13;
            this.label10.Text = "Riwayat Penyakit";
            // 
            // txtAlamat
            // 
            this.txtAlamat.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(212, 241);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(732, 129);
            this.txtAlamat.TabIndex = 12;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(4, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "Alamat";
            // 
            // txtNomorTelepon
            // 
            this.txtNomorTelepon.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomorTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomorTelepon.Location = new System.Drawing.Point(212, 197);
            this.txtNomorTelepon.Name = "txtNomorTelepon";
            this.txtNomorTelepon.Size = new System.Drawing.Size(732, 30);
            this.txtNomorTelepon.TabIndex = 10;
            this.txtNomorTelepon.TextChanged += new System.EventHandler(this.txtNomorTelepon_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(4, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nomor Telepone";
            // 
            // txtIDPasien
            // 
            this.txtIDPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPasien.Location = new System.Drawing.Point(212, 27);
            this.txtIDPasien.Name = "txtIDPasien";
            this.txtIDPasien.Size = new System.Drawing.Size(732, 30);
            this.txtIDPasien.TabIndex = 8;
            this.txtIDPasien.TextChanged += new System.EventHandler(this.txtIDPasien_TextChanged);
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPasien.Location = new System.Drawing.Point(212, 69);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(732, 30);
            this.txtNamaPasien.TabIndex = 7;
            this.txtNamaPasien.TextChanged += new System.EventHandler(this.txtNamaPasien_TextChanged);
            // 
            // dateTglLhirPasien
            // 
            this.dateTglLhirPasien.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTglLhirPasien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTglLhirPasien.Location = new System.Drawing.Point(212, 150);
            this.dateTglLhirPasien.Margin = new System.Windows.Forms.Padding(5);
            this.dateTglLhirPasien.Name = "dateTglLhirPasien";
            this.dateTglLhirPasien.Size = new System.Drawing.Size(732, 34);
            this.dateTglLhirPasien.TabIndex = 5;
            this.dateTglLhirPasien.ValueChanged += new System.EventHandler(this.dateTglLhirPasien_ValueChanged);
            // 
            // CBJenisKelamin
            // 
            this.CBJenisKelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBJenisKelamin.FormattingEnabled = true;
            this.CBJenisKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.CBJenisKelamin.Location = new System.Drawing.Point(212, 108);
            this.CBJenisKelamin.Name = "CBJenisKelamin";
            this.CBJenisKelamin.Size = new System.Drawing.Size(732, 33);
            this.CBJenisKelamin.TabIndex = 6;
            this.CBJenisKelamin.SelectedIndexChanged += new System.EventHandler(this.CBJenisKelamin_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(3, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID Pasien";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nama Pasien";
            // 
            // StaffFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1828, 1000);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StaffFrm";
            this.Text = "StaffFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.staffFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelPendaftaran.ResumeLayout(false);
            this.panelPendaftaran.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnPendaftaran;
        private System.Windows.Forms.Panel panelPendaftaran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDPasien;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.ComboBox CBJenisKelamin;
        private System.Windows.Forms.DateTimePicker dateTglLhirPasien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomorTelepon;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRiwayatPenyakit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTglDaftar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbNamaDokter;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNamaPasienPembayaran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDPendaftaranPembayaran;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIDPasienPembayaran;
        private System.Windows.Forms.Button btnSearchPasienPembayaran;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtJumlahPembayaran;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTanggalPembayaran;
        private System.Windows.Forms.ComboBox cbStatusPembayaran;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbMetodePembayaran;
        private System.Windows.Forms.Button btnSavePembayaran;
    }
}