using PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._1_Por_que_los_Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._3_La_Herencia_Visibilidad
{
    internal class PruebaPersona3
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            PersonaInglesa persona2 = new PersonaInglesa();
            PersonaInglesa persona3 = new PersonaInglesa();
            PersonaItaliana persona4 = new PersonaItaliana();

            persona1.SetNombre("Rutchy");
            persona2.SetNombre("George");
            persona3.SetNombre("Brayant");
            persona4.SetNombre("Mario");

            persona1.Saludar();

            persona2.Saludar();
            persona2.TomarTe();
            persona3.Saludar();
            persona3.TomarTe();

            persona4.Saludar();
        }
    }
}
