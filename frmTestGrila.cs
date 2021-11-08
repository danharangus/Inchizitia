using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchizitia
{
    public partial class frmTestGrila : Form
    {
        public frmTestGrila()
        {
            InitializeComponent();
        }

        public int nrIntrebare = 0;


        public string[] intrebare = new string[1000];
        public string[] var_a = new string[1000];
        public string[] var_b = new string[1000];
        public string[] var_c = new string[1000];
        public string[] lectie = new string[1000];
        public string[] corect = new string[1000];
        public string[] selectat = new string[1000];
        public int[] index = new int[1000]; // iti trebe un vector unde retii intreabrile luat "random" din baza pentru ca trebe sa avem un buton de next si prev
        public bool[] viz = new bool[1000];

        public int total  = 0;

        private void Select()
        {
            string link = String.Format(variabile.site + "/selectIntrebari.php?passw=" + variabile.passw);
            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string response = inStream.ReadToEnd();
            inStream.Close();


            string[] cuvinte = Regex.Split(response, "~");

            int j = 0;
            for(int i = 0; i < cuvinte.Length - 6; i+=6)
            {
             //   MessageBox.Show("ok");
                bool OK = false;
                foreach (string str in variabile.lectiiTest)
                {
                    if (str == cuvinte[i + 4])
                    {
                        OK = true;
                    }
                }
                if (OK)
                {
                    intrebare[j] = cuvinte[i];
                    var_a[j] = cuvinte[i + 1];
                    var_b[j] = cuvinte[i + 2];
                    var_c[j] = cuvinte[i + 3];
                    lectie[j] = cuvinte[i + 4];
                    corect[j] = cuvinte[i + 5];
                    j++;
                  //  MessageBox.Show(intrebare[j] + " " + var_a[j] + " " + var_b[j] + " " + var_c[j] + " " + lectie[j] + " " + corect[j] + " ");
                }
            }

            total = j;

        }

        

        private void closeTestGrila_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point LastPoint;

        private void frmTestGrila_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmTestGrila_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void frmTestGrila_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLectiiTest.testGrila = null;
            frmEvaluare.TestGrila = null;
        }

        private void frmTestGrila_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);

            Select();

            if(total == 0)
            {
                MessageBox.Show("Eroare: Lecţiile selectate nu conţin nicio întrebare!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (total == 0)
            {
                btnNext.Enabled = false;
                btnBack.Enabled = false;
                btnCheck.Enabled = false;
            }

            Random r = new Random();

            //avem total - 1 intrebari deeeci in index retinem nrIntreabarilor

            if(total > 10)
            {
                total = 10;
            }

            for (int nrIntrebare = 0; nrIntrebare < total; nrIntrebare++)
            {
                int a = r.Next(0, total - 1); // luam un numar random

                

                while (viz[a])
                {
                    a = r.Next(0, total);
                }
                viz[a] = true;


                index[nrIntrebare] = a;
            }

            nrIntrebare = 0;
            lblIntrebare.Text = intrebare[index[nrIntrebare]];
            rb1.Text = var_a[index[nrIntrebare]];
            rb2.Text = var_b[index[nrIntrebare]];
            rb3.Text = var_c[index[nrIntrebare]];

        }

        private void lblIntrebare_Click(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
                selectat[index[nrIntrebare]] = "a";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
                selectat[index[nrIntrebare]] = "b";

        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if(rb3.Checked)
            selectat[index[nrIntrebare]] = "c";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(btnCheck.Enabled == false)
            {
                if(selectat[index[nrIntrebare]] == corect[index[nrIntrebare]])
                    pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\corect.png");
                else
                    pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\wrong.png");
            }

            if(nrIntrebare >= total-1)
            {
                nrIntrebare = 0;
            }
            else
            {
                nrIntrebare++;
            }

            lblIntrebare.Text = intrebare[index[nrIntrebare]];
            rb1.Text = var_a[index[nrIntrebare]];
            rb2.Text = var_b[index[nrIntrebare]];
            rb3.Text = var_c[index[nrIntrebare]];

            if (selectat[index[nrIntrebare]] == null)
            {
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
            }
            else
            {
                if (selectat[index[nrIntrebare]] == "a")
                {
                    rb1.Checked = true;
                }
                else if (selectat[index[nrIntrebare]] == "b")
                {
                    rb2.Checked = true;
                }
                else
                {
                    rb3.Checked = true;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnCheck.Enabled == false)
            {
                if (selectat[index[nrIntrebare]] == corect[index[nrIntrebare]])
                    pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\corect.png");
                else
                    pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\wrong.png");
            }

            if (nrIntrebare <= 0)
            {
                nrIntrebare = total - 1;
            }
            else
            {
                nrIntrebare--;
            }
            lblIntrebare.Text = intrebare[index[nrIntrebare]];
            rb1.Text = var_a[index[nrIntrebare]];
            rb2.Text = var_b[index[nrIntrebare]];
            rb3.Text = var_c[index[nrIntrebare]];
            if (selectat[index[nrIntrebare]] == null)
            {
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
            }
            else
            {
                if(selectat[index[nrIntrebare]] == "a")
                {
                    rb1.Checked = true;
                }
                else if(selectat[index[nrIntrebare]] == "b")
                {
                    rb2.Checked = true;
                }
                else
                {
                    rb3.Checked = true;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int punctaj = 0;
            if(MessageBox.Show("Atentie! După verificare răspunsurile nu mai pot fi modificate! Sunteţi sigur?", "Verificare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                for(nrIntrebare=0; nrIntrebare < total; nrIntrebare++)
                {
                    if(selectat[index[nrIntrebare]] == corect[index[nrIntrebare]])
                    {
                        punctaj++;
                    }
                }
                MessageBox.Show("Aţi obţinut " + punctaj + " puncte!", "", MessageBoxButtons.OK);
                btnCheck.Enabled = false;
                rb1.Enabled = false;
                rb2.Enabled = false;
                rb3.Enabled = false;
            }

            if (selectat[index[nrIntrebare]] == corect[index[nrIntrebare]])
                pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\corect.png");
            else
                pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\wrong.png");


        }

        private void pbCloseTestGrila_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
