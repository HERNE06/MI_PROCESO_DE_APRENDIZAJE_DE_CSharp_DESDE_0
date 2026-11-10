using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._07_Mas_Comprobaciones_de_Errores_Exepciones
{
    //Ejercicio 8.7.1

    /* Un programa que pida al usuario el nombre de un fichero de origen y el de un fichero de destino, y que vuelque al segundo fichero el 
     * contenido del primero, convertido a mayúsculas. Se debe controlar los posibleserrores, como que el fichero de origen no exista, o que 
     * el fichero de destino no se pueda crear.*/

    internal class Ejercicio8_7_1
    {
        public static void EJercicio()
        {
            Console.WriteLine("MOVER DATOS CONVERTIDOS A MAYUSCULAS DE UNA FICHERO A OTRO\n");

            string ficheroOrigenN, ficheroDestinoN, linea;

            StreamReader ficheroOrigen;
            StreamWriter ficheroDestino;

            Console.Write("Nombre del fichero de origen: ");
            ficheroOrigenN = Console.ReadLine();
            Console.Write("Nombre del fichero de destino: ");
            ficheroDestinoN = Console.ReadLine();

            try
            {
                ficheroOrigen = File.OpenText(ficheroOrigenN);
                ficheroDestino = File.CreateText(ficheroDestinoN);

                do
                {
                    linea = ficheroOrigen.ReadLine();
                    if (linea != null)
                    {                       
                        ficheroDestino.WriteLine(linea.ToUpper());
                    }

                } while (linea != null);

                ficheroOrigen.Close();
                ficheroDestino.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo buscado no existe");
            }
            catch(IOException ex)
            {
                Console.WriteLine("Ha ocurrido un error! {0}", ex);
            }
        }
    }
}
