using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._2.Estructuras_de_Control
{
    internal class Estructuras_Alternativas
    {

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
    }
}
