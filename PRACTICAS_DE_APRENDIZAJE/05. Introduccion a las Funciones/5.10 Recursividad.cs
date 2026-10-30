using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._5._Introduccion_a_las_Funciones
{
    internal class Recursividad
    {

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_1

        /*Crear una función que calcule el valor de elevar un número entero a otro número entero (por ejemplo, 5 elevado a 3 = 53 = 5 ·5 ·5 = 125). 
            * Esta función se debe crear de forma recursiva. */
        public static double PotenciaRecursividad(double basee, double exponente)
        {
            if (exponente == 1)
                return basee;

             return basee * PotenciaRecursividad(basee, exponente - 1);
        }

        public static void LlamarRecursividad()
        {
            Console.WriteLine("POTENCIAAAAAAAAAAAAAAAAAA");

            Console.Write("Base: ");
            double basee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Exponente: ");
            double exponente = Convert.ToDouble(Console.ReadLine());

            double resultado = PotenciaRecursividad(basee, exponente);

            Console.WriteLine("{0} elevado a {1} = {2}", basee, exponente, resultado);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_2

        /* Como alternativa, crear una función que calcule el valor de elevar un número entero a otro número entero de forma NO recursiva 
          * (lo que llamaremos "de forma iterativa"), usando la orden "for".*/
        public static int Potencia(int basee, int exponente)
        {
            int resultado = 1;
            for (int i = 1; i <= exponente; i++) 
            {
                resultado *= basee;
            }
            return resultado;
        }

        public static void LlamarPotencia()
        {
            Console.WriteLine("POTENCIAAAAAAAAAAAAAAAAAA");

            Console.Write("Base: ");
            int basee = Convert.ToInt32(Console.ReadLine());
            Console.Write("Exponente: ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            int resultado = Potencia(basee, exponente);
            Console.WriteLine("{0} elevado a {1} = {2}", basee, exponente, resultado);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_3

        /*Crear un programa que emplee recursividad para calcular un número de la serie Fibonacci (en la que los dos primeros elementos valen 1, 
          * y para los restantes, cada elemento es la suma de los dos anteriores). */
        public static void  SucecionFibonacci(int num1, int num2)
        {
            if (num2 < 500)
                return;

            Console.Write(num1 + " ");

            SucecionFibonacci(num2, num1 + num2);

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_4

        /* Crear un programa que emplee recursividad para calcular la suma de los elementos de un vector.*/
        public static int SumaVectorRecursividad(int[] numeros, int contador)
        {
            if(contador == numeros.Length)
            {
                return 0;
            }

            return numeros[contador] + SumaVectorRecursividad(numeros, contador + 1);
        }

        public static void LlamarSumaVector() 
        {
            int[] numeros = { 2, 2, 2, 2, 2, 2 };
            int resultado = SumaVectorRecursividad(numeros, 0);
            Console.WriteLine("La suma de lso elementos es: {0}", resultado);

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_5

        /* Crear un programa que emplee recursividad para calcular el mayor de los elementos de un vector.*/
        public static int ElementosMayorVector(int[] numeros, int indice)
        {
            if (indice == numeros.Length - 1) 
            {
                return numeros[indice];
            }
            
            int mayor;

            mayor = ElementosMayorVector(numeros, indice + 1);

            if(mayor > numeros[indice]) 
            {
                return mayor;
            }

            return numeros[indice];
        }

        public static void LlamarElementosMayor()
        {
            int[] vector = { 10, 15, 50, 500, 4, 12, 25 };
            Console.WriteLine("Cual elementos de este vectos {10, 15, 50, 8, 500, 12, 25} es mayor");

            int elementoMayor = ElementosMayorVector(vector, 0);
            Console.WriteLine("El elemento mayor es: {0}", elementoMayor);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_6

        /* Crear un programa que emplee recursividad para dar la vuelta a una cadena de caracteres 
         * (por ejemplo, a partir de "Hola" devolvería "aloH").*/
        public static string CadernaInvertidaRecursica(string cadena, int posicion)
        {
            if (posicion == -1)
            {
                return "";
            }

            string cadena2 = CadernaInvertidaRecursica(cadena, posicion - 1);

            return cadena[posicion] + cadena2;

        }

        public static void LlamarCadenaInvertida()
        {
            string cadena = "Hola";
            int posicion = cadena.Length - 1;
            string cadenaInvertida = CadernaInvertidaRecursica(cadena, posicion);
            Console.WriteLine(cadenaInvertida);
        }
        
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_7

        /*Crear, tanto de forma recursiva como de forma iterativa, una función diga si una cadena de caracteres es simétrica (un palíndromo). 
         *Por ejemplo, "DABALEARROZALAZORRAELABAD" es un palíndromo. */
        public static void Palindromo()
        {
            Console.WriteLine("ES O NO UN PALINDROMO");

            bool palindromo = true;
            string palabra = "oso";

            for(int i = 0; i < palabra.Length / 2; i++) 
            {
                if (palabra[i] != palabra[palabra.Length - 1 - i])
                {
                    palindromo = false;
                    break;
                }
            }

            if (palindromo) Console.WriteLine("La palabra {0} es un palindromo", palabra);
            else Console.WriteLine("La palabra {0} no es un palindromo", palabra);

        }

        public static bool PalindromoRecursivo(string palabra, int indice)
        {
            if(indice == palabra.Length / 2)
            {
                return true;
            }

            bool palindromo = PalindromoRecursivo(palabra, indice + 1);

            if(palabra[indice] != palabra[palabra.Length - 1 - indice])
            {
                return false;
            }

            return palindromo;
        }

        public static void LlamarPlalindromo()
        {
            string palabra = "ose";
            bool palindromo = PalindromoRecursivo(palabra, 0);

            if (palindromo) Console.WriteLine("La palabra {0} es un palindromo", palabra);
            else Console.WriteLine("La palabra {0} no es un palindromo", palabra);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_8

        /* Crear un programa que encuentre el máximo común divisor de dos números usando el algoritmo de Euclides: Dados dos números enteros 
         * positivos m y n, tal que m > n, para encontrar su máximo común divisor, es decir, el mayor entero positivo que divide a ambos: 
         * - Dividir m por n para obtener el resto r (0 ≤ r < n) ; - Si r = 0, el MCD es n.; - Si no, el máximo común divisor es MCD(n,r).*/
        public static void MaximoComunDivisor()
        {

            Console.WriteLine("MCD DE DOS NUMEROS");
            int num1, num2, mod;

            Console.WriteLine("Escribe dos numeros para daber su MCD\n");
            Console.Write("Numero 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                mod = num1 % num2;
                num1 = num2;
                num2 = mod;

            } while (mod > 0);

            Console.WriteLine("El MCD es {0}", num1);       
        }

        public static int MCDRecursivo(int num1, int num2)
        {
            if(num1 % num2 == 0)
            {
                return num2;
            }

            return MCDRecursivo(num2, num1 % num2);

        }

        public static void LlamarMCDRecursivo()
        {

            Console.WriteLine("MCD DE DOS NUMEROS");
            int num1, num2;

            Console.WriteLine("Escribe dos numeros para daber su MCD\n");
            Console.Write("Numero 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = MCDRecursivo(num1, num2);
            Console.WriteLine("El MCD es {0}", resultado);

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_9


        /* Crea dos funciones que sirvan para saber si un cierto texto es subcadena de una cadena. No puedes usar "Contains" 
         * ni "IndexOf", sino que debes analizar letra a letra. Una función debe ser iterativa y la otra debe ser recursiva.*/
        public static bool EsSubCadena(string cadena, string texto)
        {
            for(int i = 0; i < cadena.Length; i++)
            {
                int j = 0;
                 while(j < texto.Length && i + j < cadena.Length && cadena[i + j] == texto[j])
                {
                    j++;
                }

                if (j == texto.Length) return true;
            }

            return false;


        }


        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_10_10

        /* Crea una función que reciba una cadena de texto, y una subcadena, y devuelva cuántas veces aparece la subcadena en la cadena, como 
         * subsecuencia formada a partir de sus letras en orden. Por ejemplo, si recibes la palabra "Hhoola" y la subcadena "hola", la respuesta 
         * sería 4, porque se podría tomar la primera H con la primera O (y con la L y con la A), la primera H con la segunda O, la segunda H con 
         * la primera O, o bien la segunda H con la segunda O. Si recibes "hobla", la respuesta sería 1. Si recibes "ohla", la respuesta sería 0, 
         * porque tras la H no hay ninguna O que permita completar la secuencia en orden.*/
        public static void CuantasVeces()
        {


        }
    }
}
