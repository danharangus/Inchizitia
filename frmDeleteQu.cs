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
    public partial class frmDeleteQu : Form
    {
        public frmDeleteQu()
        {
            InitializeComponent();
        }

        public string[] intrebari = new string[1024];

        private void frmDeleteQu_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
            string link = variabile.site + "/selectIntrebDel.php?passw=" + variabile.passw;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string s = inStream.ReadToEnd();

            intrebari = s.Split('`');

            inStream.Close();

            for (int i = 0; i < intrebari.Length - 1; i++)
            {
                MessageBox.Show(intrebari[i]);
                lstB.Items.Add(intrebari[i]);
            }
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sunteti sigur ca doriti sa stergeti intrebariile selectate?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                for (int i = 0; i < lstB.CheckedItems.Count; i++)
                {
                    string link = variabile.site + "/deleteIntrebare.php?passw=" + variabile.passw + "&intrebare=" + lstB.CheckedItems[i];

                    WebRequest webRequest;
                    WebResponse webResponse;
                    webRequest = WebRequest.Create(link);
                    webResponse = webRequest.GetResponse();


                    MessageBox.Show("Intreabrile au fost stearse cu succes!");
                }
                this.Close();
            }
            
            
        }

        Point lastPoint;
        private void frmDeleteQu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmDeleteQu_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmDeleteQu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdmin.fdq = null;
        }

        private void pbCloseLectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
