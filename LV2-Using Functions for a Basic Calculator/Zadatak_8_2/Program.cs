using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_8_2
{
    class Program
    {
        static void DajPovrsinu(int nStranicaA, int nStranicaB)
        {
            int p = nStranicaA * nStranicaB;
            Console.WriteLine(p);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Unesi duzinu stranice a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Unesi duzinu stranice b: ");
            b = Int32.Parse(Console.ReadLine());
            DajPovrsinu(a, b);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
