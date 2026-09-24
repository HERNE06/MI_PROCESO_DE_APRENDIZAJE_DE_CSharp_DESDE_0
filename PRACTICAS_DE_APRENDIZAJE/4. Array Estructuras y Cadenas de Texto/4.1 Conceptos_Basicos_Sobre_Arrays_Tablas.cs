using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._4.Array_Estructuras_y_Cadenas_de_Texto
{
    internal class Conceptos_Basicos_Sobre_Arrays_Tablas
    {

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
            for (int p = 0; p < 10; p++)
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
                Console.Write("Nombre {0}:", i + 1);
                Nombres[i] = Console.ReadLine();

                if (Nombres[i] == "") break;
            }

            Console.WriteLine("\nLISTADO DE NOMBRES INTRODUCIDOS");

            for (int i = 0; i < 100; i++)
            {
                if (Nombres[i] == "") break;
                Console.WriteLine("\n Nombre {0}: {1}", i + 1, Nombres[i]);
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
                Console.Write("Valor {0}: ", v1 + 1);
                Vector1[v1] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("\nVALORES DEL VECTOR 2");
            for (int v2 = 0; v2 < 3; v2++)
            {
                Console.Write("Valor {0}: ", v2 + 1);
                Vector2[v2] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                Resultado += Vector1[i] * Vector2[i];
            }

            Console.Write("\nProfucto Escalar: {0}", Resultado);
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
            }
            if (Encontrado == false) { Console.WriteLine("15 no fue encontrado"); }



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
                        if (Cantidad < Capacidad)
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
                                Nombres[i] = Nombres[i - 1];
                            }
                            Agregado = true;
                            Nombres[PosicionInsertar - 1] = NombreInsertar;
                            Cantidad++;
                            Console.WriteLine("Nombre insertado corectamente");
                        }
                        break;
                    case 4:
                        Console.WriteLine("La poscion del nombre que desea borrar: ");
                        int PosicionEliminar = Convert.ToInt16(Console.ReadLine());

                        for (i = PosicionEliminar; i < Cantidad; i++)
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
    }
}
