using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._3.Tipos_de_Datos_Basicos
{
    internal class Tipos_de_Datos_Caracter
    {

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
    }
}
