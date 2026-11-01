using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._4_Como_se_Disenan_las_Clases
{
    internal class Calefactor
    {
        protected int temperatura;
        protected bool encender;

        public void Encender()
        {
            encender = true;
        }

        public void Apagar()
        {
            encender = false;
        }

        public void FijarTemperatura(int temp)
        {
            temperatura = temp;
        }

        public Calefactor()
        {
            encender = true;
            temperatura = 95;
        }

    }
}
