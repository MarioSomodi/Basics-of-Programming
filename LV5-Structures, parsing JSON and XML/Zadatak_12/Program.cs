using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Zadatak_12
{
    public struct Restoran
    {
        public int id;
        public string naziv;
        public string opis;
        public string adresa;
        public string grad;
        public int odsati;
        public int dosati;
        public Restoran(int i, string n, string o, string a, string g, int ods, int dos)
        {
            id = i;
            naziv = n;
            opis = o;
            adresa = a;
            grad = g;
            odsati = ods;
            dosati = dos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string sXml = "";
            StreamReader oSr = new StreamReader("C:\\Mario_Somodi\\LV5\\OsnoveProgramiranjaLV5\\Zadatak_12\\restorani.xml");
            using (oSr)
            {
                sXml = oSr.ReadToEnd();
            }
            XmlDocument oXml = new XmlDocument();
            oXml.LoadXml(sXml);
            XmlNodeList oNodes = oXml.SelectNodes("//data/restoran");
            List<Restoran> lRestorani = new List<Restoran>();
            foreach (XmlNode oNode in oNodes)
            {
            	lRestorani.Add(new Restoran(Int32.Parse(oNode.Attributes["id"].Value), oNode.Attributes["naziv"].Value, oNode.Attributes["opis"].Value, oNode.Attributes["adresa"].Value, oNode.Attributes["grad"].Value, Int32.Parse(oNode.Attributes["odsati"].Value), Int32.Parse(oNode.Attributes["dosati"].Value)));
            }
  
            foreach (Restoran element in lRestorani)
            {
                if (element.dosati > 23 || element.dosati < 6)
                {
                    Console.WriteLine("\n{0}. Restoran", element.id);
                    Console.WriteLine("Naziv: " + element.naziv);
                    Console.WriteLine("Opis: " + element.opis);
                    Console.WriteLine("Adresa: " + element.adresa);
                    Console.WriteLine("Grad: " + element.grad);
                    Console.WriteLine("Radno vrijeme: {0} - {1}", element.odsati, element.dosati);
                }
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
