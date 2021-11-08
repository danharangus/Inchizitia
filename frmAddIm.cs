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
    public partial class frmAddIm : Form
    {
        public frmAddIm()
        {
            InitializeComponent();
        }

        List<string> path = new List<string>();
        List<string> desc = new List<string>();

        string Titlu = frmPanouLectii.flec.lblTitlu.Text;


        private void frmAddIm_Load(object sender, EventArgs e)
        {
            ///dupa ce inchid formul asta nu se facce update la pozele de la lectie
            ///daca sterg poza si am formul de adaugare deschis nu se face update la adaugarea de imagini

            string link = variabile.site + "/selectImg.php?passw=" + variabile.passw + "&lectie=" + Titlu;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string r = inStream.ReadToEnd();
            inStream.Close();

            string[] cuv = r.Split('`');

            for (int i = 0; i < cuv.Length - 1; i += 2)
            {
                path.Add(cuv[i]);
                desc.Add(cuv[i + 1]);
            }

            maxim = path.Count();
            curent = 0;

            ShowImg();

        }


        public int maxim = 0;
        public int curent = 0;

        private void lblAddImg_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            copiaza_fisier(ofd.FileName, variabile.dirPath + "\\ImaginiLectii\\" + Titlu);




            maxim = path.Count;

            ShowImg();

            (Tag as frmLectie).areImg = true;
            (Tag as frmLectie).c = path.Count;
            (Tag as frmLectie).ShowImg();

            MessageBox.Show("Imagine adaugata cu succes!");

        }

        public void ShowImg()
        {
            if (curent < 0)
                curent = 0;

            if (maxim != 0)
                curent %= maxim;

            try
            {
                txtDesc.ReadOnly = false;
                pbImg.Image = new Bitmap("ImaginiLectii\\" + Titlu + "\\" + path[curent]);
                txtDesc.Text = desc[curent];

                if(maxim > 1)
                {
                    pbPrev.Visible = pbNext.Visible = true;
                }
            }
            catch
            {
                pbPrev.Visible = pbNext.Visible = false;
                txtDesc.ReadOnly = true;
                pbImg.Image = new Bitmap("NoImage.jpg");
                txtDesc.Text = "NO IMAGE";
            }
        }


        private void copiaza_fisier(string sursa, string destinatie)
        {
            string numef = Path.GetFileNameWithoutExtension(sursa);

            string extensie = Path.GetExtension(sursa);

            int contor = 0;

            string numeNou = destinatie + '/' + numef + extensie;

            while (File.Exists(numeNou))
            {
                contor++;
                numeNou = destinatie + '/' + numef + contor + extensie;
            }

            File.Copy(sursa, numeNou);



            string s = variabile.site + "/insertImg.php?passw=parolaFoarteSugestivaPentruBazaDeDateid6296242_softCareEsteBazaDeDateALuiSamy&tit=" + Titlu + "&fisier=" + Path.GetFileName(numeNou) + "&descriere=" + Path.GetFileNameWithoutExtension(numeNou);

            WebRequest webRequest;
            WebResponse webresponse;
            webRequest = WebRequest.Create(s);
            webresponse = webRequest.GetResponse();

            path.Add(Path.GetFileName(numeNou));
            desc.Add(Path.GetFileNameWithoutExtension(numeNou));
            (Tag as frmLectie).path.Add(Path.GetFileName(numeNou));
            (Tag as frmLectie).desc.Add(Path.GetFileNameWithoutExtension(numeNou));
            (Tag as frmLectie).Show();
            maxim++;

        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            curent++;
            curent %= maxim;

            ShowImg();
        }

        private void lblChange_Click(object sender, EventArgs e)
        {
            ///UPDATE LA DESCRIERE


            string s = variabile.site + "/updateDesc.php?passw=parolaFoarteSugestivaPentruBazaDeDateid6296242_softCareEsteBazaDeDateALuiSamy&descriere=" + txtDesc.Text + "&titlu=" + variabile.TitluLectiei + "&fisier=" + path[curent];

            WebRequest webRequest;
            WebResponse webresponse;
            webRequest = WebRequest.Create(s);
            webresponse = webRequest.GetResponse();

            desc[curent] = txtDesc.Text;

            MessageBox.Show("Descriere modificata!");


            functii.ModImg((Tag as frmLectie).path, (Tag as frmLectie).desc);
            (Tag as frmLectie).ShowImg();
        }

        Point lastPoint;

        private void frmAddIm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmAddIm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }



        private void lblPrev_Click(object sender, EventArgs e)
        {
            curent--;

            if (curent < 0)
                curent = path.Count - 1;

            ShowImg();
        }

        private void frmAddIm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLectie.fai = null;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbCloseLectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }

}

