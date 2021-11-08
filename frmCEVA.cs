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
    public partial class frmCEVA : Form
    {
        public frmCEVA()
        {
            InitializeComponent();
        }

        public static frmAddLec fal;
        public static frmAddIntrebare fi;
        public static frmChangeLess fcl;

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
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string s = inStream.ReadToEnd();

            lec = s.Split('`');


            inStream.Close();
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
           for(int i = 1; i < 9; i++)
            {
                this.Controls["label" + i.ToString()].Visible = false;
            }
        }

        private void frmPanouLectii_Load(object sender, EventArgs e)
        {
            SelectLes();
            HideLabels();
            FillLabels();

            int a = 0;

            if (lec.Count() <= 9)
                btnPrev.Visible = btnNext.Visible = false;

            if (lec.Count() % 8 == 0)
                a = 1;

            
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
            frmMain.fadmin = null;
            nrLab = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(fal == null)
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

        int c = 0;

        public List < string > lab = new List < string >();

        private void DeleteClick(object sender, EventArgs e)
        {
            Label l = sender as Label;

            l.ForeColor = Color.Red;

            lab.Add(l.Text);
        }

        private void pbDel_Click(object sender, EventArgs e)
        {       
            c++;

            if (c % 2 == 0)
                lblText.Text = "Select";
            else
                lblText.Text = "Delete";
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void lblConf_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sunteti sigur ca doriti sa stergeti lectiile selectate?", "", MessageBoxButtons.YesNoCancel))
            {
                for(int i = 0; i < lab.Count; i++)
                {
                    ///script de delete in php 

                    string link = variabile.site + "/deleteLec.php?passw=" + variabile.passw + "&tit=" + lab[i];

                    WebRequest webRequest;
                    WebResponse webResponse;
                    webRequest = WebRequest.Create(link);
                    webResponse = webRequest.GetResponse();

                    File.Delete(variabile.dirPath + "/ImaginiLectii/" + lab[i]);
                }

                nrLab = 0;

                lab.Clear();


                for(int i = 0; i < lec.Count(); i++)
                {
                    lec.SetValue("", i);
                }

                ///update la lectiile ramase (pui in labele lectiile)  

                for (int i = 1; i < 9; i++)
                {
                    this.Controls["label" + i.ToString()].ForeColor = Color.Black;
                }

                SelectLes();
                HideLabels();
                FillLabels();

                

                c = 0;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nrLab = 0;
            C++;

            int a = 0;

            if (lec.Count() % 8 == 0)
                a = 1;

            C %= (lec.Count() / 8) + 1  - a;

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

        private void label1_Click(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (c % 2 == 0)
            {
                variabile.lectie = l.Text;

                fi = new frmAddIntrebare();
                fi.Show();
            }
            else
            {
                if (l.ForeColor == Color.Black)
                {
                    l.ForeColor = Color.Red;
                    lab.Add(l.Text);
                }
                else
                {
                    l.ForeColor = Color.Black;
                    lab.Remove(l.Text);
                }
            }
        }

        private void lblChangeLess_Click(object sender, EventArgs e)
        {
            if(fcl == null)
            {
                fcl = new frmChangeLess();
                fcl.Show();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
