using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("i = {0}", i);
                f = f * i;
                Console.WriteLine("Faktorijel je {0}", f);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
