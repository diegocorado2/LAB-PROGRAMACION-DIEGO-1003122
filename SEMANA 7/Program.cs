using System;

namespace L1_DECG_1003122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre:");
            string nombre = Console.ReadLine(); 

            Console.WriteLine("Hola Mundo");
            Console.WriteLine("soy" + nombre);

            Console.Write("Hola Mundo");
            Console.Write("soy " + nombre);

            Console.ReadKey();
        }
    }
}
