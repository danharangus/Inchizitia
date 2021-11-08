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
using System.IO;

namespace Inchizitia
{
    public partial class frmPanouLectii : Form
    {
        public frmPanouLectii()
        {
            InitializeComponent();
        }

        public static frmLectie flec;
        public static frmAddLec fal;

        public static int nrLab = 0;
        public string[] lec = new string[1024];

        public int C = 0;

        public static bool[] open = new bool[1024];


        public void SelectLes()
        {

            string link = variabile.site + "/selectLectii.php?passw=" + variabile.passw;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            
            try
            {
                webResponse = webRequest.GetResponse();
                inStream = new StreamReader(webResponse.GetResponseStream());
                string s = inStream.ReadToEnd();
                lec = s.Split('`');
                inStream.Close();
            }
            catch
            {
                MessageBox.Show("Lectile nu s-au incarcat corect!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }



        }

        public void FillLabels()
        {
            for (int i = C * 8; i < C * 8 + 9; i++)
            {
                try
                {
                    if (lec[i] != "")
                    {
                        nrLab++;
                        this.Controls["label" + nrLab.ToString()].Text = lec[i];
                        this.Controls["label" + nrLab.ToString()].Visible = true;
                    }
                    else
                        break;
                }
                catch
                {
                    break;
                }
            }
        }

        public void HideLabels()
        {
            for (int i = 1; i < 9; i++)
            {
                this.Controls["label" + i.ToString()].Visible = false;
            }
        }

        private void frmPanouLectii_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);

            SelectLes();
            HideLabels();
            FillLabels();

            if (lec.Count() <= 9)
                pbPrev.Visible = pbPrev.Visible = false;
        }

        Point lastPoint;

        private void frmPanouLectii_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmPanouLectii_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void frmPanouLectii_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.PanouLectii = null;
            nrLab = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (fal == null)
            {
                fal = new frmAddLec();
                fal.Show();
                this.Close();
            }
        }

        public bool isDigit(char c)
        {
            return (c >= '1' && c <= '9');
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenClick(object sender, EventArgs e)
        {
            Label l = sender as Label;

            variabile.TitluLectiei = l.Text;

            string s = l.Name;

            int i = 0;

            while (!isDigit(s[i]))
            {
                i++;
            }

            string nr = "";

            for (int j = i; j < s.Length; j++)
            {
                nr += s[j];
            }

            variabile.nrLec = nr;

            if (!open[int.Parse(nr)])
            {
                open[int.Parse(nr)] = true;
                flec = new frmLectie();
                flec.Show();
                this.Hide();
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label l = sender as Label;

                variabile.TitluLectiei = l.Text;

                string s = l.Name;

                int i = 0;

                while (!isDigit(s[i]))
                {
                    i++;
                }

                string nr = "";

                for (int j = i; j < s.Length; j++)
                {
                    nr += s[j];
                }

                variabile.nrLec = nr;

                if (!open[int.Parse(nr)])
                {
                    open[int.Parse(nr)] = true;
                    flec = new frmLectie();
                    flec.Show();
                }

            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            nrLab = 0;
            C++;

            int a = 0;

            if (lec.Count() % 8 == 0)
                a = 1;

            C %= (lec.Count() / 8) + 1 - a;

            HideLabels();
            FillLabels();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            nrLab = 0;
            C--;

            int a = 0;

            if (lec.Count() % 8 == 0)
                a = 1;

            if (C < 0)
                C = (lec.Count() / 8) - a;

            HideLabels();
            FillLabels();
        }

        private void pbClosePanouLectii_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
