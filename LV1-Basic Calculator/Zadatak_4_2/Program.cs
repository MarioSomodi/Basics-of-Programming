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
            Console.Write("Enter the first number : ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            int y = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the third number : ");
            int z = Int32.Parse(Console.ReadLine());
            int r = (x + y) * z;
            Console.WriteLine(r);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
