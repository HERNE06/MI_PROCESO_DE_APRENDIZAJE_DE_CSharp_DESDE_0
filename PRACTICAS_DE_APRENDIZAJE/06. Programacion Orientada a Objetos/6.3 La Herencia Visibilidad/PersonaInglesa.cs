using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._1_Por_que_los_Objetos;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._3_La_Herencia_Visibilidad
{
    //Ejercicio 6.3.1

    /*Ampliar las clases del ejercicio 6.2.2, creando un nuevo proyecto con las siguientes características: La clase Persona no cambia. 
     * Se creará una nueva clase PersonaInglesa, en el fichero "personaInglesa.cs".  Esta clase deberá heredar las características de 
     * la clase "Persona", y añadir un método "TomarTe", de tipo void, que escribirá en pantalla "Estoy tomando té".  Crear también una 
     * clase llamada Prueba- Persona2, en el fichero "pruebaPersona2.cs". Esta clase deberá contener sólo la función Main, que creará 
     * dos objetos de tipo Persona y uno de tipo PersonaInglesa, les asignará un nombre, les pedirá que saluden y pedirá a la persona 
     * inglesa que tome té.*/

    internal class PersonaInglesa : Persona
    {
        public void TomarTe()
        {
            Console.WriteLine("Estoy tomando te.");
        }

        public new void Saludar()
        {
            Console.WriteLine("Hi, i am {0}", nombre);
        }
    }
}
