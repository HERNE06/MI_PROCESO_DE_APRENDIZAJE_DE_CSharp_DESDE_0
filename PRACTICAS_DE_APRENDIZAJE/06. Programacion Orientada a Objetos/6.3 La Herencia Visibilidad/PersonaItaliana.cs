using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._1_Por_que_los_Objetos;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._3_La_Herencia_Visibilidad
{
    // Ejercicio 6.3.2

    /*Ampliar las clases del ejercicio 6.3.1, creando un nuevo proyecto con las siguientes características:La clase 
     * Persona no cambia. La clase PersonaInglesa se modificará para que redefina el método "Saludar", para 
     * que escriba en pantalla "Hi, I am " seguido de su nombre. 
     * 
     * Se creará una nueva clase PersonaItaliana, en el fichero "personaItaliana.cs".  Esta clase deberá heredar 
     * las características de la clase "Persona", pero redefinir el método "Saludar", para que escriba en pantalla 
     * "Ciao". Crear también una clase llamada PruebaPersona3, en el fichero " pruebaPersona3.cs". Esta clase deberá 
     * contener sólo la función Main, que creará un objeto de tipo Persona, dos de tipo PersonaInglesa, uno de tipo 
     * PersonaItaliana, les asignará un nombre, les pedirá que saluden y pedirá a la persona inglesa que tome té.*/

    internal class PersonaItaliana : Persona
    {
        public new void Saludar()
        {
            Console.WriteLine("Ciao");
        }
    }
}
