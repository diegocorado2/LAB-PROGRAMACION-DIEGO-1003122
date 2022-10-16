using System;

namespace L10_DECG_1003122
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo_Rectangulo triangulo = new Triangulo_Rectangulo();
            Console.Write("INGRESE EL CATETO A: ");
            triangulo.catetoA = double.Parse(Console.ReadLine());

            Console.Write("Ingrese El Angulo Opuesto a A: ");
            triangulo.anguloOpuestoA = double.Parse(Console.ReadLine());


            Console.WriteLine("CATETO B: " + triangulo.ObtenerCatetoB());
            Console.WriteLine("HIPOTENUSA: " + triangulo.ObtenerHipotenusa());
            Console.WriteLine("ANGULO OPUESTO a B: " + triangulo.ObtenerAnguloOpuestoB());
            Console.WriteLine("AREA DEL TRIANGULO: " + triangulo.ObtenerArea());

        }
    }
}
