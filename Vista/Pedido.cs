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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmbPEDIDO.Items.Add("Especial - $2100");
            cmbPEDIDO.Items.Add("Muzzarella - $2080");
            cmbPEDIDO.Items.Add("Fugazzeta - $1950");
            cmbPEDIDO.Items.Add("Napolitana - $2200");
            cmbPEDIDO.Items.Add("Roquefort - $2500");

            cmbBEBIDA.Items.Add("CocaCola 1,5L - $450");
            cmbBEBIDA.Items.Add("Sprite 1,5L - $420");
            cmbBEBIDA.Items.Add("Fanta 1,5L - $430");
            cmbBEBIDA.Items.Add("Schweppes 1,5L - $400");
            cmbBEBIDA.Items.Add("Aquarius 1,5L - $380");
            cmbBEBIDA.Items.Add("Sin Bebida");

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CALCULAR_PRECIO()
        {
            int PEDIDO, BEBIDA, ENVIO, TOTAL;

            PEDIDO = 0;
            BEBIDA = 0;
            ENVIO = 0;
            TOTAL = 0;

            #region PEDIDO
            if (cmbPEDIDO.Text == "Especial")
            {
                PEDIDO = 2100;
            }
            if (cmbPEDIDO.Text == "Muzzarella")
            {
                PEDIDO = 2080;
            }
            if (cmbPEDIDO.Text == "Fugazzeta")
            {
                PEDIDO = 1950;
            }
            if (cmbPEDIDO.Text == "Napolitana")
            {
                PEDIDO = 2200;
            }
            if (cmbPEDIDO.Text == "Especial")
            {
                PEDIDO = 2500;
            }
            
            #endregion

            #region BEBIDA
            if(cmbBEBIDA.Text == "CocaCola")
            {
                BEBIDA = 450;
            }
            if (cmbBEBIDA.Text == "Sprite")
            {
                BEBIDA = 420;
            }
            if (cmbBEBIDA.Text == "Fanta")
            {
                BEBIDA = 430;
            }
            if (cmbBEBIDA.Text == "Schweppes")
            {
                BEBIDA = 400;
            }
            if (cmbBEBIDA.Text == "Aquarius")
            {
                BEBIDA = 380;
            }
            if (cmbBEBIDA.Text == "Sin Bebida")
            {
                BEBIDA = 0;
            }
            
            #endregion

            #region ENVIO
            if (cbSI.Checked)
            {
                ENVIO = 210;
            }
            else
            {
                ENVIO = 0;
            }
            #endregion
           
            TOTAL = PEDIDO + BEBIDA + ENVIO;

        }

        private void btnCOMPRAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if(cmbPEDIDO.SelectedItem == "")
            {
                MessageBox.Show("Elija su pedido");
            }
            if (cmbBEBIDA.SelectedItem == "")
            {
                MessageBox.Show("Elija su bebida");
            }
            if(cbSI.Checked == false && cbNO.Checked == false)
            {
                MessageBox.Show("Seleccione si quiere Envio o No");
            }
            #endregion
        }
    }
}
