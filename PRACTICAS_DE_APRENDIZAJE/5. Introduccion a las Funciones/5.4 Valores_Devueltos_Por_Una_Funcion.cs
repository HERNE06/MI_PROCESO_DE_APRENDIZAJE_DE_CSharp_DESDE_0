using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._5._Introduccion_a_las_Funciones
{
    internal class Valores_Devueltos_Por_Una_Funcion
    {

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_1
        /* Crear una función que calcule el cubo de un número real (float) que se indique como parámetro. El resultado deberá ser otro número real. Probar esta 
        * función para calcular el cubo de 3.2 y el de 5.*/

        public static float CuboNumero(float n)
        {
            return n * n * n;
        }

        public static void LlamarCuboNumero()
        {
            float numero = 3.2f;
            float resultado;

            resultado = CuboNumero(numero);
            Console.WriteLine("{0} elecado a 3 = {1}", numero, resultado);
            Console.WriteLine("y 5 elevado a 3 = {0}", CuboNumero(5));

        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_2
        /*Crear una función que calcule el menor de dos números enteros que recibirá como parámetros. El resultado será otro número entero. */

        public static int NumeroMenorQue(int num1, int num2)
        {
            if (num1 < num2) return num1;
            else return num2; ;
        }

        public static void LlamarNumeroMenorQue()
        {
            Console.WriteLine("Escribe 2 numeros");

            Console.Write("\nNumero 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNumero 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = NumeroMenorQue(num1, num2);
            Console.WriteLine("\nEl numero menor es {0}", resultado);
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_3
        /* Crear una función llamada "signo", que reciba un número real, y devuelva un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/

        public static int NumeroNegativoPositivo(float num)
        {
            if (num < 0) return -1;
            else if (num == 0) return 0;
            else return 1;
        }

        public static void LlamarNumeroNegativoPositivo()
        {
            Console.Write("Introduce un numero: ");
            float nume = Convert.ToSingle(Console.ReadLine());

            int resultado = NumeroNegativoPositivo(nume);

            Console.WriteLine(resultado);

        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_4
        /* Crear una función que devuelva la primera letra de una cadena de texto. Probar esta función para calcular la primera letra de la frase "Hola".*/

        public static char PrimeraLetraString(string cadena)
        {
            return cadena[0];
        }

        public static void LlamarPrimeraLetraString()
        {
            Console.WriteLine("Calcular cual es la primera letra de una frase");
            char letra = PrimeraLetraString("Hola");
            Console.WriteLine(letra);
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_5
        /* Crear una función que devuelva la última letra de una cadena de texto. Probar esta función para calcular la última letra de la frase "Hola".*/

        public static char UltimaLetraStrig(string cadena)
        {
            int total = cadena.Length;
            return cadena[total - 1];
        }

        public static void LlamarUltimaLetraString()
        {
            Console.WriteLine("Calcular cual es la ultima letra de una frase");
            char letra = UltimaLetraStrig("Hola");
            Console.WriteLine(letra);
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_6
        /* Crear una función que reciba un número y calcule y muestre en pantalla el valor del perímetro y de la superficie de un cuadrado que tenga como lado 
          * el número que se ha indicado como parámetro.*/

        public static void CalcularPerimetroyArea(int x)
        {
            int area = x * x;
            int perimetro = x * 4;

            Console.WriteLine("El perimetro es: {0} \n El area es: {1}.", perimetro, area);
        }

        public static void LlamarCualcularPerimetroyArea()
        {
            Console.WriteLine("CALCULAR PERIMETRO Y AREA.");
            Console.Write("\nMedida: ");
            int medida = Convert.ToInt16(Console.ReadLine());
            CalcularPerimetroyArea(medida);
        }
    }
}
