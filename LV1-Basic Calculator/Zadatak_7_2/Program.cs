using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int a = Int32.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Paran");
            }
            else
            {
                Console.WriteLine("Neparan");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
