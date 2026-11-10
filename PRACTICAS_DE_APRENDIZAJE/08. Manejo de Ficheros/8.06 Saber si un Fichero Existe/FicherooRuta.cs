using System;
using System.IO;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._06_Saber_si_un_Fichero_Existe
{
    //Ejervicio 8.6.1

    /*Mejorar el ejercicio 8.3.2 para que compruebe antes si el fichero existe, y muestre un mensaje de aviso en caso de que no sea así.*/
    internal class FicherooRuta
    {
        public static void Ejercicio_8_6_1()
        {
            Console.WriteLine("BUSCAR FICHERO POR NOMBRE");

            string linea, ficheroBuscado, enter;

            Console.Write("Nombre del Fichero: ");
            ficheroBuscado = Console.ReadLine();

            if (File.Exists(ficheroBuscado))
            {
                StreamReader fichero = File.OpenText(ficheroBuscado);
                do
                {
                    for (int i = 0; i < 25; i++)
                    {
                        linea = fichero.ReadLine();
                        if (linea != null)
                        {
                            Console.WriteLine(linea);
                        }
                        if (linea == null)
                        {
                            fichero.Close();
                            break;
                        }
                    }

                    Console.WriteLine("\nPreciona Enter para seguir mostrando.");
                    enter = Console.ReadLine();

                } while (enter == "");
            }
            else Console.WriteLine("El fichero que busca no existe");
        }
    }
}
