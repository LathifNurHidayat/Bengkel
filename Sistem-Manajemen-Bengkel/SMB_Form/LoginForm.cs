﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            CustomPanel(panel1);
        }

        private void CustomPanel(Panel panel)
        {
            int cornerRadius = 20;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // kiri atas
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // kanan atas
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // kanan bawah
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // kiri bawah
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

    }
}
