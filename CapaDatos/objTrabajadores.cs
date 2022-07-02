﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class objTrabajadores
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private string residencia { get; set; }
        private string cargo { get; set; }
        private int horasTrabajadas { get; set; }
        private string jornada { get; set; } 

        private objTrabajadores(string nombre,int edad, string residencia,string cargo,int horasTrabajadas,string jornada)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.residencia = residencia;
            this.cargo = cargo;
            this.horasTrabajadas = horasTrabajadas;
            this.jornada = jornada;
        }

        private objTrabajadores()
        {

        }
    } 
}