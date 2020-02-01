using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Contactos = new string[10];

            while (true)
            {
                int numero1, numero2, numero3;
                numero1 = 0;
                int menu = 0;

                bool isclose = false;
                Console.Clear();
                Console.WriteLine("lista de contactos");
                Console.WriteLine("Que decea Hacer?\n");
                Console.WriteLine("1-agregar contactos\n 2-editar los contactos\n 3- Borrar contactos\n 4- ver lista de contactos\n 5- salir de la agenda\n");

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Pulsa la categoria que desea introducir online");
                            Console.WriteLine("1: Lista de Contactos\n");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            switch (numero1)
                            {
                                case 1:
                                    if (string.IsNullOrEmpty(Contactos[9]))
                                    {
                                        Console.WriteLine("Ingrese el contactos .");
                                        string contacto = Console.ReadLine();
                                        for (int i = 0; i < Contactos.Length; i++)
                                        {
                                            string elemento = Contactos[i];
                                            if (string.IsNullOrEmpty(elemento))
                                            {
                                                Contactos[i] = contacto;
                                            }
                                        }
                                    }
                                    break;
                            }


                        }
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("Introdusca la categoria que desea editar ;) \n ");
                        Console.WriteLine(" 1: Lista de Contactos\n");
                        numero2 = Int32.Parse(Console.ReadLine());
                        switch (numero2)
                        {
                            case 1:
                                if (string.IsNullOrEmpty(Contactos[0]))
                                {
                                    Console.WriteLine("No hay nada en la lista");
                                }
                                else
                                {
                                    Console.WriteLine(" Esta es la lista de las contactos \n");
                                    for (int i = 0; i < Contactos.Length; i++)
                                    {
                                        string elemento = Contactos[i];
                                        Console.WriteLine((i + 1) + " - " + elemento);
                                        Console.WriteLine("introduce la pocision que de deseas cambiar ");
                                        int nu1 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("introdusca el nombre nuevo");
                                        string edifrut = Console.ReadLine();
                                        Contactos[nu1 - 1] = edifrut;

                                    }

                                }
                                break;
                        }
                        break;
                    case 3:

                        Console.Clear();
                        Console.WriteLine("introduca la categoria de la que desea borrar un cantactos \n ");
                        Console.WriteLine(" borrar contactos");
                        numero3 = Int32.Parse(Console.ReadLine());
                        switch (numero3)
                        {
                            case 1:
                                if (string.IsNullOrEmpty(Contactos[0]))
                                {
                                    Console.WriteLine("No hay nada en la lista ");
                                }
                                else
                                {
                                    Console.WriteLine(" Lista de contactos \n");
                                    for (int i = 0; i < Contactos.Length; i++)
                                    {
                                        string elemento = Contactos[i];
                                        Console.WriteLine((i + 1) + " - " + elemento);

                                    }
                                    Console.WriteLine("introduce el numero de la posicion que deseas borrar ");
                                    int nu1 = Convert.ToInt32(Console.ReadLine());
                                    Contactos[nu1 - 1] = null;
                                }
                                break;
                        }

                        break;


                    case 4:
                        Console.WriteLine("Productos que estan en la lista");
                        if (string.IsNullOrEmpty(Contactos[0]))
                        {
                            Console.WriteLine("No hay nada en esta lista");
                        }
                        else
                            Console.WriteLine("Lista de contactos \n");
                        for (int i = 0; i < Contactos.Length; i++)
                        {
                            string elemento = Contactos[i];
                            Console.WriteLine((i + 1) + " - " + elemento);
                            Console.ReadKey();

                        }
                        Console.ReadKey();
                        break;





                }
            }
        }
}   }

