using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2 * 3;
            int b = 4 * 3;
            if (a == b)
            {
                Console.WriteLine("Istina");
            }
            else
            {
                Console.WriteLine("Laz");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
