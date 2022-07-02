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
    public partial class frmDueno : Form
    {
        public static dueno nuevoDueno = new dueno();
        public frmDueno()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtCargo.Clear();
        }

        public void ingresarInformacion()
        {
            try
            {
                int cedula = int.Parse(txtCedula.Text);
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                string cargo = txtCargo.Text;
                int acciones = 0;
                nuevoDueno.crearDueno(cedula, nombre, edad,cargo,acciones);
                limpiarCampos();
                MessageBox.Show("Información Ingresada Correctamente", "Ingresada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Información Incorrecta...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDueno_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresarInformacion();
        }
    }
}
