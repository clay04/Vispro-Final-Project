namespace Klinik
{
    partial class PerawatFrm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRiwayatPemeriksaanAwal = new System.Windows.Forms.Button();
            this.btnPemeriksaanAwal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPemeriksaanAwal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDPasien = new System.Windows.Forms.TextBox();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRiwayatPenyakitPasien = new System.Windows.Forms.TextBox();
            this.txtKeluhanPasien = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.PanelRiwayatPemeriksaanAwal = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDPasienRiw = new System.Windows.Forms.TextBox();
            this.txtNamaPasienRiw = new System.Windows.Forms.TextBox();
            this.txtKeluhanRiw = new System.Windows.Forms.TextBox();
            this.txtRiwayatPenyakitRiw = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPemeriksaanAwal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelRiwayatPemeriksaanAwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.btnRiwayatPemeriksaanAwal);
            this.splitContainer1.Panel1.Controls.Add(this.btnPemeriksaanAwal);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PanelRiwayatPemeriksaanAwal);
            this.splitContainer1.Panel2.Controls.Add(this.panelPemeriksaanAwal);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1902, 1033);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klinik.Properties.Resources.logo_klinik;
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRiwayatPemeriksaanAwal
            // 
            this.btnRiwayatPemeriksaanAwal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayatPemeriksaanAwal.Location = new System.Drawing.Point(20, 521);
            this.btnRiwayatPemeriksaanAwal.Name = "btnRiwayatPemeriksaanAwal";
            this.btnRiwayatPemeriksaanAwal.Size = new System.Drawing.Size(353, 38);
            this.btnRiwayatPemeriksaanAwal.TabIndex = 7;
            this.btnRiwayatPemeriksaanAwal.Text = "Riwayat Pemeriksaan Awal";
            this.btnRiwayatPemeriksaanAwal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayatPemeriksaanAwal.UseVisualStyleBackColor = true;
            this.btnRiwayatPemeriksaanAwal.Click += new System.EventHandler(this.btnRiwayatPemeriksaanAwal_Click);
            // 
            // btnPemeriksaanAwal
            // 
            this.btnPemeriksaanAwal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPemeriksaanAwal.Location = new System.Drawing.Point(20, 473);
            this.btnPemeriksaanAwal.Name = "btnPemeriksaanAwal";
            this.btnPemeriksaanAwal.Size = new System.Drawing.Size(353, 38);
            this.btnPemeriksaanAwal.TabIndex = 6;
            this.btnPemeriksaanAwal.Text = "Pemeriksaan Awal";
            this.btnPemeriksaanAwal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPemeriksaanAwal.UseVisualStyleBackColor = true;
            this.btnPemeriksaanAwal.Click += new System.EventHandler(this.btnPemeriksaanAwal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hallo Perawat";
            // 
            // panelPemeriksaanAwal
            // 
            this.panelPemeriksaanAwal.Controls.Add(this.label2);
            this.panelPemeriksaanAwal.Controls.Add(this.panel1);
            this.panelPemeriksaanAwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPemeriksaanAwal.Location = new System.Drawing.Point(0, 0);
            this.panelPemeriksaanAwal.Name = "panelPemeriksaanAwal";
            this.panelPemeriksaanAwal.Size = new System.Drawing.Size(1531, 1033);
            this.panelPemeriksaanAwal.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtRiwayatPenyakitPasien);
            this.panel1.Controls.Add(this.txtKeluhanPasien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtNamaPasien);
            this.panel1.Controls.Add(this.txtIDPasien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(80, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 663);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pemeriksaan Awal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Pasien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Pasien";
            // 
            // txtIDPasien
            // 
            this.txtIDPasien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPasien.Location = new System.Drawing.Point(482, 59);
            this.txtIDPasien.Name = "txtIDPasien";
            this.txtIDPasien.Size = new System.Drawing.Size(369, 38);
            this.txtIDPasien.TabIndex = 4;
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPasien.Location = new System.Drawing.Point(482, 103);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(769, 38);
            this.txtNamaPasien.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(61, 166);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 43);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Riwayat Penyakit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 38);
            this.label6.TabIndex = 7;
            this.label6.Text = "Keluhan";
            // 
            // txtRiwayatPenyakitPasien
            // 
            this.txtRiwayatPenyakitPasien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiwayatPenyakitPasien.Location = new System.Drawing.Point(482, 300);
            this.txtRiwayatPenyakitPasien.Name = "txtRiwayatPenyakitPasien";
            this.txtRiwayatPenyakitPasien.Size = new System.Drawing.Size(769, 38);
            this.txtRiwayatPenyakitPasien.TabIndex = 10;
            // 
            // txtKeluhanPasien
            // 
            this.txtKeluhanPasien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeluhanPasien.Location = new System.Drawing.Point(482, 256);
            this.txtKeluhanPasien.Name = "txtKeluhanPasien";
            this.txtKeluhanPasien.Size = new System.Drawing.Size(769, 38);
            this.txtKeluhanPasien.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(61, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PanelRiwayatPemeriksaanAwal
            // 
            this.PanelRiwayatPemeriksaanAwal.Controls.Add(this.panel2);
            this.PanelRiwayatPemeriksaanAwal.Controls.Add(this.dataGridView1);
            this.PanelRiwayatPemeriksaanAwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRiwayatPemeriksaanAwal.Location = new System.Drawing.Point(0, 0);
            this.PanelRiwayatPemeriksaanAwal.Name = "PanelRiwayatPemeriksaanAwal";
            this.PanelRiwayatPemeriksaanAwal.Size = new System.Drawing.Size(1531, 1033);
            this.PanelRiwayatPemeriksaanAwal.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtRiwayatPenyakitRiw);
            this.panel2.Controls.Add(this.txtKeluhanRiw);
            this.panel2.Controls.Add(this.txtNamaPasienRiw);
            this.panel2.Controls.Add(this.txtIDPasienRiw);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(83, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1331, 365);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Pasien";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nama Pasien";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Keluhan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 31);
            this.label10.TabIndex = 3;
            this.label10.Text = "Riwayat Penyakit";
            // 
            // txtIDPasienRiw
            // 
            this.txtIDPasienRiw.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPasienRiw.Location = new System.Drawing.Point(357, 62);
            this.txtIDPasienRiw.Name = "txtIDPasienRiw";
            this.txtIDPasienRiw.Size = new System.Drawing.Size(304, 38);
            this.txtIDPasienRiw.TabIndex = 4;
            // 
            // txtNamaPasienRiw
            // 
            this.txtNamaPasienRiw.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPasienRiw.Location = new System.Drawing.Point(357, 108);
            this.txtNamaPasienRiw.Name = "txtNamaPasienRiw";
            this.txtNamaPasienRiw.Size = new System.Drawing.Size(684, 38);
            this.txtNamaPasienRiw.TabIndex = 5;
            // 
            // txtKeluhanRiw
            // 
            this.txtKeluhanRiw.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeluhanRiw.Location = new System.Drawing.Point(357, 155);
            this.txtKeluhanRiw.Multiline = true;
            this.txtKeluhanRiw.Name = "txtKeluhanRiw";
            this.txtKeluhanRiw.Size = new System.Drawing.Size(684, 98);
            this.txtKeluhanRiw.TabIndex = 6;
            // 
            // txtRiwayatPenyakitRiw
            // 
            this.txtRiwayatPenyakitRiw.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiwayatPenyakitRiw.Location = new System.Drawing.Point(357, 266);
            this.txtRiwayatPenyakitRiw.Name = "txtRiwayatPenyakitRiw";
            this.txtRiwayatPenyakitRiw.Size = new System.Drawing.Size(684, 38);
            this.txtRiwayatPenyakitRiw.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1143, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Serach";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1143, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1143, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 45);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(22, 894);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(353, 52);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // PerawatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PerawatFrm";
            this.Text = "PerawatFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PerawatFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPemeriksaanAwal.ResumeLayout(false);
            this.panelPemeriksaanAwal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelRiwayatPemeriksaanAwal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRiwayatPemeriksaanAwal;
        private System.Windows.Forms.Button btnPemeriksaanAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPemeriksaanAwal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.TextBox txtIDPasien;
        private System.Windows.Forms.TextBox txtRiwayatPenyakitPasien;
        private System.Windows.Forms.TextBox txtKeluhanPasien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel PanelRiwayatPemeriksaanAwal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRiwayatPenyakitRiw;
        private System.Windows.Forms.TextBox txtKeluhanRiw;
        private System.Windows.Forms.TextBox txtNamaPasienRiw;
        private System.Windows.Forms.TextBox txtIDPasienRiw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogout;
    }
}