using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinalPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            string password = "", user = "";
            int me = 0;

            IDatos datoscliente1 = new Biblioteca();


            //Inicio de sesion

            while (password != "admin" || user != "admin")

            {
                Console.Clear();
                Console.WriteLine("INICIO DE SESION");

                Console.Write("Usuario: ");
                user = Console.ReadLine();
                Console.Write("Contraseña: ");
                password = Console.ReadLine();

                if (password.Equals("admin") && user.Equals("admin"))

                do
                {
                    Console.Clear();
                    Console.WriteLine("¿Que quieres hacer?");
                    Console.WriteLine("1. Nueva Renta");
                    Console.WriteLine("2. Ver Libros Rentados");
                    Console.WriteLine("3. Salir");

                    int opcion;

                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Categoria: ");
                            Console.WriteLine("1. Terror");
                            Console.WriteLine("2. Sci-Fi");
                            Console.WriteLine("3. Comedia");

                            int category;

                            category = Convert.ToInt32(Console.ReadLine());

                            string librorent1, librorent2, librorent3;

                            int diasrent1, diasrent2, diasrent3;

                            switch (category)
                            {


                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("¿Cual libro es?");
                                    librorent1 = Console.ReadLine();
                                    Console.WriteLine("¿Por cuanto tiempo se rentara? (dias)");
                                    try
                                    {
                                        diasrent1 = int.Parse(Console.ReadLine());
                                    }
                                    catch (System.FormatException)
                                    {
                                        Console.WriteLine("Nos has introducido un valor entero");
                                        goto ERROR1;
                                    }

                                    StreamWriter fichero;
                                    fichero = File.AppendText("libros.txt");
                                    fichero.WriteLine("Se rento el libro " + librorent1 + " por un tiempo de " + diasrent1 + " dias" );
                                    fichero.WriteLine("_____________________");
                                    fichero.Close();

                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("¿Cual libro es?");
                                    librorent2 = Console.ReadLine();
                                    Console.WriteLine("¿Por cuanto tiempo se rentara? (dias)");
                                    try
                                    {
                                        diasrent2 = int.Parse(Console.ReadLine());
                                    }
                                    catch (System.FormatException)
                                    {
                                        Console.WriteLine("Nos has introducido un valor entero");
                                        goto ERROR1;
                                    }


                                    fichero = File.AppendText("libros.txt");
                                    fichero.WriteLine("Se rento el libro " + librorent2 + " por un tiempo de " + diasrent2 + " dias");
                                    fichero.WriteLine("____________________________________________");
                                    fichero.Close();

                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("¿Cual libro es?");
                                    librorent3 = Console.ReadLine();
                                    Console.WriteLine("¿Por cuanto tiempo se rentara? (dias)");
                                    try
                                    {
                                        diasrent3 = int.Parse(Console.ReadLine());
                                    }
                                    catch (System.FormatException)
                                    {
                                        Console.WriteLine("Nos has introducido un valor entero");
                                        goto ERROR1;
                                    }


                                    fichero = File.AppendText("libros.txt");
                                    fichero.WriteLine("Se rento el libro " + librorent3 + " por un tiempo de " + diasrent3 + " dias"); 
                                    fichero.WriteLine("____________________________________________");
                                    fichero.Close();

                                    break;

                            }
                            break;

                        case 2:
                            Console.Clear();

                            StreamReader fichero1;
                            string linea;


                            fichero1 = File.OpenText("libros.txt");
                            linea = fichero1.ReadToEnd();
                            Console.WriteLine(linea);
                            fichero1.Close();

                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("BAI");
                            break;

                        default:
                            Console.WriteLine("No es una opcion valida");
                            break;
                    }
                        Console.ReadKey();

                } while (me != 3);

            ERROR1: Console.WriteLine("ERROR");
                

                Console.ReadKey();

            }
        }
    }
}
