using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmINICIOSESION : Form
    {
        public frmINICIOSESION()
        {
            InitializeComponent();
        }

        private void frmINICIOSESION_Load(object sender, EventArgs e)
        {

        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            string admin, adminpass;

            admin = "admin1";
            adminpass = "admin1";

            if (txtNOMBRE.Text == admin && txtCONTRASEÑA.Text == adminpass)
            {
                MessageBox.Show("Ingreso con éxito!");
            }
            else
            {
                MessageBox.Show("Ingreso incorrecto");
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
