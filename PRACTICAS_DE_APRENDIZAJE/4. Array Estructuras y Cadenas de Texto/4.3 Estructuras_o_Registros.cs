using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAS_DE_APRENDIZAJE._4.Array_Estructuras_y_Cadenas_de_Texto
{
    internal class Estructuras_o_Registros
    {
        static void Main(string[] args)
        {

        }

        /*_____________________________________________________________________________________________________________*/
        struct Musicaa_MP3
        {
            public string Artista;
            public string Titulo;
            public int Duracion;
            public float Tamano;
        }

        static void ejercicio4_3_1_1()
        {
            /*Un "struct" que almacene datos de una canción en formato MP3: Artista, Título, Duración (en segundos), Tamaño del fichero (en KB). Un programa debe 
             * pedir los datos de una canción al usuario, almacenarlos en dicho "struct" y después mostrarlos en pantalla..*/

            Console.WriteLine("INDTRODUCE LOS SIGUIENTES DATOS DE KLA MUSICA");
            Musicaa_MP3 musica;

            Console.Write("Nombre del artista: ");
            musica.Artista = Console.ReadLine();
            Console.Write("Titulo de la musica: ");
            musica.Titulo = Console.ReadLine();
            Console.Write("Duracion la musica: ");
            musica.Duracion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tamaño del fichero: ");
            musica.Tamano = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nDato de la musica.");
            Console.WriteLine("\nArtista: {0} \nTitulo {1} \nDuracion: {2} seg \nTamaño: {3} KB", musica.Artista, musica.Titulo, musica.Duracion, musica.Tamano);

        }

        /*_____________________________________________________________________________________________________________*/

        struct Musica_MP3
        {
            public string Artista;
            public string Titulo;
            public int Duracion;
            public float Tamano;
        }
        static void ejercicio4_3_2_1()
        {
            /*Ampliar el programa 4.3.1.1, para que almacene datos de hasta 100 canciones. Deberá tener un menú que permita las opciones: añadir una nueva canción, 
             * mostrar el título de todas las canciones, buscar la canción que contenga un cierto texto (en el artista o en el título).*/

            Musica_MP3[] musica = new Musica_MP3[100];
            char opcion;
            int cantidad = 0;

            do
            {
                Console.WriteLine("SELECCIONS UNA OPCION\n");
                Console.WriteLine("1. Agregar nueva cancion");
                Console.WriteLine("2. Mostar todas la canciones");
                Console.WriteLine("3. Buscar una cancion");
                Console.WriteLine("4. Salir");

                Console.Write("Opcion: ");
                opcion = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case ('1'):
                        Console.WriteLine("COMPLETE LOS DATOS PARA AGREGAR UNA NUEVA MUSICA\n");
                        if (cantidad < musica.Length)
                        {
                            Console.Write("Nombre del artista: ");
                            musica[cantidad].Artista = Console.ReadLine();
                            Console.Write("Titulo de la musica: ");
                            musica[cantidad].Titulo = Console.ReadLine();
                            Console.Write("Duracion de la musisca: ");
                            musica[cantidad].Duracion = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tamaño del fichero: ");
                            musica[cantidad].Tamano = Convert.ToSingle(Console.ReadLine());

                            cantidad++;
                        }
                        else Console.WriteLine("Espacio insuficiente, no de puede agregar mas musicas");
                        Console.Clear();
                        break;

                    case ('2'):
                        Console.WriteLine("LISTA DE TODAS LA MUSICAS\n");

                        for (int i = 0; i < musica.Length && i < cantidad; i++)
                        {
                            Console.WriteLine("\n{0}. {1}", i + 1, musica[i].Titulo);
                        }

                        break;

                    case ('3'):
                        bool encontrado = false;
                        int posicion = -1;
                        Console.WriteLine("BUSCAR MUSICA POR NOMBRE\n");
                        Console.Write("Nombre de la musica: ");
                        string nombrebusqueda = Console.ReadLine();

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (musica[i].Titulo == nombrebusqueda)
                            {
                                encontrado = true;
                                posicion = i;
                                break;

                            }

                        }
                        if (encontrado)
                        {
                            Console.WriteLine("Artista: {0} \nTitulo: {1} \n Duracion: {2} \nTamaño: {3}", musica[posicion].Artista, musica[posicion].Titulo, musica[posicion].Tamano, musica[posicion].Duracion, musica[posicion]);
                        }

                        break;

                    default:
                        Console.WriteLine("Debe elegir una opcion valida");
                        break;
                }

            } while (opcion != '4');


        }

        /*_____________________________________________________________________________________________________________*/
        struct imagenes
        {
            public string nombre;
            public int ancho;
            public int alto;
            public float tamanho;
        }

        static void ejercicio4_3_2_2()
        {
            /*Un programa que permita guardar datos de "imágenes" (ficheros de ordenador que contengan fotografías o cualquier otro tipo de información gráfica). 
             * De cada imagen se debe guardar: nombre (texto), ancho en píxeles (por ejemplo 2000), alto en píxeles (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6).
             * El programa debe ser capaz de almacenar hasta 700 imágenes (deberá avisar cuando su capacidad esté llena). Debe permitir las opciones: añadir una ficha nueva,
             * ver todas las fichas (número y nombre de cada imagen), buscar la ficha que tenga un cierto nombre.*/

            imagenes[] imagen = new imagenes[700];
            int cantidad = 0;
            int posicion = -1;
            int opcion;
            bool econtrado = false;

            do
            {
                Console.WriteLine("GESTION DE INFORMACIONES GRAFICAS");
                Console.WriteLine("\nElija la una opcion");
                Console.WriteLine("\n1. Agregar una nueva ficha");
                Console.WriteLine("2. Ver todas las fichas");
                Console.WriteLine("3. Buscar una ficha");
                Console.WriteLine("4. Salir");

                Console.Write("\nOpcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case (1):

                        Console.WriteLine("AGREGAR FICHAS");
                        Console.WriteLine("\nCompleta todos los datos corresponidentes");

                        if (cantidad < 700)
                        {
                            Console.Write("\nNombre de la imagen: ");
                            imagen[cantidad].nombre = Console.ReadLine();
                            Console.Write("Ancho de la imagen: ");
                            imagen[cantidad].ancho = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Alto de la imagen: ");
                            imagen[cantidad].alto = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tamaño de la imagen: ");
                            imagen[cantidad].tamanho = Convert.ToSingle(Console.ReadLine());

                            cantidad++;

                            Console.WriteLine("\nFicha agregada corecctamente");
                            Console.Write("\nEnter para volver al menu principal: ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (cantidad > 700)
                        {
                            Console.WriteLine("\nNo se puede guardar mas fichas, capcidad maxima alcanzada");
                            Console.Write("\nEnter para volver al menu principal: ");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case (2):

                        Console.WriteLine("LISTA DE TODAS LA FICHAS AGREGADAS");
                        for (int i = 0; i < imagen.Length && i < cantidad; i++)
                        {
                            Console.WriteLine("\n FICHA #: {0} \nNombre: {1} \nAncho: {2} px \nAlto: {3} px \nTamaño: {4} KB", i + 1, imagen[i].nombre, imagen[i].ancho, imagen[i].alto, imagen[i].tamanho);
                        }

                        Console.Write("\nEnter para volver al menu principal: ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case (3):

                        Console.WriteLine("BUSCAR FICHAS POR NOMBRE");
                        Console.Write("Nombre de la imagen: ");
                        string nombreBusqueda = Console.ReadLine();

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (imagen[i].nombre == nombreBusqueda)
                            {
                                econtrado = true;
                                posicion = i;
                                break;
                            }
                        }
                        Console.WriteLine("\nResultado de la busqueda");
                        if (econtrado)
                        {
                            Console.WriteLine("\n FICHA: {0} \nNombre: {1}\n Ancho {2} px \nAlto {3} px \nTamaño {4} KB", posicion + 1, imagen[posicion].nombre, imagen[posicion].ancho, imagen[posicion].alto, imagen[posicion].tamanho);
                            Console.Write("\nEnter para volver al menu principal: ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (!econtrado)
                        {
                            Console.WriteLine("\nFicha no encontrada");
                            Console.Write("\nEnter para volver al menu principal: ");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    default:
                        break;
                }

            } while (opcion != 4);

        }

        /*_____________________________________________________________________________________________________________*/

        struct duracion
        {
            public int minutos;
            public int segundos;

        }

        struct musica_MP3
        {
            public string artista;
            public string titulo;
            public duracion tiempoTotal;
            public float tamano;
        }

        static void ejercicio4_3_3_1()
        {
            /*Ampliar el programa 4.3.2.1, para que el campo "duración" se almacene como minutos y segundos, usando un "struct" anidado que contenga a su vez estos dos campos.
             para que almacene datos de hasta 100 canciones. Deberá tener un menú que permita las opciones: añadir una nueva canción, 
             * mostrar el título de todas las canciones, buscar la canción que contenga un cierto texto (en el artista o en el título).
             */

            musica_MP3[] musica = new musica_MP3[100];
            int cantidad = 0;
            int posicion = 0;
            int opcion;
            bool encontrado = false;

            do
            {
                Console.WriteLine("PUTO PLAYLISTE DE MUSICAS\n");
                Console.WriteLine("1: Agregar musica.");
                Console.WriteLine("2: Ver lista de musica.");
                Console.WriteLine("3: Buscar musica.");
                Console.WriteLine("4: Salir.");

                Console.Write("\nElige una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("AGREGAR UNA NUEVA CANCION");

                        if (cantidad < 100)
                        {
                            Console.WriteLine("\nConpleta todos los datos");

                            Console.Write("\nNombre del artista: ");
                            musica[cantidad].artista = Console.ReadLine();
                            Console.Write("Titulo de la cancion: ");
                            musica[cantidad].titulo = Console.ReadLine();
                            Console.Write("Minutos: ");
                            musica[cantidad].tiempoTotal.minutos = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Segundos: ");
                            musica[cantidad].tiempoTotal.segundos = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tamaño: ");
                            musica[cantidad].tamano = Convert.ToSingle(Console.ReadLine());

                            cantidad++;

                            Console.WriteLine("\nMusica agregada correctamente");
                            Console.WriteLine("\nPrecione enter para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        Console.WriteLine("LISTA DE TODAS LAS MUSICAS");
                        if (cantidad > 0)
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("\nArtista: {0} \nTitulo: {1} \nMinutos: {2} \nSegundos: {3} \nTamaño: {4}", musica[i].artista, musica[i].titulo, musica[i].tiempoTotal.minutos, musica[i].tiempoTotal.segundos, musica[i].tamano);
                            }

                            Console.WriteLine("Precione enter para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("No hay canciones guardadas");
                            Console.WriteLine("Precione enter para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        Console.WriteLine("BUSCAR MUSICA");
                        Console.Write("Nombre de la cancion a buscar: ");
                        string nombrebuscado = Console.ReadLine();

                        if (cantidad > 0)
                        {
                            for (int i = 0; i < musica.Length && i < cantidad; i++)
                            {
                                if (nombrebuscado == musica[i].titulo)
                                {
                                    posicion = i;
                                    encontrado = true;
                                    break;
                                }
                            }

                            if (encontrado)
                            {
                                Console.WriteLine("Resultado de la busqueda");
                                Console.WriteLine("\nArtista: {0} \nTitulo: {1} \nMinutos: {2} \nSegundos: {3} \nTamaño: {4}", musica[posicion].artista, musica[posicion].titulo, musica[posicion].tiempoTotal.minutos, musica[posicion].tiempoTotal.segundos, musica[posicion].tamano);

                                Console.WriteLine("Precione enter para volver al menu principal");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("No hay canciones guardada con ese nombre");
                                Console.WriteLine("Precione enter para volver al menu principal");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay canciones guardadas");
                            Console.WriteLine("Precione enter para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    default:
                        break;
                }

            } while (opcion != 4);
        }
    }
}
