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
    public partial class ABMAdmin : Form
    {
        private int selectedIndex = 0;

        public ABMAdmin()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                List<Modelo.Usuario> listaUsuarios = Controladora.ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
                dgvABM.DataSource = listaUsuarios;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar los usuario" + Ex.Message);
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
           frmREGISTRO formuREGISTRO = new frmREGISTRO();
            formuREGISTRO.Show();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            Modelo.Usuario selected = dgvABM.SelectedRows[0].DataBoundItem as Modelo.Usuario;
            Controladora.ControladoraUsuarios.obtener_instancia().Eliminar_Usuario(selected);
            dgvABM.DataSource = null;
            List<Modelo.Usuario> listaUsuarios = Controladora.ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
            dgvABM.DataSource = listaUsuarios;

        }
    }
}
