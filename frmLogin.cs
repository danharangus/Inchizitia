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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void closeRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point LastPoint;
        Image Hidden = Image.FromFile(variabile.dirPath + "/Icons/hidden.png");
        Image Shown = Image.FromFile(variabile.dirPath + "/Icons/shown.png");

        private bool Check(string user, string pass)
        {
            string link = String.Format(variabile.site + "/login.php?passw=" + variabile.passw + "&user={0}&pass={1}", user, pass);
            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string response = inStream.ReadToEnd();
            inStream.Close();

            

            if (response != "0")
            {
                string[] res = response.Split('`');
                variabile.tip = res[0];
                variabile.NumeUtilizator = res[1];
                return true;
            }
            else
            {
                return false;
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
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

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!variabile.ExistaNet)
            {
                MessageBox.Show("EROARE: Nu există conexiune la internet.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Clear();
                txtPass.Clear();
                return;
            }
            if (Check(txtUser.Text, CreateMD5(txtPass.Text)) && txtUser.Text != "" && txtUser.Text != "")
            {
                //MessageBox.Show("Te-ai conectat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                variabile.logat = true;
                (this.Tag as frmMain).pbLogin.Visible = false;
                (this.Tag as frmMain).pbDeconectare.Visible = true;
                (this.Tag as frmMain).pbEvaluare.Visible = true;
                (this.Tag as frmMain).pbInregistrare.Visible = false;

                variabile.mail = txtUser.Text;
                variabile.parola = txtPass.Text;

                if(variabile.tip == "admin")
                {
                    (this.Tag as frmMain).pbAdmin.Visible = true;
                }
                (this.Tag as frmMain).pbUser.Visible = true;
                Close();
            }
            else
            {
                MessageBox.Show("Nume sau parola greșită.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Login = null;
        }

        private void pbCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            
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
                txtPass.UseSystemPasswordChar = true;
                pbPSH.BackgroundImage = Hidden;
            }
        }
    }
}
