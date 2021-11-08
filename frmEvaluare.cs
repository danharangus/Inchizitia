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
    public partial class frmEvaluare : Form
    {
        public frmEvaluare()
        {
            InitializeComponent();
        }

        public static frmGameImg fgi;

        private void closeLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        Point LastPoint;


        private void frmEvaluare_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmEvaluare_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void lblTestGrila_MouseEnter(object sender, EventArgs e)
        {
            TGCross1.Visible = true;
            TGCross2.Visible = true;

            lblTestGrila.Font = new Font(lblTestGrila.Font.Name, lblTestGrila.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }

        private void lblTestGrila_MouseLeave(object sender, EventArgs e)
        {
            TGCross1.Visible = false;
            TGCross2.Visible = false;
            lblTestGrila.Font = new Font(lblTestGrila.Font.Name, lblTestGrila.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);
        }

        private void frmEvaluare_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Evaluare = null;
        }

        public static frmTestGrila TestGrila;
        public static frmLectiiTest LectiiTest;

        private void lblTestGrila_Click(object sender, EventArgs e)
        {

            if (LectiiTest == null)
            {
                LectiiTest = new frmLectiiTest();
                LectiiTest.Show();
                this.Close();
            }
        }

        private void lblJocImagini_MouseEnter(object sender, EventArgs e)
        {
            JICross1.Visible = true;
            JIcross2.Visible = true;
            lblJocImagini.Font = new Font(lblJocImagini.Font.Name, lblJocImagini.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }

        private void lblJocImagini_MouseLeave(object sender, EventArgs e)
        {
            JICross1.Visible = false;
            JIcross2.Visible = false;
            lblJocImagini.Font = new Font(lblJocImagini.Font.Name, lblJocImagini.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);
        }

        public static frmJocImagini JocImagini;

        private void lblJocImagini_Click(object sender, EventArgs e)
        {
            if (JocImagini == null)
            {
                JocImagini = new frmJocImagini();
                JocImagini.Show();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(fgi == null)
            {
                fgi = new frmGameImg();
                fgi.Show();
                this.Close();
            }
        }

        private void lmp_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
        }

        private void lmp_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void lmp_DragLeave(object sender, EventArgs e)
        {
            mpc1.Visible = mpc2.Visible = false;
            lmp.Font = new Font(lmp.Font.Name, lmp.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);

        }

        private void lmp_DragEnter(object sender, EventArgs e)
        {
            mpc1.Visible = mpc2.Visible = true;
            lmp.Font = new Font(lmp.Font.Name, lmp.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
    }
}
