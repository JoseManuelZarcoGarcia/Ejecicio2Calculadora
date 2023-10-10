using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Calculadora.Servicios
{
    internal interface Ejercicio2CalculosInterfaz
    {
        /// <summary>
        /// Llamada al metodo que pregunta el primer numero
        /// jzg - 101023
        /// </summary>
        /// <returns></returns>
        public int dameUnNum();

        /// <summary>
        /// Llamada al metodo que pregunta el segundo numero
        /// jzg - 101023
        /// </summary>
        /// <returns></returns>
        public int dameOtroNum();

        /// <summary>
        /// Llamada al metodo que implementa el metodo suma
        /// jzg - 101023
        /// </summary>
        /// <returns></returns>
        public void suma();

        /// <summary>
        /// Llamada al metodo que implementa el metodo resta
        /// jzg - 101023
        /// </summary>
        /// <returns></returns>
        public void resta();

        /// <summary>
        /// Llamada al metodo que implementa el metodo multiplicacion
        /// jzg - 101023
        /// </summary>
        /// <returns></returns>
        public void multiplicacion();

        /// <summary>
        /// Llamada al metodo que implementa el metodo division
        /// jzg - 101023
        /// </summary>
        /// <returns></returns>
        public void division();

    }
}
