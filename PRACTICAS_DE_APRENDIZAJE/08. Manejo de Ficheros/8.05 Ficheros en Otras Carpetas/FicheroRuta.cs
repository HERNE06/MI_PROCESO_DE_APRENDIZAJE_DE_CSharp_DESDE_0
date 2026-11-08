using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._05_Ficheros_en_Otras_Carpetas
{
    //Ejercicio 8.5.1

    /*Crear un programa que pida al usuario pares de números enteros y escriba su suma (con el formato "20 + 3 = 23") en pantalla y en 
     *un fichero llamado "sumas.txt", que se encontrará en un subdirectorio llamado "resultados". Cada vez que se ejecute el programa, 
     *deberá añadir los nuevos resultados a continuación de los resultados de las ejecuciones anteriores.*/

    internal class FicheroRuta
    {
        public static void Ejercicio8_5_1()
        {
            int num1, num2, resultado;

            Console.WriteLine("LOS RESULTADOS DE LA SUMA SE GUARDARAN EN UN FICHERO\n");

            Console.Write("Primer numero: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            resultado = num1 + num2;
            Console.WriteLine("\n{0} + {1} = {2}", num1, num2, resultado);

            StreamWriter fichero = File.AppendText(@"..\..\resultados\sumas.txt");

            fichero.WriteLine(num1.ToString() + " + " + num2.ToString() + " = " + resultado.ToString());
            fichero.Close();

        }
    }
}
