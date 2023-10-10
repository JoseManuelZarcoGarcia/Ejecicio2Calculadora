using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Calculadora.Servicios
{
    internal class Ejercicio2CalculosImplementacion : Ejercicio2CalculosInterfaz
    {


        /// <summary>
        /// Metodo que pregunta y guarda el primer nuemro
        /// jzg - 101029
        /// </summary>
        /// <returns></returns>
        public int dameUnNum()
        {
            int numEscrito;

            Console.WriteLine("Escriba un numero: ");
            numEscrito = int.Parse(Console.ReadLine());

            return numEscrito;

        }

        /// <summary>
        /// Metodo que Metodo que pregunta y guarda el primer nuemro
        /// jzg - 101029
        /// </summary>
        /// <returns></returns>
        public int dameOtroNum()
        {
            int numEscrito;

            Console.WriteLine("Escriba otro numero: ");
            numEscrito = int.Parse(Console.ReadLine());

            return numEscrito;

        }


        public void suma() 
        {
            int num1, num2, resultado;

            num1 = dameUnNum();
            num2 = dameOtroNum();
            resultado=num1 + num2;

            Console.WriteLine(resultado);
        }

        public void resta()
        {
            int num1, num2, resultado;

            num1 = dameUnNum();
            num2 = dameOtroNum();
            resultado = num1 - num2;

            Console.WriteLine(resultado);
        }

        public void multiplicacion()
        {
            int num1, num2, resultado;

            num1 = dameUnNum();
            num2 = dameOtroNum();
            resultado = num1 * num2;

            Console.WriteLine(resultado);
        }

        public void division()
        {
            int num1, num2, resultado;

            num1 = dameUnNum();
            num2 = dameOtroNum();
            resultado = num1 / num2;

            Console.WriteLine(resultado);
        }
    }
}
