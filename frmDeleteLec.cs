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
    public partial class frmDeleteLec : Form
    {
        public frmDeleteLec()
        {
            InitializeComponent();
        }

        public string[] lec = new string[1024];

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Sunteti sigur ca doriti sa stergeti lectiile selectate?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                for (int i = 0; i < clb.CheckedItems.Count; i++)
                {
                    string link = variabile.site + "/deleteLec.php?passw=" + variabile.passw + "&tit=" + clb.CheckedItems[i];

                    WebRequest webRequest;
                    WebResponse webResponse;
                    webRequest = WebRequest.Create(link);
                    webResponse = webRequest.GetResponse();

                    try
                    { Directory.Delete(variabile.dirPath + "/ImaginiLectii/" + clb.CheckedItems[i]); }
                    catch { }
                }

                MessageBox.Show("Lectiile au fost sterse cu succes!");
                this.Close();
            }
           

            
        }

        private void frmDeleteLec_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);

            string link = variabile.site + "/selectLectii.php?passw=" + variabile.passw;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string response = inStream.ReadToEnd();

            string[] lec = response.Split('`');

            for (int i = 0; i < lec.Length - 1; i++)
            {
                clb.Items.Add(lec[i]);
            }
        }

        private void frmDeleteLec_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdmin.fdl = null;
        }

        Point lastPoint;
        private void frmDeleteLec_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmDeleteLec_MouseMove(object sender, MouseEventArgs e)
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
    }
}
