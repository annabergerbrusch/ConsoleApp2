﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();
            string uppername = navn.ToUpper();
            Console.WriteLine("Velkommen" + " " + uppername);
            Console.WriteLine("Tryk en tast for at fortsætte");
            Console.ReadKey();
        }

    }
}
