using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MånedslønGennemsnit
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int[] månedslønninger;
            månedslønninger = new int[6];
            månedslønninger[0] = 10000;
            månedslønninger[1] = 20000;
            månedslønninger[2] = 15000;
            månedslønninger[3] = 20000;
            månedslønninger[4] = 30000;
            månedslønninger[5] = 15000;
            System.Array.Sort(månedslønninger);
            double sum = 0;
            for (int i = 0; i < månedslønninger.Length; i++)
            {
                sum += månedslønninger[i];
            }

            double gns = sum / månedslønninger.Length;
            

            for (int i = 0; i < 6; i++)
            Console.WriteLine(månedslønninger[i]);
            string gnsString = gns.ToString("N2");
            Console.WriteLine("Gennemsnitsløn " + gnsString);
            


            // Strenge


            //string navn;
            //navn = null;
            //navn = "Mikkel";
            //string nytnavn = navn.ToUpper();
            //Console.WriteLine(nytnavn);
            //Console.WriteLine(navn.Substring(0, 2));
            //Console.WriteLine(navn.PadLeft(10, '*'));
            //Console.WriteLine(navn.IndexOf('k', 3));

            string fnavn = "Mikkel";
            string enavn = "Cronberg";
            string full = fnavn + " " + enavn;
            Console.WriteLine(full);
            Console.WriteLine($"{fnavn} {enavn}");



            //System.Text.StringBuilder. Bruges når man har med streng og løkker at gøre.

            // Arbejde med strenge:

            string navn = "Mikkel";
            string efternavn = "Cronberg";
            string samletStreng = navn + " " + enavn;
            string navnStort = samletStreng.ToUpper();
            Console.WriteLine(navnStort);
            string lilleNavn = navnStort.ToLower();
            Console.WriteLine(lilleNavn);
            string del = samletStreng.Substring(7,4);
            Console.WriteLine(del);

            string[] array1 = { navn, efternavn };
            for (int i = 0; i < 2; i++)
                Console.WriteLine(array1[i]);


            // 10-tabel:

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    string tal = (i * j).ToString();
                    if (i * j < 51)
                        Console.ForegroundColor = ConsoleColor.White;
                    else Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(tal.PadLeft(4,'*'));
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}

