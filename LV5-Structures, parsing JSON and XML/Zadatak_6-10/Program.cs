using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_10
{
    //6. Zadatak
    public struct Knjiga
    {
        public string sifra;
        public string naziv;
        public string autor;
        public int godina;
        public Knjiga(string s, string n, string a, int g)
        {
            sifra = s;
            naziv = n;
            autor = a;
            godina = g;
        }
    }
    //Kraj 6. zadatka
    class Program
    {
        //9. Zadatak
        static void IspisKnjiga(List<Knjiga> lista)
        {
            //8. Zadatak
            for (int i = 0; i < lista.Count(); i++)
            {
                Console.WriteLine("Sifra: {0}", lista[i].sifra);
                Console.WriteLine("Naziv: {0}", lista[i].naziv);
                Console.WriteLine("Autor: {0}", lista[i].autor);
                Console.WriteLine("Godina: {0}", lista[i].godina);
            }
            //Kraj 8. zadatka
        }
        //Kraj 9. zadatka

        //10. Zadatak
        static void PretragaKnjiga(List<Knjiga> lista)
        {
            Console.Write("Unesi naziv knjige o kojoj zelis vise informacija: ");
            string unospretrage = Console.ReadLine();
            bool nadena = false;
            for (int i = 0; i < lista.Count(); i++)
            {
                if(unospretrage == lista[i].naziv)
                {
                    Console.WriteLine("Sifra: {0}", lista[i].sifra);
                    Console.WriteLine("Autor: {0}", lista[i].autor);
                    Console.WriteLine("Godina: {0}", lista[i].godina);
                    nadena = true;
                }
            }
            if (nadena == false)
            {
                Console.WriteLine("Knjiga ne postoji!");
            }
        }
        //Kraj 10. Zadatka

        static void Main(string[] args)
        {
            //7. Zadatak
            List<Knjiga> lKnjiga = new List<Knjiga>();
            Knjiga K1 = new Knjiga("knji1352", "Propali", "Ivan Peric", 1992);
            Knjiga K2 = new Knjiga("knji1572", "Somali", "Pero Ivanic", 1943);
            Knjiga K3 = new Knjiga("knji1872", "Kokoli", "Iva Sokol", 1976);
            Knjiga K4 = new Knjiga("knji1982", "Suborti", "Karlo Mikic", 1945);
            Knjiga K5 = new Knjiga("knji1112", "Ceduro", "Petar Pan", 1652);
            lKnjiga.Add(K1);
            lKnjiga.Add(K2);
            lKnjiga.Add(K3);
            lKnjiga.Add(K4);
            lKnjiga.Add(K5);
            //Kraj 7. zadatka

            IspisKnjiga(lKnjiga);
            PretragaKnjiga(lKnjiga);
            Console.ReadKey();
        }
    }
}
