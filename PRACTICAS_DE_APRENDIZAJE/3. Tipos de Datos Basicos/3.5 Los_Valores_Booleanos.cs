using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._3.Tipos_de_Datos_Basicos
{
    internal class Los_Valores_Booleanos
    {
        static void Main(string[] args)
        {

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
    }
}
