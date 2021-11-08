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
    public partial class frmLectie : Form
    {
        public frmLectie()
        {
            InitializeComponent();
        }

        public List<string> path = new List<string>();
        public List<string> desc = new List<string>();

        public int c = 0;

        public bool areImg = false;

        private void frmLectie_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);

            if (variabile.tip != "elev" && variabile.tip != "")
            {
                pbDel.Visible = pbAdd.Visible = true;
            }
            lblTitlu.Text = variabile.TitluLectiei;
            lblNr.Text = variabile.nrLec;

            Lectie();
            functii.Imagini(path, desc);

            areImg = (path.Count != 0);
            c = path.Count;

            ShowImg();
        }

        public void ShowImg()
        {
            try
            {
                if (areImg)
                {
                    pbDel.Visible = true;

                    if (path.Count > 1)
                    {
                        pbNext.Visible = pbPrev.Visible = true;

                    }
                    else
                    {
                        pbNext.Visible = pbPrev.Visible = false;
                    }

                    pbImg.ImageLocation =variabile.dirPath + "/ImaginiLectii\\" + lblTitlu.Text + "\\" + path[Click];
                    lblDesc.Text = desc[Click];
                }
                else
                {
                    pbDel.Visible = false;
                    pbNext.Visible = pbPrev.Visible = false;
                    lblDesc.Text = "Nicio imagine";
                    pbImg.ImageLocation =variabile.dirPath + "/NoImage.jpg";
                }
            }
            catch
            {
                pbDel.Visible = false;
                areImg = false;
                pbNext.Visible = pbPrev.Visible = false;
                lblDesc.Text = "Nicio imagine";
                pbImg.ImageLocation = variabile.dirPath + "/NoImage.jpg";
            }
        }

        public void ModImg()
        {
            path.Clear();
            desc.Clear();

            functii.Imagini(path, desc);

            ///trebe sa pui pozele iarasi

        }



        private void Lectie()
        {
            string link = variabile.site + "/selectContinut.php?passw=" + variabile.passw + "&tit=" + variabile.TitluLectiei;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            lbl1.Text = inStream.ReadToEnd();
            inStream.Close();


            if (lbl1.Text == "ERROR")
            {
                lbl1.Text = "";
                if (DialogResult.OK == MessageBox.Show("Lectie invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error))
                {
                    this.Close();
                }

            }


        }



        Point lastPoint;
        private void frmLectie_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void frmLectie_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmLectie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inchizitia.frmPanouLectii.open[int.Parse(lblNr.Text)] = false;
            frmMain.PanouLectii.Show();
            this.Dispose();
        }

        public int Click = 0;

        private void pbNext_Click(object sender, EventArgs e)
        {
            Click++;
            Click %= c;

            pbImg.ImageLocation = variabile.dirPath + "\\imaginiLectii\\" + lblTitlu.Text + "\\" + path[Click];
            lblDesc.Text = desc[Click];
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            Click--;

            if (Click < 0)
                Click = c - 1;

            pbImg.ImageLocation = variabile.dirPath + "\\imaginiLectii\\" + lblTitlu.Text + "\\" + path[Click];
            lblDesc.Text = desc[Click];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sunteti sigur ca doriti sa stergeti aceasta imagine?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                Delete();
            }
        }

        public void Delete()
        {
            string s = variabile.site + "/deleteImg.php?passw=parolaFoarteSugestivaPentruBazaDeDateid6296242_softCareEsteBazaDeDateALuiSamy&tit=" + lblTitlu.Text + "&fisier=" + path[Click];

            WebRequest webRequest;
            WebResponse webresponse;
            webRequest = WebRequest.Create(s);
            webresponse = webRequest.GetResponse();

            pbImg.ImageLocation = variabile.dirPath + "\\NoImage.jgp";
            
            try
            {
                File.Delete(variabile.dirPath + "/ImaginiLectii/" + lblTitlu.Text + "/" + path[Click]);
            }
            catch
            {
                //MessageBox.Show("HAHA NU ITI STERG POZA!");
            }

            path.RemoveAt(Click);
            desc.RemoveAt(Click);

            Click = 0;
            ShowImg();

            c = path.Count();

            if (c == 1)
                pbNext.Visible = pbPrev.Visible = false;
        }


        public static frmAddIm fai;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (fai == null)
            {
                fai = new frmAddIm();
                fai.Tag = this;
                fai.Show();
            }
        }

        private void pnlSimulareDeCarte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitlu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitlu_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void tAdd_Tick(object sender, EventArgs e)
        {

        }

        private void pnlPrim_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
