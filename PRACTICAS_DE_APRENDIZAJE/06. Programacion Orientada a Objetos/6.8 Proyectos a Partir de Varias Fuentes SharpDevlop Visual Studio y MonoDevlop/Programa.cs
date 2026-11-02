using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._06._Programacion_Orientada_a_Objetos._6._8_Proyectos_a_Partir_de_Varias_Fuentes_SharpDevlop_Visual_Studio_y_MonoDevlop
{
    //Ejercicio 6.8.1

    /* Crear un proyecto que represente el esqueleto de un juego básico. Contendrá una clase principal Programa, que a su vez 
     * contendrá las clases Presentacion, Ayuda, Creditos y Juego, cada una de ellas con su método Ejecutar. 
     * El juego contendrá: o Un Enemigo, con una coordenada x, otra y, un método Mover y un método Dibujar. o un Personaje, con una coordenada x, 
     * otra y, cuatro método MoverDerecha, MoverIzquierda y similares, y un método Dibujar. o Un Nivel, con un método Dibujar y un método 
     * EsPosibleMover, que recibirá dos coordenadas x e y, y devolverá un valor booleano.*/
    internal class Programa
    {
        static void Main(string[] args)
        {

        }

        internal class Juego
        {

            public void Ejecutar()
            {

            }

            internal class Personaje
            {
                protected string nombre;
                protected int eje_x;
                protected int eje_y;

                public void MoverArriba(int y)
                {
                    eje_y += y;
                }

                public void MoverAbajo(int y)
                {
                    eje_y -= y;
                }

                public void MoverDeracha(int x)
                {
                    eje_x += x;
                }

                public void MoverIzquierda(int x)
                {
                    eje_x -= x;
                }

                public void Dibujar()
                {

                }
            }

            internal class Enemigo
            {
                protected string nombre;
                protected int eje_x;
                protected int eje_y;

                public void Mover(int x, int y)
                {
                    eje_x += x;
                    eje_y += y;
                }

                public void Dibujar()
                {

                }
            }

            internal class Nivel
            {
                protected bool mover;

                public void Dibujar()
                {

                }

                public bool EsPosibleMover(int x, int y)
                {
                    return true;
                }
            }
        }
        internal class Presentacion
        {

            public void Ejecutar()
            {

            }

        }

        internal class Ayuda
        {

            public void Ejecutar()
            {

            }

        }

        internal class Credito
        {

            public void Ejecutar()
            {

            }   
        }
    }
}
