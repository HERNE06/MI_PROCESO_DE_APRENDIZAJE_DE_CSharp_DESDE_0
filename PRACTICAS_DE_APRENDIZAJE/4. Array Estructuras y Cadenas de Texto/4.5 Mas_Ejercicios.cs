using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._4._Array_Estructuras_y_Cadenas_de_Texto
{
    internal class Mas_Ejercicios
    {
        static void Main(string[] args)
        {

        }

        /*_____________________________________________________________________________________________________________*/
        struct Personas
        {
            public string nombre;
            public string apellido;
            public int edad;
        }

        static void ejercicio4_5_1()
        {
            /* Un programa que pida el nombre, el apellido y la edad de una persona, los almacene en un "struct" y luego muestre los tres datos en una misma línea, separados por comas.*/
            Personas persona;
            Console.WriteLine("EJERCICIO DE STRUCTS");

            Console.Write("Nombre: ");
            persona.nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            persona.apellido = Console.ReadLine();
            Console.Write("Edad: ");
            persona.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}", persona.nombre, persona.apellido, persona.edad);

        }

        /*_____________________________________________________________________________________________________________*/

        struct fecha
        {
            public int dia;
            public int mes;
            public int anio;
        }

        struct Personass
        {
            public string nombreCompleto;
            public fecha fechaNacimiento;
        }
        static void ejercicio4_5_2()
        {
            /* Un programa que pida datos de 8 personas: nombre, dia de nacimiento, mes de nacimiento, y año de nacimiento (que se deben almacenar en una tabla de structs). 
             * Después deberá repetir lo siguiente: preguntar un número de mes y mostrar en pantalla los datos de las personas que cumplan los años durante ese mes. 
             * Terminará de repetirse cuando se teclee 0 como número de mes.*/

            Console.WriteLine("MAS EJERCICIOS DE STRUCS");
            Personass[] persona = new Personass[8];

            Console.WriteLine("Escribe los datos correspodiente para ocho personas");

            for (int i = 0; i < persona.Length; i++)
            {
                Console.WriteLine("\nPersona {0}", i + 1);
                Console.Write("\nNombre: ");
                persona[i].nombreCompleto = Console.ReadLine();
                Console.Write("Día de nacimiento: ");
                persona[i].fechaNacimiento.dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mes de nacimiento: ");
                persona[i].fechaNacimiento.mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Año de nacimiento: ");
                persona[i].fechaNacimiento.anio = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nEscribe un numero de mes para saber quien cumple años en ese mes.");
            int mes;

            do
            {
                Console.Write("Mes: ");
                mes = Convert.ToInt32(Console.ReadLine());

                if (mes == 0) break;

                for (int i = 0; i < persona.Length; i++)
                {
                    if (mes == persona[i].fechaNacimiento.mes)
                    {
                        Console.WriteLine("\nNombre: {0} \nDía de nacimiento: {1} \nMes de nacimiento: {2} \nAño de nacimiento: {3}", persona[i].nombreCompleto, persona[i].fechaNacimiento.dia, persona[i].fechaNacimiento.mes, persona[i].fechaNacimiento.anio);
                    }
                }

            } while (true);

            Console.WriteLine("Fin del programa");

        }

        /*_____________________________________________________________________________________________________________*/

        struct Persons
        {
            public string nombre;
            public string direccion;
            public string telefono;
            public int edad;
        }

        static void ejercicio4_5_3()
        {
            /* Un programa que sea capaz de almacenar los datos de 50 personas: nombre, dirección, teléfono, edad (usando una tabla de structs). Deberá ir pidiendo los datos uno por uno, 
             * hasta que un nombre se introduzca vacío (se pulse Intro sin teclear nada). Entonces deberá aparecer un menú que permita:
                o Mostrar la lista de todos los nombres.
                o Mostrar las personas de una cierta edad.
                o Mostrar las personas cuya inicial sea la que el usuario indique.
                o Salir del programa
            (lógicamente, este menú debe repetirse hasta que se escoja la opción de "salir").*/

            Console.WriteLine("ALMACENAMIENTO DE DATOS DE 50 PERSONAS");
            Persons[] person = new Persons[50];
            int cantidad = 0;
            bool encontrado = false;

            Console.WriteLine("Completa los datos correspondientes para cada persona y enter para salir");
            for (int i = 0; i < person.Length; i++)
            {
                Console.Write("\nNombre: ");
                person[i].nombre = Console.ReadLine();

                if (person[i].nombre == "")
                {
                    break;
                }

                Console.Write("Direccion: ");
                person[i].direccion = Console.ReadLine();
                Console.Write("Telefono: ");
                person[i].telefono = Console.ReadLine();
                Console.Write("Edad: ");
                person[i].edad = Convert.ToInt32(Console.ReadLine());
                cantidad++;
            }

            Console.Clear();
            char opcion;
            do
            {
                Console.WriteLine("Elige una opcion.");
                Console.WriteLine("a. Mostrar la lista de todos los nombres.");
                Console.WriteLine("b. Mostrar las personas de una cierta edad");
                Console.WriteLine("c. Mostrar las personar con x inicial");
                Console.WriteLine("d. Salir del programa");

                opcion = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 'a':
                        if (cantidad > 0)
                        {
                            Console.WriteLine("LISTA DE PERSONAS REGISTRADAS");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("\nPersona: {0} \nNombre Completo: {1} ", i + 1, person[i].nombre);
                            }
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("NO HAY PERSONAS REGISTRADAS");
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 'b':
                        encontrado = false;
                        Console.WriteLine("BUSCAR PERSONAS POR EDAD");

                        Console.Write("\nEdad a buscar: ");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Personas con la edad de {0}", edad);
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (edad == person[i].edad)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nPersona: {0} \nNombre Completo: {1} \nDireccion: {2} \nTelefono: {3} \nEdad: {4}", i + 1, person[i].nombre, person[i].direccion, person[i].telefono, person[i].edad);
                                }
                            }
                            if (!encontrado) Console.WriteLine("No hay una persona registradas con la edad de \"{0}\" años", edad);

                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No hay personar registradas");
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 'c':
                        encontrado = false;
                        Console.WriteLine("BUSCAR PERSONA POR EL INICIAL DE SU NOMBRE");
                        char inicial = Convert.ToChar(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            Console.WriteLine("Lista de personas con la inicial {0}", inicial);
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (person[i].nombre[0] == inicial)
                                {
                                    encontrado = true;
                                    Console.WriteLine("\nPersona: {0} \nNombre Completo: {1} \nDireccion: {2} \nTelefono: {3} \nEdad: {4}", i + 1, person[i].nombre, person[i].direccion, person[i].telefono, person[i].edad);
                                }
                            }

                            if (!encontrado) Console.WriteLine("No existen personas con la inicia \"{0}\"", inicial);
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay personar registradas");
                            Console.WriteLine("\nPreciona Enter para volver al menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 'd':
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Seleccione una opcion valida");
                        break;
                }

            } while (opcion != 'd');

        }

        /*_____________________________________________________________________________________________________________*/
        struct Ficheros
        {
            public string nombre;
            public long tamanyo;
        }

        static void ejercicio4_5_4()
        {
            /* Mejorar la base de datos de ficheros (ejemplo 46) para que no permita introducir tamaños incorrectos (números negativos) ni nombres de fichero vacíos.*/

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
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
                        break;

                    case 2:

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
                        break;

                    case 3:
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
                        break;

                    case 4:
                        encontrado = false;
                        Console.WriteLine("Buscar fichero por su nombre");

                        Console.Write("Nombre del fichero: ");
                        string nombreBusqueda = Console.ReadLine();
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
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 5);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_5()
        {
            /* Ampliar la base de datos de ficheros (ejemplo 46) para que incluya una opción de búsqueda parcial, en la que el usuario indique parte del nombre y se muestre 
             * todos los ficheros que contienen ese fragmento (usando "Contains" o "IndexOf"). Esta búsqueda no debe distinguir mayúsculas y minúsculas (con la ayuda de ToUpper o ToLower).*/


            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Busqueda Pacial de nombre");
                Console.WriteLine("6. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
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
                        break;

                    case 2:

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
                        break;

                    case 3:
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
                        break;

                    case 4:
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
                        break;

                    case 5:
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
                            Console.WriteLine("No hay ficheros registrados");
                            Console.WriteLine("\nPreciona enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 6);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_6()
        {
            /*Ampliar el ejercicio anterior (4.5.5) para que la búsqueda sea incremental: el usuario irá indicando letra a letra el texto que quiere buscar, y se mostrará todos los datos 
             * que lo contienen (por ejemplo, primero los que contienen "j", luego "ju", después "jua" y finalmente "juan"). */

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Busqueda pacial de nombre");
                Console.WriteLine("6. Busqueda incremental");
                Console.WriteLine("7. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
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
                        break;

                    case 2:

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
                        break;

                    case 3:
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
                        break;

                    case 4:
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
                        break;

                    case 5:
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

                        break;

                    case 6:
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

                        break;

                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 7);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_7()
        {
            /*Ampliar la base de datos de ficheros (ejemplo 46) para que se pueda borrar un cierto dato (habrá que "mover hacia atrás" todos los datos que había después de ese,
             * y disminuir el contador de la cantidad de datos que tenemos). */

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            bool borrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("\n1. Agregar una nuevo fichero");
                Console.WriteLine("2. Mostrar los nombres de todos los ficheros almacenados");
                Console.WriteLine("3. Mostrar ficheros que sean mas de x tamaña");
                Console.WriteLine("4. Ver todos los datos de un fichero");
                Console.WriteLine("5. Busqueda pacial de nombre");
                Console.WriteLine("6. Busqueda incremental");
                Console.WriteLine("7. Borrar fichero");
                Console.WriteLine("8. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
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
                        break;

                    case 2:

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
                        break;

                    case 3:
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
                        break;

                    case 4:
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
                        break;

                    case 5:
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

                        break;

                    case 6:
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

                        break;

                    case 7:
                        borrado = false;
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


                        break;

                    case 8:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 8);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_8()
        {
            /* Mejorar la base de datos de ficheros (ejemplo 46) para que se pueda modificar un cierto dato a partir de su número (por ejemplo, el dato número 3). 
             * En esa modificación, se deberá permitir al usuario pulsar Intro sin teclear nada, para indicar que no desea modificar un cierto dato, en vez de reemplazarlo por una cadena vacía.*/

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
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
                Console.WriteLine("9. Salir de la apliiacion\n");

                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
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
                        break;

                    case 2:

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
                        break;

                    case 3:
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
                        break;

                    case 4:
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
                        break;

                    case 5:
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

                        break;

                    case 6:
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

                        break;

                    case 7:
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
                        break;

                    case 8:
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

                        break;

                    case 9:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");

                        Console.WriteLine("\nPreciona enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 9);

        }

        /*_____________________________________________________________________________________________________________*/
        static void ejercicio4_5_9()
        {
            /* Ampliar la base de datos de ficheros (ejemplo 46) para que se permita ordenar los datos por nombre. Para ello, deberás buscar información sobre algún método de 
             * ordenación sencillo, como el "método de burbuja" (en el siguiente apartado tienes algunos), y aplicarlo a este caso concreto.*/

            Ficheros[] fichero = new Ficheros[1000];
            int cantidad = 0;
            int opcion;
            bool encontrado = false;
            string nombreBusqueda;

            Console.WriteLine("REGISTRO Y MANEJO DE FICHEROS");
            do
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

                switch (opcion)
                {
                    case 1:
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
                        break;

                    case 2:

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
                        break;

                    case 3:
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
                        break;

                    case 4:
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
                        break;

                    case 5:
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

                        break;

                    case 6:
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

                        break;

                    case 7:
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
                        break;

                    case 8:
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
                        break;

                    case 9:
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
