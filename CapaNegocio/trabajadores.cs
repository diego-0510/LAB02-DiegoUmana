using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class trabajadores
    { 
        private List<objTrabajadores> listTrabajadores = new List<objTrabajadores>();

        public void crearTrabajador(int cedula,string nombre,int edad,string residencia,string cargo,int horasTrabajadas,string jornada)
        {
            objTrabajadores trabajadores = new objTrabajadores(cedula,nombre, edad, residencia, cargo, horasTrabajadas, jornada);
            listTrabajadores.Add(trabajadores);
        }

        public dynamic[] buscarTrabajador(int cedula)
        {
            objTrabajadores trabajadorBuscado = new objTrabajadores();
            dynamic[] listaEncontrado = new dynamic[6];

            foreach (objTrabajadores buscandoTrabajador in listTrabajadores)
            {
                if (buscandoTrabajador.cedula == cedula)
                {
                    trabajadorBuscado = buscandoTrabajador;
                    listaEncontrado[0] = trabajadorBuscado.nombre;
                    listaEncontrado[1] = trabajadorBuscado.edad.ToString();
                    listaEncontrado[2] = trabajadorBuscado.residencia;
                    listaEncontrado[3] = trabajadorBuscado.cargo;
                    listaEncontrado[4] = trabajadorBuscado.horasTrabajadas.ToString();
                    listaEncontrado[5] = trabajadorBuscado.jornada;


                }
            }
            return listaEncontrado;

        }

        
    }
}
