using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._07._Utilizacion_Avanzada_de_Clases._7._1_La_Palabra_Static
{
    internal class Almacen_Ficheros
    {

        //Ejercicio 7.1.1

        /*Crea una nueva versión del ejercicio 5.2.3, en la que métodos y variables no sean "static".*/

        //ejercicio5_2_3
        /*Vamos a hacer un ejemplo completo que use tablas ("arrays"), registros ("struct") y que además manipule cadenas. 
         * La idea va a ser la siguiente: Crearemos un programa que pueda almacenar datos de hasta 1000 ficheros (archivos de ordenador). 
         * Para cada fichero, debe guardar los siguientes datos: Nombre del fichero, Tamaño (en KB, un número de 0 a 8.000.000.000). 
         * El programa mostrará un menú que permita al usuario las siguientes operaciones:
         
            1- Añadir datos de un nuevo fichero
            2- Mostrar los nombres de todos los ficheros almacenados
            3- Mostrar ficheros que sean de más de un cierto tamaño (por ejemplo, 2000 KB).
            4- Ver todos los datos de un cierto fichero (a partir de su nombre)
            5- Salir de la aplicación (como no usamos ficheros, los datos se perderán).*/

        struct Ficheros
        {
            public string nombre;
            public long tamanyo;
        }

        Ficheros[] fichero = new Ficheros[1000];
        int cantidad = 0;
        int opcion, posicion;
        bool encontrado = false;

        public void MenuPrincipal()
        {

            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("\nSeleccione una opcion.");
            Console.WriteLine("\n1. Agregar una nuevo fichero.");
            Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados.");
            Console.WriteLine("3. Mostrar ficheros que sean de más de un cierto tamaño.");
            Console.WriteLine("4. Buscar por nombre");
            Console.WriteLine("5. Salir de la apliiacion\n");

            Console.Write("Opcion: ");
            opcion = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

        }

        public void AgregarFichero()
        {
            Console.WriteLine("AGREGAR NUEVO FICHERO\n");

            if(cantidad < 1000)
            {
                Console.Write("Nombre: ");
                fichero[cantidad].nombre = Console.ReadLine();
                Console.Write("Tamaño: ");
                fichero[cantidad].tamanyo = Convert.ToInt32(Console.ReadLine());

                if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("Debe llenar todos los campos");
                else if (fichero[cantidad].nombre == "") Console.WriteLine("Debe escribir el nombre del fichero");
                else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("Debe escribir el tamaño del fichero");
                else
                {
                    cantidad++;
                    Console.WriteLine("Fichero guardado correctamente");
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void MostrarFicheros()
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("No hay ficheros almacenados");

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Lista de Ficheros.\n");
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Nombre: {0} \nTamaño: {1}\n", fichero[i].nombre, fichero[i].tamanyo);
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void BuscarTamanyo()
        {
            Console.WriteLine("Buscar a Partir de cierto Tamaño\n");

            Console.Write("Tamaño: ");
            long tamanyoBuscado = Convert.ToInt32(Console.ReadLine());
            
            if(cantidad <= 0)
            {
                Console.WriteLine("No hay ficheros con un tamaño mayor a {0} almacenados", tamanyoBuscado);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Ficheros con un tamaño mayor a {0}: \n", tamanyoBuscado);
                for(int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].tamanyo > tamanyoBuscado)
                    {
                        Console.WriteLine("Nombre: {0} \nTamaño: {1}\n", fichero[i].nombre, fichero[i].tamanyo);
                    }
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void BuscarPorNombre()
        {
            encontrado = false;
            Console.WriteLine("Buscar Fichero por Nombre.\n");
            Console.Write("Nombre: ");

            string nombreBuscado = Console.ReadLine();

            if(cantidad <= 0)
            {
                Console.WriteLine("No hay ficheros almacenados");

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                for(int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].nombre == nombreBuscado)
                    {
                        posicion = i;
                        encontrado = true;
                    }
                }
            }

            if (encontrado)
            {
                Console.WriteLine("Nombre: {0} \nTamaño: {1}\n", fichero[posicion].nombre, fichero[posicion].tamanyo);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("No hay ficheros registrados con el nombre: {0}", nombreBuscado);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void AlmacenFicheros()
        {

            do
            {
                MenuPrincipal();

                switch (opcion)
                {
                    case 1:
                        AgregarFichero();
                        break;

                    case 2:
                        MostrarFicheros();
                        break;

                    case 3:
                        BuscarTamanyo();
                        break;


                    case 4:
                        BuscarPorNombre();
                        break;

                    default:
                        Console.WriteLine("Elija una opcion valida");
                        break;
                }
            } while (opcion != 5);

        }

    }
}
