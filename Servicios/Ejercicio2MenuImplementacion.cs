using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Calculadora.Servicios
{
    internal class Ejercicio2MenuImplementacion : Ejercicio2MenuInterfaz
    {
        /// <summary>
        /// Metodo que inserta el menu
        /// jzg - 091029
        /// </summary>
        /// <returns></returns>
        public int implementacionMenu()
        {

            int eleccionSeleccionada;

            Console.WriteLine("###############################");
            Console.WriteLine("1. Cerrar ");
            Console.WriteLine("2. Suma ");
            Console.WriteLine("3. Resta ");
            Console.WriteLine("4. Multiplicación ");
            Console.WriteLine("5. División ");
            Console.WriteLine("###############################");
            Console.WriteLine("seleccione una opcion");

            eleccionSeleccionada = Console.ReadKey(true).KeyChar - ('0');

            return eleccionSeleccionada;
        }

        

    }
}
