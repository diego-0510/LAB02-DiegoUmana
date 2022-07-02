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
    public partial class frmPago : Form
    {
        public int cedulaTrabajador = 0;
        public proceso lista = frmPrincipal.proceso;
        public dynamic trabajador;
        double pagoHora;

        public frmPago()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
            btnPagar.Enabled = false;
        }

        private void frmPago_Load(object sender, EventArgs e)
        {

        }

        public void calcularSalario()
        {
            double impuesto;
            int horasTrabajadas = int.Parse(txtCostoHora.Text);
            double pagoSalario = horasTrabajadas * pagoHora;
            if(pagoSalario>3000 || pagoSalario < 5000)
            {
                impuesto = pagoSalario * 0.9;
                pagoSalario =pagoSalario-impuesto ;
            }
            if(pagoSalario > 5000)
            {
                impuesto = pagoSalario * 0.12;
                pagoSalario = pagoSalario-impuesto;
                MessageBox.Show("Cobro de Impuestos del 12%", "Atencion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtSalario.Text = pagoSalario.ToString();
        }

        public void mostrarInformacion(proceso mostrar)
        {
            try
            {
                trabajador = mostrar.buscarTrabajador(cedulaTrabajador);
                txtNombre.Text = trabajador[0];
                txtEdad.Text = trabajador[1];
                txtResidencia.Text = trabajador[2];
                txtCargo.Text = trabajador[3];
                txtHorasTrabajadas.Text = trabajador[4];
                txtTipoJornada.Text = trabajador[5];
                if (txtTipoJornada.Text.Equals("Diurna"))
                {
                    txtCostoHora.Text = "15";
                    pagoHora = 15;
                }
                if (txtTipoJornada.Text.Equals("Nocturna"))
                {
                    txtCostoHora.Text = "25";
                    pagoHora = 25;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                cedulaTrabajador = int.Parse(txtCedulaBuscar.Text);
                mostrarInformacion(lista);
                btnCalcular.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularSalario();
            btnPagar.Enabled = true;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago Realizado", "Pago",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
