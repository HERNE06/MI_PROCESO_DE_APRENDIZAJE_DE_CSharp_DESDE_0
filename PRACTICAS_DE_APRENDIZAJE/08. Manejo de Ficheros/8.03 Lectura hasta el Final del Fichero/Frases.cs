using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._03_Lectura_hasta_el_Final_del_Fichero
{
    // Ejercicio 8.3.1

    /* Un programa que pida al usuario que teclee frases, y las almacene en el fichero "frases.txt". Acabará cuando el usuario 
     * pulse Intro sin teclear nada. Después deberá mostrar el contenido del fichero.*/

    internal class Frases
    {
        public static void FicheroFrases()
        {
            Console.WriteLine("GUARDAR FRASES INTRODUCIDAS POR EL USUARIO\n");

            string frase;
            StreamWriter wFichero = File.CreateText("frases.txt");

            Console.Write("Frase: ");
            frase = Console.ReadLine();

            while(frase != "")
            {
                wFichero.WriteLine(frase);

                Console.Write("Frase: ");
                frase = Console.ReadLine();
            }

            wFichero.Close();

            Console.WriteLine("\nFRASES GUARDADAS POR EL USUARIO");

            string linea;
            StreamReader rFichero = File.OpenText("frases.txt");

            do
            {
                linea = rFichero.ReadLine();
                if(linea != null) Console.WriteLine(linea);

            } while (linea != null);

            rFichero.Close();
        }
    }
}
