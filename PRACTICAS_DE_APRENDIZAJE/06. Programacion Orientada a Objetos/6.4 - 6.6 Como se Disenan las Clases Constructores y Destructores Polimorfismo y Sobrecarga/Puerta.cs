using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._4_Como_se_Disenan_las_Clases
{
    internal class Puerta
    {
        protected int ancho;
        protected int alto;
        protected int color;
        protected bool abierta;

        public void Abrir()
        {
            abierta = true;
        }

        public void Cerrar()
        {
            abierta = false;
        }

        public Puerta()
        {

        }
    }
}
