using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5_2
{
    class Program
    {
        static void ZbrojiPolja(int [,]polje1, int [,]polje2)
        {
            int s;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    s = polje1[i, j] + polje2[i, j];
                    Console.Write("{0}  ", s);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] aPolje5a = new int[3, 4] { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 7, 8, 9, 10 } };
            int[,] aPolje5b = new int[3, 4] { { 11, 12, 23, 12 }, { 12, 45, 66, 87 }, { 23, 45, 77, 33 } };
            ZbrojiPolja(aPolje5a, aPolje5b);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
