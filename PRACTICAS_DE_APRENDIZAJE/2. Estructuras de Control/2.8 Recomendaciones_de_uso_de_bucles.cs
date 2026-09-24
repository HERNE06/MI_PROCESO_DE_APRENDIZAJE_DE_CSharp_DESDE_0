using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._2.Estructuras_de_Control
{
    internal class Recomendaciones_de_uso_de_bucles
    {
        static void Main(string[] args)
        {

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_8_1()
        {
            /* Crear un programa que dé al usuario la oportunidad de adivinar un número del 1 al 100 (prefijado en el programa) en un máximo de 6 intentos. 
             * En cada pasada deberá avisar de si se ha pasado o se ha quedado corto. */
            Console.WriteLine("ADIVINA EL NUMERO ENTRE 1 Y 100, TIENES 6 INTENTOS");
            Console.WriteLine("TIENES 6 INTENTOS");

            int numGenerado, numUsuario, numIntentos = 6;
            Random num = new Random();
            numGenerado = num.Next(1, 100);

            Console.Write("Adivina --> ");
            numUsuario = Convert.ToInt32(Console.ReadLine());

            do
            {
                numIntentos--;
                if (numUsuario < numGenerado)
                {
                    Console.WriteLine("\nNOO!! INCORRECTO");
                    Console.WriteLine("Pista: El numero es mayor");
                    Console.WriteLine("Te queda {0} intentos", numIntentos);
                }
                else if (numUsuario > numGenerado)
                {
                    Console.WriteLine("\nNOO!! INCORRECTO");
                    Console.WriteLine("Pista: El numero es menor");
                    Console.WriteLine("Te queda {0} intentos", numIntentos);
                }

                Console.Write("\nSiguente intento --> ");
                numUsuario = Convert.ToInt32(Console.ReadLine());

            }
            while (numIntentos > 0);
            if (numIntentos == 0)
            {
                Console.WriteLine("PERDISTE, NO TE QUEDAN MAS INTENTOS");
            }
            else Console.Write("PERDISTE, NO TE QUEDAN MAS INTENTOS");
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_8_2()
        {
            /* Crear un programa que descomponga un número (que teclee el usuario) como producto de su factores primos. 
             * Por ejemplo, 60 = 2 · 2 · 3 · 5 */
            Console.WriteLine("DECOMPOSICION DE UN NUMERO POR SUS FACTORES PRIMOS");
            Console.WriteLine("\nEscribe el numero");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int x = 2; x <= num; x++)
            {
                while (num % x == 0)
                {
                    Console.Write("{0} . ", x);
                    num /= x;
                }
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_8_3()
        {
            /* Crea un programa que calcule un número elevado a otro, usando multiplicaciones sucesivas. */
            Console.WriteLine("POTENCIACIACION");
            int num, elevado, resultado = 1;
            Console.Write("Numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Elevado a: ");
            elevado = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < elevado; i++)
            {
                resultado *= num;
            }
            Console.WriteLine("{0} elevado a {1} = {2}", num, elevado, resultado);
        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_8_4()
        {
            /* Crea un programa que "dibuje" un rectángulo formado por asteriscos, con el ancho y el alto que indique el usuario, usando dos "for" anidados. 
             * Por ejemplo, si desea anchura 4 y altura 3, el rectángulo sería así:
                ****
                ****
                ****            */
            Console.WriteLine("CREACION DE RECTENGULOS A MEDIDA DEL USUARIO");

            int altura, ancho;
            Console.Write("Introduce la altura: ");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < altura; a++)
            {
                for (int h = 0; h < ancho; h++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_8_5()
        {
            /* Crea un programa que "dibuje" un triángulo decreciente, con la altura que indique el usuario. Por ejemplo, si el usuario dice que desea 4 caracteres 
             * de alto, el triángulo sería así:
                 ****
                 ***
                 **
                 *      */
            Console.WriteLine("CREACION DE TRIANGULO DECRECIENTE A MEDIDA DEL USUARIO");

            int altura;
            Console.Write("Introduce la altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < altura; a++)
            {
                for (int i = altura; i > a; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_8_6()
        {
            /* Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una fila (o columna) de asteriscos y cuyo interior esté formado por espacios 
             * en blanco, con el ancho y el alto que indique el usuario. Por ejemplo, si desea anchura 4 y altura 3, el rectángulo sería así:
                ****
                *   *
                ****   */

            Console.WriteLine("CREACION DE RETANAGULO HUEVO");
            int altura, ancho;
            Console.Write("Introduce la altrua: ");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introducele en ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            for (int h = 0; h < altura; h++)
            {
                for (int a = 0; a < ancho; a++)
                {
                    if (h == 0 || h == altura - 1 || a == 0 || a == ancho - 1)
                    {
                        Console.Write("*");
                    }
                    else { Console.Write(" "); }
                }
                Console.WriteLine();
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_8_7()
        {
            /* Crea un programa que "dibuje" un triángulo creciente, alineado a la derecha, con la altura que indique el usuario. Por ejemplo, si el usuario dice 
             * que desea 4 caracteres de alto, el triángulo sería así:
                *
                **
                ***
                ****    */
            Console.WriteLine("TRIANGULO CRECIENTE ALINEADO A LA DERACHA COÑO");
            int altura;
            Console.Write("Introduzca la altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < altura; a++)
            {
                for (int an = 0; an <= a; an++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_8_8()
        {
            /* Crear un programa que devuelva el cambio de una compra, utilizando monedas (o billetes) del mayor valor posible. Supondremos que tenemos una 
             * cantidad ilimitada de monedas (o billetes) de 2000, 1000, 500, 200, 100, 50, 25, 10, 5,  y 1, y que no hay decimales. La ejecución podría ser algo como:
                Precio? 44
                Pagado? 100
                Su cambio es de 56: 50 5 1
                Precio? 1
                Pagado? 100
                Su cambio es de 99: 50 20 20 5 2 2 */

            Console.WriteLine("PROCESO DE PAGO");
            int montoPago, Precio, Devolucion;

            Console.Write("Introduce el precio del Producto: ");
            Precio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el pago: ");
            montoPago = Convert.ToInt32(Console.ReadLine());

            if (montoPago < Precio) Console.WriteLine("\nDinero Isufuciente");

            Devolucion = montoPago - Precio;
            Console.WriteLine("Su Devoluciones de {0}", Devolucion);

            while (Devolucion >= 2000)
            {
                Console.Write("2000 ");
                Devolucion -= 2000;
            }

            while (Devolucion >= 1000)
            {
                Console.Write("1000 ");
                Devolucion -= 1000;
            }

            while (Devolucion >= 500)
            {
                Console.Write("500 ");
                Devolucion -= 500;
            }

            while (Devolucion >= 200)
            {
                Console.Write("200 ");
                Devolucion -= 200;
            }

            while (Devolucion >= 100)
            {
                Console.Write("100 ");
                Devolucion -= 100;
            }

            while (Devolucion >= 50)
            {
                Console.Write("50 ");
                Devolucion -= 50;
            }

            while (Devolucion >= 25)
            {
                Console.Write("25 ");
                Devolucion -= 25;
            }

            while (Devolucion >= 10)
            {
                Console.Write("10 ");
                Devolucion -= 10;
            }

            while (Devolucion >= 5)
            {
                Console.Write("5 ");
                Devolucion -= 5;
            }

            while (Devolucion >= 1)
            {
                Console.Write("1 ");
                Devolucion -= 1;
            }

        }
    }
}
