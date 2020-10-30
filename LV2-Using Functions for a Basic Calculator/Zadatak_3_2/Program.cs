using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int f = 1;
            while (i <= 10)
            {
                Console.WriteLine("i = {0}", i);
                f = f * i;
                Console.WriteLine("Faktorijel je {0}", f);
                i++;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
