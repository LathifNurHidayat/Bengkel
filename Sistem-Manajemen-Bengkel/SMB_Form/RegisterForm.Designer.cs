﻿namespace Sistem_Manajemen_Bengkel.SMB_Form.LoginRegister
{
    partial class RegisterForm
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
            LabelConfirmPass = new Label();
            label9 = new Label();
            panel6 = new Panel();
            TextConfirmPassword = new TextBox();
            LabelEmail = new Label();
            LabelNoHP = new Label();
            LabelNIK = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            TextNIK = new TextBox();
            panel9 = new Panel();
            TextNomorHP = new TextBox();
            panel7 = new Panel();
            TextPassword = new TextBox();
            panel2 = new Panel();
            TextEmail = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            TextAlamat = new TextBox();
            panel3 = new Panel();
            TextNamaLengkap = new TextBox();
            LinkMasuk = new LinkLabel();
            label1 = new Label();
            ButtonDaftar = new Button();
            LabelPassword = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LabelPassword);
            panel1.Controls.Add(LabelConfirmPass);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(LabelEmail);
            panel1.Controls.Add(LabelNoHP);
            panel1.Controls.Add(LabelNIK);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(LinkMasuk);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ButtonDaftar);
            panel1.Location = new Point(27, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 646);
            panel1.TabIndex = 2;
            // 
            // LabelConfirmPass
            // 
            LabelConfirmPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelConfirmPass.ForeColor = Color.Red;
            LabelConfirmPass.Location = new Point(365, 477);
            LabelConfirmPass.Name = "LabelConfirmPass";
            LabelConfirmPass.Size = new Size(205, 23);
            LabelConfirmPass.TabIndex = 29;
            LabelConfirmPass.Text = "Password tidak valid";
            LabelConfirmPass.TextAlign = ContentAlignment.MiddleRight;
            LabelConfirmPass.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 477);
            label9.Name = "label9";
            label9.Size = new Size(149, 23);
            label9.TabIndex = 28;
            label9.Text = "Confirm Password";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextConfirmPassword);
            panel6.Location = new Point(18, 503);
            panel6.Name = "panel6";
            panel6.Size = new Size(552, 41);
            panel6.TabIndex = 27;
            // 
            // TextConfirmPassword
            // 
            TextConfirmPassword.BorderStyle = BorderStyle.None;
            TextConfirmPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextConfirmPassword.Location = new Point(6, 7);
            TextConfirmPassword.Name = "TextConfirmPassword";
            TextConfirmPassword.Size = new Size(538, 24);
            TextConfirmPassword.TabIndex = 6;
            TextConfirmPassword.Tag = "ConfirmPassword";
            // 
            // LabelEmail
            // 
            LabelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.ForeColor = Color.Red;
            LabelEmail.Location = new Point(365, 322);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(205, 23);
            LabelEmail.TabIndex = 26;
            LabelEmail.Text = "Email sudah terdaftar";
            LabelEmail.TextAlign = ContentAlignment.MiddleRight;
            LabelEmail.Visible = false;
            // 
            // LabelNoHP
            // 
            LabelNoHP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoHP.ForeColor = Color.Red;
            LabelNoHP.Location = new Point(365, 85);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(205, 23);
            LabelNoHP.TabIndex = 25;
            LabelNoHP.Text = "Nomor HP sudah terdaftar";
            LabelNoHP.TextAlign = ContentAlignment.MiddleRight;
            LabelNoHP.Visible = false;
            // 
            // LabelNIK
            // 
            LabelNIK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNIK.ForeColor = Color.Red;
            LabelNIK.Location = new Point(87, 84);
            LabelNIK.Name = "LabelNIK";
            LabelNIK.Size = new Size(199, 23);
            LabelNIK.TabIndex = 24;
            LabelNIK.Text = "NIK sudah terdaftar";
            LabelNIK.TextAlign = ContentAlignment.MiddleRight;
            LabelNIK.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(18, 162);
            label8.Name = "label8";
            label8.Size = new Size(126, 23);
            label8.TabIndex = 23;
            label8.Text = "Nama Lengkap";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 242);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 22;
            label7.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(18, 322);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 21;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 400);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 20;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(302, 84);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 19;
            label4.Text = "No. HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 84);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 18;
            label3.Text = "No. KTP";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TextNIK);
            panel5.Location = new Point(18, 110);
            panel5.Name = "panel5";
            panel5.Size = new Size(268, 41);
            panel5.TabIndex = 17;
            // 
            // TextNIK
            // 
            TextNIK.BorderStyle = BorderStyle.None;
            TextNIK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNIK.Location = new Point(6, 7);
            TextNIK.Name = "TextNIK";
            TextNIK.Size = new Size(251, 24);
            TextNIK.TabIndex = 0;
            TextNIK.Tag = "NIK";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(TextNomorHP);
            panel9.Location = new Point(302, 110);
            panel9.Name = "panel9";
            panel9.Size = new Size(268, 41);
            panel9.TabIndex = 16;
            // 
            // TextNomorHP
            // 
            TextNomorHP.BorderStyle = BorderStyle.None;
            TextNomorHP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNomorHP.Location = new Point(6, 7);
            TextNomorHP.Name = "TextNomorHP";
            TextNomorHP.Size = new Size(254, 24);
            TextNomorHP.TabIndex = 1;
            TextNomorHP.Tag = "HP";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextPassword);
            panel7.Location = new Point(18, 426);
            panel7.Name = "panel7";
            panel7.Size = new Size(552, 41);
            panel7.TabIndex = 14;
            // 
            // TextPassword
            // 
            TextPassword.BorderStyle = BorderStyle.None;
            TextPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPassword.Location = new Point(6, 7);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(538, 24);
            TextPassword.TabIndex = 5;
            TextPassword.Tag = "Password";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextEmail);
            panel2.Location = new Point(18, 348);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 41);
            panel2.TabIndex = 10;
            // 
            // TextEmail
            // 
            TextEmail.BorderStyle = BorderStyle.None;
            TextEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.Location = new Point(6, 7);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(538, 24);
            TextEmail.TabIndex = 4;
            TextEmail.Tag = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(82, 109, 130);
            label2.Location = new Point(240, 17);
            label2.Name = "label2";
            label2.Size = new Size(117, 35);
            label2.TabIndex = 9;
            label2.Text = "DAFTAR";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TextAlamat);
            panel4.Location = new Point(18, 268);
            panel4.Name = "panel4";
            panel4.Size = new Size(552, 41);
            panel4.TabIndex = 1;
            // 
            // TextAlamat
            // 
            TextAlamat.BorderStyle = BorderStyle.None;
            TextAlamat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextAlamat.Location = new Point(6, 7);
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(538, 24);
            TextAlamat.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextNamaLengkap);
            panel3.Location = new Point(18, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 41);
            panel3.TabIndex = 0;
            // 
            // TextNamaLengkap
            // 
            TextNamaLengkap.BorderStyle = BorderStyle.None;
            TextNamaLengkap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNamaLengkap.Location = new Point(6, 8);
            TextNamaLengkap.Name = "TextNamaLengkap";
            TextNamaLengkap.Size = new Size(538, 24);
            TextNamaLengkap.TabIndex = 2;
            // 
            // LinkMasuk
            // 
            LinkMasuk.AutoSize = true;
            LinkMasuk.Location = new Point(341, 609);
            LinkMasuk.Name = "LinkMasuk";
            LinkMasuk.Size = new Size(51, 20);
            LinkMasuk.TabIndex = 8;
            LinkMasuk.TabStop = true;
            LinkMasuk.Text = "Masuk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 609);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 8;
            label1.Text = "Sudah memiliki akun ?";
            // 
            // ButtonDaftar
            // 
            ButtonDaftar.BackColor = Color.FromArgb(82, 109, 130);
            ButtonDaftar.FlatAppearance.BorderSize = 0;
            ButtonDaftar.FlatStyle = FlatStyle.Flat;
            ButtonDaftar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonDaftar.ForeColor = Color.White;
            ButtonDaftar.Location = new Point(18, 556);
            ButtonDaftar.Name = "ButtonDaftar";
            ButtonDaftar.Size = new Size(552, 45);
            ButtonDaftar.TabIndex = 7;
            ButtonDaftar.Text = "Daftar";
            ButtonDaftar.UseVisualStyleBackColor = false;
            // 
            // LabelPassword
            // 
            LabelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.ForeColor = Color.Red;
            LabelPassword.Location = new Point(152, 401);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(418, 23);
            LabelPassword.TabIndex = 30;
            LabelPassword.Text = "Harus berupa kombinasi huruf besar/kecil, dan angka";
            LabelPassword.TextAlign = ContentAlignment.MiddleRight;
            LabelPassword.Visible = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(641, 699);
            Controls.Add(panel1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Panel panel4;
        private TextBox TextAlamat;
        private Panel panel3;
        private TextBox TextNamaLengkap;
        private LinkLabel LinkMasuk;
        private Label label1;
        private Button ButtonDaftar;
        private PictureBox pictureBox5;
        private Panel panel2;
        private TextBox TextEmail;
        private Panel panel7;
        private TextBox TextPassword;
        private Panel panel5;
        private TextBox TextNIK;
        private Panel panel9;
        private TextBox TextNomorHP;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label LabelNIK;
        private Label LabelEmail;
        private Label LabelNoHP;
        private Label LabelConfirmPass;
        private Label label9;
        private Panel panel6;
        private TextBox TextConfirmPassword;
        private Label LabelPassword;
    }
}