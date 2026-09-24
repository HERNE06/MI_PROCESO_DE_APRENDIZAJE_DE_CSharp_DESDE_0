using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._4._Array_Estructuras_y_Cadenas_de_Texto
{
    internal class Ordenaciones_Simples
    {

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_6_1()
        {
            /*Un programa que pida al usuario 5 números en coma flotante y los muestre ordenados. */

            Console.WriteLine("ORDENAR NUMEROS.");
            float[] numeros = new float[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("{0}: ", i + 1);
                numeros[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("\nNumeros introducidos por el usuario");
            foreach (float numero in numeros)
            {
                Console.WriteLine("{0}", numero);
            }

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        float Temporal = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = Temporal;
                    }
                }
            }

            Console.WriteLine("\nNumeros ordenados");
            foreach (float numero in numeros)
            {
                Console.WriteLine("{0}", numero);
            }

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_6_2()
        {
            /*Un programa que pida al usuario 5 nombres y los muestre ordenados alfabéticamente. */

            Console.WriteLine("ORDENAR NUMEROS.");
            string[] nombres = new string[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("{0}: ", i + 1);
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombres.Length - 1; i++)
            {
                for (int j = i; j < nombres.Length; j++)
                {
                    if (string.Compare(nombres[i], nombres[j]) > 0)
                    {
                        string temporal = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = temporal;
                    }
                }
            }

            Console.WriteLine("\nNombres Ordenados");
            foreach (string nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_6_3()
        {
            /* Un programa que pida al usuario varios números, los vaya añadiendo a un array, mantenga el array ordenado continuamente y muestre el resultado 
             * tras añadir cada nuevo dato. Terminará cuando el usuario teclee "fin".*/

            int[] numeros = new int[25];
            string numeroUs;
            int cantidad = 0;
            Console.WriteLine("EJERCICIOS DE ORDENACION DE NUMEROS");

            do
            {
                Console.Write("\nNumero: ");
                numeroUs = (Console.ReadLine());

                if (cantidad < 25)
                {
                    numeros[cantidad] = int.Parse(numeroUs);
                    cantidad++;
                }

                if (numeroUs == "fin")
                {
                    break;
                }


                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {

                        if (numeros[i] > numeros[j])
                        {
                            int temporal = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = temporal;
                        }
                    }
                }

                Console.WriteLine("\nNumeros Ordenador");

                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("{0}, ", numeros[i]);
                }

            } while (true);


        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_6_4()
        {
            /* Ampliar el ejercicio anterior, para añadir una segunda fase en la que el usuario pueda "preguntar" si un cierto valor está en el array. 
             * Como el array está ordenado, la búsqueda no se hará hasta el final de los datos, sino hasta que se encuentre el dato buscado o un un dato mayor que él.*/

            int[] numeros = new int[25];
            string numeroUs;
            int cantidad = 0;
            Console.WriteLine("EJERCICIOS DE ORDENACION DE NUMEROS");

            do
            {
                Console.Write("\nNumero: ");
                numeroUs = (Console.ReadLine());

                if (numeroUs == "fin")
                {
                    break;
                }

                if (cantidad < 25)
                {
                    numeros[cantidad] = int.Parse(numeroUs);
                    cantidad++;
                }

                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {

                        if (numeros[i] > numeros[j])
                        {
                            int temporal = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = temporal;
                        }
                    }
                }

                Console.WriteLine("\nNumeros Ordenador");

                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("{0}, ", numeros[i]);
                }

            } while (true);

            Console.WriteLine("VERIFICAR EXISTENCIA DE UN NUMERO EN EL ARRAY");

            Console.Write("Numero: ");
            int numBusqueda = Convert.ToInt16(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (numeros[i] == numBusqueda)
                {
                    encontrado = true;
                    break;
                }

            }

            if (encontrado) Console.WriteLine("Si!, Este numero se encuantra registrada en el array");
            else Console.WriteLine("Este numero no es encuentra registrado en el array");


        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_6_5()
        {
            /*Realizar una variante del ejercicio anterior, que en vez de hacer una búsqueda lineal (desde el principio), use "búsqueda binaria": 
             * se comenzará a comparar con el punto medio del array; si nuestro dato es menor, se vuelve a probar en el punto medio de la mitad inferior del array, 
             * y así sucesivamente. */

            int[] numeros = new int[25];
            string numeroUs;
            int cantidad = 0;
            Console.WriteLine("EJERCICIOS DE ORDENACION DE NUMEROS");

            do
            {
                Console.Write("\nNumero: ");
                numeroUs = (Console.ReadLine());

                if (numeroUs == "fin")
                {
                    break;
                }

                if (cantidad < 25)
                {
                    numeros[cantidad] = int.Parse(numeroUs);
                    cantidad++;
                }

                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {

                        if (numeros[i] > numeros[j])
                        {
                            int temporal = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = temporal;
                        }
                    }
                }

                Console.WriteLine("\nNumeros Ordenador");

                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("{0}, ", numeros[i]);
                }

            } while (true);

            Console.WriteLine("VERIFICAR EXISTENCIA DE UN NUMERO EN EL ARRAY");

            Console.Write("Numero: ");
            int numBusqueda = Convert.ToInt16(Console.ReadLine());
            bool encontrado = false;

            int inicio = 0;
            int fin = cantidad = 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (numeros[medio] == numBusqueda)
                {
                    encontrado = true;
                    break;
                }
                else if (numeros[medio] < numBusqueda)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            if (encontrado) Console.WriteLine("Si!, Este numero se encuantra registrada en el array");
            else Console.WriteLine("Este numero no es encuentra registrado en el array");

        }
    }
}
