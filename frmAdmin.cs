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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        public static frmAddLec fal;
        public static frmDeleteLec fdl;
        public static frmAddIntrebare fai;
        public static frmDeleteQu fdq;
        public static frmChangeLess fcl;

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
        }

        private void lblAddLec_Click(object sender, EventArgs e)
        {
            if (fal == null)
            {
                fal = new frmAddLec();
                fal.Show();
                this.Close();
            }
        }

        private void lblAddLec_MouseEnter(object sender, EventArgs e)
        {
            Label L = sender as Label;

            (this.Controls[L.Name + "1"] as PictureBox).Visible = (this.Controls[L.Name + "2"] as PictureBox).Visible = true;
            L.Font = new Font(L.Font.Name, L.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);

        }

        private void lblAddLec_MouseLeave(object sender, EventArgs e)
        {
            Label L = sender as Label;

            (this.Controls[L.Name + "1"] as PictureBox).Visible = (this.Controls[L.Name + "2"] as PictureBox).Visible = false;
            L.Font = new Font(L.Font.Name, L.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);
        }

        private void AL_Click(object sender, EventArgs e)
        {
            if(fal == null)
            {
                fal = new frmAddLec();
                fal.Show();
            }
        }

        Point lastPoint;

        private void frmAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseButtons.Left == e.Button)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SL_Click(object sender, EventArgs e)
        {
            if(fdl == null)
            {
                fdl = new frmDeleteLec();
                fdl.Show();
            }
        }

        private void AI_Click(object sender, EventArgs e)
        {
            if(fai == null)
            {
                fai = new frmAddIntrebare();
                fai.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.fadmin = null;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(fdq == null)
            {
                fdq = new frmDeleteQu();
                fdq.Show();
            }
        }

        private void pbCloseLectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ML_Click(object sender, EventArgs e)
        {
            if (fcl == null)
            {
                fcl = new frmChangeLess();
                fcl.Show();
            }
        }
    }
}
