using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> brojevi1 = new List<double>(5);
            List<double> brojevi2 = new List<double>(5);
            List<double> brojevi3 = new List<double>(10);

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Unesi broj {0} prve liste: ", i+1);
                int z = Int32.Parse(Console.ReadLine());
                brojevi1.Add(z);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Unesi broj {0} druge liste: ", i + 1);
                int t = Int32.Parse(Console.ReadLine());
                brojevi2.Add(t);
            }
            foreach (int element in brojevi1)
            {
                brojevi3.Add(element);
            }
            foreach (int element in brojevi2)
            {
                brojevi3.Add(element);
            }
            Console.WriteLine("Prva lista");
            foreach (int element in brojevi1)
            {
                Console.Write("{0}  ", element);
            }
            Console.WriteLine("\nDruga lista");
            foreach (int element in brojevi2)
            {
                Console.Write("{0}  ", element);
            }
            Console.WriteLine("\nPrva i Druga lista spojene");
            foreach (int element in brojevi3)
            {
                Console.Write("{0}  ", element);
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
