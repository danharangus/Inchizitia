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
    public partial class frmAddLec : Form
    {
        public frmAddLec()
        {
            InitializeComponent();
        }

        private void AddLec_Click(object sender, EventArgs e)
        {
            if(txtContinut.Text.Length > variabile.TextMaxim)
            {
                MessageBox.Show("Lectie este prea lunga!");
                return;
            }

            if (exista_lectie())
            {
                MessageBox.Show("Această lecţie există deja!");
                return;
            }

            string link = variabile.site + "/insertLec.php?passw=" + variabile.passw + "&tit=" + txtTitlu.Text + "&continut=" + txtContinut.Text;

            string path = variabile.dirPath + "\\ImaginiLectii\\" + txtTitlu.Text;

            DirectoryInfo d = Directory.CreateDirectory(path);

            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            MessageBox.Show("Lectie adaugata cu succes!");
            txtContinut.Text = txtTitlu.Text = "";
            
        }

        private bool exista_lectie()
        {
            string link = variabile.site + "/verfLec.php?passw=" + variabile.passw + "&tit=" + txtTitlu.Text;
            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string response = inStream.ReadToEnd();
            inStream.Close();

            if (response != "")
                return true;
            
     
            return false;
        }

        Point lastPoint;

        private void frmAddLec_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmAddLec_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmAddLec_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdmin.fal = null;
        }

        private void frmAddLec_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
        }

        private void pbCloseLectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
