using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._5._Introduccion_a_las_Funciones
{
    internal class Algunas_Funciones_Utiles
    {
        static void Main(string[] args)
        {

        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_9_1_1
        /* Crear un programa que genere un número al azar entre 1 y 100. El usuario tendrá 6 oportunidades para acertarlo.*/
        static void AdivinaElNumero()
        {
            int intentosRestantes = 6;
            int numIntentos = 1;
            bool adivinado = false;
            Random generarNumero = new Random();
            int numAdivinar = generarNumero.Next(1, 100);
            int numUsuario;

            Console.WriteLine("ADIVINA EL UN NUMERO ENTRE 1 Y 100");

            do
            {
                if (intentosRestantes == 0 || adivinado == true) break;

                Console.WriteLine("Intento #{0}", numIntentos);
                Console.Write("\nAdvina: ");
                numUsuario = Convert.ToInt16(Console.ReadLine());
                numIntentos++;

                if (numUsuario == numAdivinar)
                {
                    Console.WriteLine("\n_________________________________________________");
                    adivinado = true;
                    Console.WriteLine("Felicidades! Adivinates el numero en {0} intentos", numIntentos);
                }
                else
                {
                    intentosRestantes--;
                    Console.WriteLine("\n_________________________________________________");
                    Console.WriteLine("Que pena, no haz adivinado, te quedan {0} intentos", intentosRestantes);
                }
                if (!adivinado && intentosRestantes == 0) Console.WriteLine("Haz perdido pendejo, el numero era {0}", numAdivinar);
            }
            while (true);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_9_1_2
        /* Mejorar el programa del ahorcado (4.4.8.3), para que la palabra a adivinar no sea tecleado por un segundo usuario, sino que se escoja al azar de un 
          * "array" de palabras prefijadas (por ejemplo, nombres de ciudades).*/
        static void Ahorcado()
        {
            int intentos = 8;
            bool acertado = false;
            string[] nombrePaises = { "Argentina", "Rusia", "Haiti", "España", "Brazil", "China", "Ucrania", "Salvador", "Israel", "Suiza" };

            Random Selecionador = new Random();
            int selectPais = Selecionador.Next(0, 10);
            StringBuilder paisAdivinar = new StringBuilder(nombrePaises[selectPais].ToLower());
            string palabraGuardada = paisAdivinar.ToString();

            Console.WriteLine("_____________________________________");
            Console.WriteLine("ADIVINA LA PALABRA.");
            Console.WriteLine("Tematica: Nombre de paises");
            Console.WriteLine("_____________________________________");

            Console.WriteLine("\nEl pais tiene {0} letras.\n", paisAdivinar.Length);
            for (int i = 0; i < paisAdivinar.Length; i++)
            {
                paisAdivinar[i] = '-';
            }
            Console.Write(paisAdivinar);

            do
            {
                acertado = false;
                if (intentos == 0 || paisAdivinar.ToString() == palabraGuardada) break;

                Console.Write("\nLetra: ");
                char letra = Convert.ToChar(Console.ReadLine().ToLower());

                for (int i = 0; i < palabraGuardada.Length; i++)
                {
                    if (palabraGuardada[i] == letra)
                    {
                        acertado = true;
                        paisAdivinar[i] = letra;
                    }
                }
                Console.WriteLine("\n{0}", paisAdivinar);

                if (acertado) Console.WriteLine("\nAcertaste, Continua te falta poco");
                else
                {
                    intentos--;
                    Console.WriteLine("No acertaste, te quedan {0} intentos", intentos);
                }
            } while (true);

            if (paisAdivinar.ToString() == palabraGuardada) Console.WriteLine("Felicidades! Haz Adivinado.");
            else Console.WriteLine("Pendejo! Perdiste.");
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/

        //ejercicio5_9_1_3
        /* Crea un programa que "dibuje" asteriscos en 100 posiciones al azar de la pantalla . Para ayudarte para escribir en cualquier coordenada, puedes usar 
         * un array de dos dimensiones (con tamaños 24 para el alto y 79 para el ancho), que primero rellenes y luego dibujes en pantalla.*/

        static void Pantalla()
        {
            int posicion = 0;
            Random localisacion = new Random();

            char[,] pantalla = new char[24, 79];

            for (int filas = 0; filas < 24; filas++)
            {
                for (int columnas = 0; columnas < 79; columnas++)
                {
                    Console.Write(pantalla[filas, columnas] = '.');
                }
                Console.WriteLine();
            }

            do
            {
                int fila = localisacion.Next(0, 24);
                int columna = localisacion.Next(0, 79);

                pantalla[fila, columna] = '*';

                posicion++;

            } while (posicion < 100);

            Console.WriteLine("\n\nDIBUJO DE LAS POCICIONES");

            for (int filas = 0; filas < 24; filas++)
            {
                for (int columnas = 0; columnas < 79; columnas++)
                {
                    Console.Write(pantalla[filas, columnas]);
                }
                Console.WriteLine();
            }
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_9_2_1
        /* Crea un programa que halle cualquier raíz de un número. El usuario deberá indicar el número (por ejemplo, 2) y el índice de la raíz (por ejemplo, 
             * 3 para la raíz cúbica). Pista: hallar la raíz cúbica de 2 es lo mismo que elevar 2 a 1/3.*/
        public static double RaizCuandrada(double basee, double exponente)
        {
            double raiz = Math.Pow(basee, exponente);
            return raiz;
        }

        static void LlamarRaiz()
        {
            Console.WriteLine("BUSCAR LA RAIZ DE CUALQUIER NUMERO");
            Console.Write("\nBase: ");
            double basee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Expponente: ");
            double exponente = Convert.ToDouble(Console.ReadLine());

            double resultado = RaizCuandrada(basee, exponente);
            Console.WriteLine("\n{0} elevado a {1} = {2}", basee, exponente, resultado);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_2_2()
        {
            /*Haz un programa que resuelva ecuaciones de segundo grado, del tipo ax2 + bx + c = 0. El usuario deberá introducir los valores de a, b y c. Se deberá 
             * crear una función "raicesSegundoGrado", que recibirá como parámetros los coeficientes a, b y c, así como las soluciones x1 y x2 (por referencia). 
             * Deberá devolver los valores de las dos soluciones x1 y x2. Si alguna solución no existe, se devolverá como valor 100.000 para esa solución. 
             * Pista: la solución se calcula con x = -b  raíz (b2 – 4·a·c) / 2·a*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_2_3()
        {
            /*Haz un programa que pida al usuario 5 datos numéricos, los guarde en un array, pida un nuevo dato y muestre el valor del array que se encuentra 
             * más cerca de ese dato, siendo mayor que él. */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_2_4()
        {
            /*Haz un programa que pida al usuario 5 datos numéricos, los guarde en un array, pida un nuevo dato y muestre el valor del array que se encuentra 
             * más cerca de ese dato en valor absoluto (es decir, el más próximo, sea mayor que él o menor que él). */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_2_5()
        {
            /*Crea una función que calcule la distancia entre dos puntos (x1,y1) y (x2,y2), usando la expresión d = raíz [ (x1-x2)2 + (y1-y2)2 ].*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_2_6()
        {
            /*Crea un programa que muestre los valores de la función y = 10 * seno(x*5), para valores de x entre 0 y 72 grados. Recuerda que las funciones 
             * trigonométricas esperan que el ángulo se indique en radianes, no en grados. La equivalencia es que 360 grados son 2*PI radianes. */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_2_7()
        {
            /*Crea un programa que "dibuje" la gráfica de la función y = 10 * seno(x*5), para valores de x entre 0 y 72 grados. Para ayudarte para escribir en 
             * cualquier coordenada, puedes usar un array de dos dimensiones, que primero rellenes y luego dibujes en pantalla (mira el ejercicio 5.9.1.3). */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_2_8()
        {
            /* Crea un programa que "dibuje" un círculo dentro de un array de dos dimensiones, usando las ecuaciones x = xCentro + radio * coseno(ángulo), 
             * y = yCentro + radio * seno(ángulo). Si tu array es de 24x79, las coordenadas del centro serían (12,40). Recuerda que el ángulo se debe indicar en 
             * radianes (mira el ejercicio 5.9.2.6).*/

        }
    }
}
