using System;
using System.Collections.Generic;

namespace JustAnotherConsoleApp
{
    class Program
    {
        public static List<int> Numeros = new List<int>();
        public static void Main(string[] args)
        {
            Menu();
        }
        private static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("List Handler: \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menu:\n");
            Console.WriteLine("1.Agregar elemento a la lista.");
            Console.WriteLine("2.Mostrar Lista.");
            Console.WriteLine("3.Eliminar ultimo elemento de la lista.");
            Console.WriteLine("4.Eliminar un elemento de la lista.");
            Console.WriteLine("5.Salir");
            string? Opcion = Console.ReadLine();
            switch (Opcion)
            {
                case "1":
                    AgregarElemento(Numeros);
                    break;
                case "2":
                    MostrarLista(Numeros);
                    break;
                case "3":
                    EliminarUltimoElemento(Numeros);
                    break;
                case "4":
                    EliminarElementoLista(Numeros);
                    break;
                case "5":
                    Salir();
                    break;
            }
        }
        private static void AgregarElemento(List<int> Lista)
        {
            Console.Write("\nEscriba el dato que desea insertar: ");
            string? DatoString = Console.ReadLine();
            int Dato;
            if (!string.IsNullOrEmpty(DatoString) && int.TryParse(DatoString, out Dato)){
                Dato = Convert.ToInt32(DatoString);
                Lista.Add(Dato);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDato insertado correctamente.");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                Menu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("\nEl dato insertado no puede ser nulo o ser de un formato diferente a entero.");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                Menu();
            }
        }
        private static void MostrarLista(List<int> Lista)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elementos de la lista: \n");
            Console.ForegroundColor = ConsoleColor.White;

            for(int i = 0; i < Lista.Count; i++)
            {
                Console.Write("- {0} ",Lista[i]);
            }
            Console.ReadKey();
            Menu();
        }
        private static void EliminarUltimoElemento(List<int> Lista)
        {
            Lista.RemoveAt(Lista.Count);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nElemento eliminado con exito\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Menu();
        }
        private static void EliminarElementoLista(List<int> Lista)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nEscriba el dato del elemento que desea eliminar: ");
            Console.ForegroundColor = ConsoleColor.White;
            string? DatoString = Console.ReadLine();
            int Dato;
            if (string.IsNullOrEmpty(DatoString) && int.TryParse(DatoString, out Dato))
            {
                Dato = Convert.ToInt32(DatoString);
                Lista.Remove(Dato);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEl dato ha sido eliminado con exito.\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Menu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEl dato debe ser entero, no puede estar vacio o tener caracteres.\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                EliminarElementoLista(Lista);
            }
        }
        private static void Salir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ha salido con exito.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\nHecho por Manases Lovera");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.WriteLine("\n\n");
        }
    }
}