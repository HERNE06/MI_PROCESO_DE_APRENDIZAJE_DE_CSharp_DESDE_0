using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._5._Introduccion_a_las_Funciones
{
    internal class Conceptos_Basicos_Sobre_Funciones
    {

        /*_____________________________________________________________________________________________________________*/

        //ejercicio5_2_1
        public static void BorrarPantalla()
        {
            /* Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando 25 líneas en blanco. No debe devolver ningún valor. Crea también un 
             * "Main" que permita probarla.*/
            int linea = 0;

            while (linea < 25)
            {
                Console.WriteLine();
                linea++;
            }
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_2_2

        public static void DibujarCuadro3x3()
        {
            /* Crea una función llamada "DibujarCuadrado3x3", que dibuje un cuadrado formato por 3 filas con 3 asteriscos cada una. Crea también un "Main" 
             * que permita probarla.*/

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /*_____________________________________________________________________________________________________________*/
        //ejercicio5_2_3

        /* Descompón en funciones la base de datos de ficheros (ejemplo 46), de modo que el "Main" sea breve y más legible (Pista: las variables que se compartan 
         * entre varias funciones deberán estar fuera de todas ellas, y deberán estar precedidas por la palabra "static").*/
        struct Ficheros
        {
            public string nombre;
            public long tamanyo;
        }

        static Ficheros[] fichero = new Ficheros[1000];
        static int cantidad = 0;
        static int opcion;
        static bool encontrado = false;
        static string nombreBusqueda;

        public static void MenuPrincipal()
        {
            Console.WriteLine("Seleccione una opcion.");
            Console.WriteLine("\n1. Agregar una nuevo fichero");
            Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
            Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
            Console.WriteLine("4. Ver todos los datos de un fichero");
            Console.WriteLine("5. Busqueda pacial de nombre");
            Console.WriteLine("6. Busqueda incremental");
            Console.WriteLine("7. Borrar fichero");
            Console.WriteLine("8. Modificar fichero");
            Console.WriteLine("9. Ordenar ficheros alfabeticamente");
            Console.WriteLine("10. Salir de la apliiacion\n");

            Console.Write("Opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public static void AgregarFichiero()
        {
            Console.WriteLine("\nAgregar un nuevo fichero");

            if (cantidad < 1000)
            {
                Console.Write("\nNombre: ");
                fichero[cantidad].nombre = Console.ReadLine();
                Console.Write("Tamaño: ");
                fichero[cantidad].tamanyo = Convert.ToInt64(Console.ReadLine());

                if (fichero[cantidad].nombre == "" && fichero[cantidad].tamanyo < 0) Console.WriteLine("El nombre no puede estar vacio y el tamaño debe ser mayor a cero");
                else if (fichero[cantidad].nombre == "") Console.WriteLine("El nombre del fichero no puede estar vacio");
                else if (fichero[cantidad].tamanyo < 0) Console.WriteLine("El tamaño del fichero debe ser mayor a cero");
                else
                {
                    cantidad++;
                    Console.WriteLine("\nFichero registrado correctamente");
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nCantidad maxima de registros alcanzada");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void FicherosAlmacenados()
        {
            if (cantidad > 0)
            {
                Console.WriteLine("Ficheros Almacenados\n");
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, fichero[i].nombre);
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BuscarFichieroxTamanyo()
        {
            encontrado = false;
            Console.WriteLine("Ficheros con un tamaño mayor a \"x\" KB");

            Console.Write("\nTamaño a buscar: ");
            float tamanyo = Convert.ToSingle(Console.ReadLine());

            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].tamanyo > tamanyo)
                    {
                        encontrado = true;
                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                    }
                }
                if (!encontrado) Console.WriteLine("No se encontradon ficheron mayores a {0} KB", tamanyo);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BuscarFicheroxNombre()
        {
            encontrado = false;
            Console.WriteLine("Buscar fichero por su nombre");

            Console.Write("Nombre del fichero: ");
            nombreBusqueda = Console.ReadLine();
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].nombre.ToLower() == nombreBusqueda.ToLower())
                    {
                        encontrado = true;
                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                    }
                }

                if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("No hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BusquedaParcial()
        {
            encontrado = false;
            Console.WriteLine("\nBusqueda parcial por el nombre");

            Console.Write("\nNombre parcial: ");
            nombreBusqueda = Console.ReadLine();

            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].nombre.ToLower().Contains(nombreBusqueda.ToLower()))
                    {
                        encontrado = true;
                        Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                    }
                }

                if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", nombreBusqueda);

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BusquedaParcialxLentra()
        {
            encontrado = false;
            Console.WriteLine("Busqueda parcial");
            Console.WriteLine("\nAgrega letra por letra para ir buscando.");
            string letra = "";
            string busqueda = "";

            do
            {
                if (cantidad > 0)
                {
                    Console.Write("\nLetra: ");
                    letra = (Console.ReadLine());
                    busqueda += letra;
                    Console.WriteLine(busqueda);

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (fichero[i].nombre.ToLower().Contains(busqueda.ToLower()))
                        {
                            encontrado = true;
                            Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                        }
                    }

                    if (!encontrado) Console.WriteLine("No se encontradon ficheron con el nombre {0}", busqueda);

                    if (letra == "")
                    {
                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("\nNo hay ficheros registrados");
                    Console.WriteLine("\nPreciona enter para volver al menu");
                    Console.ReadKey();
                    Console.Clear();
                }


            } while (letra != "");
        }

        public static void BorrarFichero()
        {
            encontrado = false;
            Console.WriteLine("Borrar fichero");

            Console.Write("Nombre del fichero que desea borrar: ");
            string nombre = Console.ReadLine();
            int posicion = 0;

            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (fichero[i].nombre == nombre)
                    {
                        encontrado = true;
                        posicion = i;
                        break;
                    }
                }

                if (encontrado)
                {
                    for (int i = posicion; i < cantidad - 1; i++)
                    {
                        fichero[i] = fichero[i + 1];
                    }
                    cantidad--;

                    Console.WriteLine("Fichero borrado correctamente");
                }
                else Console.WriteLine("No se encontro fichero con ese nombre.");


                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo hay ficheros registrados");
                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void ModificarFichero()
        {
            encontrado = false;
            string nombreTemporal, nombreNuevo;
            string tamanyoTemporal, tamanyoNuevo;

            Console.WriteLine("Modificar fichero");

            Console.Write("\nNumero de fichero: ");
            int numFichero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                if (i == numFichero - 1)
                {
                    encontrado = true;
                    nombreTemporal = fichero[i].nombre;
                    tamanyoTemporal = fichero[i].tamanyo.ToString();

                    Console.WriteLine("Datos de fichero");
                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);

                    if (encontrado)
                    {
                        Console.WriteLine("Escribe los datos que quiere modificar o perciona Enter para mantener los datos anteriores");

                        Console.Write("\nNombre: ");
                        nombreNuevo = Console.ReadLine();
                        if (nombreNuevo == "") fichero[i].nombre = nombreTemporal;
                        else fichero[i].nombre = nombreNuevo;

                        Console.Write("\nTamaño: ");
                        tamanyoNuevo = (Console.ReadLine());
                        if (tamanyoNuevo == "") fichero[i].tamanyo = long.Parse(tamanyoTemporal);
                        else fichero[i].tamanyo = long.Parse(tamanyoNuevo);
                    }

                    Console.WriteLine("Datos actualizados");
                    Console.WriteLine("\nFichero: {0} \nNombre: {1} \nTamaño: {2} KB", i + 1, fichero[i].nombre, fichero[i].tamanyo);
                    break;
                }
            }

            Console.WriteLine("\nPreciona enter para volver al menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void OrdenarFicheros()
        {
            Console.WriteLine("Ordenamiento de ficheros");

            Console.WriteLine("\n1. Ordenar por nombre.");
            Console.WriteLine("2. Ordenar por tamaño.");

            Console.Write("Opcion: ");
            int opcionn = Convert.ToInt32(Console.ReadLine());
            string temporal = "";
            long temporaL = 0;

            if (opcionn == 1)
            {
                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {
                        if (string.Compare(fichero[i].nombre, fichero[j].nombre, true) > 0)
                        {
                            temporal = fichero[i].nombre;
                            fichero[i].nombre = fichero[j].nombre;
                            fichero[j].nombre = temporal;
                        }
                    }
                }

                Console.WriteLine("Ficheros ordenados alfabeticamente.");
                foreach (Ficheros dato in fichero)
                {
                    Console.WriteLine("{0}", dato.nombre);
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
            else if (opcionn == 2)
            {
                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {
                        if (fichero[i].tamanyo > fichero[j].tamanyo)
                        {
                            temporaL = fichero[i].tamanyo;
                            fichero[i].tamanyo = fichero[j].tamanyo;
                            fichero[j].tamanyo = temporaL;
                        }
                    }
                }

                Console.WriteLine("Ficheros ordenados por tamaño.");
                foreach (Ficheros dato in fichero)
                {
                    Console.WriteLine("{0}", dato.tamanyo);
                }

                Console.WriteLine("\nPreciona enter para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void BaseDeDatosFicheros()
        {
            do
            {
                MenuPrincipal();

                switch (opcion)
                {
                    case 1:
                        AgregarFichiero();
                        break;

                    case 2:
                        FicherosAlmacenados();
                        break;

                    case 3:
                        BuscarFichieroxTamanyo();
                        break;

                    case 4:
                        BuscarFicheroxNombre();
                        break;

                    case 5:
                        BusquedaParcial();
                        break;

                    case 6:
                        BusquedaParcialxLentra();
                        break;

                    case 7:
                        BorrarFichero();
                        break;

                    case 8:
                        ModificarFichero();
                        break;

                    case 9:
                        OrdenarFicheros();
                        break;

                    case 10:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != 10);
        }
    }
}
