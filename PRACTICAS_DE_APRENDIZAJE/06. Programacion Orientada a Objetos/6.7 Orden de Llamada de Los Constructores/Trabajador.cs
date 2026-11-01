using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._7_Orden_de_Llamada_de_Los_Constructores
{
    //Ejemplo 7.7.1

    /*Crear un único fuente que contenga las siguientes clases: o Una clase Trabajador, cuyo constructor escriba en pantalla 
     * "Soy un trabajador". o Una clase Programador, que derive de Trabajador, cuyo constructor escriba en pantalla "Soy programador". 
     * o Una clase Analista, que derive de Trabajador, cuyo constructor escriba en pantalla "Soy analista". o Una clase Ingeniero, 
     * que derive de Trabajador, cuyo constructor escriba en pantalla "Soy ingeniero". o Una clase IngenieroInformatico, que derive de 
     * Ingeniero, cuyo constructor escriba en pantalla "Soy ingeniero informático". o Una clase "PruebaDeTrabajadores", que cree un objeto 
     * perteneciente a cada una de esas clases.*/

    internal class Trabajador
    {
        public Trabajador()
        {
            Console.WriteLine("Soy un trabajador");
        }
    }
}
