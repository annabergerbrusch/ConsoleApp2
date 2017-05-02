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
            string gnsString = gns.ToString();
            Console.WriteLine("Gennemsnitsløn " + gnsString);
            Console.ReadKey();

        }
    }
}
