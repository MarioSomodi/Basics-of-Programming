using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Jedan");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Dva");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Tri");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Cetiri");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Pet");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nepoznat broj");
                        break;
                    }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
