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
    public partial class frmAddIntrebare : Form
    {
        public frmAddIntrebare()
        {
            InitializeComponent();
        }

        string[] lec = new string[1024];


        private void rbb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string corect = "";

            if (!variabile.ExistaNet)
            {
                MessageBox.Show("EROARE: Nu există conexiune la internet.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtboxIntrebare.Text == "" || txtboxA.Text == "" || txtboxB.Text == "" || txtboxC.Text == "" || cmbLec.SelectedIndex == -1)
            {
                MessageBox.Show("EROARE: Toate câmpurile sunt obligatorii!.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rba.Checked)
            {
                corect = "a";
            }
            else if (rbb.Checked)
            {
                corect = "b";
            }
            else if (rbc.Checked)
            {
                corect = "c";
            }
            else
            {
                MessageBox.Show("EROARE: Trebuie să selectaţi răspunsul corect!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string link = String.Format(variabile.site + "/addIntrebare.php?passw=" + variabile.passw + "&intrebare={0}&var_a={1}&var_b={2}&var_c={3}&lectie={4}&corect={5}", txtboxIntrebare.Text, txtboxA.Text, txtboxB.Text, txtboxC.Text, cmbLec.SelectedItem.ToString(), corect);

                StreamReader inStream;
                WebRequest webRequest;
                WebResponse webResponse;
                webRequest = WebRequest.Create(link);
                webResponse = webRequest.GetResponse();

                inStream = new StreamReader(webResponse.GetResponseStream());
                inStream.Close();

                MessageBox.Show("Întrebarea a fost adăugată cu succes!", "", MessageBoxButtons.OK);
                txtboxIntrebare.Text = "";
                txtboxA.Text = "";
                txtboxB.Text = "";
                txtboxC.Text = "";
                cmbLec.SelectedIndex = -1;
                rba.Checked = false;
                rbb.Checked = false;
                rbc.Checked = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void closeAddIntrebare_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point LastPoint;

        private void frmAddIntrebare_Load(object sender, EventArgs e)
        {

            this.KeyDown += new KeyEventHandler(functii.ChangeMusic);
            if (!variabile.ExistaNet)
            {
                pbNoNetwork.Visible = true;
                pbNetwork.Visible = false;
            }
            else
            {
                pbNoNetwork.Visible = false;
                pbNetwork.Visible = true;
            }

            SelectLectii();
        }

        private void SelectLectii()
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
            inStream.Close();

            for(int i = 0; i < lec.Length; i++)
            {
                cmbLec.Items.Add(lec[i]);
            }

        }

        private void frmAddIntrebare_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmAddIntrebare_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void txtboxLectie_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddIntrebare_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdmin.fai = null;
        }
    }
}
