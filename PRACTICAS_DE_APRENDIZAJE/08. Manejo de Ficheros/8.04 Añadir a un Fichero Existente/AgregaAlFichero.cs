using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._04_Añadir_a_un_Fichero_Existente
{
    //Ejercicio 8.4.1

    /*Un programa que pida al usuario que teclee frases, y las almacene en el fichero "registro.txt", que puede existir anteriormente 
     *(y que no deberá borrarse, sino añadir al final de su contenido). Cada sesión acabará cuando el usuario pulse Intro sin teclear nada.*/

    internal class AgregaAlFichero
    {
        public static void FicheroAgregar()
        {
            Console.WriteLine("AGRAGAR FRASES A UN FICHERO EXISTENTE\n");
            string frase;
            StreamWriter fichero = File.AppendText("registro.txt");

            do
            {
                Console.Write("Escribe la Frase: ");
                frase = Console.ReadLine();

                fichero.WriteLine(frase);

            } while (frase != "");

            fichero.Close();

            Console.WriteLine("\nCONTENIDO DE FICHERO\n");

            string linea;
            StreamReader fichero2 = File.OpenText("registro.txt");

            do
            {
                linea = fichero2.ReadLine();
                if (linea != null) Console.WriteLine(linea);

            } while (linea != null);
        }
    }
}
