using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchizitia
{
    public partial class frmJocImagini : Form
    {
        public frmJocImagini()
        {
            InitializeComponent();
        }


        Point LastPoint;

        private void frmJocImagini_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void pbCloseJocImagini_Click(object sender, EventArgs e)
        {
            Close();
        }

        public List<string> path = new List<string>();
        public List<string> desc = new List<string>();
        public List<string> titlu = new List<string>();

        public static int nrImg;
        public static bool[] ap = new bool[1000];

        public static void SelectImagini(List<string> path, List<string> desc, List<string> titlu)
        {
            string link = variabile.site + "/selectJocImg.php?passw=" + variabile.passw;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string s = inStream.ReadToEnd();
            inStream.Close();



            string[] cuv = s.Split('`');

            for (int i = 0; i < cuv.Length - 2; i += 3)
            {
                path.Add(cuv[i]);
                desc.Add(cuv[i + 1]);
                titlu.Add(cuv[i + 2]);
            }

        }

        public static int[] index = new int[10];

        private void frmJocImagini_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
            ap = new bool[1000];

            SelectImagini(path, desc, titlu);
            nrImg = path.Count;


            Random r = new Random();
            int nr;
            // cb1.Items.Add("a");
            int c = 1;
            for (int i = 1; i <= nrImg && c <= 6; i++)
            {
                
                nr = r.Next(0, nrImg);

                while (ap[nr])
                {
                    nr = r.Next(0, nrImg);
                }

                ap[nr] = true;

                if (File.Exists("ImaginiLectii\\" + titlu[nr] + "\\" + path[nr]))
                {
                    (Controls["pb" + c.ToString()] as PictureBox).Image = new Bitmap("ImaginiLectii\\" + titlu[nr] + "\\" + path[nr]);
                    index[c] = nr;

                    for (int j = 0; j < desc.Count; j++)
                    {
                        (Controls["cb" + i.ToString()] as ComboBox).Items.Add(desc[j]);
                    }
                    c++;
                }
            }

        }

        private void frmJocImagini_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void frmJocImagini_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEvaluare.JocImagini = null;
          //  frmMain.Evaluare.Show();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Atentie! După verificare răspunsurile nu mai pot fi modificate! Sunteţi sigur?", "Verificare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int punctaj = 0;
                for (int i = 1; i <= 6; i++)
                {
                    this.Controls["p" + i.ToString()].Visible = true;

                    if ((Controls["cb" + i.ToString()] as ComboBox).SelectedItem != null)
                    {
                        if (desc[index[i]] == (Controls["cb" + i.ToString()] as ComboBox).SelectedItem.ToString())
                        {
                            punctaj++;       
                            (this.Controls["p" + i.ToString()] as PictureBox).Image = Image.FromFile(variabile.dirPath + "/Icons/corect.png");
                        }
                        else
                        {
                            (this.Controls["p" + i.ToString()] as PictureBox).Image = Image.FromFile(variabile.dirPath + "/Icons/wrong.png");
                        }
                    }
                    else
                    {
                        (this.Controls["p" + i.ToString()] as PictureBox).Image = Image.FromFile(variabile.dirPath + "/Icons/wrong.png");
                    }


                    (Controls["cb" + i.ToString()] as ComboBox).Enabled = false;
                }

                MessageBox.Show("Aţi obţinut " + punctaj + " puncte!", "", MessageBoxButtons.OK);
                btnCheck.Enabled = false;
            }
        }
    }



}
