﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Operaciones
    {
        /// <summary>
        /// Calcular la suma de los elementos de una array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>double</returns>
        public double Suma(double[] array) 
        {
            double suma = 0;
            foreach (double x in array)
            {
                suma += x;
            }
            return suma;
        }

        
        /// <summary>
        /// Retorna una cadena con un saludo
        /// </summary>
        /// <param name="nombrePersona"></param>
        /// <returns></returns>
        public string Saludo(string nombrePersona)
        {
            return "Bienvenido " + nombrePersona;
        }
    }
}
