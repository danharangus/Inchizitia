using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Inchizitia
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        Point LastPoint;

        private bool Exista()
        {
            string link = String.Format(variabile.site + "/check.php?passw=" + variabile.passw + "&user={0}", txtMail.Text);
            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string response = inStream.ReadToEnd();
            inStream.Close();

            if (response == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtMail.Text == "" || txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("EROARE: Toate câmpurile sunt obligatorii!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!variabile.ExistaNet)
            {
                MessageBox.Show("EROARE: Nu există conexiune la internet.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Clear();
                txtPass.Clear();
                txtMail.Clear();
                return;
            }
            if(Exista())
            {
                MessageBox.Show("Acest mail nu este disponibil.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Clear();
                txtPass.Clear();
                txtMail.Clear();
                return;
            }
            try
            {
                string link = String.Format(variabile.site + "/insertUsers.php?passw=" + variabile.passw + "&user={0}&pass={1}&mail={2}&role=elev", txtUser.Text, CreateMD5(txtPass.Text), txtMail.Text);
                StreamReader inStream;
                WebRequest webRequest;
                WebResponse webResponse;
                webRequest = WebRequest.Create(link);
                webResponse = webRequest.GetResponse();

                inStream = new StreamReader(webResponse.GetResponseStream());
                inStream.Close();

                MessageBox.Show("Te-ai înregistrat cu succes!", "", MessageBoxButtons.OK);
                variabile.logat = true;
                variabile.tip = "elev";

                (this.Tag as frmMain).pbLogin.Visible = false;
                (this.Tag as frmMain).pbDeconectare.Visible = true;
                (this.Tag as frmMain).pbEvaluare.Visible = true;
                (this.Tag as frmMain).pbInregistrare.Visible = false;
                variabile.NumeUtilizator = txtUser.Text;
                variabile.parola = txtPass.Text;
                if (variabile.tip == "admin")
                {
                    (this.Tag as frmMain).pbAdmin.Visible = true;
                }
                variabile.NumeUtilizator = txtUser.Text;
                txtUser.Clear();
                txtPass.Clear();
                txtMail.Clear();
            }
            catch(Exception ex)
            {
                
            }
       }

        private void frmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void closeRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        Image Hidden = Image.FromFile(variabile.dirPath + "/Icons/hidden.png");
        Image Shown = Image.FromFile(variabile.dirPath + "/Icons/shown.png");

        private void frmRegister_Load(object sender, EventArgs e)
        {
            pbPSH.BackgroundImage = Hidden;

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
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Register = null;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            return;
            var a = sender as TextBox;

            char c = a.Text.Last();

            if(!((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
            {
                a.Text.Remove(a.Text.Length - 1);
            }
        }

        private void pbPSH_Click(object sender, EventArgs e)
        {
            if (pbPSH.BackgroundImage == Hidden)
            {
                pbPSH.BackgroundImage = Shown;
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                pbPSH.BackgroundImage = Hidden;
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
