using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_10_2
{
    class Program
    {
        static int DohvatiIzbornik()
        {
            int a;
            Console.WriteLine("Izaberi broj operacije koju ces koristiti : \n1 - zbrajanje\n2 - oduzimanje\n3 - mnozenje\n4 - djeljenje");
            a = Int32.Parse(Console.ReadLine());
            return a;
        }
        static double Zbrajanje(double nPrviBroj, double nDrugiBroj)
        {
            double z = nPrviBroj + nDrugiBroj;
            return z;
        }

        static double Oduzimanje(double nPrviBroj, double nDrugiBroj)
        {
            double r = nPrviBroj - nDrugiBroj;
            return r;
        }

        static double Mnozenje(double nPrviBroj, double nDrugiBroj)
        {
            double u = nPrviBroj * nDrugiBroj;
            return u;
        }

        static double Djeljenje(double nPrviBroj, double nDrugiBroj)
        {
            double k = nPrviBroj / nDrugiBroj;
            return k;
        }
        static void IzvrsiOperaciju(int IDOperacije, double nPrviBroj, double nDrugiBroj)
        {
            switch (IDOperacije)
            {
                case 1:
                    {
                        Console.WriteLine("Zbroj vasa dva broja je {0}", Zbrajanje(nPrviBroj, nDrugiBroj));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Razlika vasa dva broja je {0}", Oduzimanje(nPrviBroj, nDrugiBroj));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Umnozak vasa dva broja je {0}", Mnozenje(nPrviBroj, nDrugiBroj));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Kolicnik vasa dva broja je {0}", Djeljenje(nPrviBroj, nDrugiBroj));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operator koji ste izabrali nije podrzan");
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Unesi prvi broj: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            b = Int32.Parse(Console.ReadLine());
            IzvrsiOperaciju(DohvatiIzbornik(), a, b);
            Console.ReadKey();
        }
    }
}
