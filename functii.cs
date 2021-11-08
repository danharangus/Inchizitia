using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Inchizitia
{
    class functii
    {
        public static void Imagini(List<string> path, List<string> desc)
        {
            string link = variabile.site + "/selectImg.php?passw=" + variabile.passw + "&lectie=" + variabile.TitluLectiei;

            StreamReader inStream;
            WebRequest webRequest;
            WebResponse webResponse;
            webRequest = WebRequest.Create(link);
            webResponse = webRequest.GetResponse();

            inStream = new StreamReader(webResponse.GetResponseStream());

            string s = inStream.ReadToEnd();
            inStream.Close();



            string[] cuv = s.Split('`');

            for (int i = 0; i < cuv.Length - 1; i += 2)
            {
                desc.Add(cuv[i + 1]);
                path.Add(cuv[i]);
            }

        }

       
        public static void ModImg(List<string> path, List<string> desc)
        {
            path.Clear();
            desc.Clear();

            Imagini(path, desc);

            ///trebe sa pui pozele iarasi pentru ca toate is cu pisici

        }

        public static void OpenGI()
        {
            frmEvaluare.fgi = new frmGameImg();
            frmEvaluare.fgi.Show();
        }

        public static void ChangePb(PictureBox pb, bool on)
        {
            if(on == true)
            {

            }
        }

        public static void ChangeMusic(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F4")
            {
                if (variabile.c % 2 == 0)
                {
                    variabile.Main.pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\MusicOff.png");
                    variabile.Main.player.Stop();
                }
                else
                {
                    variabile.Main.pb.Image = Image.FromFile(variabile.dirPath + "\\Icons\\MusicOn.png");
                    variabile.Main.player.PlayLooping();
                }

                variabile.c++;
            }
        }
    }
}
