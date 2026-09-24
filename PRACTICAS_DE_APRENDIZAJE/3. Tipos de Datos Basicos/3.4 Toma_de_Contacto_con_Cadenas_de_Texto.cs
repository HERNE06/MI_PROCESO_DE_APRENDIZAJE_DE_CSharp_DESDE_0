using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._3.Tipos_de_Datos_Basicos
{
    internal class Toma_de_Contacto_con_Cadenas_de_Texto
    {
        static void Main(string[] args)
        {

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
    }
}
