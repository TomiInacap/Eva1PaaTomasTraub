/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1TT
{
    internal class Menu
    {
        ListaBuques listaB = new ListaBuques();


        public void Apply()
        {
            Buque duno = new Buque("35899", "Tara", "Chile", 20, 15, 255000);
            Buque ddos = new Buque("35877", "Larry", "Bolivia xD", 20, 5, 45000);
            Buque dtres = new Buque("35866", "Eva1", "Dinamarca", 20, 11, 355000);

            bool chao = true;
            string opcion = "";
            while (chao)
            {
                Console.WriteLine("1. Agregar Buque");
                Console.WriteLine("2. Buscar Buque");
                Console.WriteLine("3. Listar Buques ??? (ojala) ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Testing: Creando un Buque (1)");
                        string codigo = "";
                        string nombre;
                        string pais;
                        int cantidadContainers;
                        int cantidadContainersCargados = 0;
                        int gastoTransporte;
                        bool validacod = true;
                        bool validacc = true;

                        while (validacod)
                        {
                            try
                            {
                                Console.WriteLine("Ingresa el Codigo del Buque (string)");
                                codigo = Console.ReadLine();
                                if (codigo.Length > 4)
                                {
                                    validacod = false;
                                } else
                                {
                                    Console.WriteLine("El Codigo del Buque debe tener como minimo 5 caracteres.");
                                }
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine("El Codigo debe tener como minimo 5 caracteres.");
                            }
                        }
                        Console.WriteLine("Ingresa Nombre de Buque (string)");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa País de Buque (string)");
                        pais = Console.ReadLine();
                        Console.WriteLine("Ingresa la Cantidad de Containers del Buque (int)");
                        cantidadContainers = int.Parse(Console.ReadLine());
                        while (validacc)
                        {
                            try
                            {
                                Console.WriteLine("Ingresa la Cantidad de Containers Cargados del Buque (int)");
                                    cantidadContainersCargados = int.Parse(Console.ReadLine());
                                if (cantidadContainersCargados < 21)
                                {
                                    validacc = false;
                                }
                                else
                                {
                                    Console.WriteLine("El Buque solo puede cargar 20 Contaienrs Cargados.");
                                }
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(" sigues en el 'try' ");
                            }
                        }
                        Console.WriteLine("Ingresa el Gasto de Transporte del Buque (int)");
                        gastoTransporte = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        Buque b = new Buque(codigo, nombre, pais, cantidadContainers, cantidadContainersCargados, gastoTransporte);
                        if (listaB.AgregarB(b))
                            Console.WriteLine("Buque wenons");
                        else
                            Console.WriteLine("Neeeeeiin");
                        Console.WriteLine(" ");
                        break;

                    case "2":
                        Console.WriteLine("Busca un Buque por su Codigo (string)");
                        BuscarBuque();
                        Console.WriteLine(" ");
                        break;

                    case "3":
                        Console.WriteLine("Listado de Buques:");
                        /*foreach (Buque)
                        {
                            Console.WriteLine("Listado de Buque");
                            Console.WriteLine("Código: " + b.Codigo);
                            Console.WriteLine("Nombre: " + b.Nombre);
                            Console.WriteLine("Pais: " + b.Pais);
                            Console.WriteLine("Cantidad de Containers: " + b.CantidadContainers);
                            Console.WriteLine("Cantidad de Containers Cargados: " + b.CantidadContainersCargados);
                            Console.WriteLine("Gasto de Transporte: " + b.GastoTransporte);
                            Console.WriteLine(" ");

                        }*/
/*
                        Console.WriteLine(duno);

                        Console.WriteLine(" ");
                        break;

                    case "4":
                        Console.WriteLine(" 4 ");
                        
                        Console.WriteLine(" ");
                        break;

                    case "5":
                        Console.WriteLine("Presionó 5 - Chao !! ");
                        chao = false;
                        Console.WriteLine("Hasta Luego");
                        Console.WriteLine("Presiona cualquier tecla para salir");
                        Console.ReadKey();
                        Console.WriteLine(" ");
                        break;
                    default:
                        Console.WriteLine("Sólo valores entre 1 y 5 ");
                        Console.WriteLine(" ");
                        break;
                }
            }
        }




        public void BuscarBuque()
        {
            string codigo = "0";
            bool bien = false;
            while (!bien)
            {
                try
                {
                    Console.WriteLine("Ingresa el Codigo del Buque para Buscar");
                    codigo = Console.ReadLine();
                    bien = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("escribe algo porfa");
                }
            }

            Buque b = listaB.BuscarBuque(codigo);
            if (b != null)
            {
                Console.WriteLine("Buque Encontrado y sus Datos");
                Console.WriteLine("Código: " + b.Codigo);
                Console.WriteLine("Nombre: " + b.Nombre);
                Console.WriteLine("Pais: " + b.Pais);
                Console.WriteLine("Cantidad de Containers: " + b.CantidadContainers);
                Console.WriteLine("Cantidad de Containers Cargados: " + b.CantidadContainersCargados);
                Console.WriteLine("Gasto de Transporte: " + b.GastoTransporte);
            }
            else
            {
                Console.WriteLine("No se encontro naipe :( ");
            }
        }  //fin metodo buscar




    }
}

*/