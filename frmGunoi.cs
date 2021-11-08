using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchizitia
{
    public partial class frmGunoi : Form
    {
        public frmGunoi()
        {
            InitializeComponent();
        }

        private void frmGunoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void frmGunoi_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode);
        }
    }
}
