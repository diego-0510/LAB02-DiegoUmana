using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace LABOR_2
{
    public partial class frmCompraAcciones : Form
    {
        public int cedulaDueno = 0;
        public dynamic dueno;
        public dueno nuevoDueno=frmDueno.nuevoDueno;

        public frmCompraAcciones()
        {
            InitializeComponent();
        }

        public void mostrarInformacion()
        {
            try
            {
                dueno = nuevoDueno.buscarDueno(cedulaDueno);
                txtNombre.Text = dueno[0];
                txtEdad.Text = dueno[1];
                txtCargo.Text = dueno[2];
                txtAccionesPropiedad.Text = dueno[3];
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                cedulaDueno = int.Parse(txtCedulaBuscar.Text);
                mostrarInformacion();
                

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void compra()
        {
            int nuevasAcciones = int.Parse(txtAcciones.Text);

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}
