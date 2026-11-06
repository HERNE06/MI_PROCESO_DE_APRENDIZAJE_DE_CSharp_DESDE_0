using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._02_Lectura_de_un_Fichero_de_Texto
{
    //Ejercicio 8.2.1

    /*Crea un programa que lea las tres primeras líneas del fichero creado en el apartado anterior y las muestre en pantalla.*/

    internal class LeerFichero
    {
        public static void LecturaFichero()
        {
            Console.WriteLine("LEER UN FICHIERO\n");

            StreamReader fichero = File.OpenText("RegistroUsuario.txt");
            string linea;

            for(int i = 0; i < 3; i++)
            {
                linea = fichero.ReadLine();
                Console.WriteLine(linea);
            }
        }
    }
}
