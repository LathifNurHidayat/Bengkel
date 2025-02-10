﻿using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KendaraanForm
{
    partial class InputEditKendaraan
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
            panel1 = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            ComboKendaraan = new Syncfusion.WinForms.ListView.SfComboBox();
            panel10 = new Panel();
            TextTahun = new TextBox();
            panel11 = new Panel();
            TextKapasitasMesin = new TextBox();
            label3 = new Label();
            panel8 = new Panel();
            TextMerek = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            TextNoPolisi = new TextBox();
            label6 = new Label();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel3 = new Panel();
            LabelNoKTP = new Label();
            panel7 = new Panel();
            TextTelepon = new TextBox();
            panel6 = new Panel();
            TextNama = new TextBox();
            label2 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            TextNomorKTP = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComboKendaraan).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(ButtonBatal);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 679);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(ComboKendaraan);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(544, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 561);
            panel4.TabIndex = 2;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(175, 36);
            label9.Name = "label9";
            label9.Size = new Size(257, 23);
            label9.TabIndex = 66;
            label9.Text = "Nomor polisi sudah terdaaftar";
            label9.TextAlign = ContentAlignment.MiddleRight;
            label9.Visible = false;
            // 
            // ComboKendaraan
            // 
            ComboKendaraan.BackColor = Color.White;
            ComboKendaraan.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            ComboKendaraan.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            ComboKendaraan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.Location = new Point(49, 244);
            ComboKendaraan.Name = "ComboKendaraan";
            ComboKendaraan.Size = new Size(383, 44);
            ComboKendaraan.Style.EditorStyle.BackColor = Color.White;
            ComboKendaraan.Style.EditorStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            ComboKendaraan.Style.ReadOnlyEditorStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            ComboKendaraan.Style.TokenStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(TextTahun);
            panel10.Location = new Point(49, 435);
            panel10.Name = "panel10";
            panel10.Size = new Size(383, 44);
            panel10.TabIndex = 5;
            // 
            // TextTahun
            // 
            TextTahun.BackColor = Color.White;
            TextTahun.BorderStyle = BorderStyle.None;
            TextTahun.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTahun.Location = new Point(4, 10);
            TextTahun.Name = "TextTahun";
            TextTahun.Size = new Size(373, 23);
            TextTahun.TabIndex = 49;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(TextKapasitasMesin);
            panel11.Location = new Point(49, 342);
            panel11.Name = "panel11";
            panel11.Size = new Size(383, 44);
            panel11.TabIndex = 4;
            // 
            // TextKapasitasMesin
            // 
            TextKapasitasMesin.BackColor = Color.White;
            TextKapasitasMesin.BorderStyle = BorderStyle.None;
            TextKapasitasMesin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextKapasitasMesin.Location = new Point(4, 10);
            TextKapasitasMesin.Name = "TextKapasitasMesin";
            TextKapasitasMesin.Size = new Size(373, 23);
            TextKapasitasMesin.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(49, 407);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 65;
            label3.Text = "Tahun";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(TextMerek);
            panel8.Location = new Point(49, 151);
            panel8.Name = "panel8";
            panel8.Size = new Size(383, 44);
            panel8.TabIndex = 2;
            // 
            // TextMerek
            // 
            TextMerek.BackColor = Color.White;
            TextMerek.BorderStyle = BorderStyle.None;
            TextMerek.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextMerek.Location = new Point(4, 10);
            TextMerek.Name = "TextMerek";
            TextMerek.Size = new Size(373, 23);
            TextMerek.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(49, 314);
            label8.Name = "label8";
            label8.Size = new Size(178, 25);
            label8.TabIndex = 64;
            label8.Text = "Kapasitas Mesin (cc)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(49, 216);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 61;
            label4.Text = "Transmisi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(49, 123);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 60;
            label5.Text = "Merek";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(TextNoPolisi);
            panel9.Location = new Point(49, 61);
            panel9.Name = "panel9";
            panel9.Size = new Size(383, 44);
            panel9.TabIndex = 1;
            // 
            // TextNoPolisi
            // 
            TextNoPolisi.BackColor = Color.White;
            TextNoPolisi.BorderStyle = BorderStyle.None;
            TextNoPolisi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextNoPolisi.Location = new Point(4, 10);
            TextNoPolisi.Name = "TextNoPolisi";
            TextNoPolisi.Size = new Size(373, 23);
            TextNoPolisi.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(49, 33);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 57;
            label6.Text = "No. Polisi";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.None;
            ButtonSimpan.BackColor = Color.LimeGreen;
            ButtonSimpan.BackgroundColor = Color.LimeGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(889, 615);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(135, 45);
            ButtonSimpan.TabIndex = 4;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
            // 
            // ButtonBatal
            // 
            ButtonBatal.Anchor = AnchorStyles.None;
            ButtonBatal.BackColor = Color.Red;
            ButtonBatal.BackgroundColor = Color.Red;
            ButtonBatal.BorderColor = Color.DarkGray;
            ButtonBatal.BorderRadius = 5;
            ButtonBatal.BorderSize = 0;
            ButtonBatal.FlatAppearance.BorderSize = 0;
            ButtonBatal.FlatStyle = FlatStyle.Flat;
            ButtonBatal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatal.ForeColor = Color.White;
            ButtonBatal.Location = new Point(742, 615);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 3;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(LabelNoKTP);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(36, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 561);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // LabelNoKTP
            // 
            LabelNoKTP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoKTP.ForeColor = Color.Red;
            LabelNoKTP.Location = new Point(225, 33);
            LabelNoKTP.Name = "LabelNoKTP";
            LabelNoKTP.Size = new Size(205, 23);
            LabelNoKTP.TabIndex = 56;
            LabelNoKTP.Text = "Nomor KTP tidak ditemukan";
            LabelNoKTP.TextAlign = ContentAlignment.MiddleRight;
            LabelNoKTP.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextTelepon);
            panel7.Location = new Point(47, 244);
            panel7.Name = "panel7";
            panel7.Size = new Size(383, 44);
            panel7.TabIndex = 3;
            // 
            // TextTelepon
            // 
            TextTelepon.BackColor = Color.White;
            TextTelepon.BorderStyle = BorderStyle.None;
            TextTelepon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTelepon.Location = new Point(4, 10);
            TextTelepon.Name = "TextTelepon";
            TextTelepon.Size = new Size(373, 23);
            TextTelepon.TabIndex = 49;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextNama);
            panel6.Location = new Point(47, 151);
            panel6.Name = "panel6";
            panel6.Size = new Size(383, 44);
            panel6.TabIndex = 2;
            // 
            // TextNama
            // 
            TextNama.BackColor = Color.White;
            TextNama.BorderStyle = BorderStyle.None;
            TextNama.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextNama.Location = new Point(4, 10);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(373, 23);
            TextNama.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(47, 216);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 53;
            label2.Text = "Telepon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(47, 123);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 51;
            label7.Text = "Nama";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextNomorKTP);
            panel2.Location = new Point(47, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 44);
            panel2.TabIndex = 1;
            // 
            // TextNomorKTP
            // 
            TextNomorKTP.BackColor = Color.White;
            TextNomorKTP.BorderStyle = BorderStyle.None;
            TextNomorKTP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextNomorKTP.Location = new Point(4, 10);
            TextNomorKTP.Name = "TextNomorKTP";
            TextNomorKTP.PlaceholderText = "🔍 Cari berdasarkan nomor KTP ";
            TextNomorKTP.Size = new Size(373, 23);
            TextNomorKTP.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(47, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 43;
            label1.Text = "No. KTP";
            // 
            // InputEditKendaraan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputEditKendaraan";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ComboKendaraan).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private TextBox TextNomorKTP;
        private Panel panel4;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private Label label2;
        private Label label7;
        private Panel panel7;
        private TextBox TextTelepon;
        private Panel panel6;
        private TextBox TextNama;
        private Label LabelNoKTP;
        private Panel panel10;
        private TextBox TextTahun;
        private Panel panel11;
        private TextBox TextKapasitasMesin;
        private Label label3;
        private Panel panel8;
        private TextBox TextMerek;
        private Label label8;
        private Label label4;
        private Label label5;
        private Panel panel9;
        private TextBox TextNoPolisi;
        private Label label6;
        private Syncfusion.WinForms.ListView.SfComboBox ComboKendaraan;
        private Label label9;
    }
}