using System;

namespace compra_de_alimentos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] Frutas = new string[10];
            string[] vegetales = new string[10];
            string[] lacteos = new string[10];

            while (true)
            {

                int numero1, numero2, numero3;
                numero1 = 0;
                int menu = 0;
                
                bool isclose = false;
                Console.Clear();
                Console.WriteLine("Lista de compras Online/n");
                Console.WriteLine("Pulse el numero de la opcion deceada");
                Console.WriteLine("1-agregar alimentos\n 2- editar alimentos\n 3- borrar alimentos\n 4-ver la lista de compras\n 5- salir del programa\n");
               
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Pulsa la categoria que desea introducir online");
                        Console.WriteLine("1: Lista de Frutas\n 2: Lista de vegetales\n 3: lista de lacteos\n");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        switch (numero1)
                        {
                            case 1:
                                if (string.IsNullOrEmpty(Frutas[9]))
                                {
                                    Console.WriteLine("Digite la fruta.");
                                    string fruta = Console.ReadLine();

                                    for (int i = 0; i < Frutas.Length; i++)
                                    {
                                        string elemento = Frutas[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            Frutas[i] = fruta;

                                            break;
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay dispobibles, Hablamos el martes");
                                    Console.ReadKey();

                                }
                                break;

                            case 2:
                                if (string.IsNullOrEmpty(vegetales[9]))
                                {
                                    Console.WriteLine("Digite Los vegetales.");
                                    string vegetale = Console.ReadLine();

                                    for (int i = 0; i < vegetales.Length; i++)
                                    {
                                        string elemento = vegetales[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            vegetales[i] = vegetale;

                                            break;
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay disponibles, Hablamos el martes");
                                    Console.ReadKey();

                                }
                                break;
                            case 3:
                                if (string.IsNullOrEmpty(lacteos[9]))
                                {
                                    Console.WriteLine("Digite el nombre de los prosductos lacteos.");
                                    string Lacteos = Console.ReadLine();

                                    for (int i = 0; i < lacteos.Length; i++)
                                    {
                                        string elemento = lacteos[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            lacteos[i] = Lacteos;

                                            break;
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No se encuentran disponibles, Hablamos el martes");
                                    Console.ReadKey();

                                }
                                break;


                        }
                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("Introdusca la categoria que desea editar ;) \n ");
                        Console.WriteLine(" 1: Lista de frutas \n 2: Lista de vegetales \n 3: Lista lacteos \n ");
                        numero2 = Int32.Parse(Console.ReadLine());
                        switch (numero2)
                        {
                            case 1:
                                if (string.IsNullOrEmpty(Frutas[0]))
                                {
                                    Console.WriteLine("No hay nada en la lista");
                                }
                                else
                                {
                                    Console.WriteLine(" Esta es la lista de las frutas \n");
                                    for (int i = 0; i < Frutas.Length; i++)
                                    {
                                        string elemento = Frutas[i];
                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }
                                    Console.WriteLine("introduce la pocision que de deseas cambiar ");
                                    int nu1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("introdusca el nombre nuevo");
                                    string edifrut = Console.ReadLine();
                                    Frutas[nu1 - 1] = edifrut;
                                }break;

                            case 2:
                                if (string.IsNullOrEmpty(vegetales[0]))
                                {
                                    Console.WriteLine("No hay nada en la lista ");
                                }
                                else
                                {
                                    Console.WriteLine(" Lista de vegetales \n");
                                    for (int i = 0; i < vegetales.Length; i++)
                                    {
                                        string elemento = vegetales[i];
                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }
                                    Console.WriteLine("introduce la pocision que de deseas cambiar ");
                                    int nu1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("introdusca el nombre nuevo");
                                    string edifrut = Console.ReadLine();
                                    vegetales[nu1 - 1] = edifrut;
                                }break;

                            case 3:
                                if (string.IsNullOrEmpty(lacteos[0]))
                                {
                                    Console.WriteLine("No hay nada en la lista");
                                }
                                else
                                {
                                    Console.WriteLine(" Lista de vegetales \n");
                                    for (int i = 0; i < lacteos.Length; i++)
                                    {
                                        string elemento = lacteos[i];
                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }
                                    Console.WriteLine("introduce la pocision que de deseas cambiar ");
                                    int nu1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("introdusca el nombre nuevo");
                                    string edifrut = Console.ReadLine();
                                    Frutas[nu1 - 1] = edifrut;
                                }
                                break;

                        } 



                        break;







                    case 3:
                        Console.Clear();
                        Console.WriteLine("introduca la categoria de la que desea borrar un producto \n ");
                        Console.WriteLine(" 1: Lista de frutas \n 2: Lista de vegetales \n 3: Lista lacteos \n ");
                        numero3 = Int32.Parse(Console.ReadLine());
                        switch (numero3)
                        {
                            case 1:
                                if (string.IsNullOrEmpty(Frutas[0]))
                                {
                                    Console.WriteLine("No hay nada en la lista ");
                                }
                                else
                                {
                                    Console.WriteLine(" Lista de frutas \n");
                                    for (int i = 0; i <Frutas.Length; i++)
                                    {
                                        string elemento =Frutas[i];
                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }
                                    Console.WriteLine("introduce el numero de la posicion que deseas borrar ");
                                    int nu1 = Convert.ToInt32(Console.ReadLine());


                                   Frutas[nu1 - 1] = null;
                                }
                                break;


                            case 2:
                                if (string.IsNullOrEmpty(vegetales[0]))
                                {
                                    Console.WriteLine("No hay nada en esta lista. ");
                                }
                                else
                                {
                                    Console.WriteLine(" Lista de vegetales \n");
                                    for (int i = 0; i < vegetales.Length; i++)
                                    {
                                        string elemento = vegetales[i];
                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }
                                    Console.WriteLine("Posicion del producto que deseas borrar ");
                                    int nu1 = Convert.ToInt32(Console.ReadLine());


                                    vegetales[nu1 - 1] = null;
                                }
                                break;





                            case 3:
                                if (string.IsNullOrEmpty(lacteos[0]))
                                {
                                    Console.WriteLine("No hay nada en la lista ");
                                }
                                else
                                {
                                    Console.WriteLine(" Lista de Productos lacteos \n");
                                    for (int i = 0; i < lacteos.Length; i++)
                                    {
                                        string elemento = lacteos[i];
                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }
                                    Console.WriteLine("Introducta la posicion que decea borrar ");
                                    int nu1 = Convert.ToInt32(Console.ReadLine());
                                    
                                    
                                    Frutas[nu1 - 1] = null;
                                }
                                break;




                        }






                        break;



                    case 4:
                        Console.WriteLine("Productos que estan en la lista");
                        if (string.IsNullOrEmpty(Frutas[0]))
                        {
                            Console.WriteLine("No hay nada en esta lista");
                        }
                        else
                        {
                            Console.WriteLine("Lista de frutas \n");
                            for (int i = 0; i < Frutas.Length; i++)
                            {

                                string elemento = Frutas[i];

                                Console.WriteLine((i + 1) + " - " + elemento);


                                

                            }
                            Console.ReadKey();
                        }
                        if (string.IsNullOrEmpty(vegetales[0]))
                        {
                            Console.WriteLine("No hay vegetales guardados");

                        }
                        else
                        {
                            Console.WriteLine("esta es la lista de vegetales\n");
                            for (int i = 0; i < vegetales.Length; i++)
                            {

                                string elemento = vegetales[i];

                                Console.WriteLine((i + 1) + " - " + elemento);

                               


                            }
                            Console.ReadKey();
                        }
                        if (string.IsNullOrEmpty(lacteos[0]))
                        {
                            Console.WriteLine("No hay Lacteos Guardados");
                        }
                        else
                        {
                            Console.WriteLine("lista de lacteos\n");
                            for (int i = 0; i < lacteos.Length; i++)
                            {

                                string elemento = lacteos[i];

                                Console.WriteLine((i + 1) + " - " + elemento);




                            }
                            Console.ReadKey();
                        }
                        
                        
                        break;
                } 

                switch (menu)
                {
                    case 5:
                        isclose = true;
                        break;


                }
                if (isclose)
                {
                    break;
                }

            }
            Console.WriteLine("Gracias por usar nuestros seervicios online");
            Console.ReadKey();

        }
    }
}
