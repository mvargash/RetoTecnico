using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetoTecnicoLogica;

namespace RetoTecnico
{
    class RetoMain
    {
        private static Program _program = new Program();

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int opcion;

            do
            {
                Console.WriteLine("Bienvenidos al Reto Técnico");
                Console.WriteLine("===========================");
                Console.WriteLine("Seleccione una opciones:");
                Console.WriteLine("1.- Repeticiones encontradas");
                Console.WriteLine("2.- Buscar las repeticiones");
                Console.WriteLine("3.- Salir");


                do
                {                   
                    opcion = Int32.Parse((Console.ReadLine()));
                } while (opcion < 0);

                switch (opcion)
                {

                    case 1:
                        _program.ObtenerRepeticiones();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese filtro");
                        string filtro = Console.ReadLine();
                        _program.ObtenerRepeticiones(filtro);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Menu();
                        break;
                }

            } while (opcion != 0);
        }
    }
}
