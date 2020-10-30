using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, p;
            do
            {
                Console.Write("Unesi prvi broj: ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("Unesi drugi broj: ");
                b = Double.Parse(Console.ReadLine());
                p = (a + b) / 2;
                Console.WriteLine("Prosjecna vrijednost je: {0}", p);
            } while (p > 5);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
