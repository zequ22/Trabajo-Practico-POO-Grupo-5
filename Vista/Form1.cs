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
    public partial class frmPRINCIPAL : Form
    {
        public frmPRINCIPAL()
        {
            InitializeComponent();
        }

        private void frmPRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnINICIARSESION_Click(object sender, EventArgs e)
        {
            frmINICIOSESION formuINICIOSESION = new frmINICIOSESION();

            formuINICIOSESION.Show();
        }

        private void btnREGISTRARME_Click(object sender, EventArgs e)
        {
            frmREGISTRO formuREGISTRO = new frmREGISTRO();

            formuREGISTRO.Show();
        }
    }
}
