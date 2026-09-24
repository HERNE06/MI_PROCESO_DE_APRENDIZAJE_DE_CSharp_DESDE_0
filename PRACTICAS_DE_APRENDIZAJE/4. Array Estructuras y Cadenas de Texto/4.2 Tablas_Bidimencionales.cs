using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._4.Array_Estructuras_y_Cadenas_de_Texto
{
    internal class Tablas_Bidimencionales
    {
        static void Main(string[] args)
        {

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_2_1()
        {
            /*Un programa que pida al usuario dos bloques de 10 números enteros (usando un array de dos dimensiones). Después deberá mostrar el mayor dato que se 
             * ha introducido en cada uno de ellos.*/

            int[][] num;
            num = new int[2][];
            num[0] = new int[10];
            num[1] = new int[10];

            Console.WriteLine("EJEMPLO DE ARRAY DE DOS DIMENCIONES");

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("\nGrupo {0} ", i + 1);
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.Write("Numero {0} : ", j + 1);
                    num[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("\nNumeros del grupo {0}", i + 1);
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.Write("{0}", num[i][j]);
                }
            }
        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_2_2()
        {
            /*Un programa que pida al usuario dos bloques de 6 cadenas de texto. Después pedirá al usuario una nueva cadena y comprobará si aparece en alguno de los 
             * dos bloques de información anteriores.*/

            string[][] texto;
            texto = new string[2][];
            texto[0] = new string[6];
            texto[1] = new string[6];

            Console.WriteLine("EJEMPLO DE ARRAY DE DOS DIMENCIONES CON TEXTOS");
            Console.WriteLine("ESCRIBE DOS BLOQUES DE NOMBRES, 6 EN CADA BLOQUE");

            for (int i = 0; i < texto.Length; i++)
            {
                Console.WriteLine("\nBloque {0}", i + 1);
                for (int j = 0; j < texto[i].Length; j++)
                {
                    Console.Write("Nombre {0}: ", j + 1);
                    texto[i][j] = Console.ReadLine();
                }
            }

            Console.WriteLine("Escribe un nombre para buscarlo o fin para finalizar");
            Console.WriteLine("\nNombre:");
            string nombre = Console.ReadLine();

            bool encontrado = false;

            if (nombre != "fin")
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    for (int j = 0; j < texto[i].Length; j++)
                    {
                        if (texto[i][j] == nombre)
                        {
                            encontrado = true;
                        }
                    }
                }

                if (encontrado)
                {
                    Console.WriteLine("El nombre {0} ha sido encontrado", nombre);

                }
                else Console.WriteLine("El nombre {0} no ha sido encontrado", nombre);
            }

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_2_3()
        {
            /*Un programa que calcule el determinante de una matriz de 2x2.*/
            int[][] matrizA = new int[2][];
            matrizA[0] = new int[2];
            matrizA[1] = new int[2];
            int resultado = 0;

            Console.WriteLine("DETERMINANTE DE UNA MATRIZ 2X2");
            Console.WriteLine("\nIntroduce los cada elemento de la matriz");
            for (int i = 0; i < matrizA.Length; i++)
            {
                for (int j = 0; j < matrizA[i].Length; j++)
                {
                    Console.Write("fila {0} columna {1}: ", i + 1, j + 1);
                    matrizA[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizA.Length; i++)
            {
                for (int j = 0; j < matrizA[i].Length; j++)
                {
                    resultado = matrizA[0][0] * matrizA[1][1] - matrizA[0][1] * matrizA[1][0];
                }
            }

            Console.WriteLine(resultado);
        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_2_4()
        {
            /*Un programa que calcule el determinante de una matriz de 3x3.*/
            int[][] matrizA = new int[3][];
            matrizA[0] = new int[3];
            matrizA[1] = new int[3];
            matrizA[2] = new int[3];
            int resultado = 0;

            Console.WriteLine("DETERMINANTE DE UNA MATRIZ 3x3");
            Console.WriteLine("Escribe cada elmento de la matriz");
            for (int i = 0; i < matrizA.Length; i++)
            {
                for (int j = 0; j < matrizA[i].Length; j++)
                {
                    Console.Write("Fila {0} columna {1}: ", i + 1, j + 1);
                    matrizA[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //for(int i = 0;i< matrizA.Length; i++)
            //{
            //    for(int j = 0; j < matrizA[i].Length; j++) 
            //    {
            //        resultado = (matrizA[0][0]* matrizA[1][1]* matrizA[2][2] + matrizA[0][1] * matrizA[1][2] * matrizA[2][0]) - (matrizA[0][2] * matrizA[1][1] * matrizA[2][0] + matrizA[0][0] * matrizA[1][2] * matrizA[2][1] + matrizA[0][1] * matrizA[1][0] * matrizA[2][2]);
            //    }
            //}

            Console.WriteLine("La determinante es {0}", resultado);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_2_5()
        {
            /*UUn programa que calcule si las filas de una matriz son linealmente dependientes.*/

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_2_6()
        {
            /*Un programa que use matrices para resolver un sistema de ecuaciones lineales mediante el método de Gauss.*/

        }
    }
}
