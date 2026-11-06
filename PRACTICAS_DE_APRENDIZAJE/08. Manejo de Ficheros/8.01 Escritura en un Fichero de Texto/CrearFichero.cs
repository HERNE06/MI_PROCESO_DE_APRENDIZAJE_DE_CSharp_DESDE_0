using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._01_Escritura_en_un_Fichero_de_Texto
{
   //Ejercicio 8.1.1
   //
    /*Crea un programa que vaya leyendo las frases que el usuario teclea y las guarde en un fichero de texto llamado 
     * "registroDeUsuario.txt". Terminará cuando la frase introducida sea "fin" (esa frase no deberá guardarse en el fichero).*/

    public class CrearFichero
    {
        public static void EscrituraFichero()
        {
            Console.WriteLine("GUARDAR FRASES DEL USUARIO EN UN FICHIERO");

            Console.Write("\nFrase: ");
            string frase = Console.ReadLine();

            StreamWriter fichero = File.CreateText("RegistroUsuario.txt");

            while (frase.ToLower() != "fin")
            {              
                fichero.WriteLine(frase);

                Console.Write("\nFrase: ");
                frase = Console.ReadLine();
            }

            fichero.Close();
        }
    }
}
