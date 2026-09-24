using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._1.Toma_de_contacto_con_CSharp
{
    internal class Pequeñas_Mejoras_Ejercicios
    {
        static void Main(string[] args)
        {

        }

        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_9_1()
        {
            /*Multiplicar dos números tecleados por usuario. El programa deberá contener un comentario al principio, que recuerde cual es su objetivo.*/
            int num1, num2, resultado;
            Console.WriteLine("MULTIPLICACION DE DOS NUMEROS");
            Console.Write("Escribe el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe el Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = num1 * num2;
            Console.WriteLine(resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_9_2()
        {
            /*El usuario tecleará dos números (x e y), y el programa deberá calcular cuál es el resultado de su división y el resto de esa división. 
             * Deberás usar "Write" en vez de "WriteLine" para pedir los datos, e incluir un comentario con tu nombre y la fecha en que has realizado el programa.*/
            int x, y, resultado;
            Console.Write("Introduce un valor numerico para x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un valor numerico para y: ");
            y = Convert.ToInt32(Console.ReadLine());
            resultado = x / y;
            Console.WriteLine("El resultado de dividir x entre y el igual a: {0}", resultado);
            resultado = x % y;
            Console.WriteLine("El restante de la division es: {0}", resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_9_3()
        {
            /*El usuario tecleará dos números (a y b), y el programa mostrará el resultado de la operación (a+b)*(a-b) y el resultado de la operación a2-b2.*/
            int a, b, resultado;
            Console.Write("Escribe el valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe el valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());

            resultado = (a + b) * (a - b);
            Console.Write("(a+b)x(a-b) = {0}", resultado);

            resultado = a * 2 - b * 2;
            Console.Write("a2-b2 = {0}", resultado);

        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_9_4()
        {
            /*Sumar tres números tecleados por usuario.*/
            int num1, num2, num3, resultado;
            Console.WriteLine("SUMA DE TRES NUMERO");

            Console.Write("Escribre el primer numero:  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribre el segundo numero:  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribre el tercer numero:  ");
            num3 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2 + num3;
            Console.Write("El resultado es: {0}", resultado);

        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_9_5()
        {
            /*Pedir al usuario un número y mostrar su tabla de multiplicar. Por ejemplo, si el número es el 3, debería escribirse algo como
                3 x 0 = 0
                3 x 1 = 3
                3 x 2 = 6
…
                3 x 10 = 30*/
            int num, resultado;
            Console.WriteLine("TABLA DE MULTIPLICAR");
            Console.Write("Introduce la tabla que deseas: ");
            num = Convert.ToInt32(Console.ReadLine());

            resultado = num * 0;
            Console.WriteLine("{0} x 0 = {1}", num, resultado);
            resultado = num * 1;
            Console.WriteLine("{0} x 1 = {1}", num, resultado);
            resultado = num * 2;
            Console.WriteLine("{0} x 2 = {1}", num, resultado);
            resultado = num * 3;
            Console.WriteLine("{0} x 3 = {1}", num, resultado);
            resultado = num * 4;
            Console.WriteLine("{0} x 4 = {1}", num, resultado);
            resultado = num * 5;
            Console.WriteLine("{0} x 5 = {1}", num, resultado);
            resultado = num * 6;
            Console.WriteLine("{0} x 6 = {1}", num, resultado);
            resultado = num * 7;
            Console.WriteLine("{0} x 7 = {1}", num, resultado);
            resultado = num * 8;
            Console.WriteLine("{0} x 8 = {1}", num, resultado);
            resultado = num * 9;
            Console.WriteLine("{0} x 9 = {1}", num, resultado);
            resultado = num * 10;
            Console.WriteLine("{0} x 10 = {1}", num, resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_9_6()
        {
            /*Crea un programa que convierta de grados Celsius (centígrados) a Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados centígrados y usará 
             * las siguiente tablas de conversión: kelvin = celsius + 273 ; fahrenheit = celsius x 18 / 10 + 32*/
            int celsius, Kelvin, Fahrenheit;
            Console.WriteLine("Conversor de grados C a K y F");
            Console.Write("Introduce la contidad de grados Celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            Kelvin = celsius + 273;
            Fahrenheit = celsius * 10 / 10 + 32;

            Console.WriteLine("{0} Celsuis = {1} Kelvin y {2} Fahrenheit", celsius, Kelvin, Fahrenheit);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_9_7()
        {
            /*Pide al usuario una cantidad de "millas" y muestra la equivalencia en metros, usando: 1 milla = 1609.344 metros.*/
            int millas;
            float metros;
            Console.WriteLine("CONVERSION  DE MILLAS A METROS");
            Console.Write("Intrduce el valor en millas: ");

            millas = Convert.ToInt32(Console.ReadLine());
            metros = 1609.344f * millas;
            Console.WriteLine("{0} millas es igual a {1} metros", millas, metros);
        }
    }
}
