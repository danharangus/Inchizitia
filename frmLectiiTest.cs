using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchizitia
{
    public partial class frmLectiiTest : Form
    {
        public frmLectiiTest()
        {
            InitializeComponent();
        }


        public void SelectLectii()
        {
            string link = variabile.site + "/selectLectii.php?passw=" + variabile.passw;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string response = inStream.ReadToEnd();

            string[] lectii = Regex.Split(response, "`");
            for(int i = 0; i < lectii.Length-1; i++)
            {
                clb.Items.Add(lectii[i]);
            }
        }

        private void closeLectiiTest_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLectiiTest_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
            SelectLectii();
        }

        Point LastPoint;

        private void frmLectiiTest_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }


        private void frmLectiiTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        public static frmTestGrila testGrila;

        private void btnNext_Click(object sender, EventArgs e)
        {

            variabile.lectiiTest = new string[1000];
            for(int i = 0; i < clb.CheckedItems.Count; i++)
            {
                variabile.lectiiTest[i] = clb.CheckedItems[i].ToString();
               // MessageBox.Show(variabile.lectiiTest[i]);
            }

            if(testGrila == null)
            {
                testGrila = new frmTestGrila();
                testGrila.Show();
            }

            Close();
        }

        private void frmLectiiTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEvaluare.LectiiTest = null;
        }
    }
}
