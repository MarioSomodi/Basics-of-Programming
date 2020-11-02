using System;
using System.IO;

namespace Zadatak_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Datoteke\Datum&Vrijeme.txt";
            while (true)
            {
                DateTime now = DateTime.Now;
                StreamWriter time = new StreamWriter(path, true);
                Console.WriteLine(now.ToString("F"));
                time.WriteLine(now.ToString("F"));
                time.Close();
                System.Threading.Thread.Sleep(30000);
            }
        }
    }
}
