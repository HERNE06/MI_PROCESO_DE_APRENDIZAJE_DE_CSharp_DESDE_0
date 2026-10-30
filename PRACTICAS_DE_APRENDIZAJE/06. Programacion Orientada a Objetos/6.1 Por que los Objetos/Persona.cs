using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._1_Por_que_los_Objetos
{
    //Ejercicio 6.2.1

    /*(6.2.1) Crear una clase llamada Persona, en el fichero "persona.cs". Esta clase deberá tener un atributo "nombre", 
     *de tipo string. También deberá tener un método"SetNombre", de tipo void y con un parámetro string, que permita 
     *cambiar el valor del nombre. Finalmente, también tendrá un método "Saludar", que escribirá en pantalla "Hola, soy 
     *" seguido de su nombre.  Crear también una clase llamada PruebaPersona. Esta clase deberá contener sólo la función 
     *Main, que creará dos objetos de tipo Persona, les asignará un nombre y les pedirá que saluden.*/

    internal class Persona
    {

        string nombre;

        public void SetNombre(string nombreNuevo)
        {
            nombre = nombreNuevo;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", nombre);
        }

    }
}
