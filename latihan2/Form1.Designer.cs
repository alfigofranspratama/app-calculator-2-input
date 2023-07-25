namespace latihan2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnReset = new Button();
            labelHasil = new Label();
            txtHasil = new TextBox();
            btnSisaBagi = new Button();
            btnKali = new Button();
            btnBagi = new Button();
            btnKurang = new Button();
            btnTambah = new Button();
            txtAngkaKedua = new TextBox();
            lblAngkaKedua = new Label();
            txtAngkaPertama = new TextBox();
            lblAngkaPertama = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(labelHasil);
            groupBox1.Controls.Add(txtHasil);
            groupBox1.Controls.Add(btnSisaBagi);
            groupBox1.Controls.Add(btnKali);
            groupBox1.Controls.Add(btnBagi);
            groupBox1.Controls.Add(btnKurang);
            groupBox1.Controls.Add(btnTambah);
            groupBox1.Controls.Add(txtAngkaKedua);
            groupBox1.Controls.Add(lblAngkaKedua);
            groupBox1.Controls.Add(txtAngkaPertama);
            groupBox1.Controls.Add(lblAngkaPertama);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 344);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(6, 307);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(340, 31);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // labelHasil
            // 
            labelHasil.AutoSize = true;
            labelHasil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHasil.Location = new Point(6, 254);
            labelHasil.Name = "labelHasil";
            labelHasil.Size = new Size(44, 21);
            labelHasil.TabIndex = 10;
            labelHasil.Text = "Hasil";
            labelHasil.Visible = false;
            labelHasil.Click += label1_Click_1;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(6, 278);
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(340, 23);
            txtHasil.TabIndex = 9;
            txtHasil.Visible = false;
            // 
            // btnSisaBagi
            // 
            btnSisaBagi.BackColor = Color.Green;
            btnSisaBagi.ForeColor = SystemColors.Control;
            btnSisaBagi.Location = new Point(6, 169);
            btnSisaBagi.Name = "btnSisaBagi";
            btnSisaBagi.Size = new Size(340, 35);
            btnSisaBagi.TabIndex = 8;
            btnSisaBagi.Text = "Sisa Bagi";
            btnSisaBagi.UseVisualStyleBackColor = false;
            btnSisaBagi.Click += btnSisaBagi_Click;
            // 
            // btnKali
            // 
            btnKali.BackColor = Color.Green;
            btnKali.ForeColor = SystemColors.Control;
            btnKali.Location = new Point(6, 210);
            btnKali.Name = "btnKali";
            btnKali.Size = new Size(176, 35);
            btnKali.TabIndex = 7;
            btnKali.Text = "Kali";
            btnKali.UseVisualStyleBackColor = false;
            btnKali.Click += btnKali_Click;
            // 
            // btnBagi
            // 
            btnBagi.BackColor = Color.Green;
            btnBagi.ForeColor = SystemColors.Control;
            btnBagi.Location = new Point(180, 210);
            btnBagi.Name = "btnBagi";
            btnBagi.Size = new Size(166, 35);
            btnBagi.TabIndex = 6;
            btnBagi.Text = "Bagi";
            btnBagi.UseVisualStyleBackColor = false;
            btnBagi.Click += button1_Click_1;
            // 
            // btnKurang
            // 
            btnKurang.BackColor = Color.Green;
            btnKurang.ForeColor = SystemColors.Control;
            btnKurang.Location = new Point(180, 128);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(166, 35);
            btnKurang.TabIndex = 5;
            btnKurang.Text = "Kurang";
            btnKurang.UseVisualStyleBackColor = false;
            btnKurang.Click += button1_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Green;
            btnTambah.ForeColor = SystemColors.Control;
            btnTambah.Location = new Point(6, 128);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(176, 35);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtAngkaKedua
            // 
            txtAngkaKedua.Location = new Point(6, 99);
            txtAngkaKedua.Name = "txtAngkaKedua";
            txtAngkaKedua.Size = new Size(340, 23);
            txtAngkaKedua.TabIndex = 3;
            txtAngkaKedua.TextChanged += textBox1_TextChanged;
            // 
            // lblAngkaKedua
            // 
            lblAngkaKedua.AutoSize = true;
            lblAngkaKedua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAngkaKedua.Location = new Point(6, 75);
            lblAngkaKedua.Name = "lblAngkaKedua";
            lblAngkaKedua.Size = new Size(176, 21);
            lblAngkaKedua.TabIndex = 2;
            lblAngkaKedua.Text = "Masukkan Angka Kedua";
            lblAngkaKedua.Click += label1_Click;
            // 
            // txtAngkaPertama
            // 
            txtAngkaPertama.Location = new Point(6, 39);
            txtAngkaPertama.Name = "txtAngkaPertama";
            txtAngkaPertama.Size = new Size(340, 23);
            txtAngkaPertama.TabIndex = 1;
            // 
            // lblAngkaPertama
            // 
            lblAngkaPertama.AutoSize = true;
            lblAngkaPertama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAngkaPertama.Location = new Point(6, 15);
            lblAngkaPertama.Name = "lblAngkaPertama";
            lblAngkaPertama.Size = new Size(190, 21);
            lblAngkaPertama.TabIndex = 0;
            lblAngkaPertama.Text = "Masukkan Angka Pertama";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 368);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Aplikasi Penjumlahan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAngkaPertama;
        private Label lblAngkaPertama;
        private TextBox txtAngkaKedua;
        private Label lblAngkaKedua;
        private Button btnTambah;
        private Button btnKurang;
        private Button btnBagi;
        private Button btnSisaBagi;
        private Button btnKali;
        private Label labelHasil;
        private TextBox txtHasil;
        private Button btnReset;
    }
}