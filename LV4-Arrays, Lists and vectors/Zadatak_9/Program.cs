using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> brojevi = new List<double>();
            while (brojevi.Count() < 12)
            {
                Console.Write("Unesi broj: ");
                int i = Int32.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    brojevi.Add(i);
                }
            }
            Console.WriteLine("Vasa lista je:");
            foreach (int element in brojevi)
            {
                Console.Write("{0}  ", element);
            }
            Console.WriteLine(brojevi.Count());
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
