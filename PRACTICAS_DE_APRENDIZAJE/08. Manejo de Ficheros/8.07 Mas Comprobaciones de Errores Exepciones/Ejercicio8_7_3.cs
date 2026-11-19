using System;
using System.IO;

namespace PRACTICAS_DE_APRENDIZAJE._08._Manejo_de_Ficheros._8._07_Mas_Comprobaciones_de_Errores_Exepciones
{
    //Ejercicio 8.7.3

    /* Un programa que pida al usuario repetidamente pares de números y la operación a realizar con ellos (+, -, *, /) y guarde en un 
     * fichero "calculadora.txt" el resultado de dichos cálculos (con la forma "15 * 6 = 90"). Debe controlar los posibles errores, 
     * como que los datos no sean numéricos, la división entre cero, o que el fichero no se haya podido crear.*/

    internal class Ejercicio8_7_3
    {
        public static void Ejercicio()
        {
            Console.WriteLine("C A L C U L A D O R A\n");

            int num1, num2, resultado;
            char operador;
            bool continuar = true;
            StreamWriter fichero; ;

            while (continuar)
            {
                Console.Write("Primer numero: ");
                string dato1 = Console.ReadLine();
                if (dato1 == "") break;

                try
                {
                    num1 = Convert.ToInt32(dato1);

                    Console.Write("Segundo numero: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Operador (+, -, *, /): ");
                    operador = Convert.ToChar(Console.ReadLine());

                    fichero = File.AppendText("calculadora.txt");

                    switch (operador)
                    {
                        case '+':
                            resultado = num1 + num2;
                            fichero.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
                            break;
                        case '-':
                            resultado = num1 - num2;
                            fichero.WriteLine("{0} - {1} = {2}", num1, num2, resultado);
                            break;
                        case '*':
                            resultado = num1 * num2;
                            fichero.WriteLine("{0} * {1} = {2}", num1, num2, resultado);
                            break;
                        case '/':
                            resultado = num1 / num2;
                            fichero.WriteLine("{0} / {1} = {2}", num1, num2, resultado);
                            break;
                        default:
                            Console.WriteLine("Operacion no valida (+, -, *, /).");
                            continue;
                    }
                    fichero.Close();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Solo es valido numeros para realizar la operacion.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("El archivo donde quiere guardar las operaciones no existe.");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("No tienes permiso a este archivo");
                }
                catch(IOException e)
                {
                    Console.WriteLine("error: {0}", e);
                }
                catch(Exception e)
                {
                    Console.WriteLine("error: {0}", e);
                }
            }
            Console.WriteLine("Fin del Programa.");
        }
    }
}

 
 
 
