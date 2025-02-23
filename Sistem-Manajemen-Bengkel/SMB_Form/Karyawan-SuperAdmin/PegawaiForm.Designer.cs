﻿namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm
{
    partial class PegawaiForm
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
            Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo gridBordersInfo1 = new Syncfusion.WinForms.DataGrid.Styles.GridBordersInfo();
            PanelBooking = new SMB_CustomTolbox.LathifPanel();
            label7 = new Label();
            lathifButton1 = new SMB_CustomTolbox.LathifButton();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            GridListBooking = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            PanelBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListBooking).BeginInit();
            SuspendLayout();
            // 
            // PanelBooking
            // 
            PanelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelBooking.BackColor = Color.White;
            PanelBooking.BorderColor = Color.PaleVioletRed;
            PanelBooking.BorderRadius = 15;
            PanelBooking.BorderSize = 0;
            PanelBooking.Controls.Add(textBoxExt1);
            PanelBooking.Controls.Add(GridListBooking);
            PanelBooking.Controls.Add(label7);
            PanelBooking.Controls.Add(lathifButton1);
            PanelBooking.ForeColor = Color.White;
            PanelBooking.Location = new Point(11, 12);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1059, 679);
            PanelBooking.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(5, 15);
            label7.Name = "label7";
            label7.Size = new Size(207, 42);
            label7.TabIndex = 16;
            label7.Text = "\U0001f9d1‍🔧  Karyawan";
            // 
            // lathifButton1
            // 
            lathifButton1.BackColor = Color.MediumSlateBlue;
            lathifButton1.BackgroundColor = Color.MediumSlateBlue;
            lathifButton1.BorderColor = Color.DarkGray;
            lathifButton1.BorderRadius = 5;
            lathifButton1.BorderSize = 0;
            lathifButton1.FlatAppearance.BorderSize = 0;
            lathifButton1.FlatStyle = FlatStyle.Flat;
            lathifButton1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lathifButton1.ForeColor = Color.White;
            lathifButton1.Location = new Point(25, 120);
            lathifButton1.Name = "lathifButton1";
            lathifButton1.Size = new Size(135, 45);
            lathifButton1.TabIndex = 15;
            lathifButton1.Text = "➕ Tambah ";
            lathifButton1.TextColor = Color.White;
            lathifButton1.UseVisualStyleBackColor = false;
            // 
            // textBoxExt1
            // 
            textBoxExt1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxExt1.BeforeTouchSize = new Size(362, 34);
            textBoxExt1.Border3DStyle = Border3DStyle.Bump;
            textBoxExt1.BorderColor = Color.DimGray;
            textBoxExt1.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt1.FocusBorderColor = Color.Black;
            textBoxExt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExt1.Location = new Point(677, 131);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.PlaceholderText = "🔍   Search";
            textBoxExt1.Size = new Size(362, 34);
            textBoxExt1.TabIndex = 20;
            // 
            // GridListBooking
            // 
            GridListBooking.AccessibleName = "Table";
            GridListBooking.AllowEditing = false;
            GridListBooking.AllowGrouping = false;
            GridListBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListBooking.Location = new Point(18, 185);
            GridListBooking.Name = "GridListBooking";
            GridListBooking.PreviewRowHeight = 35;
            GridListBooking.ShowToolTip = true;
            GridListBooking.Size = new Size(1023, 439);
            GridListBooking.Style.AddNewRowStyle.Borders = gridBordersInfo1;
            GridListBooking.Style.AddNewRowStyle.VerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            GridListBooking.Style.Border3DStyle = Border3DStyle.Flat;
            GridListBooking.Style.BorderColor = Color.Silver;
            GridListBooking.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            GridListBooking.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            GridListBooking.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            GridListBooking.Style.CurrentCellStyle.BackColor = Color.White;
            GridListBooking.Style.CurrentCellStyle.BorderColor = Color.White;
            GridListBooking.Style.HeaderStyle.BackColor = Color.Gainsboro;
            GridListBooking.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            GridListBooking.TabIndex = 19;
            GridListBooking.Text = "sfDataGrid1";
            // 
            // KaryawanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(PanelBooking);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "KaryawanForm";
            PanelBooking.ResumeLayout(false);
            PanelBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridListBooking).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SMB_CustomTolbox.LathifPanel PanelBooking;
        private SMB_CustomTolbox.LathifButton lathifButton1;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridListBooking;
    }
}