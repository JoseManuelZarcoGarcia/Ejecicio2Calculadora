using Ejercicio2Calculadora.Servicios;

namespace Ejercicio2Calculadore.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            Ejercicio2MenuInterfaz im = new Ejercicio2MenuImplementacion();
            Ejercicio2CalculosInterfaz ic = new Ejercicio2CalculosImplementacion();



            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = im.implementacionMenu();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 1:
                        Console.WriteLine("[info] - se cerrara el programa");
                        cerrarMenu = true;
                        break;

                    case 2:
                        Console.WriteLine("[info] - suma");
                        ic.suma();
                        break;

                    case 3:
                        Console.WriteLine("[info] - resta");
                        ic.resta();
                        break;

                    case 4:
                        Console.WriteLine("[info] - multiplicacion");
                        ic.multiplicacion();
                        break;

                    case 5:
                        Console.WriteLine("[info] - division");
                        ic.division();
                        break;

                    default:
                        Console.WriteLine("[info] - la opcion deseada no existe.");
                        break;
                }

            }

        }

    }

}