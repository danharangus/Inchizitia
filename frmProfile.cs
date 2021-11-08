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
    public partial class frmProfile : Form
    {
        Image Hidden = Image.FromFile(variabile.dirPath + "/Icons/hidden.png");
        Image Shown = Image.FromFile(variabile.dirPath + "/Icons/shown.png");

        public frmProfile()
        {
            InitializeComponent();
        }

        private void pbCloseLectie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            pbPSH.BackgroundImage = Hidden;

            txtMail.Text = variabile.mail;
            txtPass.Text = variabile.parola;
            txtName.Text = variabile.NumeUtilizator;
        }

        private void pbPSH_Click(object sender, EventArgs e)
        {
            if(pbPSH.BackgroundImage == Hidden)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Editare profil")
            {
                txtPass.Visible = pbPSH.Visible = lblPass.Visible = btnSave.Visible = true;
                txtMail.ReadOnly = txtName.ReadOnly = false;
                btnEdit.Text = "Inapoi";
            }
            else
            {
                txtPass.Visible = pbPSH.Visible = lblPass.Visible = btnSave.Visible = false;
                txtMail.ReadOnly = txtName.ReadOnly = true;
                btnEdit.Text = "Editare profil";
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string link = variabile.site + "/checkMail.php?passw=" + variabile.passw + "&user=" + txtMail.Text;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());
            string s = inStream.ReadToEnd();
            inStream.Close();

            if ( s == "" || s == variabile.mail)
            {
                link = variabile.site + "/updateUser.php?passw=" + variabile.passw + "&newMail=" + txtMail.Text + "&oldMail=" + variabile.mail + "&user=" + txtName.Text + "&pass=" + CreateMD5(txtPass.Text);
                webRequest = WebRequest.Create(link);
                webResponse = webRequest.GetResponse();

                inStream = new StreamReader(webResponse.GetResponseStream());

                inStream.Close();
                btnEdit.Visible = true;
                btnSave.Visible = txtPass.Visible = pbPSH.Visible = lblPass.Visible = false;
                btnEdit.Text = "Editare profil";
            }
            else
            {
                MessageBox.Show("Acest mail nu este valid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.fuser = null;
        }
    }
}
