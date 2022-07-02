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
    public partial class frmPrincipal : Form
    {
        public static proceso proceso = new proceso();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtResidencia.Clear();
            txtCargo.Clear();
            txtHorasTrabajadas.Clear();
            
        }

        public void ingresarInformacion()
        {
            try
            {
                int cedula = int.Parse(txtCedula.Text);
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                string residencia = txtResidencia.Text;
                string cargo = txtCargo.Text;
                int horasTrabajadas = int.Parse(txtHorasTrabajadas.Text);
                string jornada = cmbJornada.Text;
                proceso.crearTrabajador(cedula,nombre,edad,residencia,cargo,horasTrabajadas,jornada);
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresarInformacion();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPago ventanaPagar = new frmPago();
            ventanaPagar.Visible = true;
            ventanaPagar.mostrarInformacion(proceso);
        }
    }
}
