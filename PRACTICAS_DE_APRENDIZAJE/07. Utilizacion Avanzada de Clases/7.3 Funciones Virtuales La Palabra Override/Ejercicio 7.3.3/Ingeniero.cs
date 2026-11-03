using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._07._Utilizacion_Avanzada_de_Clases._7._3_Funciones_Virtuales_La_Palabra_Override.Ejercicio_7._3._3
{
    internal class Ingeniero : Trabajador
    {
        public Ingeniero()
        {
            Console.WriteLine("Soy un Ingeniero");
        }

        public new void Hablar()
        {
            Console.WriteLine("Hola, soy un Ingeniero");
        }
    }
}
