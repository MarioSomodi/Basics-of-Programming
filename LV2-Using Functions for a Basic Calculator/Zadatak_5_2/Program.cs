using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int f = 1;
            do
            {
                Console.WriteLine("i = {0}", i);
                f = f * i;
                Console.WriteLine("Faktorijel je {0}", f);
                i++;
            } while (i <= 10);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
