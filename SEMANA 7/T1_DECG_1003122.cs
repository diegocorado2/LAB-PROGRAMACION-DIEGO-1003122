using System;

namespace T1_DECG_1003122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi Segundo Programa");
            string NOMBRE, EDAD, CARRERA, CARNE;
            Console.WriteLine();
            Console.WriteLine("ingrese nombre");
            NOMBRE = Console.ReadLine();
            Console.WriteLine("ingrese edad");
            EDAD = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ingrese carrera");
            CARRERA = Console.ReadLine();
            Console.WriteLine("ingrese carné");
            CARNE= Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Soy " + NOMBRE + " tengo " + EDAD + " años y estudio la carrera de " + CARRERA+". "+


"Mi número de carné es " + CARNE);



        }
    }
}
