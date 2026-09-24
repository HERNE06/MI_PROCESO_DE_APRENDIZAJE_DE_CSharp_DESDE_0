using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._5._Introduccion_a_las_Funciones
{
    internal class Parametros_de_una_Funcion
    {

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_3_1
        public static void DibujarCuadro(int h, int a)
        {
            /* Crea una función que dibuje en pantalla un cuadrado del ancho (y alto) que se indique como parámetro. Completa el programa con un Main que permita probarla.*/

            Console.WriteLine("EJERCICO DE FUNCION CON PARAMETROS.\n Dibujo de cuando en pantalla");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_3_2
        public static void DibujarRectangulo(int a, int h)
        {
            /* Crea una función que dibuje en pantalla un rectángulo del ancho y alto que se indiquen como parámetros. Completa el programa con un Main que permita probarla.*/
            Console.WriteLine("EJERCICO DE FUNCION CON PARAMETROS.\n Dibujo de rectangulo en pantalla");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_3_3
        public static void DibujarRectanguloHueco(int alto, int ancho)
        {
            /*Crea una función que dibuje en pantalla un rectángulo hueco del ancho y alto que se indiquen como parámetros, formado por una letra que también 
             * se indique como parámetro. Completa el programa con un Main que pida esos datos al usuario y dibuje el rectángulo.*/

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (i == 0 || i == alto - 1 || j == 0 || j == ancho - 1)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
