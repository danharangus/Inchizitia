using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Inchizitia
{
    public partial class frmGameImg : Form
    {
        public frmGameImg()
        {
            InitializeComponent();
        }

        bool oke = false;

        public static int PersBest = 60 * 60 * 24 * 30;
        public static int Best = 60 * 60 * 24 * 30;
        Image im = Image.FromFile("Icons\\spate.png");
        string[] img = new string[1024];
        Image[] ims = new Image[1024];
        bool[] mar = new bool[1024];
        int[] nu = new int[1024];
        bool[] marcat = new bool[1024];
        string[] scores = new string[1024];

        private void frmGameImg_Load(object sender, EventArgs e)
        {      
            string link = variabile.site + "/selectScoreMatch.php?passw=" + variabile.passw;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string s = inStream.ReadToEnd();

            if (s == "`" || s == "")
            {
                lblB.Text = "N/A";
                SelectPerso();
                return;
            }
            scores = s.Split('`');

            for(int i = 0; i < scores.Length; i++)
            {
                try
                {
                    int a = int.Parse(scores[i]);

                    if (a < Best)
                    {
                        Best = a;
                    }
                }
                catch
                {

                }
            }

            inStream.Close();

            lblB.Text = Best.ToString();

            SelectPerso();
        }

        public void SelectPerso()
        {
            string link = variabile.site + "/selectPersoScore.php?passw=" + variabile.passw + "&name=" + variabile.NumeUtilizator;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string s = inStream.ReadToEnd();

            if (s == "")
            {
                lblBP.Text = "N/A";
                return;
            }
            PersBest = int.Parse(s.Remove(s.Length - 1, 1));

            inStream.Close();

            lblBP.Text = PersBest.ToString();
        }

        public void ShowImg()
        {
            for(int i = 0; i < 12; i++)
                this.Controls["p" + i.ToString()].BackgroundImage = ims[nu[i]];
            
        }

        public void Rand(int Image)
        {
            if (Image == 6)
                return;

            Random r = new Random();

            int a = r.Next(0, 12);

            while(mar[a])
                a = r.Next(0, 12);

            mar[a] = true;

            int b = r.Next(0, 12);

            while(mar[b])
                b = r.Next(0, 12);

            mar[b] = true;

            nu[a] = nu[b] = Image;

            Rand(++Image);                   
        }

        private void Select()
        {
            string link = variabile.site + "/selectGameImage.php?passw=" + variabile.passw;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            img = inStream.ReadToEnd().Split('`');
            inStream.Close();

            int c = 0;

            for (int i = 0; i < img.Length && c < 6; i++)
            {
                if(File.Exists(variabile.dirPath + "/" + img[i]))
                {
                    ims[c] = Image.FromFile(variabile.dirPath + "/" + img[i]);
                    c++;
                }
                
            }
            
        }

        private void Create()
        {
            int distCol = 223;
            int distLin = 200;

            int curent = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.Controls.Add(new PictureBox
                    {
                        Name = "p" + curent.ToString(),
                        Size = new Size(200, 150),
                        Location = new Point(65 + distCol * j, 50 + distLin * i),
                        BackgroundImage = im,
                        BackgroundImageLayout = ImageLayout.Stretch,
                    });

                    (this.Controls["p" + curent.ToString()] as PictureBox).Click += PicClicked;

                    curent++;
                }
            }
        }

        int Click = 0;

        int imag;
        int nr1 = -1, nr2 = -1;

        int corecte = 0;

        private void PicClicked(object sender, EventArgs e)
        {
            if (!oke)
                return;
               
            PictureBox pb = sender as PictureBox;

            string name = pb.Name;

            int nr;

            if (name.Length > 2)
                nr = int.Parse(name[1].ToString()) * 10 + int.Parse(name[2].ToString());
            else
                nr = int.Parse(name[1].ToString());

            if(marcat[nr])
            {
                return;
            }


            if (Click % 2 == 0)
            {     
                pb.BackgroundImage = ims[nu[nr]];
                pb.BorderStyle = BorderStyle.Fixed3D;

                imag = nu[nr];

                nr1 = nr;
            }
            else if(nr != nr1)
            {
               
                pb.BorderStyle = BorderStyle.Fixed3D;
                pb.BackgroundImage = ims[nu[nr]];

                nr2 = nr;

                if (imag != nu[nr])
                {
                    Switch(false);
                    tWrong.Start();
                }
                else
                {
                    marcat[nr1] = marcat[nr] = true;
                    corecte++;
                }
            
            }
            
            Click++;
        }

        private void Switch(bool da)
        {
            foreach (Control c in this.Controls)
                if ((c as PictureBox) != null && (c.Name != "pbCloseLectie"))
                {
                    string name = c.Name;

                    int nr;

                    if (name.Length > 2)
                        nr = int.Parse(name[1].ToString()) * 10 + int.Parse(name[2].ToString());
                    else
                        nr = int.Parse(name[1].ToString());

                    if (!marcat[nr])
                        c.Enabled = da;
                    else
                        c.Enabled = false;
                }
        }

        private void tShow_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
                this.Controls["p" + i.ToString()].BackgroundImage = im;

            Switch(true);
            oke = true;

            tBg.Stop();
        }

        int time = 0;

        private void tTime_Tick(object sender, EventArgs e)
        {
            if(corecte == 6)
            {
                tTime.Stop();
                MessageBox.Show("Felicitări, aţi terminat jocul în " + lTime.Text + " secunde!");
                

                if (time < PersBest)
                {         
                    if(PersBest == 60 * 60 * 24 * 30)
                    {
                        string link2 = variabile.site + "/insertScores.php?passw=" + variabile.passw + "&name=" + variabile.NumeUtilizator + "&score=" + time.ToString();

                        WebRequest webRequest2;
                        WebResponse webResponse2;
                        webRequest2 = WebRequest.Create(link2);
                        webResponse2 = webRequest2.GetResponse();

                        this.Close();
                        return;
                    }

                    string link = variabile.site + "/deleteLastAndUpdateScores.php?passw=" + variabile.passw + "&name=" + variabile.NumeUtilizator + "&score=" + (time - 1).ToString();

                    WebRequest webRequest;
                    WebResponse webResponse;
                    webRequest = WebRequest.Create(link);
                    webResponse = webRequest.GetResponse();    
                }


                this.Close();
                return;
            }

            lTime.Text = time.ToString();
            time++;
        }

        private void frmGameImg_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEvaluare.fgi = null;
        }

        Point lastPoint;

        private void frmGameImg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmGameImg_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pbCloseLectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
            Select();
            Create();
            Switch(false);
            Rand(0);
            ShowImg();
            tBg.Start();
            tTime.Start();
            Switch(true);
            pnlStart.Visible = false;
        }

        private void pnlStart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lTime_Click(object sender, EventArgs e)
        {

        }

        private void tWrong_Tick(object sender, EventArgs e)
        {
            this.Controls["p" + nr1.ToString()].BackgroundImage = this.Controls["p" + nr2.ToString()].BackgroundImage = im;
            tWrong.Stop();

            Switch(true);  
        }
    }
}
