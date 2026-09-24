using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._2.Estructuras_de_Control
{
    internal class Estructuras_Repetitivas
    {
        static void Main(string[] args)
        {

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_1_1()
        {
            /*Crear un programa que pida al usuario su contraseña (numérica). Deberá terminar cuando introduzca como contraseña el número 1111, pero volvérsela a pedir 
             * tantas veces como sea necesario.*/
            int contrasena = 1111;
            int verifContrasena;
            Console.Write("INTRODUZCA SU CONTRASEÑA: ");
            verifContrasena = Convert.ToInt32(Console.ReadLine());

            while (verifContrasena != contrasena)
            {
                Console.WriteLine("Contraseña incorrecta. Intentelo de nuevo");
                Console.Write("INTRODUZCA SU CONTRASEÑA: ");
                verifContrasena = Convert.ToInt32(Console.ReadLine());
            }
            if (verifContrasena == contrasena)
            {
                Console.WriteLine("BIENVENIDO MMG");
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_1_2()
        {
            /*Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".*/
            int numeros = 1;
            while (numeros <= 10)
            {
                numeros++;
                Console.WriteLine(numeros);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_1_3()
        {
            /*Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "while".*/
            int numeros = 26;
            while (numeros > 10)
            {
                numeros = numeros - 2;
                Console.WriteLine(numeros);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercico2_2_1_4()
        {
            /*Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10).*/
            Console.WriteLine("CUANTAS CIFRAS ENTERAS TIENE UN NUMERO X");
            int numero, resultado;
            int contCifras = 1;
            Console.Write("Introduce un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            resultado = numero / 10;
            while (resultado > 0)
            {
                resultado /= 10;
                contCifras++;
            }
            Console.WriteLine($"El numero {numero} es de {contCifras} cifras");
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercico2_2_1_5()
        {
            /*Crear el diagrama de flujo y la versión en C# de un programa que dé al usuario tres oportunidades para adivinar un número del 1 al 10.*/
            int numeroUsuario, numeroGenerado;
            int intentos = 3;
            Console.WriteLine("ADIVINA EL NUMERO ENTRE 1 Y 10\n");
            Random numero = new Random();
            numeroGenerado = numero.Next(1, 10);

            Console.Write("Introduce el numero: ");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());
            if (numeroUsuario == numeroGenerado) Console.WriteLine("Felicidades, Adivinaste el numero");

            while (numeroUsuario != numeroGenerado && intentos > 0)
            {
                intentos--;
                if (intentos > 0)
                {
                    Console.WriteLine("Numero Equivocado, Intentalo de nuevo");
                    Console.Write("Introduce el numero: ");
                    numeroUsuario = Convert.ToInt32(Console.ReadLine());
                }
                else Console.WriteLine("Perdiste, no te quedan mas intentos");
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_2_1()
        {
            /*Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero).*/
            Console.WriteLine("SUMA DE NUMEROS POSITIVOS");
            int numero, resultado = 0;

            Console.Write("Escribe el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Sumando...");
                resultado += numero;
                Console.Write("Escribe el siguiente numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero > 0);

            Console.WriteLine("La suma total es {0}:", resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_2_2()
        {
            /*Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while"..*/
            Console.WriteLine("CONTENO DEL 1 AL 10");
            int contador = 0;
            do
            {
                contador++;
                Console.WriteLine(contador);
            } while (contador < 10);

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_2_3()
        {
            /*Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "do..while".*/
            Console.WriteLine("CONTADOR DESCENDENTE 26 AL 10");
            int contador = 26;
            do
            {
                contador = contador - 2;
                Console.WriteLine(contador);
            }
            while (contador > 10);

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_2_4()
        {
            /*Crea un programa que pida al usuario su identificador y su contraseña (ambos numéricos), y no le permita seguir hasta que introduzca como 
             * identificador "1234" y como contraseña "1111".*/
            Console.WriteLine("LOGIN\n");
            int usuario, contrasena;

            do
            {
                Console.Write("Usuario: ");
                usuario = Convert.ToInt32(Console.ReadLine());
                Console.Write("Contraseña: ");
                contrasena = Convert.ToInt32(Console.ReadLine());

                if (usuario != 1234 && contrasena != 1111)
                {
                    Console.WriteLine("\nDatos Erroneo, Intentalo de Nuevo\n");
                }

            }
            while (usuario != 1234 && contrasena != 1111);

            Console.WriteLine("\nSesion Iniciada, Bienvenido");
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_2_5()
        {
            /*Crea un programa que pida al usuario su identificador y su contraseña, y no le permita seguir hasta que introduzca como nombre "Pedro" 
             * y como contraseña "Peter"..*/

            Console.WriteLine("LOGIN\n");
            string nombre, contrasena;

            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Contraseña: ");
                contrasena = Console.ReadLine();

                if (nombre != "Pedro" && contrasena != "Peter")
                {
                    Console.WriteLine("\nDatos Erroneo, Intentalo de Nuevo\n");
                }

            }
            while (nombre != "Pedro" && contrasena != "Peter");

            Console.WriteLine("\nSesion Iniciada, Bienvenido");
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_3_1()
        {
            /*Crear un programa que muestre los números del 15 al 5, descendiendo (pista: en cada pasada habrá que descontar 1, por ejemplo haciendo i=i-1, 
             * que se puede abreviar i--).*/
            Console.WriteLine("Contador Descendente");
            for (int cont = 15; cont >= 5; cont--)
            {
                Console.WriteLine("{0}", cont);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_3_2()
        {
            /*Crear un programa que muestre los primeros ocho números pares (pista: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar el doble 
             * del valor que hace de contador).*/
            Console.WriteLine("Primeros 8 numeros pares");
            for (int numpar = 0; numpar <= 16; numpar = numpar + 2)
            {
                Console.WriteLine("{0}", numpar);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_3_3()
        {
            /*Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).*/
            Console.WriteLine("ABECEDARIO EN DECREMENTO");
            for (char letra = 'Z'; letra >= 'A'; letra--)
            {
                Console.Write("{0} ", letra);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_3_4()
        {
            /*Crear un programa que escriba en pantalla la tabla de multiplicar del 5.*/
            Console.WriteLine("Tabla de Multiplicar del 5");
            int tabla = 5, num, resultado;

            for (num = 0; num <= 10; num++)
            {
                resultado = tabla * num;
                Console.WriteLine("{0} x {1} = {2}", tabla, num, resultado);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_2_3_5()
        {
            /*Crear un programa que escriba en pantalla los números del 1 al 50 que sean múltiplos de 3 (pista: habrá que recorrer todos esos números y ver si 
             * el resto de la división entre 3 resulta 0).*/
            Console.WriteLine("MULTIPLOS DE 3 ENTRE 1 Y 50");
            int resultado, num;
            for (num = 1; num <= 50; num++)
            {
                resultado = num % 3;
                if (resultado == 0)
                    Console.Write("{0} ", num);
            }
        }
    }
}
