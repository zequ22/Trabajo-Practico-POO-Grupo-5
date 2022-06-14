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
    public partial class frmREGISTRO : Form
    {
        public frmREGISTRO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmREGISTRO_Load(object sender, EventArgs e)
        {
            cmbPUESTO.Items.Add("Cajero");
            cmbPUESTO.Items.Add("Cocinero");
            cmbPUESTO.Items.Add("Repartidor");
            cmbPUESTO.Items.Add("Mantenimiento");

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
