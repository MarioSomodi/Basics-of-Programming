using System;
using System.IO;

namespace Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\fpsdr\Desktop\Mario_Somodi\LV3\OsnoveProgramiranjaLV3\Datoteke\TelefonskiImenik.txt";
            string ime, prezime, telbroj, sadrzaj;
            StreamWriter unosUtelefonskiimenik = new StreamWriter(path, true);
            Console.Write("Unesite ime: ");
            ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            prezime = Console.ReadLine();
            Console.Write("Unesite telefonski broj: ");
            telbroj = Console.ReadLine();
            unosUtelefonskiimenik.WriteLine("Ime: {0}", ime);
            unosUtelefonskiimenik.WriteLine("Prezime: {0}", prezime);
            unosUtelefonskiimenik.WriteLine("Telefonski broj: {0}", telbroj);
            unosUtelefonskiimenik.Flush();
            unosUtelefonskiimenik.Close();
            StreamReader citanjeIzTelImenika = new StreamReader(path);
            sadrzaj = citanjeIzTelImenika.ReadToEnd();
            Console.WriteLine(sadrzaj);
            citanjeIzTelImenika.Close();
            Console.ReadKey();
        }
    }
}
