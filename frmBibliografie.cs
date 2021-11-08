using System;
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
    public partial class frmBibliografie : Form
    {
        public frmBibliografie()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void frmBibliografie_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmBibliografie_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmBibliografie_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.fb = null;
        }

        private void pbCloseLectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBibliografie_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
        }
    }
}
