using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Zadatak_14
{
    class Program
    {
        public struct Igraci
        {
            public int rb;
            public string oib;
            public string ime;
            public string prezime;
            public string adresa;
            public string grad;
            public string klub;
            public int godina;            public Igraci(int r, string o, string i, string p, string a, string g, string k, int god)
            {
                rb = r;
                oib = o;
                ime = i;
                prezime = p;
                adresa = a;
                grad = g;
                klub = k;
                godina = god;
            }
        }
        public static void IspisIgraca(List<Igraci> lIgraci)
        {
            for (int i = 0; i < lIgraci.Count(); i++)
            {
                int godIgraca = 2019 - lIgraci[i].godina;
                if (godIgraca < 20 && lIgraci[i].grad == "Virovitica")
                {
                    Console.WriteLine("{0}. Igrac", lIgraci[i].rb);
                    Console.WriteLine("OIB: {0}", lIgraci[i].oib);
                    Console.WriteLine("Ime: {0}", lIgraci[i].ime);
                    Console.WriteLine("Prezime: {0}", lIgraci[i].prezime);
                    Console.WriteLine("Adresa: {0}", lIgraci[i].adresa);
                    Console.WriteLine("Grad: {0}", lIgraci[i].grad);
                    Console.WriteLine("Klub: {0}", lIgraci[i].klub);
                    Console.WriteLine("Godina: {0}", lIgraci[i].godina);
                    Console.WriteLine("\n------------------------------\n");
                }
            }
        }
        static void Main(string[] args)
        {
            List<Igraci> lIgraci = new List<Igraci>();
            StreamReader oSr = new StreamReader("D:\\Mario\\Faks\\Osnove_Programiranja\\Labaratorijske_Vjezbe\\LV5\\OsnoveProgramiranjaLV5\\Zadatak_14\\igraci.json");
            string sJson = "";
            using (oSr)
            {
                sJson = oSr.ReadToEnd();
                lIgraci = JsonConvert.DeserializeObject<List<Igraci>>(sJson);
            }
            IspisIgraca(lIgraci);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
