using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._2.Estructuras_de_Control
{
    internal class Alternativas_Para_Control_de_Errore
    {

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
    }
}
