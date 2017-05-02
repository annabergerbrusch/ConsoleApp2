using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        enum Filtyper
        {
            csv,
            pdf,
            txt
        }

        struct Person
        {
        public int Id;
        public string Navn;
        }
           
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            Filtyper ft = Filtyper.csv;
            Console.WriteLine("ft");
            // Overvej hvordan man kan udskrive værdien og ikke strengen.
            Console.WriteLine(ft);

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato);

            string datostring = dato.ToString("ddyyMM");
            Console.WriteLine(datostring);

            datostring = dato.ToString("dMy");
            Console.WriteLine(datostring);

            datostring = dato.ToLongDateString();
            Console.WriteLine(datostring);


            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);


            Console.ReadKey();

        }

    }
}
