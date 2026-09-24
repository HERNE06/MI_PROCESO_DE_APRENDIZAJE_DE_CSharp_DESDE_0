using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._1.Toma_de_contacto_con_CSharp
{
    internal class Datos_Introducidos_por_el_Usuario
    {
        static void Main(string[] args)
        {

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
    }
}
