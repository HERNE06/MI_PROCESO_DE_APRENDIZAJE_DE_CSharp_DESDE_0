using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._07._Utilizacion_Avanzada_de_Clases._7._4_Llamada_a_Un_Metodo_de_Clase_Padre.Ejercicio_7._4._2
{
    internal class Analista : Trabajador
    {
        public Analista() : base()
        {

        }

        public override void Hablar()
        {
            Console.WriteLine("Soy un analista.");
        }
    }
}
