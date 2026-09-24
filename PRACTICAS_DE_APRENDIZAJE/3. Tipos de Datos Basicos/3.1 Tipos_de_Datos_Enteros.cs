using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._3.Tipos_de_Datos_Basicos
{
    internal class Tipos_de_Datos_Enteros
    {

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
    }
}
