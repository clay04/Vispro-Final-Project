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
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPendaftaran = new System.Windows.Forms.Button();
            this.panelPendaftaran = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnPendaftaran);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelPendaftaran);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1828, 1000);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
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
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pendaftaran";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
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
            this.panel1.Size = new System.Drawing.Size(1445, 711);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnSubmit.Location = new System.Drawing.Point(8, 648);
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
    }
}