using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class objTrabajadores
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string residencia { get; set; }
        public string cargo { get; set; }
        public int horasTrabajadas { get; set; }
        public string jornada { get; set; } 

        public objTrabajadores(int cedula,string nombre,int edad, string residencia,string cargo,int horasTrabajadas,string jornada)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.edad = edad;
            this.residencia = residencia;
            this.cargo = cargo;
            this.horasTrabajadas = horasTrabajadas;
            this.jornada = jornada;
        }

        public objTrabajadores()
        {

        }
    } 
}
