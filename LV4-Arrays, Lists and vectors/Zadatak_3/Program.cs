using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aPolje3 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Unesi broj: ");
                aPolje3[i] = Int32.Parse(Console.ReadLine());
            }
            foreach (int element in aPolje3)
            {
                if (element % 2 == 0)
                {
                    Console.Write("{0}  ", element);
                }
            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
