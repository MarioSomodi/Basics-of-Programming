using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_9_1
{ 
        class Program
        {
            static void Main(string[] args)
            {

                int a = 34 + 37 * (23 - 8) - 22 * 23;

                switch (a)
                {
                    case 0:
                        {
                            Console.WriteLine("Nula");
                            break;
                        }
                    case 83:
                        {
                            Console.WriteLine("OsamdesetTri");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nepoznat");
                            break;
                        }
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
   }