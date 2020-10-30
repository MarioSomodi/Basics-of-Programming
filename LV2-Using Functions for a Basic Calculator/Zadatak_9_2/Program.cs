using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_9_2
{
    class Program
    {
        static void DajSumuParnih(int nBroj)
        {
            int s = 0;
            for (int i = 1; i <= nBroj; i++)
            {
                if (i % 2 == 0)
                {
                    s += i;
                }
            }
            Console.WriteLine("Suma parnih brojeva je {0}", s);
        }
        static void DajUmnozakNeparnih(int nBroj)
        {
            int u = 1;
            for (int i = 1; i <= nBroj; i++)
            {
                if (i % 2 != 0)
                {
                    u *= i;
                }
            }
            Console.WriteLine("Umnozak neparnih brojeva je {0}", u);
        }
        static void Main(string[] args)
        {
            int a;
            Console.Write("Unesi broj do 50: ");
            a = Int32.Parse(Console.ReadLine());
            if (a > 50)
            {
                Console.Write("Unjeli ste broj veci od 50 , unesite broj ponovno : ");
                a = Int32.Parse(Console.ReadLine());
            }
            DajSumuParnih(a);
            DajUmnozakNeparnih(a);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
