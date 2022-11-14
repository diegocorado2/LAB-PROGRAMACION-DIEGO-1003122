using System;

namespace Proyecto2_Album
{
    class Program
    {
        static Album album;
        static void marcarEstampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if(i>=0)
            {
                album.estampas[i].marcar();
                
            }
            else 
            {
                Console.WriteLine("Estamapa no encontrada");
            }
        }

        static void RepetirEstampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if (i >= 0)
            {
                album.estampas[i].repetir();
                
            }
            else
            {
                Console.WriteLine("Estamapa no encontrada");
            }
        }

        static void EstampaFaltante(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if (i >= 0)
            {
                album.estampas[i].repetir();             
            }
            else
            {
                Console.WriteLine("Estamapa no encontrada");
            }
        }


        static void Main(string[] args)
        {
            album = new Album();

            album.mostrarMarcadas();
          
            int opcion=0;          
            do
            {
                Console.WriteLine("Ingresar el codigo de la estampa·");
                String cod = Console.ReadLine();
                
                Console.WriteLine("___Bienvenido Elegia una Opción___");
                Console.WriteLine("1. Revisar Estampas Marcadas");
                Console.WriteLine("2. Revisar Estampas repetidas");
                Console.WriteLine("3. Revisar Estampas faltantes ");
                Console.WriteLine("4. Salir");

                Console.Write("Ingresar Opción: ");
                opcion = int.Parse(Console.ReadLine());

                 if (opcion==1)
                 {
                    marcarEstampa(cod);
                    album.mostrarMarcadas();                   
                 }

                else if(opcion==2)
                {
                    RepetirEstampa(cod);
                    album.mostrarRepetidas();
                }

                else if(opcion==3)
                {
                    EstampaFaltante(cod);
                    album.mostrarFalatantes();
                }

                 else if(opcion==4)
                {
                    Console.WriteLine("ADIOS");
                }

                else Console.WriteLine("Opción No Valida");

                Console.ReadKey();
                Console.Clear();

            } while (opcion != 4);
        }
    }
}
