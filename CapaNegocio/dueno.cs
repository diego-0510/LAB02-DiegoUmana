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

        public dynamic[] buscarDueno(int cedula)
        {
            objDueno duenoBuscado = new objDueno();
            dynamic[] listaEncontrado = new dynamic[4];

            foreach (objDueno buscandoDueno in listDueno)
            {
                if (buscandoDueno.cedula == cedula)
                {
                    duenoBuscado = buscandoDueno;
                    listaEncontrado[0] = buscandoDueno.nombre;
                    listaEncontrado[1] = buscandoDueno.edad.ToString();
                    listaEncontrado[2] = buscandoDueno.cargo;
                    listaEncontrado[3] = buscandoDueno.acciones.ToString();

                }
            }
            return listaEncontrado;

        }
    }
}
