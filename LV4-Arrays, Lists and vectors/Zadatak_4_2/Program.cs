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
            int[,] aPolje4a = new int[3, 3];
            int[,] aPolje4b = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Upisi elemnt u {0} redku i {1} stupcu: ",i + 1,j + 1);
                    aPolje4a[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Polje 4a");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}  ", aPolje4a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    aPolje4b[i, j] = aPolje4a[i, j] * aPolje4a[i, j];
                }
            }
            Console.WriteLine("Polje 4b kojem je svaki element zapravo kvadrat elementa iz polja 4a");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}  ", aPolje4b[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
