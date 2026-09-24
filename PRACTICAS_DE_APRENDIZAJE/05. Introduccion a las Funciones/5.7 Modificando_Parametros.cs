using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._5._Introduccion_a_las_Funciones
{
    internal class Modificando_Parametros
    {

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_7_1

        /*Crear una función "intercambia", que intercambie el valor de los dos números enteros que se le indiquen como parámetro. */

        public static void Intercambiar(ref int num1, ref int num2)
        {
            int temporal = num1;
            num1 = num2;
            num2 = temporal;
        }

        public static void LlamarIntercambiar()
        {
            int num1 = 10;
            int num2 = 20;
            Console.Write("Num1: {0} \nNum2: {1}", num1, num2);
            Intercambiar(ref num1, ref num2);
            Console.Write("\nNum1: {0} \nNum2: {1}", num1, num2);
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_7_2

        /* Crear una función "iniciales", que reciba una cadena como "Nacho Cabanes" y devuelva las letras N y C (primera letra, y letra situada tras el primer 
          * espacio), usando parámetros por referencia.*/
        public static void Iniciales(ref string inicial)
        {
            string primeraLetra = inicial[0].ToString();
            string segundaLetra = "";

            for (int i = 0; i < inicial.Length; i++)
            {
                if (inicial[i] == ' ')
                {
                    segundaLetra = inicial[i + 1].ToString();
                    break;
                }
            }
            inicial = primeraLetra + " , " + segundaLetra;
        }

        public static void LlamarIniciales()
        {
            Console.WriteLine("Ejercicio de funciones");
            Console.WriteLine("\nIntroduce una cadena dos pcadenas separadado por un espacio y se te mostrara las inciales de cada cadena:");
            Console.Write("\nTextos: ");
            string inicial = Console.ReadLine();

            Iniciales(ref inicial);

            Console.WriteLine(inicial);
        }
    }
}
