﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchizitia
{
    public partial class frmAddEvents : Form
    {
        public frmAddEvents()
        {
            InitializeComponent();
        }

        public frmMain fm;

        private void frmAddEvents_Load(object sender, EventArgs e)
        {
            fm.Show();
            this.Hide();
        }
    }
}
