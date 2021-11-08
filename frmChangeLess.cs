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
    public partial class frmChangeLess : Form
    {
        public frmChangeLess()
        {
            InitializeComponent();
        }

        public string[] lec = new string[1024];

        private void lblChange_Click(object sender, EventArgs e)
        {
            cmbLec.SelectedIndex = -1;
      
            string link = variabile.site + "/updateContent.php?passw=" + variabile.passw + "&tit=" + cmbLec.Text + "&content=" + txtChange.Text;

            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

        }

        private void frmChangeLess_Load(object sender, EventArgs e)
        {
            string link = variabile.site + "/selectLectii.php?passw=" + variabile.passw;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string s = inStream.ReadToEnd();

            lec = s.Split('`');

            for(int i = 0; i < lec.Count(); i++)
            {
                cmbLec.Items.Add(lec[i]);
            }

            inStream.Close();
        }

        private void cmbLec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLec.SelectedIndex == -1)
                return;

            string link = variabile.site + "/selectContinut.php?passw=" + variabile.passw + "&tit=" + cmbLec.Text;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            txtChange.Text = inStream.ReadToEnd();
            inStream.Close();


            if (txtChange.Text == "ERROR" && DialogResult.OK == MessageBox.Show("Lectie invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                this.Close();
            }
        }

        private void frmChangeLess_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCEVA.fcl = null;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
