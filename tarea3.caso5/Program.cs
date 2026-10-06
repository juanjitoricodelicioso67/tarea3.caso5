using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int disponibles, vender, quedan;

            Console.Write("Digite las unidades disponibles: ");
            disponibles = int.Parse(Console.ReadLine());

            Console.Write("Digite las unidades que desea vender: ");
            vender = int.Parse(Console.ReadLine());

            if (disponibles >= 0 && vender > 0)
            {
                if (vender <= disponibles)
                {
                    quedan = disponibles - vender;

                    Console.WriteLine("La venta se puede realizar");
                    Console.WriteLine("Unidades disponibles: " + disponibles);
                    Console.WriteLine("Unidades vendidas: " + vender);
                    Console.WriteLine("Unidades restantes: " + quedan);
                }
                else
                {
                    Console.WriteLine("No hay suficientes unidades para realizar la venta");
                }
            }
            else
            {
                Console.WriteLine("Las cantidades no son validas");
            }

            Console.ReadKey();
        }
    }
}