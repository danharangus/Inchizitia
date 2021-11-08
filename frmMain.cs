using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Media;

namespace Inchizitia
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static frmPanouLectii PanouLectii;
        public static frmLogin Login;
        public static frmRegister Register;
        public static frmEvaluare Evaluare;
        public static frmAdmin fadmin;
        public static frmBibliografie fb;
        public static frmHelp fhelp;
        public static frmProfile fuser;
        Point lastPoint;



        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        public SoundPlayer player = new SoundPlayer();

        private void frmMain_Load(object sender, EventArgs e)
        {
            variabile.Main = this;

            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);

            try
            {
                player.SoundLocation = variabile.dirPath + "\\muzica.wav";
                player.PlayLooping();
            }
            catch
            {

            }
        }

        private void lblLectii_Click(object sender, EventArgs e)
        {
            if (PanouLectii == null)
            {
                PanouLectii = new frmPanouLectii();
                PanouLectii.Show();
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            if (Login == null)
            {
                Login = new frmLogin();
                Login.Tag = this;
                Login.Show();
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            if (Register == null)
            {
                Register = new frmRegister();
                Register.Tag = this;
                Register.Show();
            }
        }

        private void closeMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblEvaluare_Click(object sender, EventArgs e)
        {
            if (Evaluare == null)
            {
                Evaluare = new frmEvaluare();
                Evaluare.Show();
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pbInchizitor.Image = new Bitmap("Icons\\inchizitor sus.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pbInchizitor.Image = new Bitmap("Icons\\inchizitor sus mijloc.png");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pbInchizitor.Image = new Bitmap("Icons\\inchizitor jos mijloc.png");
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pbInchizitor.Image = new Bitmap("Icons\\inchizitor jos.png");
        }

        private void pbAdmin_Click(object sender, EventArgs e)
        {
            if (fadmin == null)
            {
                fadmin = new frmAdmin();
                fadmin.Show();
            }
        }

        int muzica = 0;

        private void pb_Click(object sender, EventArgs e)
        {
            if (muzica % 2 == 0)
            {
                pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\MusicOff.png");
                player.Stop();
            }
            else
            {
                pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\MusicOn.png");
                player.PlayLooping();
            }

            muzica++;

        }

        private void pbDeconectare_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteți sigur că vreți să vă deconectați?", "Deconectare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                variabile.tip = "";
                variabile.NumeUtilizator = "";

                pbLogin.Visible = pbInregistrare.Visible = true;
                variabile.logat = pbDeconectare.Visible = pbEvaluare.Visible = pbAdmin.Visible = pbUser.Visible = false;
            }
        }

        private void pbBibliografie_Click(object sender, EventArgs e)
        {
            if (fb == null)
            {
                fb = new frmBibliografie();
                fb.Show();
            }
        }

        private void pbAdmin_MouseEnter(object sender, EventArgs e)
        {
            pbInchizitor.Image = new Bitmap("Icons\\inchizitor jos jos.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (fhelp == null)
            {
                fhelp = new frmHelp();
                fhelp.Show();
            }
        }

        private void pbCloseLectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (fuser == null)
            {
                fuser = new frmProfile();
                fuser.Show();
            }
        }
    }
}
