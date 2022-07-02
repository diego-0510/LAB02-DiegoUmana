using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class objDueno
    {

        public int cedula { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string cargo { get; set; }
        public int acciones { get; set; }
        

        public objDueno(int cedula, string nombre, int edad,string cargo, int acciones)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.edad = edad;
            this.cargo = cargo;
            this.acciones = acciones;
        }

        public objDueno()
        {

        }


    }
}
