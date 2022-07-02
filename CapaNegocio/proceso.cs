using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class proceso
    { 
        private List<objTrabajadores> listTrabajadores = new List<objTrabajadores>();

        public void crearTrabajador(int cedula,string nombre,int edad,string residencia,string cargo,int horasTrabajadas,string jornada)
        {
            objTrabajadores trabajadores = new objTrabajadores(cedula,nombre, edad, residencia, cargo, horasTrabajadas, jornada);
            listTrabajadores.Add(trabajadores);
        }
    }
}
