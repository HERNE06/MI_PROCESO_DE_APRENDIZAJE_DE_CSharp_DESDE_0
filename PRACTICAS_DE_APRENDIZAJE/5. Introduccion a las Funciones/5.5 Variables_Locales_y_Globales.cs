using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._5._Introduccion_a_las_Funciones
{
    internal class Variables_Locales_y_Globales
    {
        static void Main(string[] args)
        {

        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_5_1

        /* Crear una función "pedirEntero", que reciba como parámetros el texto que se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo 
         * aceptable. Deberá pedir al usuario que introduzca el valor tantas veces como sea necesario, volvérselo a pedir en caso de error, y devolver un valor 
         * correcto. Probarlo con un programa que pida al usuario un año entre 1800 y 2100.*/

        public static int PedirEntero(string texto, int minimo, int maximo)
        {
            Console.Write("Introduce el numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero < minimo && numero > maximo)
            {
                Console.WriteLine("Error, el numero debe estar entro {0} y {1}.", minimo, maximo);
                Console.WriteLine(texto);
                numero = Convert.ToInt32(Console.ReadLine());
            }
            return numero;
        }

        public static void LlamarPedirEntero()
        {
            string texto = "Introduce una numero entro 1800 y 2100";
            int anyo = PedirEntero(texto, 1800, 2100);
            Console.WriteLine("El numero introducido es : {0}", anyo);
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_5_2

        /* Crear una función "escribirTablaMultiplicar", que reciba como parámetro un número entero, y escriba la tabla de multiplicar de ese número 
            * (por ejemplo, para el 3 deberá llegar desde "3x0=0" hasta "3x10=30").*/

        public static void TablaMultiplicar(int num)
        {
            for (int i = 0; i <= 10; i++)
            {
                int resultado = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, resultado);
            }
        }

        public static void LlamarTablaMultiplicar()
        {
            Console.WriteLine("Escribe un numero para generar su tabla de multimplicacion");
            Console.Write("\nNumero: ");
            int num = Convert.ToInt16(Console.ReadLine());
            TablaMultiplicar(num);
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_5_3
        /* Crear una función "esPrimo", que reciba un número y devuelva el valor booleano "true" si es un número primo o "false" en caso contrario.*/

        public static bool EsPrimo(int num)
        {
            bool primo = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            return primo;
        }

        public static void LllamarEsPrimo()
        {
            Console.Write("Numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool resultado = EsPrimo(num);

            if (resultado) Console.WriteLine("Es primo");
            else Console.WriteLine("No es primo");
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_5_4
        /* Crear una función que reciba una cadena y una letra, y devuelva la cantidad de veces que dicha letra aparece en la cadena. Por ejemplo, si la cadena 
        * es "Barcelona" y la letra es 'a', debería devolver 2 (porque la "a" aparece 2 veces).*/

        public static int LetraEnTetxto(string texto, char letra)
        {
            int veces = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == letra)
                {
                    veces++;
                }
            }
            return veces;
        }

        public static void LlamarLetraEnTexto()
        {
            Console.WriteLine("Cuantas veces aparecen \"x\" letra en un texto");
            Console.Write("\nEscribe el texto: ");
            string texto = Console.ReadLine();

            Console.Write("Letra a contar: ");
            char letra = Convert.ToChar(Console.ReadLine());

            int cantida = LetraEnTetxto(texto, letra);

            Console.WriteLine("La letra \"{0}\" aparece {1} veces en el texto", letra, cantida);

        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_5_5
        /* Crear una función que reciba un numero cualquiera y que devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la suma sería 6.*/

        public static int SumarDigitos(string numeros)
        {
            int resultado = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                resultado += int.Parse(numeros[i].ToString());
            }

            return resultado;
        }

        public static void LlamarSumarDigitos()
        {
            Console.WriteLine("SUMA DE DIGITOS");
            Console.Write("Introduce el digito: ");
            string num = Console.ReadLine();

            int resultado = SumarDigitos(num);
            Console.WriteLine("El resultado es: {0}", resultado);
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_5_6
        /* Crear una función que reciba una letra y un número, y escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se 
        * ha indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir
        ****
        ***
        **
        *
        */

        public static void Triangula(int num, char letra)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    Console.Write(letra);
                }
                Console.WriteLine();
            }
        }

        public static void LlamarTriangulo()
        {
            Console.Write("Numero: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.Write("Letra: ");
            char letra = Convert.ToChar(Console.ReadLine());

            Triangula(num, letra);
        }
    }
}
