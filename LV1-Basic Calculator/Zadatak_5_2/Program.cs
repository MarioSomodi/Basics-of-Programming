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
            Console.Write("Enter the first number : ");
            double x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            double y = Int32.Parse(Console.ReadLine());
            double r = (x + y) / 2;
            Console.WriteLine("Prosjecna vrijednost vasa dva broja je {0}", r);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
