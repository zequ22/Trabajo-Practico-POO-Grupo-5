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

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnREGISTRARSE_Click(object sender, EventArgs e)
        {
            try
            {
                
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Nombre = txtNOMBRE.ToString();
                usuario.Apellido = txtAPELLIDO.ToString();
                usuario.Mail = txtMAIL.ToString();
                usuario.Contraseña = txtCONTRASEÑA.ToString();
                usuario.Tel = txtTEL.ToString();
                usuario.Domicilio = txtDOMICILIO.ToString();
                usuario.Dni = txtDNI.ToString();
               
                Controladora.ControladoraUsuarios.obtener_instancia().Agregar_Usuario(usuario);
                this.Close();

            }
            catch
            {
                #region VALIDACIONES
                if (txtNOMBRE.Text == "")
                {
                    MessageBox.Show("Complete el campo NOMBRE");
                }
                if (txtAPELLIDO.Text == "")
                {
                    MessageBox.Show("Complete el campo APELLIDO");
                }
                if (txtMAIL.Text == "")
                {
                    MessageBox.Show("Complete el campo MAIL");
                }
                if (txtCONTRASEÑA.Text == "")
                {
                    MessageBox.Show("Complete el campo CONTRASEÑA");
                }
                if (txtREPITACONTRASEÑA.Text == "")
                {
                    MessageBox.Show("Complete el campo REPITA CONTRASEÑA");
                }
                if (txtTEL.Text == "")
                {
                    MessageBox.Show("Complete el campo TELEFONO");
                }
                if (txtDOMICILIO.Text == "")
                {
                    MessageBox.Show("Complete el campo DOMICILIO");
                }
                if (txtDNI.Text == "")
                {
                    MessageBox.Show("Complete el campo DNI");
                }
                #endregion

            }

        }
    }
}
