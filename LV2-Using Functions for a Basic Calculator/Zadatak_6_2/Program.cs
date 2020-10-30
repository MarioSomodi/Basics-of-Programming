using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_2
{
    class Program
    {
        static int DajFaktorijel(int nBrojFaktorijela)
        {
            int f = 1;
            for (int i = 1; i <= nBrojFaktorijela; i++)
            {
                f = f * i;
            }
            return f;
        }
        static void Main(string[] args)
        {
            int a;
            Console.Write("Unesi cijeli broj: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DajFaktorijel(a));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
