using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._4_Como_se_Disenan_las_Clases
{
    internal class Persiana
    {
        protected bool subir;

        public void Subir()
        {
            subir = true;
        }

        public void Bajar()
        {
            subir = false;
        }

        public Persiana()
        {

        }
    }
}
