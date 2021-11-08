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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        string[] desc = new string[1024];

        public int c = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            c++;
            c %= 13;

            AShow();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            c--;

            if (c < 0)
                c = 12;

            AShow();
        }

        public void AShow()
        {
            pb.Image = Image.FromFile(variabile.dirPath + "\\ImgHelp\\" + c.ToString() + ".png");
            lblDesc.Text = desc[c];
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            string link = variabile.site + "/help.php";

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            desc = inStream.ReadToEnd().Split('`');
            inStream.Close();

            AShow();
        }

        private void frmHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.fhelp = null;
        }

        Point lastPoint;

        private void frmHelp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmHelp_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PbCloseRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
