using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._07_Mas_Comprobaciones_de_Errores_Exepciones
{
    //Ejercicio 8.7.2

    /*Un programa que pida al usuario un número, una operación (+, -, *, /) y un segundo número, y muestre el resultado de la correspondiente 
     *operación. Si se teclea un dato no numérico, el programa deberá mostrar un aviso y volver a pedirlo, en vez de interrumpir la ejecución.*/
    internal class Ejercicio8_7_2
    {
        public static void Ejercicio()
        {
            Console.WriteLine("CALCULADORA BASICA\n");

            int num1, num2, resultado;
            char operador;
            do
            {
                try
                {
                    Console.Write("Primer numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Operador (+, -, *, /): ");
                    operador = Convert.ToChar(Console.ReadLine());
                    Console.Write("Segundo numero: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (operador == '+')
                    {
                        resultado = num1 + num2;
                        Console.WriteLine("\n{0} + {1} = {2}", num1, num2, resultado);
                    }
                    else if (operador == '-')
                    {
                        resultado = num1 - num2;
                        Console.WriteLine("\n{0} - {1} = {2}", num1, num2, resultado);
                    }
                    else if (operador == '*')
                    {
                        resultado = num1 * num2;
                        Console.WriteLine("\n{0} x {1} = {2}", num1, num2, resultado);
                    }
                    else if (operador == '/')
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("\n{0} ÷ {1} = {2}", num1, num2, resultado);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nDebe escribir un numero y la operacion correspondiente");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("\nNo se puede dividir por cero");
                }
            } while (true);
            
        }
    }
}
