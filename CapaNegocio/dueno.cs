using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class dueno
    {

        private List<objDueno> listDueno = new List<objDueno>();

        public void crearDueno(int cedula, string nombre, int edad, string cargo, int acciones)
        {
            objDueno dueno = new objDueno(cedula, nombre, edad, cargo,acciones);
            listDueno.Add(dueno);
        }
    }
}
