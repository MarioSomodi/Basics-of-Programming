using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3_1
{
    class Zadatak_3_1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            int b = Int32.Parse(Console.ReadLine());
            double c = a / b;
            Console.WriteLine("Reuslt of dividing your two numbers is {0}", c);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
