using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._5._Introduccion_a_las_Funciones
{
    internal class Parametros_y_Valor_de_Retorno_Main 
    {

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_11_1

        /*Crear un programa llamado "suma", que calcule (y muestre) la suma de dos números que se le indiquen como parámetro. 
         * Por ejemplo, si se teclea "suma 2 3" deberá responder "5", y si se teclea "suma 2" deberá responder "no hay suficientes 
         * datos y devolver un código de error 1. */
        public static int Suma(string[] args)
        {
            if(args.Length == 2)
            {
                int num1 = Convert.ToInt32(args[0]);
                int num2 = Convert.ToInt32(args[1]);

                Console.WriteLine(num1 + num2);
                return 0;
            }
            else
            {
                Console.WriteLine("Non hay suficientes datos");
                return 1;
            }

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_11_2

        /*Crear una calculadora básica, llamada "calcula", que deberá sumar, restar, multiplicar o dividir los dos números que 
         * se le indiquen como parámetros. Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60". */
        public static void Calcula(string[] args)
        {
            int num1, num2;

            Console.WriteLine("CALCULADORA BASICA");

            if (args[1] == "+")
            {
                num1 = int.Parse(args[0]); 
                num2 = int.Parse(args[2]);
                Console.WriteLine("{0} + {1} = {2}",num1, num2, num1 + num2);
            }
            else if (args[1] == "-")
            {
                num1 = int.Parse(args[0]);
                num2 = int.Parse(args[2]);
                Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            }
            else if (args[1] == "*")
            {
                num1 = int.Parse(args[0]);
                num2 = int.Parse(args[2]);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            }
            else if (args[1] == "/")
            {
                num1 = int.Parse(args[0]);
                num2 = int.Parse(args[2]);
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            }
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_11_3

        /* Crear una variante del ejercicio 5.11.2, en la que Main devuelva el código 1 si la operación indicada no es válida 
         * o 0 cuando sí sea una operación aceptable.*/
        public static int CalcularVariante(string[] args)
        {

            int num1, num2;

            Console.WriteLine("CALCULADORA BASICA");

            if (args.Length == 3)
            {

                if (args[1] == "+")
                {
                    num1 = int.Parse(args[0]);
                    num2 = int.Parse(args[2]);
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                }
                else if (args[1] == "-")
                {
                    num1 = int.Parse(args[0]);
                    num2 = int.Parse(args[2]);
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                }
                else if (args[1] == "*")
                {
                    num1 = int.Parse(args[0]);
                    num2 = int.Parse(args[2]);
                    Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
                }
                else if (args[1] == "/")
                {
                    num1 = int.Parse(args[0]);
                    num2 = int.Parse(args[2]);
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                }
                return 0;

            }
            else
            {
                Console.WriteLine("Operacion Invalida");
                return 1;
            }


        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_11_4

        /* Crear una variante del ejercicio 5.11.3, en la que Main devuelva también el código 2 si alguno de los dos números 
         * con los que se quiere operar no tiene un valor numérico válido.*/
        public static int CalcularVariante2(string[] args)
        {
            int num1, num2;

            Console.WriteLine("CALCULADORA BASICA");

            if (args.Length == 3)
            {

                if (args[1] == "+")
                {
                    num1 = int.Parse(args[0]);
                    num2 = int.Parse(args[2]);
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                }
                else if (args[1] == "-")
                {
                    num1 = int.Parse(args[0]);
                    num2 = int.Parse(args[2]);
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                }
                else if (args[1] == "*")
                {
                    num1 = int.Parse(args[0]);
                    num2 = int.Parse(args[2]);
                    Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
                }
                else if (args[1] == "/")
                {
                    if (int.Parse(args[2]) != 0)
                    {
                        num1 = int.Parse(args[0]);
                        num2 = int.Parse(args[2]);
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero");
                        return 1;
                    }
                }
                return 0;

            }
            else
            {
                Console.WriteLine("Operacion Invalida");
                return 1;
            }

        }
    }
}
