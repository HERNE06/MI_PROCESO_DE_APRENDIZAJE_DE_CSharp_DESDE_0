using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._1.Toma_de_contacto_con_CSharp
{
    public class Introduccion_a_las_Variables
    {

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
    }
}
