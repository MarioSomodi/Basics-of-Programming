using System;
namespace Zadatak_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Faktorijel je {0}", DajFaktorijal(a));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static int DajFaktorijal(int nBrojFaktorijela)
        {
            if (nBrojFaktorijela == 0)
            {
                return 1;
            }
            else
            {
                return nBrojFaktorijela * DajFaktorijal(nBrojFaktorijela - 1);
            }
        }

    }
}