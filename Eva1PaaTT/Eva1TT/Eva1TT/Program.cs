using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1TT
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* creacion de los 2 (en mi caso 3) buques */
            Buque duno = new Buque("35899", "Tara", "Chile", 20, 15, 255000);
            Buque ddos = new Buque("35877", "Larry", "Bolivia xD", 20, 5, 45000);
            Buque dtres = new Buque("35866", "Eva1", "Dinamarca", 20, 11, 355000);
            /* Crear 4 Containers Asociados a un Buque con las condiciones respectivas */
            Container cuno = new Container("Con01", "MSC", 20, 20, true, 1, duno);
            Container cdos = new Container("Con02", "USPS", 20, 40, true, 1, ddos);
            Container ctres = new Container("Con03", "LATAM", 20, 40, true, 1, dtres);
            Container ccuatro = new Container("Con04", "MSC", 200, 40, true, 1, ddos);

            /*Menu applicao = new Menu();
            applicao.Apply();*/

            bool chao = true;
            string opcion = "";
            while (chao)
            {
                Console.WriteLine("1. Calcular Gasto de Envio");
                Console.WriteLine("2. Sacar Peso");
                Console.WriteLine("3. Calcular valor por inspección");
                Console.WriteLine("4. Subir Container");
                Console.WriteLine("5. Puede Subir");
                Console.WriteLine("6. Salir !");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Calcular Gasto de Envio");
                        Console.WriteLine(" ");
                        break;
                    case "2":
                        Console.WriteLine("Sacar Peso");
                        Console.WriteLine(" ");
                        break;
                    case "3":
                        Console.WriteLine("Calcular valor por inspección");
                        Console.WriteLine(" ");
                        break;
                    case "4":
                        Console.WriteLine("Subir Container ");
                        Console.WriteLine(" ");
                        break;
                    case "5":
                        Console.WriteLine("Puede Subir ");
                        Console.WriteLine(" ");
                        break;
                    case "6":
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
    }
}