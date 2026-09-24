using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._4.Array_Estructuras_y_Cadenas_de_Texto
{
    internal class Cadenas_de_Caracteres
    {

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_3_1()
        {
            /*Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".*/
            Console.WriteLine("EJERCICIO DE CADENAS DE TEXTO STRING [STRING]");
            Console.Write("\nIntroduce tu nombre: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.Write("{0} ", nombre[i]);
            }

            Console.WriteLine("\nFIN");
            Console.WriteLine("\nPreciona enter para salir");
            Console.ReadKey();

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_3_2()
        {
            /*Un programa que pida una frase al usuario y la muestra en orden inverso (de la última letra a la primera).*/
            Console.WriteLine("EJERCICIO DE CADENAS DE TEXTO STRING [STRING]");
            Console.Write("\nEscribe una frace: ");
            string frace = Console.ReadLine();

            Console.WriteLine("\nFrace normal.");
            Console.WriteLine(frace);
            Console.WriteLine("\nFrace al reves");
            for (int i = frace.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", frace[i]);
            }
            Console.WriteLine("\nFIN.");
            Console.WriteLine("\nPrecione enter para salir");
            Console.ReadKey();
        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_3_3()
        {
            /*Un programa capaz de sumar dos números enteros muy grandes (por ejemplo, de 30 cifras), que se deberán pedir como cadena de texto y analizar letra a letra.*/
            Console.WriteLine("SUMA DE NUMEROS LARGOS OBTENIDOS DE STRING");

            Console.Write("Primer numero: ");
            string num1 = Console.ReadLine();
            Console.Write("Segundo numero: ");
            string num2 = Console.ReadLine();
            int llevo = 0;
            string resultado = "";

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int digito1 = int.Parse(num1[i].ToString());
                int digito2 = int.Parse(num2[i].ToString());

                int suma = digito1 + digito2 + llevo;

                int digitoResultado = suma % 10;
                llevo = suma / 10;

                resultado = digitoResultado.ToString() + resultado;
            }

            if (llevo > 0)
            {
                resultado = llevo.ToString() + resultado;
            }

            Console.WriteLine(" {0}", num1);
            Console.WriteLine("+{0}", num2);
            Console.WriteLine("_________");
            Console.WriteLine(" {0}", resultado);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_4_1()
        {
            /*Un programa que te pida tu nombre y lo muestre en pantalla como un triángulo creciente. Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla:
                J
                Ju
                Jua
                Juan*/

            Console.WriteLine("EJERCIO DE CADENA DE CARACCTERES");
            Console.Write("Introduce tu nombre: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < nombre.Length; i++)
            {
                string nombree = nombre.Substring(0, i + 1);
                Console.Write("{0}", nombree);
                Console.WriteLine();
            }

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_5_1()
        {
            /*Un programa que pida al usuario 10 frases, las guarde en un array, y luego le pregunte textos de forma repetitiva, e indique si cada uno de esos textos aparece como 
             * parte de alguno de los elementos del array. Terminará cuando el texto introducido sea "fin".*/

            string[] frase = new string[10];
            bool encontrado = false;
            string pregunta;


            Console.WriteLine("EJERCICIO DE MANEJO DE CADENAS Y SUBCADENAS");
            Console.WriteLine("\nEscribe 10 frases.");

            for (int i = 0; i < frase.Length; i++)
            {
                Console.Write("\nFrase {0}: ", i + 1);
                frase[i] = Console.ReadLine();
            }

            do
            {

                Console.WriteLine("Escribe una texto para saber si se encuantra registrado.");
                Console.Write("Texto: ");
                pregunta = Console.ReadLine();

                if (pregunta == "fin")
                {
                    break;
                }

                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i].Contains(pregunta))
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    Console.WriteLine("El texto \" {0}\" fue encontrado ", pregunta);
                }
                else
                {
                    encontrado = false;
                    Console.WriteLine("El texto \" {0}\" no fue encontrado ", pregunta);
                }

            } while (true);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_5_2()
        {
            /*Crea una versión del ejercicio 4.4.5.1 en el que, en caso de que alguno de los textos aparezca como subcadena, se avise además si se encuentra exactamente al principio.*/
            string[] frases = new string[10];
            string buscado;
            int posicion = -1;

            Console.WriteLine("EJERCICIO DE MANEJO DE CADENAS Y SUBCADENAS");
            Console.WriteLine("\nEscribe 10 frases.");

            for (int i = 0; i < frases.Length; i++)
            {
                Console.Write("frase {0}: ", i + 1);
                frases[i] = Console.ReadLine();
            }

            do
            {
                bool encontrado = false;
                Console.WriteLine("\nBuscar un texto para saber si existe.");
                Console.Write("\nTextos buscar: ");
                buscado = Console.ReadLine();

                if (buscado == "fin")
                {
                    break;
                }

                for (int i = 0; i < frases.Length; i++)
                {
                    if (frases[i].Contains(buscado))
                    {
                        encontrado = true;
                        posicion = frases[i].IndexOf(buscado, 0);
                        break;
                    }
                }

                if (encontrado && posicion == 0)
                {
                    Console.WriteLine("El texto \"{0}\" ha sido encontrado. ", buscado);
                    Console.WriteLine("Se encuntra al principio de la frase");
                }
                else if (encontrado && posicion > 0)
                {
                    Console.WriteLine("El texto \"{0}\" ha sido encontrado. ", buscado);
                    Console.WriteLine("No se encuntra al principio de la frase");
                }
                else
                {
                    Console.WriteLine("El texto \"{0}\" no ha sido encontrado. ", buscado);
                }


            } while (true);


        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_6_1()
        {
            /*Una variante del ejercicio 4.4.5.2, que no distinga entre mayúsculas y minúsculas a la hora de buscar.*/

            string[] frases = new string[10];
            string buscado;

            Console.WriteLine("EJERCICIO DE MANEJO DE CADENAS Y SUBCADENAS");
            Console.WriteLine("\nEscribe 10 frases.");

            for (int i = 0; i < frases.Length; i++)
            {
                Console.Write("frase {0}: ", i + 1);
                frases[i] = Console.ReadLine();
            }

            do
            {
                bool encontrado = false;
                int posicion = -1;
                Console.WriteLine("\nBuscar un texto para saber si existe.");
                Console.Write("\nTextos buscar: ");
                buscado = Console.ReadLine();

                if (buscado.ToLower() == "fin")
                {
                    break;
                }

                for (int i = 0; i < frases.Length; i++)
                {
                    if (frases[i].ToLower().Contains(buscado.ToLower()))
                    {
                        encontrado = true;
                        posicion = frases[i].ToLower().IndexOf(buscado.ToLower(), 0);
                        break;
                    }
                }

                if (encontrado && posicion == 0)
                {
                    Console.WriteLine("El texto \"{0}\" ha sido encontrado. ", buscado);
                    Console.WriteLine("Se encuntra al principio de la frase");
                }
                else if (encontrado && posicion > 0)
                {
                    Console.WriteLine("El texto \"{0}\" ha sido encontrado. ", buscado);
                    Console.WriteLine("No se encuntra al principio de la frase");
                }
                else
                {
                    Console.WriteLine("El texto \"{0}\" no ha sido encontrado. ", buscado);
                }


            } while (true);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_6_2()
        {
            /*Un programa que pida al usuario una frase y elimine todos los espacios redundantes que contenga (debe quedar sólo un espacio entre cada palabra y la siguiente).*/
            Console.WriteLine("EJERCICIO DE MANEJO DE CADENAS Y SUB-CADENAS");
            Console.WriteLine("\n ELIMINACION DE ESPACIOS REDUNDANTES ENTRE CADENAS");

            Console.Write("Escribe una jodida frase: ");
            string frase = Console.ReadLine();
            string frase2 = "";

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    frase2 += frase[i];
                }
                else if (i > 0 && frase[i - 1] != ' ')
                {
                    frase2 += frase[i];
                }
            }

            Console.WriteLine("Frase escrita por el ususario: {0} \nFrase corregida: {1}", frase, frase2);
        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_6_3()
        {
            /*Un programa que pida al usuario una frase y muestre sus palabras en orden inverso.*/

            Console.WriteLine("EJERCICIO DE DESCOMPISCION DE STRING \'DELIMITADORES \'");
            Console.Write("\nEscribe una frase: ");
            string frase = Console.ReadLine();
            char[] delimitadores = { ' ' };

            string[] resultado = frase.Split(delimitadores);

            for (int i = resultado.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Fragmento {0}: {1} ", i, resultado[i]);
            }

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_6_4()
        {
            /*Un programa que pida al usuario varios números separados por espacios y muestre su suma.*/

            Console.WriteLine("EJERCICIO DE \'DELIMITADORES \'");
            Console.WriteLine("\nEscribe varios numeros separados por espacios.");
            Console.Write("Numero: ");
            string numero = Console.ReadLine();
            char[] delimitador = { ' ' };

            int resultadoo = 0;
            string[] numSeparado = numero.Split(delimitador);

            for (int i = 0; i < numSeparado.Length; i++)
            {
                resultadoo += int.Parse(numSeparado[i]);
            }

            Console.WriteLine(resultadoo);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_7_1()
        {
            /*Un programa que pida al usuario cinco frases, las guarde en un array y muestre la "mayor" de ellas (la que aparecería en último lugar en un diccionario).*/
            Console.WriteLine("EJERCICO DE COMPARACION DE CADENAS");
            Console.WriteLine("\nEscribe 5 frases.\n");
            string[] frases = new string[5];

            for (int i = 0; i < frases.Length; i++)
            {
                Console.Write("Frase {0}: ", i + 1);
                frases[i] = Console.ReadLine();
            }

            Console.WriteLine("La mayor de estas frases es...");

            string mayor = frases[0];
            for (int i = 0; i < frases.Length; i++)
            {
                if (frases[i].CompareTo(mayor) > 0)
                {
                    mayor = frases[i];
                }
            }

            Console.WriteLine(mayor);


        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_8_1()
        {
            /*Un programa que pida una cadena al usuario y la modifique, de modo que las letras de las posiciones impares (primera, tercera, etc.) estén en minúsculas 
             * y las de las posiciones pares estén en mayúsculas, mostrando el resultado en pantalla. Por ejemplo, a partir de un nombre como "Nacho", la cadena resultante sería "nAcHo".*/

            Console.WriteLine("EJERCIO DE CADENAS MODIFICABLES");
            Console.Write("Escribe una frase: ");
            StringBuilder frase = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < frase.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    frase[i] = char.ToLower(frase[i]);
                }
                else if ((i + 1) % 2 == 0)
                {
                    frase[i] = char.ToUpper(frase[i]);
                }
            }

            Console.WriteLine(frase);
        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_8_2()
        {
            /*Un programa que pida tu nombre, tu día de nacimiento y tu mes de nacimiento y lo junte todo en una cadena, separando el nombre de la fecha por una coma 
             * y el día del mes por una barra inclinada, así: "Juan, nacido el 31/12".*/

            Console.WriteLine("MAS EJERCICIOS DE MANEJO DE CADENAS\n");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Dia de nacimiento: ");
            string dia = Console.ReadLine();
            Console.Write("Mes de nacimiento: ");
            string mes = Console.ReadLine();

            string cadenaResultante = nombre + " , nacido el " + dia + '/' + mes;

            Console.WriteLine(cadenaResultante);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_8_3()
        {
            /*Crear un juego del ahorcado, en el que un primer usuario introduzca la palabra a adivinar, se muestre esta programa oculta con guiones (-----) y el programa 
             * acepte las letras que introduzca el segundo usuario, cambiando los guiones por letras correctas cada vez que acierte (por ejemplo, a---a-t-). 
             * La partida terminará cuando se acierte la palabra por completo o el usuario agote sus 8 intentos.*/
            int intentos = 8;
            Console.WriteLine("______________________________________");
            Console.WriteLine("¡AHORCADO! ADIVINA LA PALABRA \nTienes {0} intentos", intentos);
            Console.WriteLine("______________________________________");

            Console.Write("Escribe la palabra a adivinar: ");
            StringBuilder palabraAdivinar = new StringBuilder(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("______________________________________");
            Console.WriteLine("¡AHORCADO! ADIVINA LA PALABRA \nTienes {0} intentos", intentos);
            Console.WriteLine("______________________________________");

            string palabraGuardada = palabraAdivinar.ToString().ToLower();

            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                palabraAdivinar[i] = '_';
            }
            Console.WriteLine("\n{0}", palabraAdivinar);


            do
            {
                bool acertado = false;
                if (intentos == 0 || palabraAdivinar.ToString() == palabraGuardada)
                {
                    break;
                }

                Console.Write("\nLetra: ");
                char letra = char.Parse(Console.ReadLine());

                for (int i = 0; i < palabraAdivinar.Length; i++)
                {
                    if (palabraGuardada[i].ToString().ToLower() == letra.ToString().ToLower())
                    {
                        palabraAdivinar[i] = letra;
                        acertado = true;
                    }
                }
                Console.WriteLine(palabraAdivinar);

                if (acertado)
                {
                    Console.WriteLine("Sii!. Continua, te falta poco");
                }
                else
                {
                    intentos--;
                    Console.WriteLine("Nop, Sigue intentando. \n Te quedan {0} intentos.", intentos);
                }

            } while (true);

            if (palabraAdivinar.ToString() == palabraGuardada)
            {
                Console.WriteLine("______________________________________");
                Console.WriteLine("Felicidades, adivinastes");
                Console.WriteLine("______________________________________");
            }
            else if (intentos == 0)
            {
                Console.WriteLine("JAJAJAJA perdiste \n La palabra era: {0} ", palabraGuardada);
            }

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_9_1()
        {
            /*Un programa que pida al usuario una frase y la descomponga en subcadenas separadas por espacios, usando "Split". Luego debe mostrar cada subcadena en una línea nueva, 
             * usando "foreach".*/

            Console.WriteLine("EJERCIO PRACTICO DEL FOREACH");
            Console.Write("Escribe una frase: ");
            string frases = Console.ReadLine();
            char separacion = ' ';

            string[] frasePartida = frases.Split(separacion);

            foreach (string frase in frasePartida)
            {
                Console.WriteLine("- {0}", frase);
            }
        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_9_2()
        {
            /*Un programa que pida al usuario varios números separados por espacios y muestre su suma (como el del ejercicio 4.4.6.4), pero empleando "foreach"..*/
            Console.WriteLine("OTRO EJERCIO MAS DEL FOREACH");
            Console.WriteLine("Introduce numeros separados por espacios");

            Console.Write("\nNumero: ");
            string numero = Console.ReadLine();

            char separador = ' ';
            string[] numeroResultante = numero.Split(separador);
            int resultado = 0;

            foreach (string digito in numeroResultante)
            {
                resultado += int.Parse(digito);
            }

            Console.WriteLine(resultado);
        }
    }
}
