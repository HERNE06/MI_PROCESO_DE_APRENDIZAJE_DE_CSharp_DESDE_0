using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._4_Como_se_Disenan_las_Clases
{
    //Ejercicio 6.6.1

    //Añade a la clase "Ventana" un nuevo método Abrir, que reciba un parámetro, que será un número del 0 al 100 que indique
    //hasta qué punto se debe abrir la ventana (100=100%, abierta; 0=0%, cerrada). Crea los atributos auxiliares que necesites para
    //reflejar esa información.

    internal class Ventana
    {
        protected int abrir;
        protected int cerrar;
        protected int porcentajeApertura;
        protected bool abierto;

        public void Abrir(int abrirr)
        {
            porcentajeApertura = abrirr;
            if (abrirr > 0 && abrirr <= 100) 
            { 
                abierto = true; 
            }
            else if (abrirr == 0) abierto = false;
        }

        public Ventana()
        {

        }
    }
}
