using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace Inchizitia
{
    class variabile
    {
        // Site

        public static string site = "http://127.0.0.1/inchizitia";
        public static string passw = "parolaFoarteSugestivaPentruBazaDeDateid6296242_softCareEsteBazaDeDateALuiSamy";
        public static bool ExistaNet = true;

        // DebugPath

        public static string dirPath = Directory.GetCurrentDirectory();

        // Login

        public static string NumeUtilizator;
        public static string tip;
        public static bool logat = false;
        public static string parola;
        public static string mail;

        // Lectii

        public static string TitluLectiei = "";
        public static string nrLec;
        public static int TextMaxim = 5000;
        public static string[] lectiiTest = new string[1000];
        public static string lec;

        ///Administrare 

        public static string lectie;

        ///Muzica

        public static int c = 0;
        
        /// habar nu am ce sa pun

        public static frmMain Main;
    }
}
