using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;


namespace PRACTICAS_DE_APRENDIZAJE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LlamarCualcularPerimetroyArea();
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_1_1()
        {
            /*un programa en C# que te salude por tu nombre (ej: "Hola, Nacho").*/
            Console.WriteLine("HOLA, RUTCHY HERNE");
        }
        /*_____________________________________________________________________________________________________________*/

        static void Ejercicio1_3_1()
        {
            /* Crea un programa que diga el resultado de sumar 118 y 56*/
            Console.WriteLine(118 + 56);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_3_2()
        {
            /* Crea un programa que diga el resultado de sumar 12345 y 67890.*/
            Console.WriteLine(12345 + 67890);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_4_1_1()
        {
            /*Hacer un programa que calcule el producto de los números 12 y 13.*/
            Console.WriteLine(12 * 13);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_4_1_2()
        {
            /*Hacer un programa que calcule la diferencia (resta) entre 321 y 213.*/
            Console.WriteLine(321 - 213);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_4_1_3()
        {
            /*Hacer un programa que calcule el resultado de dividir 301 entre 3.*/
            Console.WriteLine(301 / 3);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_4_1_4()
        {
            /*Calcular el resultado de -2 + 3 * 5*/
            Console.WriteLine(-2 + 3 * 5);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_4_2_1()
        {
            /*Calcular el resultado de (20+5) % 6*/
            Console.WriteLine((20 + 5) % 6);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_4_2_2()
        {
            /*Calcular el resultado de 15 + -5*6 / 10*/
            Console.WriteLine(15 + (-5) * 6 / 10);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_4_2_3()
        {
            /*Calcular el resultado de 2 + 10 / 5 * 2 - 7 % 1*/
            Console.WriteLine(2 + 10 / 5 * 2 - 7 % 1);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_4_2_4()
        {
            /*Hacer un programa que calcule el resto de la división de 301 entre 3.*/
            Console.WriteLine(301 % 3);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_5_3_1()
        {
            /*Crea un programa que calcule el producto de los números 121 y 132, usando variables.*/
            int num1 = 121, num2 = 132, resultado;
            resultado = num1 * num2;
            Console.WriteLine(resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_5_3_2()
        {
            /*Crea un programa que calcule la suma de 285 y 1396, usando variables.*/
            int num1 = 285, num2 = 1396, resutlado;
            resutlado = num1 + num2;
            Console.WriteLine(resutlado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_5_3_4()
        {
            /*Crea un programa que calcule el resto de dividir 3784 entre 16, usando variables.*/
            int num1 = 3784, num2 = 16, resultado;
            resultado = num1 % num2;
            Console.WriteLine(resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_8_1()
        {
            /*Crea un programa que calcule el producto de dos números introducidos por el usuario.*/
            int num1, num2, resultado;
            Console.Write("Escribe el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe el Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = num1 * num2;
            Console.WriteLine(resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio1_8_2()
        {
            /*Crea un programa que calcule la división de dos números introducidos por el usuario, así como el resto de esa división.*/
            int num1, num2, resultado;
            Console.Write("Escribe el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe el Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = num1 / num2;
            resultado = num1 % num2;
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
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_1_1()
        {
            /*Crear un programa que pida al usuario un número entero y diga si es par 
             * (pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …).*/
            Console.WriteLine("Validaccion de numeros par o impar");
            int num;
            Console.Write("Introduce el numero que desea verificar: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) Console.WriteLine("Numero par");
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_1_2()
        {
            /*Crear un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.*/
            Console.WriteLine("Comparacion de numeros <>");
            int num1, num2;
            Console.WriteLine("Escribe los numeros que desea comparar");
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2) Console.WriteLine("El numero {0} es mayor que {1}", num1, num2);
            if (num2 > num1) Console.WriteLine("El numero {0} es mayor que {1}", num2, num1);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_1_3()
        {
            /*Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del segundo
             * (pista: igual que antes, habrá que ver si el resto de la división es cero: a % b == 0).*/
            Console.WriteLine("Virificacion de multiplos");
            int num1, num2;
            Console.WriteLine("Escrible los numeros que desea verificar");
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0) Console.WriteLine("EL numero {0} es multiplo de {1}", num1, num2);
            if (num1 % num2 != 0) Console.WriteLine("EL numero {0} no es multiplo de {1}", num1, num2);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_2_1()
        {
            /*Crear un programa que pida al usuario un número entero. Si es múltiplo de 10, se lo avisará al usuario y pedirá un segundo número, 
             * para decir a continuación si este segundo número también es múltiplo de 10.*/
            Console.WriteLine("Virificacion de multiplos");
            int num1, num2;
            Console.WriteLine("Escrible los numeros que desea verificar");
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 10 == 0)
            {
                Console.WriteLine("El numero {0} es multiplo de 10", num1);

                Console.Write("Introduce un segundo numero para verificar: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 % 10 == 0) Console.WriteLine("Ël numero {0} tambien es multiplo de 10", num2);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_3_1()
        {
            /*Crear un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un primer número entero. 
             * Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". 
             * Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo número y se mostrará el producto de ambos.*/
            Console.WriteLine("Multiplicacion de dos numeros");
            int num1, num2, resultado;
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0) Console.WriteLine("0 multiplicado por cualquier numero es igual a 0");
            if (num1 != 0)
            {
                Console.Write("Segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                resultado = num1 * num2;
                Console.WriteLine(resultado);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_3_2()
        {
            /*Crear un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo. 
             * Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".*/
            Console.WriteLine("Divicion de dos numeros");
            int num1, num2, resultado;
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0) Console.WriteLine("Error, no se puede dividir entre 0");
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine(resultado);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_4_1()
        {
            /*Mejorar la solución al ejercicio 2.1.3.1, usando "else".*/
            Console.WriteLine("Multiplicacion de dos numeros");
            int num1, num2, resultado;
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0) Console.WriteLine("0 multiplicado por cualquier numero es igual a 0");
            else
            {
                Console.Write("Segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                resultado = num1 * num2;
                Console.WriteLine(resultado);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_4_2()
        {
            /*Mejorar la solución al ejercicio 2.1.3.2, usando "else".*/
            Console.WriteLine("Divicion de dos numeros");
            int num1, num2, resultado;
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0) Console.WriteLine("Error, no se puede dividir entre 0");
            else
            {
                resultado = num1 / num2;
                Console.WriteLine(resultado);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_5_1()
        {
            /*Crear un programa que pida al usuario un número enteros y diga si es múltiplo de 2 o de 3.*/
            int num1;
            Console.WriteLine("Introduce un numero para saber si es multiplos de 2 o 3");
            Console.Write(" Numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0 || num1 % 3 == 0) Console.WriteLine("Si, es Multiplo");
            else Console.WriteLine("No es multiplo");
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_5_2()
        {
            /*Crear un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo", 
             * "Los dos números son positivos" o bien "Ninguno de los números es positivo", según corresponda.*/
            Console.WriteLine("CUANTOS NUMEROS POSITIVOS O NEGATIVOS HAY");
            int num1, num2;
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0 & num2 > 0) Console.WriteLine("Ambos numeros son positivos");
            else if (num1 > 0 || num2 > 0) Console.WriteLine("Un solo numeros es positivos");
            else if (num1 < 0 & num2 < 0) Console.WriteLine("Niguno es positivo");
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_5_3()
        {
            /*Crear un programa que pida al usuario tres números reales y muestre cuál es el mayor de los tres.*/
            int num1, num2, num3;

            Console.WriteLine("CUAL NUMERO ES MAYOR?");
            Console.Write("\nPrimer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tercer numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 & num1 > num3) Console.WriteLine("El numero {0} es mayor que {1} Y {2}", num1, num2, num3);
            else if (num2 > num1 & num2 > num3) Console.WriteLine("El numero {0} es mayor que {1} Y {2}", num2, num1, num3);
            else Console.WriteLine("El numero {0} es mayor que {1} y {2}", num3, num1, num2);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_5_4()
        {
            /*Crear un programa que pida al usuario dos números enteros cortos y diga si son iguales o, en caso contrario, cuál es el mayor de ellos.*/
            int num1, num2;
            Console.WriteLine("QUE NUMERO ES MAYOT");
            Console.Write("\nPrimer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2) Console.WriteLine("Ambos numeros son iguales");
            else if (num1 > num2) Console.WriteLine("El numero {0} es mayor que {1}", num1, num2);
            else Console.WriteLine("El numero {0} es mayor que el {1}", num2, num1);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_8_1()
        {
            /*Crear un programa que use el operador condicional para mostrar un el valor absoluto de un número de la siguiente forma: si el número es positivo, 
             * se mostrará tal cual; si es negativo, se mostrará cambiado de signo.*/
            int num, valorAb;
            Console.WriteLine("VALOR ABSOLUTO DE UN NUMERO");
            Console.Write("Introduce un numero para saber su valor absoluto: ");
            num = Convert.ToInt32(Console.ReadLine());
            valorAb = (num > 0) ? num : num * (-1);
            Console.WriteLine("El valor absoluto de {0} es {1}", num, valorAb);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_1_8_2()
        {
            /*Usar el operador condicional para calcular el menor de dos números.*/
            int num1, num2, menoNum;
            Console.WriteLine("CUAL ES EL NUMERO MENOR");
            Console.Write("Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            menoNum = (num1 > num2) ? num2 : num1;
            Console.WriteLine("El numero {0} es menor", menoNum);
        }
        /*_____________________________________________________________________________________________________________*/

        static void Ejercicio2_1_9_1()
        {
            /* Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, 
             * una cifra numérica o una consonante (pista: habrá que usar un dato de tipo "char").*/
            Console.WriteLine("NUMERO, VOCAL O CONSONANTE");
            char letra;
            Console.WriteLine("Introduce un valor de las mencionadas anteriormente");
            Console.Write("Opciones: ");
            letra = char.Parse(Console.ReadLine());

            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("La opcion {0} es una vocal", letra);
                    break;

                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("La opcion {0} es un numero", letra);
                    break;
                default:
                    Console.WriteLine("La opcion {0} es una consonante", letra);
                    break;
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio2_1_9_2()
        {
            /* Crear un programa que lea una letra tecleada por el usuario y diga si se trata de un signo de puntuación, una cifra numérica o algún otro carácter.*/
            Console.WriteLine("SIGNO DE PUNTUACIO, CIFRA NUMERICA U OTRO CARACTER");
            char opcion;
            Console.Write("Pulsa una telca: ");
            opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    Console.WriteLine("{0} es una cifra numerica", opcion);
                    break;

                case '.':
                case ',':
                case ':':
                case ';':
                case '"':
                case '!':
                case '?':
                    Console.WriteLine("{0} es un signo de punutacion", opcion);
                    break;
                default:
                    Console.WriteLine("{0} es un caracter", opcion);
                    break;
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio2_1_9_3()
        {
            /* Repetir el ejercicio 2.1.9.1, empleando "if" en lugar de "switch".*/
            Console.WriteLine("NUMERO, VOCAL O CONSONANTE");
            char tecla;
            Console.WriteLine("Introduce un valor de las mencionadas anteriormente");
            Console.Write("Opciones: ");
            tecla = char.Parse(Console.ReadLine());

            if (tecla == '1') Console.WriteLine("En un numero");
            else if (tecla == '2') Console.WriteLine("En un numero");
            else if (tecla == '3') Console.WriteLine("En un numero");
            else if (tecla == '4') Console.WriteLine("En un numero");
            else if (tecla == '5') Console.WriteLine("En un numero");
            else if (tecla == '6') Console.WriteLine("En un numero");
            else if (tecla == '7') Console.WriteLine("En un numero");
            else if (tecla == '8') Console.WriteLine("En un numero");
            else if (tecla == '9') Console.WriteLine("En un numero");
            else if (tecla == '0') Console.WriteLine("En un numero");

            else if (tecla == 'a' || tecla == 'A') Console.WriteLine("En una vocal");
            else if (tecla == 'e' || tecla == 'E') Console.WriteLine("En una vocal");
            else if (tecla == 'i' || tecla == 'I') Console.WriteLine("En una vocal");
            else if (tecla == 'o' || tecla == 'O') Console.WriteLine("En una vocal");
            else if (tecla == 'u' || tecla == 'U') Console.WriteLine("En una vocal");

            else Console.WriteLine("Es una Consonante");
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejercicio2_1_9_4()
        {
            /* Repetir el ejercicio 2.1.9.2, empleando "if" en lugar de "switch".*/
            Console.WriteLine("SIGNO DE PUNTUACIO, CIFRA NUMERICA U OTRO CARACTER");
            char tecla;
            Console.Write("Pulsa una telca: ");
            tecla = Convert.ToChar(Console.ReadLine());
            if (tecla == '1') Console.WriteLine("En un numero");
            else if (tecla == '2') Console.WriteLine("En un numero");
            else if (tecla == '3') Console.WriteLine("En un numero");
            else if (tecla == '4') Console.WriteLine("En un numero");
            else if (tecla == '5') Console.WriteLine("En un numero");
            else if (tecla == '6') Console.WriteLine("En un numero");
            else if (tecla == '7') Console.WriteLine("En un numero");
            else if (tecla == '8') Console.WriteLine("En un numero");
            else if (tecla == '9') Console.WriteLine("En un numero");
            else if (tecla == '0') Console.WriteLine("En un numero");

            if (tecla == '.') Console.WriteLine("Es un signo de puntuacion");
            else if (tecla == ',') Console.WriteLine("s un signo de puntuacion");
            else if (tecla == ':') Console.WriteLine("s un signo de puntuaciono");
            else if (tecla == ';') Console.WriteLine("s un signo de puntuacion");
            else if (tecla == '?') Console.WriteLine("s un signo de puntuacion");
            else if (tecla == '!') Console.WriteLine("s un signo de puntuacion");
            else if (tecla == '"') Console.WriteLine("s un signo de puntuacion");

            else Console.WriteLine("Es algun otro caracter");
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
                    { Console.Write("*");
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

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio2_9_1()
        {
            /*Crear un programa que pregunte al usuario su edad y su año de nacimiento. Si la edad que introduce no es un número válido, mostrará un mensaje 
             * de aviso, pero aun así le preguntará su año de nacimiento.*/

            int edad, anoNacimiento;
            try
            {
                Console.Write("Intoriduce tu edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, ese no es un numero valido");
            }
            Console.Write("Introduce tu fecha de nacimciento: ");
            anoNacimiento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Naciste en el año {0}", anoNacimiento);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_1_2_1()
        {
            /*Preguntar al usuario su edad, que se guardará en un "byte". A continuación, se deberá le deberá decir que no aparenta tantos años 
             * (por ejemplo, "No aparentas 20 años")..*/
            Console.Write("Introduce tu edad: ");
            byte edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("No aparentas {0} años", edad);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_1_2_2()
        {
            /*Pedir al usuario dos números de dos cifras ("byte"), calcular su multiplicación, que se deberá guardar en un "ushort", y mostrar el resultado en pantalla..*/
            Console.WriteLine("MULTIPLICACION");
            Console.Write("Primer numero: ");
            byte num1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Segundo numero: ");
            byte num2 = Convert.ToByte(Console.ReadLine());
            ushort resultado = (ushort)(num1 * num2);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_1_2_3()
        {
            /*Pedir al usuario dos números enteros largos ("long") y mostrar su suma, su resta y su producto.*/
            Console.WriteLine("RESTA, MULTIPLICACION Y SUMA");
            Console.Write("Primer numero: ");
            byte num1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Segundo numero: ");
            byte num2 = Convert.ToByte(Console.ReadLine());

            long resultado = (long)(num1 * num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, resultado);

            resultado = (long)(num1 - num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, resultado);

            resultado = (long)(num1 + num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_1_3_1()
        {
            /*Crear un programa que use tres variables x,y,z. Sus valores iniciales serán 15, -10, 2.147.483.647. Se deberá incrementar el valor de estas variables. 
             * ¿Qué valores esperas que se obtengan? Contrástalo con el resultado obtenido por el programa.*/
            byte x = 15; sbyte y = -10; uint z = 2147483647;
            x++; y++; z++;
            Console.WriteLine("{0} | {1} | {2}", x, y, z);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_1_3_2()
        {
            /*¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5; a=a*2;*/
            byte a, b, c;
            a = 5;
            Console.WriteLine("{0}", a);
            b = ++a;
            c = a++;
            Console.Write("a = {0}, b={1}, c={2}", a, b, c);
            b = (byte)(b * 5);
            a = (byte)(a * 2);
            Console.Write("a = {0}, b={1}", b, a);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_1_4_1()
        {
            /*Crear un programa que use tres variables x,y,z. Sus valores iniciales serán 15, -10, 214. Se deberá incrementar el valor de estas variables en 12, 
             * usando el formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado obtenido por el programa.*/
            byte ValUno = 15;
            sbyte ValDos = -10;
            byte ValTres = 214;

            ValUno += 12;
            ValDos += 12;
            ValTres += 12;

            Console.WriteLine("Valor uno = {0}, Valor dos = {1}, Valor tres= {2}", ValUno, ValDos, ValTres);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_1_4_2()
        {
            /*¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b;*/


        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_2_1()
        {
            /*Calcular el área de un círculo, dado su radio (pi * radio al cuadrado)*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_2_2()
        {
            /*Crear un programa que pida al usuario a una distancia (en metros) y el tiempo necesario para recorrerla (como tres números: horas, minutos, segundos), 
             * y muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas por hora (pista: 1 milla = 1.609 metros).*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_2_3()
        {
            /*Hallar las soluciones de una ecuación de segundo grado del tipo y = Ax2 + Bx + C. Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x)*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_2_4()
        {
            /*Si se ingresan E euros en el banco a un cierto interés I durante N años, el dinero obtenido viene dado por la fórmula del interés compuesto: 
             * Resultado = e(1 + i)n Aplicarlo para calcular en cuanto se convierten 1.000 euros al cabo de 10 años al 3 % de interés anual.*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_2_5()
        {
            /*SCrea un programa que muestre los primeros 20 valores de la función y = x2 - 1*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_2_6()
        {
            /*Crea un programa que "dibuje" la gráfica de y = (x-5)2 para valores de x entre 1 y 10. Deberá hacerlo dibujando varios espacios en pantalla y 
             * luego un asterisco. La cantidad de espacios dependerá del valor obtenido para "y".*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_2_7()
        {
            /*Escribe un programa que calcule una aproximación de PI mediante la expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ... 
             * El usuario deberá indicar la cantidad de términos a utilizar, y el programa mostrará todos los resultados hasta esa cantidad de términos.*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_3_1()
        {
            /*El usuario de nuestro programa podrá teclear dos números de hasta 12 cifras significativas. El programa deberá mostrar el resultado de 
             * dividir el primer número entre el segundo, utilizando tres cifras decimales.*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_3_2()
        {
            /*Crear un programa que use tres variables x,y,z. Las tres serán números reales, y nos bastará con dos cifras decimales. Deberá pedir al usuario los 
             * valores para las tres variables y mostrar en pantalla el valor de x2 + y - z (con exactamente dos cifras decimales).*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_3_3()
        {
            /*Calcular el perímetro, área y diagonal de un rectángulo, a partir de su ancho y alto (perímetro = suma de los cuatro lados, área = base x altura,
             * diagonal usando el teorema de Pitágoras). Mostrar todos ellos con una cifra decimal.*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_3_4()
        {
            /*Calcular la superficie y el volumen de una esfera, a partir de su radio (superficie = 4 * pi * radio al cuadrado; volumen = 4/3 * pi * radio al cubo). 
             * Mostrar los resultados con 3 cifras decimales.*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_4_1()
        {
            /*Crea un programa que pida números (en base 10) al usuario y muestre su equivalente en sistema binario y en hexadecimal. Debe repetirse hasta 
             * que el usuario introduzca el número 0.*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_4_2()
        {
            /*Crea un programa que pida al usuario la cantidad de rojo (por ejemplo, 255), verde (por ejemplo, 160) y azul (por ejemplo, 0) que tiene un color, 
             * y que muestre ese color RGB en notación hexadecimal (por ejemplo, FFA000)*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_4_3()
        {
            /*Crea un programa para mostar los números del 0 a 255 en hexadecimal, en 16 filas de 16 columnas cada una (la primera fila contendrá los números 
             * del 0 al 15 –decimal-, la segunda del 16 al 31 –decimal- y así sucesivamente).*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_2_4_4()
        {
            /*Crea un programa que pida números binarios al usuario y muestre su equivalente en sistema hexadecimal y en decimal. Debe repetirse hasta que 
             * el usuario introduzca la palabra "fin".*/

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_3_1_1()
        {
            /*Crear un programa que pida una letra al usuario y diga si se trata de una vocal.*/
            Console.WriteLine("Indroduce Una Lertra");
            char Letra = Convert.ToChar(Console.ReadLine());
            switch (Letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es una vocal");
                    break;
                default:
                    Console.WriteLine("Es una consonente");
                    break;
            }

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_3_2_1()
        {
            /*Crea un programa que pida al usuario que teclee cuatro letras y las muestre en pantalla juntas, pero en orden inverso, y entre comillas dobles.
             * Por ejemplo si las letras que se teclean son a, l, o, h, escribiría "hola".*/
            Console.WriteLine("Treclea 4 letras");
            Console.Write("1ra Letra: ");
            char Letra1 = Convert.ToChar(Console.ReadLine());
            Console.Write("2da Letra: ");
            char Letra2 = Convert.ToChar(Console.ReadLine());
            Console.Write("3ra Letra: ");
            char Letra3 = Convert.ToChar(Console.ReadLine());
            Console.Write("4ta Letra: ");
            char Letra4 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" \"{0}{1}{2}{3}\" ", Letra1, Letra2, Letra3, Letra4);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_4_1()
        {
            /*Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Juan", o bien le diga 
             * "No te conozco" si teclea otro nombre.*/
            Console.Write("Introduce tu Nombre: ");
            string Nombre = Console.ReadLine();

            if (Nombre == "Juan" || Nombre == "juan" || Nombre == "JUAN") Console.WriteLine("Hola {0} Bienvenido", Nombre);
            else Console.WriteLine("No te conozco MMG");

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio3_4_2()
        {
            /*Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se debe introducir dos veces. 
             * Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas.*/
            string Usuario, Contrasena1, Contrasena2;

            Console.Write("Introduce el usuario: ");
            Usuario = Console.ReadLine();
            Console.Write("Introduce la contraseña: ");
            Contrasena1 = Console.ReadLine();
            Console.Write("Confirmar contraseña: ");
            Contrasena2 = Console.ReadLine();

            while (Contrasena2 != Contrasena1)
            {
                Console.WriteLine("Las contraseñas no Coinsiden \nIntentalo de Nuevo");
                Console.Write("Introduce la contraseña: ");
                Contrasena1 = Console.ReadLine();
                Console.Write("Confirmar contraseña: ");
                Contrasena2 = Console.ReadLine();
            }
            Console.WriteLine("Usuario y contraseña registrados correctamente.");
        }
        /*_____________________________________________________________________________________________________________*/

        static void ejercicio3_5_2()
        {
            /*Crea una versión alternativa del ejercicio 3.5.1, que use "if" en vez del operador condicional.*/
            bool iguales = true;

            Console.WriteLine("Introduce dos numero");
            byte num1, num2;
            Console.Write("Primer numero: ");
            num1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToByte(Console.ReadLine());

            iguales = (num1 == num2);

            Console.WriteLine("Los numeros iugales {0}", iguales);
        }
        /*_____________________________________________________________________________________________________________*/

        static void ejercicio3_5_4()
        {
            /*Crea una versión alternativa del ejercicio 3.5.3, que use "if" en vez del operador condicional.*/
            bool AmbosPares = true;

            Console.WriteLine("Introduce dos numero");
            byte num1, num2;
            Console.Write("Primer numero: ");
            num1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num2 = Convert.ToByte(Console.ReadLine());

            if (num1 % num2 == 0) Console.WriteLine("Ambos son mares? {0}", AmbosPares);
            else AmbosPares = false; Console.WriteLine("Ambos son pares? {0}", AmbosPares);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_1_1()
        {
            /*Crea un programa que pida al usuario 4 números, los memorice (utilizando una tabla), calcule su media aritmética y 
             * después muestre en pantalla la media y los datos tecleados.*/
            int[] num = new int[4];
            int MediaAritmetica = 0;

            Console.WriteLine("Introduce 4 numero\n");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Introduce del num {0}:", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
                MediaAritmetica += num[i];
            }

            MediaAritmetica /= 4;

            for (int i = 0; i < 4; i++) 
            {
                Console.Write("Numeros {0}:", num[i]);
            }

            Console.WriteLine("Media Aritmetica = {0}", MediaAritmetica);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_1_2()
        {

            /* Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float")
            y luego los muestre en el orden contrario al que se introdujeron.*/
            float[] num = new float[5];


            Console.WriteLine("Introduce 5 numerios FLOAT");
            Console.Write("Primer numero: ");
            num[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tercer numero: ");
            num[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cuarto numero: ");
            num[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quinto numero: ");
            num[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}{3}{4}", num[4], num[3], num[3], num[2], num[1], num[0]);


        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_1_3()
        {
            /*Un programa que pida al usuario 4 números enteros y calcule (y muestre) cuál es el mayor de ellos. 
             Nota: para calcular el mayor valor de un array, hay que cada uno de los valores que tiene almacenados 
             con el que hasta ese momento es el máximo. El valor inicial de este máximo no debería ser cero 
             (porque fallaría si todos los números son negativos), sino el primer elemento del array.*/

            int[] num = new int[4];

            Console.WriteLine("Introduce 4 numeri");
            Console.Write("Primer numero: ");
            num[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            num[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tercer numero: ");
            num[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cuarto numero: ");
            num[3] = Convert.ToInt32(Console.ReadLine());

            int nummayor = num[0];

            if (nummayor < num[1])
            {
                nummayor = num[1];
            }

            if (nummayor < num[2])
            {
                nummayor = num[2];
            }

            if (nummayor < num[3])
            {
                nummayor = num[3];
            }

            Console.WriteLine("El numero {0} es mayor", nummayor);
        }
        /*_____________________________________________________________________________________________________________*/

        static void ejercicio4_1_2_1()
        {
            /*Un programa que almacene en una tabla el número de días que tiene cada mes(supondremos que es un año no bisiesto),
            pida al usuario que le indique un mes(1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.*/

            Console.WriteLine("CUANTOS DIAS TIENES LOS MESES DE LA AÑ0");
            int[] dias_x_mes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("Indica el numero de mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[0]);
                    break;
                case 2:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[1]);
                    break;
                case 3:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[2]);
                    break;
                case 4:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[3]);
                    break;
                case 5:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[4]);
                    break;
                case 6:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[5]);
                    break;
                case 7:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[6]);
                    break;
                case 8:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[7]);
                    break;
                case 9:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[8]);
                    break;
                case 10:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[9]);
                    break;
                case 11:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[10]);
                    break;
                case 12:
                    Console.WriteLine("el mes {0} tiene {1} dias", mes, dias_x_mes[11]);
                    break;
                default:
                    break;
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_3_1()
        {
            /*Un programa que almacene en una tabla el número de días que tiene cada mes(de un año no bisiesto), pida al 
            usuario que le indique un mes(ej. 2 para febrero) y un día(ej.el día 15) y diga qué número de día es dentro 
            del año(por ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre sería el día 365).*/

            int[] DiasxMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int DiasTotales = 0;

            Console.WriteLine("Indique un numero de dia y mes");

            Console.Write("Dia: ");
            int Dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mes: ");
            int Mes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Mes - 1; i++)
            {
                DiasTotales += DiasxMes[i];
            }

            DiasTotales += Dia;

            Console.WriteLine("Este el dia {0} del año ", DiasTotales);

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_1()
        {
            /*crear otro que pida al usuario que le indique la fecha, detallando el día (1 al 31) 
            y el mes (1=enero, 12=diciembre), como respuesta muestre en pantalla el número de días que quedan hasta final de año.*/

            int[] DiasxMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int DiasTotales = 0;


            Console.Write("Introduce el Dia (1 al 31): ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el Mes(1 al 12): ");
            int mes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < mes - 1; i++)
            {
                DiasTotales += DiasxMes[i];
            }

            DiasTotales += dia;

            int diasrestantes = 365 - DiasTotales;

            Console.WriteLine("Al año le restan {0} dias", diasrestantes);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_2()
        {
            /*Crear un programa que pida al usuario 10 números en coma flotante (pista: necesitarás un array de "float") y 
             * luego los muestre en orden inverso (del último que se ha introducido al primero que se introdujo).*/

            Console.WriteLine("INTRODODUCE 10 NUMEROS.");
            float[] Numeros = new float[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Numero {0}: ", i + 1);
                Numeros[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("Numeros introducidos en orden inversa");

            for (int d = 10; d > 0; d--)
            {
                Console.WriteLine("{0}", Numeros[d]);
            }
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_3()
        {
            /*Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos.*/
            Console.WriteLine("CUAL ES EL NUMERO MAYOR");
            Console.WriteLine("Introduce 10 nuemros");
            int[] Nume = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Intoduce el numero {0}: ", i + 1);
                Nume[i] = Convert.ToInt32(Console.ReadLine());
            }

            int mayor = Nume[0];

            for (int d = 0; d < 10; d++)
            {
                if (mayor < Nume[d])
                {
                    mayor = Nume[d];
                }
            }

            Console.WriteLine("El numero mayor es {0}", mayor);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_4()
        {
            /*Un programa que pida al usuario 10 números, calcule su media y luego muestre los que están por encima de la media.*/

            Console.WriteLine("CUALES SON LOS NUMEROS MAYORES A LA MEDIA");
            Console.WriteLine("Introduce 10 nuemros");
            int[] Nume = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Intoduce el numero {0}: ", i + 1);
                Nume[i] = Convert.ToInt32(Console.ReadLine());
            }

            int media = Nume[0];

            for (int m = 0; m < 10; m++) 
            {
                media += Nume[m];
            }
            media /= 10;
            Console.WriteLine("La media es: {0} ", media);
            
            int NumSobreMedia = 0;
            for (int p = 0; p < 10; p++ ) 
            {
                if (Nume[p] > media) 
                {
                    NumSobreMedia = Nume[p];
                    Console.WriteLine(NumSobreMedia);
                }
            }
           
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_5() 
        {
            /*Un programa que pida 10 nombres y los memorice (pista: esta vez se trata de un array de "string"). 
             Después deberá pedir que se teclee un nombre y dirá si se encuentra o no entre los 10 que se han tecleado antes. 
             Volverá a pedir otro nombre y a decir si se encuentra entre ellos, y así sucesivamente hasta que se teclee "fin".*/

            Console.WriteLine("INTRODUCE 10 NOMBRES");
            string[] Nombre = new string[10];
            for (int n = 0; n < 10; n++)
            {
                Console.Write("Nombre {0}: ", n + 1);
                Nombre[n] = (Console.ReadLine());
            }

            Console.WriteLine("\nTECLEE UN NOMBRE PARA VEREFICAR O 'Fin' PARA TERMINAR");
            Console.Write("----> ");
            string Nombree = Console.ReadLine();

            while (Nombree != "Fin")
            {
                bool Encontrado = false;

                for (int i = 0; i < 10; i++)
                {
                    if (Nombre[i] == Nombree)
                    {
                        Encontrado = true;
                    }
                }
                if (Encontrado) Console.WriteLine("\nEl nombre a sido Encontrado");
                else { Console.WriteLine("\nNombre no Encontrado"); }

                Console.WriteLine("\nESCRIBE OTRO NOMBRE PARA BUCAR O 'Fin' PARA TERMINAR");
                Console.Write("----> ");
                Nombree = Console.ReadLine();
            }
            Console.WriteLine("\nFin del programa");
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_6()
        {
            /*Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro 
             sin teclear nada, momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido.*/

            Console.WriteLine("OTRO PROGRAMA MAS DE INTRODUCIR NOMBRES");
            
            string[] Nombres = new string[100];
            for (int i = 0; i < 100; i++) 
            {
                Console.Write("Nombre {0}:", i+1);
                Nombres[i] = Console.ReadLine();

                if (Nombres[i] == "") break;
            }

            Console.WriteLine("\nLISTADO DE NOMBRES INTRODUCIDOS");

            for (int i = 0; i < 100; i++)
            {
                if (Nombres[i] == "") break;
                Console.WriteLine("\n Nombre {0}: {1}",i+1, Nombres[i]);
            }       
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_7() 
        {
            /*Un programa que reserve espacio para un vector de 3 componentes, pida al usuario valores para dichas componentes (por ejemplo [2, -5, 7]) y
             * muestre su módulo (raíz cuadrada de la suma de sus componentes al cuadrado).*/

            sbyte[] Vector = new sbyte[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                Vector[i] = Convert.ToSByte(Console.ReadLine());
            }
            int Modulo = 0;
           
            for (int i = 0; i < 3; i++)
            {
                Vector[i] *= Vector[i];
                Modulo += Vector[i];
            }
            double resultado = Math.Sqrt(Modulo);     
            Console.WriteLine(resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_8() 
        {
            /*Un programa que reserve espacio para dos vectores de 3 componentes, pida al usuario sus valores y calcule la suma de ambos vectores 
             * (su primera componente será x1+y1, la segunda será x2+y2 y así sucesivamente).*/

           int[] Vector1 = new int[3];
            int[] Vector2 = new int[3];
            int[] resultado = new int[3];

            Console.WriteLine("VALORES DEL VECTOR 1\n");
            for (int v1 = 0; v1 < 3; v1++)
            {
                Console.Write("Valor {0}: ", v1 + 1);
                Vector1[v1] = Convert.ToSByte(Console.ReadLine());
            }

            Console.WriteLine("\nVALORES DEL VECTOR 2\n");
            for (int v2 = 0; v2 < 3; v2++)
            {
                Console.Write("Valor {0}: ", v2 + 1);
                Vector2[v2] = Convert.ToSByte(Console.ReadLine());
            }

            for (int r = 0; r < 3; r++)
            {
                resultado[r] = Vector1[r] + Vector2[r];
            }

            Console.WriteLine("LA SUMA TOTAL ES\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Valor {0} es {1}", i + 1, resultado[i]);
            }

        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_4_9()
        {
            /*Un programa que reserve espacio para dos vectores de 3 componentes, pida al usuario sus valores y calcule su producto escalar (x1·y1+ x2·y2+x3·y3).*/
            int[] Vector1 = new int[3];
            int[] Vector2 = new int[3];
            int Resultado = 0;

            Console.WriteLine("VALORES DEL VECTOR 1");
            for (int v1 = 0; v1 < 3; v1++) 
            {
                Console.Write("Valor {0}: ", v1+1);
                Vector1[v1] = Convert.ToInt16(Console.ReadLine());
            }
            
            Console.WriteLine("\nVALORES DEL VECTOR 2");
            for (int v2 = 0; v2 < 3; v2++)
            {
                Console.Write("Valor {0}: ", v2 + 1);
                Vector2[v2] = Convert.ToInt16(Console.ReadLine());
            }

            for(int i = 0; i < 3; i++) 
            {
                Resultado += Vector1[i] * Vector2[i];
            }

            Console.Write("\nProfucto Escalar: {0}",Resultado);
        }
        /*_____________________________________________________________________________________________________________*/
        static void Ejemplo_36b() 
        {
            int[] dato = { 10, 15, 12, 0, 0 };
            int capacidad = 5;
            int cantidad = 3;
            int i;

            // Mostramos el array
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("{0} ", dato[i]); 
            }
            Console.WriteLine();

            // Buscamos el dato "15"
            for (i = 0; i < cantidad; i++)
            {
                if (dato[i] == 15)
                {
                    Console.WriteLine("15 encontrado en la posición {0} ", i + 1);
                }
            }            

            // Añadimos un dato al final
            Console.WriteLine("\nAñadiendo 6 al final"); 
            if (cantidad < capacidad) 
            {      
                dato[cantidad] = 6; 
                cantidad++; 
            }

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("{0} ", dato[i]);           
            }
            Console.WriteLine();

            // Borramos el segundo dato
            Console.WriteLine("\nBorrando el segundo dato"); 
            int posicionBorrar = 1;
            for (i = posicionBorrar; i < cantidad - 1; i++)
            {
                dato[i] = dato[i + 1]; 
            }
            cantidad--;

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("{0} ", dato[i]);
            }
            Console.WriteLine();

            // Insertamos 30 en la tercera posición
            if (cantidad < capacidad) 
            { 
                Console.WriteLine("\nInsertando 30 en la posición 3"); 
                int posicionInsertar = 2;
                for (i = cantidad; i > posicionInsertar; i--)
                {
                    dato[i] = dato[i - 1]; 
                    dato[posicionInsertar] = 30; 
                }
                cantidad++;
            }

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("{0} ", dato[i]); 
            }
            Console.WriteLine();
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_5_1() 
        {
            /*Amplía el ejemplo anterior (36b) para que avise si el dato buscado no aparece.*/

            int[] dato = { 10, 15, 12, 0, 0 };
            int capacidad = 5;
            int cantidad = 3;
            int i;

            // Mostramos el array
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("{0} ", dato[i]);
            }
            Console.WriteLine();

            // Buscamos el dato "15"
            bool Encontrado = false;
            for (i = 0; i < cantidad; i++)
            {
                if (dato[i] == 15)
                {
                    Encontrado = true;
                    Console.WriteLine("15 encontrado en la posición {0} ", i + 1);
                }
            }  if (Encontrado == false) { Console.WriteLine("15 no fue encontrado"); }



            // Añadimos un dato al final
            Console.WriteLine("\nAñadiendo 6 al final");
            if (cantidad < capacidad)
            {
                dato[cantidad] = 6;
                cantidad++;
            }

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("{0} ", dato[i]);
            }
            Console.WriteLine();

            // Borramos el segundo dato
            Console.WriteLine("\nBorrando el segundo dato");
            int posicionBorrar = 1;
            for (i = posicionBorrar; i < cantidad - 1; i++)
            {
                dato[i] = dato[i + 1];
            }
            cantidad--;

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("{0} ", dato[i]);
            }
            Console.WriteLine();

            // Insertamos 30 en la tercera posición
            if (cantidad < capacidad)
            {
                Console.WriteLine("\nInsertando 30 en la posición 3");
                int posicionInsertar = 2;
                for (i = cantidad; i > posicionInsertar; i--)      //0->1
                {                                                                    //1->2
                    dato[i] = dato[i - 1];                                   //2->3
                }                                                                    //3->4
                dato[posicionInsertar] = 30;                        //4->
                cantidad++;                                                  //5->
            }

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("{0} ", dato[i]);
            }
            Console.WriteLine();
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_1_5_2()
        {
            /*Un programa que prepare espacio para un máximo de 10 nombres. Deberá mostrar al usuario un menú que le permita realizar las siguientes operaciones:
            o Añadir un dato al final de los ya existentes.
            o Insertar un dato en una cierta posición (como ya se ha comentado, los que quedén detrás deberán desplazarse "a la derecha" para dejarle hueco; 
            
            por ejemplo, si el array contiene "hola", "adios" y se pide insertar "bien" en la segunda posición, el array pasará a contener "hola", "bien", "adios".
            o Borrar el dato que hay en una cierta posición (como se ha visto, lo que estaban detrás deberán desplazarse "a la izquierda" para que no haya huecos; 
            
            por ejemplo, si el array contiene "hola", "bien", "adios" y se pide borrar el dato de la segunda posición, el array pasará a contener "hola", "adios"
            o Mostrar los datos que contiene el array.
            o Salir del programa.*/

            string[] Nombres = { "Rutchy", "Jeffly", "Juan", "Pedro", "Jose", "Manuel", "Maria", "", "", "" };
            int Capacidad = 10;
            int Cantidad = 7;
            int Opciones;
            int i;

            do
            {
                Console.WriteLine("\nMENU DE OPCIONES");
                Console.WriteLine("1: Mostrar los nombres de las lista");
                Console.WriteLine("2: Añadir un nombre al final de arreglo");
                Console.WriteLine("3: Inserta un nombre en una posicion entre 1 y 10");
                Console.WriteLine("4: Elimina un nombre de la lista");
                Console.WriteLine("0: Salir del programa");
                Console.Write("\nElije una opocion: ");
                Opciones = Convert.ToInt16(Console.ReadLine());

                switch (Opciones)
                {
                    case 1:
                        Console.WriteLine("\nNOMBRES");
                        for (i = 0; i < 10; i++)
                        {
                            Console.WriteLine("{0}: {1}", i + 1, Nombres[i]);
                        }
                        break;
                    case 2:
                        bool Agregado = false;
                        Console.Write("Escribe un nombre que desea agregar: ");
                        string NombreAdd = Console.ReadLine();
                        if( Cantidad < Capacidad)
                        {
                            Nombres[Cantidad] = NombreAdd;
                            Cantidad++;
                            Agregado = true;
                        }
                        Console.WriteLine("Nombre  agregado correctamente");
                        break;
                    case 3:
                        Console.Write("Numero de posicion: ");
                        int PosicionInsertar = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Nombre a insertar: ");
                        string NombreInsertar = Console.ReadLine();
                        
                        if (Cantidad < Capacidad)
                        {
                            Console.WriteLine("Insertando {0} en la lista", NombreInsertar);
                            for (i = Cantidad; i > PosicionInsertar; i--)
                            {
                                Nombres[i] = Nombres[i-1];
                            }
                            Agregado = true;
                            Nombres[PosicionInsertar-1] = NombreInsertar;
                            Cantidad++;
                            Console.WriteLine("Nombre insertado corectamente");
                        }
                        break;
                    case 4:
                        Console.WriteLine("La poscion del nombre que desea borrar: ");
                        int PosicionEliminar = Convert.ToInt16(Console.ReadLine());

                        for(i = PosicionEliminar; i < Cantidad; i++)
                        {
                            Nombres[i] = Nombres[i + 1];
                        }
                        Cantidad--;
                        break;
                    default:
                        break;
                }
            }
            while (Opciones != 0);
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
                Console.WriteLine("\nGrupo {0} ",i + 1);
                for (int j = 0; j < num[i].Length; j++) 
                {
                    Console.Write("Numero {0} : ", j + 1);
                    num[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i <num.Length; i++) 
            {
                Console.WriteLine("\nNumeros del grupo {0}", i + 1);
                for (int j = 0; j < num[i].Length; j++) 
                {
                    Console.Write("{0}", num[i][j] );   
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

            for(int i = 0; i< texto.Length; i++) 
            {
                Console.WriteLine("\nBloque {0}", i+1);
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
                for(int i = 0;i< texto.Length; i++)
                {
                    for(int j = 0;j < texto[i].Length; j++)
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

                } else Console.WriteLine("El nombre {0} no ha sido encontrado", nombre);
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
             for(int i = 0; i< matrizA.Length; i++) 
             {
                for (int j = 0; j < matrizA[i].Length; j++)
                {
                    Console.Write("fila {0} columna {1}: ", i + 1, j + 1);
                    matrizA[i][j] = Convert.ToInt32(Console.ReadLine());
                }
             }

             for(int i = 0;i< matrizA.Length; i++) 
             {
                for(int j = 0; j <matrizA[i].Length; j++) 
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
            matrizA [1] = new int[3];
            matrizA[2] = new int[3];
            int resultado = 0;

            Console.WriteLine("DETERMINANTE DE UNA MATRIZ 3x3");
            Console.WriteLine("Escribe cada elmento de la matriz");
            for (int i = 0; i< matrizA.Length; i++)
            {
                for(int j = 0; j < matrizA[i].Length; j++)
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

        /*_____________________________________________________________________________________________________________*/
        struct Musicaa_MP3
        {
            public string Artista;
            public string Titulo;
            public int Duracion;
            public float Tamano;
        }

        static void ejercicio4_3_1_1()
        {
            /*Un "struct" que almacene datos de una canción en formato MP3: Artista, Título, Duración (en segundos), Tamaño del fichero (en KB). Un programa debe 
             * pedir los datos de una canción al usuario, almacenarlos en dicho "struct" y después mostrarlos en pantalla..*/

            Console.WriteLine("INDTRODUCE LOS SIGUIENTES DATOS DE KLA MUSICA");
            Musicaa_MP3 musica;

            Console.Write("Nombre del artista: ");
            musica.Artista = Console.ReadLine();
            Console.Write("Titulo de la musica: ");
            musica.Titulo = Console.ReadLine();
            Console.Write("Duracion la musica: ");
            musica.Duracion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tamaño del fichero: ");
            musica.Tamano = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nDato de la musica.");
            Console.WriteLine("\nArtista: {0} \nTitulo {1} \nDuracion: {2} seg \nTamaño: {3} KB", musica.Artista, musica.Titulo, musica.Duracion, musica.Tamano);

        }

        /*_____________________________________________________________________________________________________________*/

        struct Musica_MP3
        {
            public string Artista;
            public string Titulo;
            public int Duracion;
            public float Tamano;
        }
        static void ejercicio4_3_2_1()
        {
            /*Ampliar el programa 4.3.1.1, para que almacene datos de hasta 100 canciones. Deberá tener un menú que permita las opciones: añadir una nueva canción, 
             * mostrar el título de todas las canciones, buscar la canción que contenga un cierto texto (en el artista o en el título).*/

            Musica_MP3[] musica = new Musica_MP3[100];
            char opcion;
            int cantidad = 0;

            do
            {
                Console.WriteLine("SELECCIONS UNA OPCION\n");
                Console.WriteLine("1. Agregar nueva cancion");
                Console.WriteLine("2. Mostar todas la canciones");
                Console.WriteLine("3. Buscar una cancion");
                Console.WriteLine("4. Salir");

                Console.Write("Opcion: ");
                opcion = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case ('1'):
                        Console.WriteLine("COMPLETE LOS DATOS PARA AGREGAR UNA NUEVA MUSICA\n");
                        if (cantidad < musica.Length)
                        {
                            Console.Write("Nombre del artista: ");
                            musica[cantidad].Artista = Console.ReadLine();
                            Console.Write("Titulo de la musica: ");
                            musica[cantidad].Titulo = Console.ReadLine();
                            Console.Write("Duracion de la musisca: ");
                            musica[cantidad].Duracion = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tamaño del fichero: ");
                            musica[cantidad].Tamano = Convert.ToSingle(Console.ReadLine());

                            cantidad++;
                        }
                        else Console.WriteLine("Espacio insuficiente, no de puede agregar mas musicas");
                        Console.Clear();
                    break;

                    case ('2'):
                        Console.WriteLine("LISTA DE TODAS LA MUSICAS\n");

                            for (int i = 0; i < musica.Length && i < cantidad; i++)
                            {
                                Console.WriteLine("\n{0}. {1}", i + 1, musica[i].Titulo);
                            }

                    break;

                    case ('3'):
                        bool encontrado = false;
                        int posicion = -1;
                        Console.WriteLine("BUSCAR MUSICA POR NOMBRE\n");
                        Console.Write("Nombre de la musica: ");
                        string nombrebusqueda = Console.ReadLine();

                        for(int i = 0; i < cantidad ; i++) 
                        {
                            if (musica[i].Titulo == nombrebusqueda) 
                            {
                                encontrado = true;
                                posicion = i;
                                break;
                                
                            }
                                
                        }
                        if (encontrado)
                        {
                            Console.WriteLine("Artista: {0} \nTitulo: {1} \n Duracion: {2} \nTamaño: {3}", musica[posicion].Artista, musica[posicion].Titulo, musica[posicion].Tamano, musica[posicion].Duracion, musica[posicion]);
                        }

                        break;

                    default:
                        Console.WriteLine("Debe elegir una opcion valida");
                        break;
                }

            } while (opcion != '4');


        }

        /*_____________________________________________________________________________________________________________*/
        struct imagenes
        {
            public string nombre;
            public int ancho;
            public int alto;
            public float tamanho;
        }

        static void ejercicio4_3_2_2()
        {
            /*Un programa que permita guardar datos de "imágenes" (ficheros de ordenador que contengan fotografías o cualquier otro tipo de información gráfica). 
             * De cada imagen se debe guardar: nombre (texto), ancho en píxeles (por ejemplo 2000), alto en píxeles (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6).
             * El programa debe ser capaz de almacenar hasta 700 imágenes (deberá avisar cuando su capacidad esté llena). Debe permitir las opciones: añadir una ficha nueva,
             * ver todas las fichas (número y nombre de cada imagen), buscar la ficha que tenga un cierto nombre.*/

            imagenes[] imagen = new imagenes[700];
            int cantidad = 0;
            int posicion = -1;
            int opcion;
            bool econtrado = false;

            do
            {
                Console.WriteLine("GESTION DE INFORMACIONES GRAFICAS");
                Console.WriteLine("\nElija la una opcion");
                Console.WriteLine("\n1. Agregar una nueva ficha");
                Console.WriteLine("2. Ver todas las fichas");
                Console.WriteLine("3. Buscar una ficha");
                Console.WriteLine("4. Salir");

                Console.Write("\nOpcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case (1):

                        Console.WriteLine("AGREGAR FICHAS");
                        Console.WriteLine("\nCompleta todos los datos corresponidentes");

                        if (cantidad < 700)
                        {
                            Console.Write("\nNombre de la imagen: ");
                            imagen[cantidad].nombre = Console.ReadLine();
                            Console.Write("Ancho de la imagen: ");
                            imagen[cantidad].ancho = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Alto de la imagen: ");
                            imagen[cantidad].alto = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tamaño de la imagen: ");
                            imagen[cantidad].tamanho = Convert.ToSingle(Console.ReadLine());

                            cantidad++;

                            Console.WriteLine("\nFicha agregada corecctamente");
                            Console.Write("\nEnter para volver al menu principal: ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (cantidad > 700) 
                        {
                            Console.WriteLine("\nNo se puede guardar mas fichas, capcidad maxima alcanzada");
                            Console.Write("\nEnter para volver al menu principal: ");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    break;

                    case (2):

                        Console.WriteLine("LISTA DE TODAS LA FICHAS AGREGADAS");
                        for (int i = 0; i < imagen.Length && i < cantidad; i++) 
                        {
                            Console.WriteLine("\n FICHA #: {0} \nNombre: {1} \nAncho: {2} px \nAlto: {3} px \nTamaño: {4} KB", i+1, imagen[i].nombre, imagen[i].ancho, imagen[i].alto, imagen[i].tamanho);
                        }

                        Console.Write("\nEnter para volver al menu principal: ");
                        Console.ReadKey();
                        Console.Clear();

                    break;

                    case (3):

                        Console.WriteLine("BUSCAR FICHAS POR NOMBRE");
                        Console.Write("Nombre de la imagen: ");
                        string nombreBusqueda = Console.ReadLine();

                        for (int i = 0; i < cantidad; i++) 
                        {
                            if (imagen[i].nombre == nombreBusqueda) 
                            {
                                econtrado = true;
                                posicion = i;
                                break;
                            }
                        }
                        Console.WriteLine("\nResultado de la busqueda");
                        if (econtrado) 
                        {
                            Console.WriteLine("\n FICHA: {0} \nNombre: {1}\n Ancho {2} px \nAlto {3} px \nTamaño {4} KB", posicion +1, imagen[posicion].nombre, imagen[posicion].ancho, imagen[posicion].alto, imagen[posicion].tamanho);
                            Console.Write("\nEnter para volver al menu principal: ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (!econtrado)
                        {
                            Console.WriteLine("\nFicha no encontrada");
                            Console.Write("\nEnter para volver al menu principal: ");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    break;

                    default:
                    break;
                }

            } while (opcion != 4);

        }

        /*_____________________________________________________________________________________________________________*/

        struct duracion
        {
            public int minutos;
            public int segundos;

        }

        struct musica_MP3
        {
            public string artista;
            public string titulo;
            public duracion tiempoTotal;
            public float tamano;
        }

        static void ejercicio4_3_3_1()
        {
            /*Ampliar el programa 4.3.2.1, para que el campo "duración" se almacene como minutos y segundos, usando un "struct" anidado que contenga a su vez estos dos campos.
             para que almacene datos de hasta 100 canciones. Deberá tener un menú que permita las opciones: añadir una nueva canción, 
             * mostrar el título de todas las canciones, buscar la canción que contenga un cierto texto (en el artista o en el título).
             */

            musica_MP3[] musica = new musica_MP3[100];
            int cantidad = 0;
            int posicion = 0;
            int opcion;
            bool encontrado = false;

            do
            {
                Console.WriteLine("PUTO PLAYLISTE DE MUSICAS\n");
                Console.WriteLine("1: Agregar musica.");
                Console.WriteLine("2: Ver lista de musica.");
                Console.WriteLine("3: Buscar musica.");
                Console.WriteLine("4: Salir.");

                Console.Write("\nElige una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("AGREGAR UNA NUEVA CANCION");

                        if (cantidad < 100)
                        {
                            Console.WriteLine("\nConpleta todos los datos");

                            Console.Write("\nNombre del artista: ");
                            musica[cantidad].artista = Console.ReadLine();
                            Console.Write("Titulo de la cancion: ");
                            musica[cantidad].titulo = Console.ReadLine();
                            Console.Write("Minutos: ");
                            musica[cantidad].tiempoTotal.minutos = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Segundos: ");
                            musica[cantidad].tiempoTotal.segundos = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tamaño: ");
                            musica[cantidad].tamano = Convert.ToSingle(Console.ReadLine());

                            cantidad++;

                            Console.WriteLine("\nMusica agregada correctamente");
                            Console.WriteLine("\nPrecione enter para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                        }                  
                    break;

                    case 2:
                        Console.WriteLine("LISTA DE TODAS LAS MUSICAS");
                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("\nArtista: {0} \nTitulo: {1} \nMinutos: {2} \nSegundos: {3} \nTamaño: {4}", musica[i].artista, musica[i].titulo, musica[i].tiempoTotal.minutos, musica[i].tiempoTotal.segundos, musica[i].tamano);
                            }

                            Console.WriteLine("Precione enter para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("No hay canciones guardadas");
                            Console.WriteLine("Precione enter para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    break;

                    case 3:
                        Console.WriteLine("BUSCAR MUSICA");
                        Console.Write("Nombre de la cancion a buscar: ");
                        string nombrebuscado = Console.ReadLine();

                        if(cantidad > 0) 
                        {
                            for(int i = 0; i < musica.Length && i < cantidad; i++) 
                            {
                                if (nombrebuscado == musica[i].titulo)
                                {
                                    posicion = i;
                                    encontrado = true;
                                    break;
                                }                                
                            }

                            if(encontrado) 
                            {
                                Console.WriteLine("Resultado de la busqueda");
                                Console.WriteLine("\nArtista: {0} \nTitulo: {1} \nMinutos: {2} \nSegundos: {3} \nTamaño: {4}", musica[posicion].artista, musica[posicion].titulo, musica[posicion].tiempoTotal.minutos, musica[posicion].tiempoTotal.segundos, musica[posicion].tamano);

                                Console.WriteLine("Precione enter para volver al menu principal");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("No hay canciones guardada con ese nombre");
                                Console.WriteLine("Precione enter para volver al menu principal");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else 
                        {
                            Console.WriteLine("No hay canciones guardadas");
                            Console.WriteLine("Precione enter para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    break;

                    default:
                        break;
                }

            } while (opcion!=4);


        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_4_3_1()
        {
            /*Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".*/
            Console.WriteLine("EJERCICIO DE CADENAS DE TEXTO STRING [STRING]");
            Console.Write("\nIntroduce tu nombre: ");
            string nombre = Console.ReadLine();

            for(int i = 0; i < nombre.Length; i++)
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
            Console.WriteLine(" {0}",resultado);

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

            for(int i = 0; i < nombre.Length; i++) 
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

            for(int i =0; i < frase.Length; i++)
            {
                Console.Write("\nFrase {0}: ", i + 1);
                frase[i] = Console.ReadLine();
            }

            do
            {

                Console.WriteLine("Escribe una texto para saber si se encuantra registrado.");
                Console.Write("Texto: ");
                pregunta = Console.ReadLine();

                if(pregunta == "fin") 
                {
                    break;
                }

                for(int i = 0; i < frase.Length; i++) 
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

            for(int i = 0; i<frases.Length; i++)
            {
                Console.Write("frase {0}: ", i+1);
                frases[i] = Console.ReadLine();
            }

            do
            {
                bool encontrado = false;
                Console.WriteLine("\nBuscar un texto para saber si existe.");
                Console.Write("\nTextos buscar: ");
                buscado = Console.ReadLine();

                if(buscado == "fin")
                {
                    break;
                }

                for(int i = 0; i<frases.Length; i++) 
                {
                    if (frases[i].Contains(buscado) ) 
                    {         
                        encontrado =true;
                        posicion = frases[i].IndexOf(buscado, 0);
                        break;
                    } 
                }

                if (encontrado && posicion == 0) 
                {
                    Console.WriteLine("El texto \"{0}\" ha sido encontrado. ", buscado);
                    Console.WriteLine("Se encuntra al principio de la frase");
                }
                else if(encontrado && posicion > 0) 
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
            char[] delimitadores = {' '};

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
            char[] delimitador = {' '};

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

            for(int i = 0; i < frases.Length; i++) 
            {
                Console.Write("Frase {0}: ", i + 1);
                frases[i] = Console.ReadLine();
            }

            Console.WriteLine("La mayor de estas frases es...");

            string mayor = frases[0];
            for(int i = 0;i < frases.Length; i++) 
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
                if ((i+1) % 2 != 0) 
                {
                    frase[i] = char.ToLower(frase[i]);
                }
                else if((i + 1) % 2 == 0) 
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

            foreach(string frase in frasePartida) 
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

            foreach ( string digito in numeroResultante)
            {
                resultado += int.Parse(digito);
            }

            Console.WriteLine(resultado);
        }

        struct Personas
        {
            public string nombre;
            public string apellido;
            public int edad;            
        }
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_1()
        {
            /* Un programa que pida el nombre, el apellido y la edad de una persona, los almacene en un "struct" y luego muestre los tres datos en una misma línea, separados por comas.*/
            Personas persona;
            Console.WriteLine("EJERCICIO DE STRUCTS");

            Console.Write("Nombre: ");
            persona.nombre = Console.ReadLine();
            Console.Write("Apellido: ");    
            persona.apellido = Console.ReadLine();
            Console.Write("Edad: ");
            persona.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}", persona.nombre, persona.apellido, persona.edad);

        }

        /*_____________________________________________________________________________________________________________*/

        struct fecha
        {
            public int dia;
            public int mes;
            public int anio;
        }

        struct Personass
        {
            public string nombreCompleto;
            public fecha fechaNacimiento;
        }
        static void ejercicio4_5_2()
        {
            /* Un programa que pida datos de 8 personas: nombre, dia de nacimiento, mes de nacimiento, y año de nacimiento (que se deben almacenar en una tabla de structs). 
             * Después deberá repetir lo siguiente: preguntar un número de mes y mostrar en pantalla los datos de las personas que cumplan los años durante ese mes. 
             * Terminará de repetirse cuando se teclee 0 como número de mes.*/

            Console.WriteLine("MAS EJERCICIOS DE STRUCS");
            Personass[] persona = new Personass[8];

            Console.WriteLine("Escribe los datos correspodiente para ocho personas");

            for (int i = 0; i <persona.Length; i++) 
            {
                Console.WriteLine("\nPersona {0}", i + 1); 
                Console.Write("\nNombre: ");
                persona[i].nombreCompleto = Console.ReadLine();
                Console.Write("Día de nacimiento: ");
                persona[i].fechaNacimiento.dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mes de nacimiento: ");
                persona[i].fechaNacimiento.mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Año de nacimiento: ");
                persona[i].fechaNacimiento.anio = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nEscribe un numero de mes para saber quien cumple años en ese mes.");
            int mes;

            do
            {
                Console.Write("Mes: ");
                mes = Convert.ToInt32(Console.ReadLine());

                if (mes == 0) break;

                for (int i = 0; i < persona.Length; i++)
                {
                    if (mes == persona[i].fechaNacimiento.mes) 
                    {
                        Console.WriteLine("\nNombre: {0} \nDía de nacimiento: {1} \nMes de nacimiento: {2} \nAño de nacimiento: {3}", persona[i].nombreCompleto, persona[i].fechaNacimiento.dia, persona[i].fechaNacimiento.mes, persona[i].fechaNacimiento.anio);
                    }
                }

            } while (true);

            Console.WriteLine("Fin del programa");

        }

        /*_____________________________________________________________________________________________________________*/

        struct Persons
        {
            public string nombre;
            public string direccion;
            public string telefono;
            public int edad;
        }

        static void ejercicio4_5_3()
        {
            /* Un programa que sea capaz de almacenar los datos de 50 personas: nombre, dirección, teléfono, edad (usando una tabla de structs). Deberá ir pidiendo los datos uno por uno, 
             * hasta que un nombre se introduzca vacío (se pulse Intro sin teclear nada). Entonces deberá aparecer un menú que permita:
                o Mostrar la lista de todos los nombres.
                o Mostrar las personas de una cierta edad.
                o Mostrar las personas cuya inicial sea la que el usuario indique.
                o Salir del programa
            (lógicamente, este menú debe repetirse hasta que se escoja la opción de "salir").*/

            Console.WriteLine("ALMACENAMIENTO DE DATOS DE 50 PERSONAS");
            Persons[] person = new Persons[50];
            int cantidad = 0;
            bool encontrado = false;

            Console.WriteLine("Completa los datos correspondientes para cada persona y enter para salir");
            for (int i = 0; i < person.Length; i++)
            {
                Console.Write("\nNombre: ");
                person[i].nombre = Console.ReadLine();

                if (person[i].nombre == "")
                {
                    break;            
                }

                Console.Write("Direccion: ");
                person[i].direccion = Console.ReadLine();
                Console.Write("Telefono: ");
                person[i].telefono = Console.ReadLine();
                Console.Write("Edad: ");
                person[i].edad = Convert.ToInt32(Console.ReadLine());
                cantidad++;
            }

            Console.Clear();
            char opcion;
            do
            {
                Console.WriteLine("Elige una opcion.");
                Console.WriteLine("a. Mostrar la lista de todos los nombres.");
                Console.WriteLine("b. Mostrar las personas de una cierta edad");
                Console.WriteLine("c. Mostrar las personar con x inicial");
                Console.WriteLine("d. Salir del programa");

                opcion = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 'a':
                        if (cantidad > 0)
                        {
                            Console.WriteLine("LISTA DE PERSONAS REGISTRADAS");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("\nPersona: {0} \nNombre Completo: {1} ", i + 1, person[i].nombre);
                            }
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        } 
                        else 
                        {
                            Console.WriteLine("NO HAY PERSONAS REGISTRADAS");
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    break;

                    case 'b':
                        encontrado = false;
                        Console.WriteLine("BUSCAR PERSONAS POR EDAD");

                        Console.Write("\nEdad a buscar: ");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Personas con la edad de {0}", edad);
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (edad == person[i].edad)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nPersona: {0} \nNombre Completo: {1} \nDireccion: {2} \nTelefono: {3} \nEdad: {4}", i + 1, person[i].nombre, person[i].direccion, person[i].telefono, person[i].edad);
                                }
                            }
                            if (!encontrado) Console.WriteLine("No hay una persona registradas con la edad de \"{0}\" años", edad);

                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay personar registradas");
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    break;
                    
                    case 'c':
                        encontrado = false;
                        Console.WriteLine("BUSCAR PERSONA POR EL INICIAL DE SU NOMBRE");
                        char inicial = Convert.ToChar(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Lista de personas con la inicial {0}", inicial);
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (person[i].nombre[0] == inicial)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nPersona: {0} \nNombre Completo: {1} \nDireccion: {2} \nTelefono: {3} \nEdad: {4}", i + 1, person[i].nombre, person[i].direccion, person[i].telefono, person[i].edad);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No existen personas con la inicia \"{0}\"", inicial);
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay personar registradas");
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    break;

                    case 'd':
                        Console.WriteLine("Saliendo del programa...");
                    break;

                    default:
                        Console.WriteLine("Seleccione una opcion valida");
                    break;
                }

            } while (opcion != 'd');

        }

        /*_____________________________________________________________________________________________________________*/
        struct Ficheros
        {
            public string nombre;
            public long tamanyo;
        }

        static void ejercicio4_5_4()
        {
            /* Mejorar la base de datos de ficheros (ejemplo 46) para que no permita introducir tamaños incorrectos (números negativos) ni nombres de fichero vacíos.*/

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nAgregar un nuevo fichero");

                        if(cantidad < 1000)
                        {
                            Console.Write("\nNombre: ");
                            fichero[cantidad].nombre = Console.ReadLine();
                            Console.Write("Tamaño: ");
                            fichero[cantidad].tamanyo =Convert.ToInt64(Console.ReadLine());

                            if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("El nombre no puede estar vacio y el tamaño debe ser mayor a cero"); 
                            else if (fichero[cantidad].nombre == "") Console.WriteLine("El nombre del fichero no puede estar vacio");
                            else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("El tamaño del fichero debe ser mayor a cero");
                            else
                            {
                                cantidad++;
                                Console.WriteLine("\nFichero registrado correctamente");
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nCantidad maxima de registros alcanzada");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Ficheros Almacenados\n");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("{0}: {1}",i+1, fichero[i].nombre );
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        encontrado = false;
                        Console.WriteLine("Ficheros con un tamaño mayor a \"x\" KB");

                        Console.Write("\nTamaño a buscar: ");
                        float tamanyo = Convert.ToSingle(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].tamanyo > tamanyo)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }
                            if (!encontrado) Console.WriteLine("No se encontradon ficheron mayores a {0} KB", tamanyo);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        encontrado =false;
                        Console.WriteLine("Buscar fichero por su nombre");

                        Console.Write("Nombre del fichero: ");
                        string nombreBusqueda = Console.ReadLine();
                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower() == nombreBusqueda.ToLower())
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 5);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_5()
        {
            /* Ampliar la base de datos de ficheros (ejemplo 46) para que incluya una opción de búsqueda parcial, en la que el usuario indique parte del nombre y se muestre 
             * todos los ficheros que contienen ese fragmento (usando "Contains" o "IndexOf"). Esta búsqueda no debe distinguir mayúsculas y minúsculas (con la ayuda de ToUpper o ToLower).*/


            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Busqueda Pacial de nombre");
                Console.WriteLine("6. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nAgregar un nuevo fichero");

                        if (cantidad < 1000)
                        {
                            Console.Write("\nNombre: ");
                            fichero[cantidad].nombre = Console.ReadLine();
                            Console.Write("Tamaño: ");
                            fichero[cantidad].tamanyo = Convert.ToInt64(Console.ReadLine());

                            if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("El nombre no puede estar vacio y el tamaño debe ser mayor a cero");
                            else if (fichero[cantidad].nombre == "") Console.WriteLine("El nombre del fichero no puede estar vacio");
                            else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("El tamaño del fichero debe ser mayor a cero");
                            else
                            {
                                cantidad++;
                                Console.WriteLine("\nFichero registrado correctamente");
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nCantidad maxima de registros alcanzada");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Ficheros Almacenados\n");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("{0}: {1}", i + 1, fichero[i].nombre);
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        encontrado = false;
                        Console.WriteLine("Ficheros con un tamaño mayor a \"x\" KB");

                        Console.Write("\nTamaño a buscar: ");
                        float tamanyo = Convert.ToSingle(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].tamanyo > tamanyo)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }
                            if (!encontrado) Console.WriteLine("No se encontradon ficheron mayores a {0} KB", tamanyo);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        encontrado = false;
                        Console.WriteLine("Buscar fichero por su nombre");

                        Console.Write("Nombre del fichero: ");
                        nombreBusqueda = Console.ReadLine();
                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower() == nombreBusqueda.ToLower())
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        encontrado = false;
                        Console.WriteLine("\nBusqueda parcial por el nombre");

                        Console.Write("\nNombre parcial: ");
                        nombreBusqueda = Console.ReadLine();

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower().Contains(nombreBusqueda.ToLower()))
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 6);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_6()
        {
            /*Ampliar el ejercicio anterior (4.5.5) para que la búsqueda sea incremental: el usuario irá indicando letra a letra el texto que quiere buscar, y se mostrará todos los datos 
             * que lo contienen (por ejemplo, primero los que contienen "j", luego "ju", después "jua" y finalmente "juan"). */

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Busqueda pacial de nombre");
                Console.WriteLine("6. Busqueda incremental");
                Console.WriteLine("7. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nAgregar un nuevo fichero");

                        if (cantidad < 1000)
                        {
                            Console.Write("\nNombre: ");
                            fichero[cantidad].nombre = Console.ReadLine();
                            Console.Write("Tamaño: ");
                            fichero[cantidad].tamanyo = Convert.ToInt64(Console.ReadLine());

                            if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("El nombre no puede estar vacio y el tamaño debe ser mayor a cero");
                            else if (fichero[cantidad].nombre == "") Console.WriteLine("El nombre del fichero no puede estar vacio");
                            else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("El tamaño del fichero debe ser mayor a cero");
                            else
                            {
                                cantidad++;
                                Console.WriteLine("\nFichero registrado correctamente");
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nCantidad maxima de registros alcanzada");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Ficheros Almacenados\n");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("{0}: {1}", i + 1, fichero[i].nombre);
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        encontrado = false;
                        Console.WriteLine("Ficheros con un tamaño mayor a \"x\" KB");

                        Console.Write("\nTamaño a buscar: ");
                        float tamanyo = Convert.ToSingle(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].tamanyo > tamanyo)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }
                            if (!encontrado) Console.WriteLine("No se encontradon ficheron mayores a {0} KB", tamanyo);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        encontrado = false;
                        Console.WriteLine("Buscar fichero por su nombre");

                        Console.Write("Nombre del fichero: ");
                        nombreBusqueda = Console.ReadLine();
                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower() == nombreBusqueda.ToLower())
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        encontrado = false;
                        Console.WriteLine("\nBusqueda parcial por el nombre");

                        Console.Write("\nNombre parcial: ");
                        nombreBusqueda = Console.ReadLine();

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower().Contains(nombreBusqueda.ToLower()))
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 6:
                        encontrado = false;
                        Console.WriteLine("Busqueda parcial");
                        Console.WriteLine("\nAgrega letra por letra para ir buscando.");
                        string letra = "";
                        string busqueda = "";

                        do
                        {
                            if (cantidad > 0)
                            {
                                Console.Write("\nLetra: ");
                                letra = (Console.ReadLine());
                                busqueda += letra;
                                Console.WriteLine(busqueda);

                                for (int i = 0; i < cantidad; i++)
                                {
                                    if (fichero[i].nombre.ToLower().Contains(busqueda.ToLower()))
                                    {
                                        encontrado = true;
                                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                    }
                                }

                                if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", busqueda);

                                if (letra == "")
                                {
                                    Console.WriteLine("\nPreciona enter para volver al menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo hay ficheros registrados");
                                Console.WriteLine("\nPreciona enter para volver al menu");
                                Console.ReadKey();
                                Console.Clear();
                            }

                            
                        } while (letra != "");

                        break;

                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 7);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_7()
        {
            /*Ampliar la base de datos de ficheros (ejemplo 46) para que se pueda borrar un cierto dato (habrá que "mover hacia atrás" todos los datos que había después de ese,
             * y disminuir el contador de la cantidad de datos que tenemos). */

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            bool borrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Busqueda pacial de nombre");
                Console.WriteLine("6. Busqueda incremental");
                Console.WriteLine("7. Borrar fichero");
                Console.WriteLine("8. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nAgregar un nuevo fichero");

                        if (cantidad < 1000)
                        {
                            Console.Write("\nNombre: ");
                            fichero[cantidad].nombre = Console.ReadLine();
                            Console.Write("Tamaño: ");
                            fichero[cantidad].tamanyo = Convert.ToInt64(Console.ReadLine());

                            if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("El nombre no puede estar vacio y el tamaño debe ser mayor a cero");
                            else if (fichero[cantidad].nombre == "") Console.WriteLine("El nombre del fichero no puede estar vacio");
                            else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("El tamaño del fichero debe ser mayor a cero");
                            else
                            {
                                cantidad++;
                                Console.WriteLine("\nFichero registrado correctamente");
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nCantidad maxima de registros alcanzada");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Ficheros Almacenados\n");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("{0}: {1}", i + 1, fichero[i].nombre);
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        encontrado = false;
                        Console.WriteLine("Ficheros con un tamaño mayor a \"x\" KB");

                        Console.Write("\nTamaño a buscar: ");
                        float tamanyo = Convert.ToSingle(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].tamanyo > tamanyo)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }
                            if (!encontrado) Console.WriteLine("No se encontradon ficheron mayores a {0} KB", tamanyo);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        encontrado = false;
                        Console.WriteLine("Buscar fichero por su nombre");

                        Console.Write("Nombre del fichero: ");
                        nombreBusqueda = Console.ReadLine();
                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower() == nombreBusqueda.ToLower())
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        encontrado = false;
                        Console.WriteLine("\nBusqueda parcial por el nombre");

                        Console.Write("\nNombre parcial: ");
                        nombreBusqueda = Console.ReadLine();

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower().Contains(nombreBusqueda.ToLower()))
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 6:
                        encontrado = false;
                        Console.WriteLine("Busqueda parcial");
                        Console.WriteLine("\nAgrega letra por letra para ir buscando.");
                        string letra = "";
                        string busqueda = "";

                        do
                        {
                            if (cantidad > 0)
                            {
                                Console.Write("\nLetra: ");
                                letra = (Console.ReadLine());
                                busqueda += letra;
                                Console.WriteLine(busqueda);

                                for (int i = 0; i < cantidad; i++)
                                {
                                    if (fichero[i].nombre.ToLower().Contains(busqueda.ToLower()))
                                    {
                                        encontrado = true;
                                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                    }
                                }

                                if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", busqueda);

                                if (letra == "")
                                {
                                    Console.WriteLine("\nPreciona enter para volver al menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo hay ficheros registrados");
                                Console.WriteLine("\nPreciona enter para volver al menu");
                                Console.ReadKey();
                                Console.Clear();
                            }


                        } while (letra != "");

                        break;

                    case 7:
                        borrado = false;
                        encontrado = false;
                        Console.WriteLine("Borrar fichero");

                        Console.Write("Nombre del fichero que desea borrar: ");
                        string nombre = Console.ReadLine();
                        int posicion = 0;

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre == nombre)
                                {
                                    encontrado = true;
                                    posicion = i;
                                    break;
                                }
                            }

                            if (encontrado)
                            {                               
                                for (int i = posicion; i < cantidad - 1; i++)
                                {
                                    fichero[i] = fichero[i + 1];
                                }
                                cantidad--;

                                Console.WriteLine("Fichero borrado correctamente");
                            }
                            else Console.WriteLine("No se encontro fichero con ese nombre.");


                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        

                        break;

                    case 8:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 8);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_8()
        {
            /* Mejorar la base de datos de ficheros (ejemplo 46) para que se pueda modificar un cierto dato a partir de su número (por ejemplo, el dato número 3). 
             * En esa modificación, se deberá permitir al usuario pulsar Intro sin teclear nada, para indicar que no desea modificar un cierto dato, en vez de reemplazarlo por una cadena vacía.*/

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Busqueda pacial de nombre");
                Console.WriteLine("6. Busqueda incremental");
                Console.WriteLine("7. Borrar fichero");
                Console.WriteLine("8. Modificar fichero");
                Console.WriteLine("9. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nAgregar un nuevo fichero");

                        if (cantidad < 1000)
                        {
                            Console.Write("\nNombre: ");
                            fichero[cantidad].nombre = Console.ReadLine();
                            Console.Write("Tamaño: ");
                            fichero[cantidad].tamanyo = Convert.ToInt64(Console.ReadLine());

                            if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("El nombre no puede estar vacio y el tamaño debe ser mayor a cero");
                            else if (fichero[cantidad].nombre == "") Console.WriteLine("El nombre del fichero no puede estar vacio");
                            else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("El tamaño del fichero debe ser mayor a cero");
                            else
                            {
                                cantidad++;
                                Console.WriteLine("\nFichero registrado correctamente");
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nCantidad maxima de registros alcanzada");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Ficheros Almacenados\n");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("{0}: {1}", i + 1, fichero[i].nombre);
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        encontrado = false;
                        Console.WriteLine("Ficheros con un tamaño mayor a \"x\" KB");

                        Console.Write("\nTamaño a buscar: ");
                        float tamanyo = Convert.ToSingle(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].tamanyo > tamanyo)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }
                            if (!encontrado) Console.WriteLine("No se encontradon ficheron mayores a {0} KB", tamanyo);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        encontrado = false;
                        Console.WriteLine("Buscar fichero por su nombre");

                        Console.Write("Nombre del fichero: ");
                        nombreBusqueda = Console.ReadLine();
                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower() == nombreBusqueda.ToLower())
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        encontrado = false;
                        Console.WriteLine("\nBusqueda parcial por el nombre");

                        Console.Write("\nNombre parcial: ");
                        nombreBusqueda = Console.ReadLine();

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower().Contains(nombreBusqueda.ToLower()))
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 6:
                        encontrado = false;
                        Console.WriteLine("Busqueda parcial");
                        Console.WriteLine("\nAgrega letra por letra para ir buscando.");
                        string letra = "";
                        string busqueda = "";

                        do
                        {
                            if (cantidad > 0)
                            {
                                Console.Write("\nLetra: ");
                                letra = (Console.ReadLine());
                                busqueda += letra;
                                Console.WriteLine(busqueda);

                                for (int i = 0; i < cantidad; i++)
                                {
                                    if (fichero[i].nombre.ToLower().Contains(busqueda.ToLower()))
                                    {
                                        encontrado = true;
                                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                    }
                                }

                                if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", busqueda);

                                if (letra == "")
                                {
                                    Console.WriteLine("\nPreciona enter para volver al menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo hay ficheros registrados");
                                Console.WriteLine("\nPreciona enter para volver al menu");
                                Console.ReadKey();
                                Console.Clear();
                            }


                        } while (letra != "");

                        break;

                    case 7:
                        encontrado = false;
                        Console.WriteLine("Borrar fichero");

                        Console.Write("Nombre del fichero que desea borrar: ");
                        string nombre = Console.ReadLine();
                        int posicion = 0;

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre == nombre)
                                {
                                    encontrado = true;
                                    posicion = i;
                                    break;
                                }
                            }

                            if (encontrado)
                            {
                                for (int i = posicion; i < cantidad - 1; i++)
                                {
                                    fichero[i] = fichero[i + 1];
                                }
                                cantidad--;

                                Console.WriteLine("Fichero borrado correctamente");
                            }
                            else Console.WriteLine("No se encontro fichero con ese nombre.");


                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 8:
                        encontrado = false;
                        string nombreTemporal, nombreNuevo;
                        string tamanyoTemporal, tamanyoNuevo;

                        Console.WriteLine("Modificar fichero");
                        
                        Console.Write("\nNumero de fichero: ");
                        int numFichero = Convert.ToInt32(Console.ReadLine());

                        for(int i = 0; i < cantidad; i++)
                        {
                            if (i == numFichero -1)
                            {
                                encontrado = true;
                                nombreTemporal = fichero[i].nombre;
                                tamanyoTemporal = fichero[i].tamanyo.ToString();

                                Console.WriteLine("Datos de fichero");
                                Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);

                                if (encontrado)
                                {
                                    Console.WriteLine("Escribe los datos que quiere modificar o perciona Enter para mantener los datos anteriores");

                                    Console.Write("\nNombre: ");
                                    nombreNuevo = Console.ReadLine();
                                    if(nombreNuevo == "")  fichero[i].nombre = nombreTemporal;
                                    else fichero[i].nombre = nombreNuevo;

                                    Console.Write("\nTamaño: ");
                                    tamanyoNuevo = (Console.ReadLine());
                                    if (tamanyoNuevo == "") fichero[i].tamanyo = long.Parse(tamanyoTemporal);
                                    else fichero[i].tamanyo = long.Parse(tamanyoNuevo);
                                }

                                Console.WriteLine("Datos actualizados");
                                Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                break;
                            }
                        }

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 9:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 9);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_9()
        {
            /* Ampliar la base de datos de ficheros (ejemplo 46) para que se permita ordenar los datos por nombre. Para ello, deberás buscar información sobre algún método de 
             * ordenación sencillo, como el "método de burbuja" (en el siguiente apartado tienes algunos), y aplicarlo a este caso concreto.*/

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Busqueda pacial de nombre");
                Console.WriteLine("6. Busqueda incremental");
                Console.WriteLine("7. Borrar fichero");
                Console.WriteLine("8. Modificar fichero");
                Console.WriteLine("9. Ordenar ficheros alfabeticamente");
                Console.WriteLine("10. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nAgregar un nuevo fichero");

                        if (cantidad < 1000)
                        {
                            Console.Write("\nNombre: ");
                            fichero[cantidad].nombre = Console.ReadLine();
                            Console.Write("Tamaño: ");
                            fichero[cantidad].tamanyo = Convert.ToInt64(Console.ReadLine());

                            if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("El nombre no puede estar vacio y el tamaño debe ser mayor a cero");
                            else if (fichero[cantidad].nombre == "") Console.WriteLine("El nombre del fichero no puede estar vacio");
                            else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("El tamaño del fichero debe ser mayor a cero");
                            else
                            {
                                cantidad++;
                                Console.WriteLine("\nFichero registrado correctamente");
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nCantidad maxima de registros alcanzada");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Ficheros Almacenados\n");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("{0}: {1}", i + 1, fichero[i].nombre);
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        encontrado = false;
                        Console.WriteLine("Ficheros con un tamaño mayor a \"x\" KB");

                        Console.Write("\nTamaño a buscar: ");
                        float tamanyo = Convert.ToSingle(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].tamanyo > tamanyo)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }
                            if (!encontrado) Console.WriteLine("No se encontradon ficheron mayores a {0} KB", tamanyo);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        encontrado = false;
                        Console.WriteLine("Buscar fichero por su nombre");

                        Console.Write("Nombre del fichero: ");
                        nombreBusqueda = Console.ReadLine();
                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower() == nombreBusqueda.ToLower())
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        encontrado = false;
                        Console.WriteLine("\nBusqueda parcial por el nombre");

                        Console.Write("\nNombre parcial: ");
                        nombreBusqueda = Console.ReadLine();

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre.ToLower().Contains(nombreBusqueda.ToLower()))
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 6:
                        encontrado = false;
                        Console.WriteLine("Busqueda parcial");
                        Console.WriteLine("\nAgrega letra por letra para ir buscando.");
                        string letra = "";
                        string busqueda = "";

                        do
                        {
                            if (cantidad > 0)
                            {
                                Console.Write("\nLetra: ");
                                letra = (Console.ReadLine());
                                busqueda += letra;
                                Console.WriteLine(busqueda);

                                for (int i = 0; i < cantidad; i++)
                                {
                                    if (fichero[i].nombre.ToLower().Contains(busqueda.ToLower()))
                                    {
                                        encontrado = true;
                                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                    }
                                }

                                if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", busqueda);

                                if (letra == "")
                                {
                                    Console.WriteLine("\nPreciona enter para volver al menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo hay ficheros registrados");
                                Console.WriteLine("\nPreciona enter para volver al menu");
                                Console.ReadKey();
                                Console.Clear();
                            }


                        } while (letra != "");

                        break;

                    case 7:
                        encontrado = false;
                        Console.WriteLine("Borrar fichero");

                        Console.Write("Nombre del fichero que desea borrar: ");
                        string nombre = Console.ReadLine();
                        int posicion = 0;

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (fichero[i].nombre == nombre)
                                {
                                    encontrado = true;
                                    posicion = i;
                                    break;
                                }
                            }

                            if (encontrado)
                            {
                                for (int i = posicion; i < cantidad - 1; i++)
                                {
                                    fichero[i] = fichero[i + 1];
                                }
                                cantidad--;

                                Console.WriteLine("Fichero borrado correctamente");
                            }
                            else Console.WriteLine("No se encontro fichero con ese nombre.");


                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 8:
                        encontrado = false;
                        string nombreTemporal, nombreNuevo;
                        string tamanyoTemporal, tamanyoNuevo;

                        Console.WriteLine("Modificar fichero");

                        Console.Write("\nNumero de fichero: ");
                        int numFichero = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (i == numFichero - 1)
                            {
                                encontrado = true;
                                nombreTemporal = fichero[i].nombre;
                                tamanyoTemporal = fichero[i].tamanyo.ToString();

                                Console.WriteLine("Datos de fichero");
                                Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);

                                if (encontrado)
                                {
                                    Console.WriteLine("Escribe los datos que quiere modificar o perciona Enter para mantener los datos anteriores");

                                    Console.Write("\nNombre: ");
                                    nombreNuevo = Console.ReadLine();
                                    if (nombreNuevo == "") fichero[i].nombre = nombreTemporal;
                                    else fichero[i].nombre = nombreNuevo;

                                    Console.Write("\nTamaño: ");
                                    tamanyoNuevo = (Console.ReadLine());
                                    if (tamanyoNuevo == "") fichero[i].tamanyo = long.Parse(tamanyoTemporal);
                                    else fichero[i].tamanyo = long.Parse(tamanyoNuevo);
                                }

                                Console.WriteLine("Datos actualizados");
                                Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                                break;
                            }
                        }

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 9:
                        Console.WriteLine("Ordenamiento de ficheros");

                        Console.WriteLine("\n1. Ordenar por nombre.");
                        Console.WriteLine("2. Ordenar por tamaño.");

                        Console.Write("Opcion: ");
                        int opcionn = Convert.ToInt32(Console.ReadLine());
                        string temporal = "";
                        long temporaL = 0;

                        if(opcionn == 1)
                        {
                            for (int i = 0; i < cantidad - 1; i++)
                            {
                                for (int j = i + 1; j < cantidad; j++)
                                {
                                    if (string.Compare(fichero[i].nombre, fichero[j].nombre, true) > 0)
                                    {
                                        temporal = fichero[i].nombre;
                                        fichero[i].nombre = fichero[j].nombre;
                                        fichero[j].nombre = temporal;
                                    }
                                }
                            }

                            Console.WriteLine("Ficheros ordenados alfabeticamente.");
                            foreach(Ficheros dato in fichero)
                            {
                                Console.WriteLine("{0}", dato.nombre);
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        } 
                        else if(opcionn == 2)
                        {
                            for(int i =0; i < cantidad -1; i++)
                            {
                                for(int j = i +1;  j < cantidad; j++)
                                {
                                    if (fichero[i].tamanyo > fichero[j].tamanyo)
                                    {
                                        temporaL = fichero[i].tamanyo;
                                        fichero[i].tamanyo = fichero[j].tamanyo;
                                        fichero[j].tamanyo = temporaL;
                                    }
                                }
                            }

                            Console.WriteLine("Ficheros ordenados por tamaño.");
                            foreach (Ficheros dato in fichero)
                            {
                                Console.WriteLine("{0}", dato.tamanyo);
                            }

                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 10:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 10);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_6_1()
        {
            /*Un programa que pida al usuario 5 números en coma flotante y los muestre ordenados. */

            Console.WriteLine("ORDENAR NUMEROS.");
            float[] numeros = new float[5];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("{0}: ", i+1);
                numeros[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("\nNumeros introducidos por el usuario");
            foreach(float numero in numeros)
            {
                Console.WriteLine("{0}", numero);
            }

            for(int i = 0; i < numeros.Length - 1; i++)
            {
                for(int j = i; j < numeros.Length; j++)
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

            for(int i= 0; i < nombres.Length -1; i++)
            {
                for(int j =i; j < nombres.Length; j++)
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
            foreach(string nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
         }

            /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_6_3()
        {
            /* Un programa que pida al usuario varios números, los vaya añadiendo a un array, mantenga el array ordenado continuamente y muestre el resultado 
             * tras añadir cada nuevo dato. Terminará cuando el usuario teclee "fin".*/

            int [] numeros = new int[25];
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


                for(int i =0; i < cantidad - 1; i++)
                {
                    for(int j = i +1; j< cantidad; j++)
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

                for(int i = 0; i < cantidad; i++) 
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

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/

        //ejercicio5_2_1
        public static void BorrarPantalla()
        {
            /* Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando 25 líneas en blanco. No debe devolver ningún valor. Crea también un 
             * "Main" que permita probarla.*/
            int linea = 0;

            while(linea < 25)
            {
                Console.WriteLine();
                linea++;
            }
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_2_2

        public static void DibujarCuadro3x3()
        {
            /* Crea una función llamada "DibujarCuadrado3x3", que dibuje un cuadrado formato por 3 filas con 3 asteriscos cada una. Crea también un "Main" 
             * que permita probarla.*/

            for(int i = 0; i < 3; i++)
            {
               for( int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_2_3

        /* Descompón en funciones la base de datos de ficheros (ejemplo 46), de modo que el "Main" sea breve y más legible (Pista: las variables que se compartan 
         * entre varias funciones deberán estar fuera de todas ellas, y deberán estar precedidas por la palabra "static").*/
        static Ficheros[] fichero = new Ficheros[1000];
        static int cantidad = 0;
        static int opcion;
        static bool encontrado = false;
        static string nombreBusqueda;

        public static void MenuPrincipal() 
        {
            Console.WriteLine("Seleccione una opcion.");
            Console.WriteLine("\n1. Agregar una nuevo fichero");
            Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
            Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
            Console.WriteLine("4. Ver todos los datos de un fichero");
            Console.WriteLine("5. Busqueda pacial de nombre");
            Console.WriteLine("6. Busqueda incremental");
            Console.WriteLine("7. Borrar fichero");
            Console.WriteLine("8. Modificar fichero");
            Console.WriteLine("9. Ordenar ficheros alfabeticamente");
            Console.WriteLine("10. Salir de la apliiacion\n");

            Console.Write("Opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public static void AgregarFichiero()
        {
            Console.WriteLine("\nAgregar un nuevo fichero");

            if (cantidad < 1000)
            {
                Console.Write("\nNombre: ");
                fichero[cantidad].nombre = Console.ReadLine();
                Console.Write("Tamaño: ");
                fichero[cantidad].tamanyo = Convert.ToInt64(Console.ReadLine());

                if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("El nombre no puede estar vacio y el tamaño debe ser mayor a cero");
                else if (fichero[cantidad].nombre == "") Console.WriteLine("El nombre del fichero no puede estar vacio");
                else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("El tamaño del fichero debe ser mayor a cero");
                else
                {
                    cantidad++;
                    Console.WriteLine("\nFichero registrado correctamente");
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nCantidad maxima de registros alcanzada");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void FicherosAlmacenados()
        {
            if (cantidad > 0)
            {
                Console.WriteLine("Ficheros Almacenados\n");
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, fichero[i].nombre);
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BuscarFichieroxTamanyo()
        {
            encontrado = false;
            Console.WriteLine("Ficheros con un tamaño mayor a \"x\" KB");

            Console.Write("\nTamaño a buscar: ");
            float tamanyo = Convert.ToSingle(Console.ReadLine());

            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].tamanyo > tamanyo)
                    {
                        encontrado = true;
                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                    }
                }
                if (!encontrado) Console.WriteLine("No se encontradon ficheron mayores a {0} KB", tamanyo);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BuscarFicheroxNombre()
        {
            encontrado = false;
            Console.WriteLine("Buscar fichero por su nombre");

            Console.Write("Nombre del fichero: ");
            nombreBusqueda = Console.ReadLine();
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].nombre.ToLower() == nombreBusqueda.ToLower())
                    {
                        encontrado = true;
                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                    }
                }

                if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("No hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BusquedaParcial()
        {
            encontrado = false;
            Console.WriteLine("\nBusqueda parcial por el nombre");

            Console.Write("\nNombre parcial: ");
            nombreBusqueda = Console.ReadLine();

            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].nombre.ToLower().Contains(nombreBusqueda.ToLower()))
                    {
                        encontrado = true;
                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                    }
                }

                if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BusquedaParcialxLentra()
        {
            encontrado = false;
            Console.WriteLine("Busqueda parcial");
            Console.WriteLine("\nAgrega letra por letra para ir buscando.");
            string letra = "";
            string busqueda = "";

            do
            {
                if (cantidad > 0)
                {
                    Console.Write("\nLetra: ");
                    letra = (Console.ReadLine());
                    busqueda += letra;
                    Console.WriteLine(busqueda);

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (fichero[i].nombre.ToLower().Contains(busqueda.ToLower()))
                        {
                            encontrado = true;
                            Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                        }
                    }

                    if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", busqueda);

                    if (letra == "")
                    {
                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("\nNo hay ficheros registrados");
                    Console.WriteLine("\nPreciona enter para volver al menu");
                    Console.ReadKey();
                    Console.Clear();
                }


            } while (letra != "");
        }

        public static void BorrarFichero()
        {
            encontrado = false;
            Console.WriteLine("Borrar fichero");

            Console.Write("Nombre del fichero que desea borrar: ");
            string nombre = Console.ReadLine();
            int posicion = 0;

            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].nombre == nombre)
                    {
                        encontrado = true;
                        posicion = i;
                        break;
                    }
                }

                if (encontrado)
                {
                    for (int i = posicion; i < cantidad - 1; i++)
                    {
                        fichero[i] = fichero[i + 1];
                    }
                    cantidad--;

                    Console.WriteLine("Fichero borrado correctamente");
                }
                else Console.WriteLine("No se encontro fichero con ese nombre.");


                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void ModificarFichero()
        {
            encontrado = false;
            string nombreTemporal, nombreNuevo;
            string tamanyoTemporal, tamanyoNuevo;

            Console.WriteLine("Modificar fichero");

            Console.Write("\nNumero de fichero: ");
            int numFichero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                if (i == numFichero - 1)
                {
                    encontrado = true;
                    nombreTemporal = fichero[i].nombre;
                    tamanyoTemporal = fichero[i].tamanyo.ToString();

                    Console.WriteLine("Datos de fichero");
                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);

                    if (encontrado)
                    {
                        Console.WriteLine("Escribe los datos que quiere modificar o perciona Enter para mantener los datos anteriores");

                        Console.Write("\nNombre: ");
                        nombreNuevo = Console.ReadLine();
                        if (nombreNuevo == "") fichero[i].nombre = nombreTemporal;
                        else fichero[i].nombre = nombreNuevo;

                        Console.Write("\nTamaño: ");
                        tamanyoNuevo = (Console.ReadLine());
                        if (tamanyoNuevo == "") fichero[i].tamanyo = long.Parse(tamanyoTemporal);
                        else fichero[i].tamanyo = long.Parse(tamanyoNuevo);
                    }

                    Console.WriteLine("Datos actualizados");
                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                    break;
                }
            }

            Console.WriteLine("\nPreciona enter para volver al menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void OrdenarFicheros()
        {
            Console.WriteLine("Ordenamiento de ficheros");

            Console.WriteLine("\n1. Ordenar por nombre.");
            Console.WriteLine("2. Ordenar por tamaño.");

            Console.Write("Opcion: ");
            int opcionn = Convert.ToInt32(Console.ReadLine());
            string temporal = "";
            long temporaL = 0;

            if (opcionn == 1)
            {
                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {
                        if (string.Compare(fichero[i].nombre, fichero[j].nombre, true) > 0)
                        {
                            temporal = fichero[i].nombre;
                            fichero[i].nombre = fichero[j].nombre;
                            fichero[j].nombre = temporal;
                        }
                    }
                }

                Console.WriteLine("Ficheros ordenados alfabeticamente.");
                foreach (Ficheros dato in fichero)
                {
                    Console.WriteLine("{0}", dato.nombre);
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else if (opcionn == 2)
            {
                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {
                        if (fichero[i].tamanyo > fichero[j].tamanyo)
                        {
                            temporaL = fichero[i].tamanyo;
                            fichero[i].tamanyo = fichero[j].tamanyo;
                            fichero[j].tamanyo = temporaL;
                        }
                    }
                }

                Console.WriteLine("Ficheros ordenados por tamaño.");
                foreach (Ficheros dato in fichero)
                {
                    Console.WriteLine("{0}", dato.tamanyo);
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BaseDeDatosFicheros()
        {
            do
            {
                MenuPrincipal();

                switch (opcion)
                {
                    case 1:
                        AgregarFichiero();
                        break;

                    case 2:
                        FicherosAlmacenados();
                        break;

                    case 3:
                        BuscarFichieroxTamanyo();
                        break;

                    case 4:
                        BuscarFicheroxNombre();
                        break;

                    case 5:
                        BusquedaParcial();
                        break;

                    case 6:
                        BusquedaParcialxLentra();
                        break;

                    case 7:
                        BorrarFichero();
                        break;

                    case 8:
                        ModificarFichero();
                        break;

                    case 9:
                        OrdenarFicheros();
                        break;

                    case 10:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != 10);        
        }

        /*_____________________________________________________________________________________________________________*/
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
        /*_____________________________________________________________________________________________________________*/

        //ejercicio5_3_3
        public static void DibujarRectanguloHueco(int alto, int ancho)
        {
            /*Crea una función que dibuje en pantalla un rectángulo hueco del ancho y alto que se indiquen como parámetros, formado por una letra que también 
             * se indique como parámetro. Completa el programa con un Main que pida esos datos al usuario y dibuje el rectángulo.*/

            for(int i = 0; i < alto; i++)
            {
                for(int j = 0; j < ancho; j++)
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

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_1
        /* Crear una función que calcule el cubo de un número real (float) que se indique como parámetro. El resultado deberá ser otro número real. Probar esta 
        * función para calcular el cubo de 3.2 y el de 5.*/

        public static float CuboNumero(float n)
        {
            return n * n * n;
        }

        public static void LlamarCuboNumero()
        {
            float numero = 3.2f;
            float resultado;

            resultado = CuboNumero(numero);
            Console.WriteLine("{0} elecado a 3 = {1}", numero, resultado);
            Console.WriteLine("y 5 elevado a 3 = {0}", CuboNumero(5));

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_2
        /*Crear una función que calcule el menor de dos números enteros que recibirá como parámetros. El resultado será otro número entero. */

        public static int NumeroMenorQue(int num1, int num2)
        {
            if(num1 < num2) return num1;
            else return num2; ;
        }

        public static void LlamarNumeroMenorQue()
        {
            Console.WriteLine("Escribe 2 numeros");

            Console.Write("\nNumero 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNumero 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = NumeroMenorQue(num1, num2);
            Console.WriteLine("\nEl numero menor es {0}", resultado);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_3
        /* Crear una función llamada "signo", que reciba un número real, y devuelva un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/

        public static int NumeroNegativoPositivo(float num)
        {
            if (num < 0) return -1;
            else if (num == 0) return 0;
            else return 1;
        }

        public static void LlamarNumeroNegativoPositivo()
        {
            Console.Write("Introduce un numero: ");
            float nume = Convert.ToSingle(Console.ReadLine());

            int resultado = NumeroNegativoPositivo(nume);

            Console.WriteLine(resultado);

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_4
        /* Crear una función que devuelva la primera letra de una cadena de texto. Probar esta función para calcular la primera letra de la frase "Hola".*/

        public static char PrimeraLetraString(string cadena)
        {
            return cadena[0];
        }

        public static void LlamarPrimeraLetraString()
        {
            Console.WriteLine("Calcular cual es la primera letra de una frase");
            char letra = PrimeraLetraString("Hola");
            Console.WriteLine(letra);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_5
        /* Crear una función que devuelva la última letra de una cadena de texto. Probar esta función para calcular la última letra de la frase "Hola".*/

        public static char UltimaLetraStrig(string cadena)
        {
            int total = cadena.Length;
            return cadena[total - 1];
        }

        public static void LlamarUltimaLetraString()
        {
            Console.WriteLine("Calcular cual es la ultima letra de una frase");
            char letra = UltimaLetraStrig("Hola");
            Console.WriteLine(letra);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_4_6
        /* Crear una función que reciba un número y calcule y muestre en pantalla el valor del perímetro y de la superficie de un cuadrado que tenga como lado 
          * el número que se ha indicado como parámetro.*/

        public static void CalcularPerimetroyArea(int x)
        {
            int area = x * x;
            int perimetro = x * 4;

            Console.WriteLine("El perimetro es: {0} \n El area es: {1}.", perimetro, area);
        }

        public static void LlamarCualcularPerimetroyArea() 
        {
            Console.WriteLine("CALCULAR PERIMETRO Y AREA.");
            Console.Write("\nMedida: ");
            int medida = Convert.ToInt16(Console.ReadLine());
            CalcularPerimetroyArea(medida);
        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_5_1()
        {
            /* Crear una función "pedirEntero", que reciba como parámetros el texto que se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo 
             * aceptable. Deberá pedir al usuario que introduzca el valor tantas veces como sea necesario, volvérselo a pedir en caso de error, y devolver un valor 
             * correcto. Probarlo con un programa que pida al usuario un año entre 1800 y 2100.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_5_2()
        {
            /* Crear una función "escribirTablaMultiplicar", que reciba como parámetro un número entero, y escriba la tabla de multiplicar de ese número 
             * (por ejemplo, para el 3 deberá llegar desde "3x0=0" hasta "3x10=30").*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_5_3()
        {
            /* Crear una función "esPrimo", que reciba un número y devuelva el valor booleano "true" si es un número primo o "false" en caso contrario.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_5_4()
        {
            /* Crear una función que reciba una cadena y una letra, y devuelva la cantidad de veces que dicha letra aparece en la cadena. Por ejemplo, si la cadena 
             * es "Barcelona" y la letra es 'a', debería devolver 2 (porque la "a" aparece 2 veces).*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_5_5()
        {
            /* Crear una función que reciba un numero cualquiera y que devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la suma sería 6.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_5_6()
        {
            /* Crear una función que reciba una letra y un número, y escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se 
             * ha indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir
                ****
                ***
                **
                *
                */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_7_1()
        {
            /*Crear una función "intercambia", que intercambie el valor de los dos números enteros que se le indiquen como parámetro. */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_7_2()
        {
            /* Crear una función "iniciales", que reciba una cadena como "Nacho Cabanes" y devuelva las letras N y C (primera letra, y letra situada tras el primer 
             * espacio), usando parámetros por referencia.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_1_1()
        {
            /* Crear un programa que genere un número al azar entre 1 y 100. El usuario tendrá 6 oportunidades para acertarlo.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_1_2()
        {
            /* Mejorar el programa del ahorcado (4.4.8.3), para que la palabra a adivinar no sea tecleado por un segundo usuario, sino que se escoja al azar de un 
             * "array" de palabras prefijadas (por ejemplo, nombres de ciudades).*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_1_3()
        {
            /* Crea un programa que "dibuje" asteriscos en 100 posiciones al azar de la pantalla . Para ayudarte para escribir en cualquier coordenada, puedes usar 
             * un array de dos dimensiones (con tamaños 24 para el alto y 79 para el ancho), que primero rellenes y luego dibujes en pantalla.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_9_2_1()
        {
            /* Crea un programa que halle cualquier raíz de un número. El usuario deberá indicar el número (por ejemplo, 2) y el índice de la raíz (por ejemplo, 
             * 3 para la raíz cúbica). Pista: hallar la raíz cúbica de 2 es lo mismo que elevar 2 a 1/3.*/

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

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_1()
        {
            /*Crear una función que calcule el valor de elevar un número entero a otro número entero (por ejemplo, 5 elevado a 3 = 53 = 5 ·5 ·5 = 125). 
             * Esta función se debe crear de forma recursiva. */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_2()
        {
            /* Como alternativa, crear una función que calcule el valor de elevar un número entero a otro número entero de forma NO recursiva 
             * (lo que llamaremos "de forma iterativa"), usando la orden "for".*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_3()
        {
            /*Crear un programa que emplee recursividad para calcular un número de la serie Fibonacci (en la que los dos primeros elementos valen 1, 
             * y para los restantes, cada elemento es la suma de los dos anteriores). */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_4()
        {
            /* Crear un programa que emplee recursividad para calcular la suma de los elementos de un vector.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_5()
        {
            /* Crear un programa que emplee recursividad para calcular el mayor de los elementos de un vector.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_6()
        {
            /* Crear un programa que emplee recursividad para dar la vuelta a una cadena de caracteres (por ejemplo, a partir de "Hola" devolvería "aloH").*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_7()
        {
            /*Crear, tanto de forma recursiva como de forma iterativa, una función diga si una cadena de caracteres es simétrica (un palíndromo). 
             * Por ejemplo, "DABALEARROZALAZORRAELABAD" es un palíndromo. */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_8()
        {
            /* Crear un programa que encuentre el máximo común divisor de dos números usando el algoritmo de Euclides: Dados dos números enteros positivos m y n, 
             * tal que m > n, para encontrar su máximo común divisor, es decir, el mayor entero positivo que divide a ambos: 
             * - Dividir m por n para obtener el resto r (0 ≤ r < n) ; - Si r = 0, el MCD es n.; - Si no, el máximo común divisor es MCD(n,r).*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_9()
        {
            /* Crea dos funciones que sirvan para saber si un cierto texto es subcadena de una cadena. No puedes usar "Contains" ni "IndexOf", sino que debes 
             * analizar letra a letra. Una función debe ser iterativa y la otra debe ser recursiva.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_10_10()
        {
            /* Crea una función que reciba una cadena de texto, y una subcadena, y devuelva cuántas veces aparece la subcadena en la cadena, como subsecuencia 
             * formada a partir de sus letras en orden. Por ejemplo, si recibes la palabra "Hhoola" y la subcadena "hola", la respuesta sería 4, porque se podría 
             * tomar la primera H con la primera O (y con la L y con la A), la primera H con la segunda O, la segunda H con la primera O, o bien la segunda H con 
             * la segunda O. Si recibes "hobla", la respuesta sería 1. Si recibes "ohla", la respuesta sería 0, porque tras la H no hay ninguna O que permita completar 
             * la secuencia en orden.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_11_1()
        {
            /*Crear un programa llamado "suma", que calcule (y muestre) la suma de dos números que se le indiquen como parámetro. Por ejemplo, si se teclea 
             * "suma 2 3" deberá responder "5", y si se teclea "suma 2" deberá responder "no hay suficientes datos y devolver un código de error 1. */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_11_2()
        {
            /*Crear una calculadora básica, llamada "calcula", que deberá sumar, restar, multiplicar o dividir los dos números que se le indiquen como parámetros. 
             * Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60". */

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_11_3()
        {
            /* Crear una variante del ejercicio 5.11.2, en la que Main devuelva el código 1 si la operación indicada no es válida o 0 cuando sí sea una operación aceptable.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio5_11_4()
        {
            /* Crear una variante del ejercicio 5.11.3, en la que Main devuelva también el código 2 si alguno de los dos números con los que se quiere operar 
             * no tiene un valor numérico válido.*/

        }

        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        static void ejercicio6_2_1()
        {
            /* */

        }
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
        /*_____________________________________________________________________________________________________________*/
    }
}
