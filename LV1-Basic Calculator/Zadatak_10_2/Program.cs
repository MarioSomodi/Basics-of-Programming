using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int choice;
            Console.Write("Unesi prvi broj : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj : ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi operaciju koju zelis \n(1-zbrajanje, 2-oduzimanje, 3-mnozonje, 4-djeljenje) : ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        double z = a + b;
                        Console.WriteLine(z);
                        break;
                    }
                case 2:
                    {
                        double z = a - b;
                        Console.WriteLine(z);
                        break;
                    }
                case 3:
                    {
                        double z = a * b;
                        Console.WriteLine(z);
                        break;
                    }
                case 4:
                    {
                        double z = a / b;
                        Console.WriteLine(z);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nepoznata operacija");
                        break;
                    }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
   }

