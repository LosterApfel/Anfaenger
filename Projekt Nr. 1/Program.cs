﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Nr._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geben Sie bitte eine Zahl ein");
            int Zahl1;
            Zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben sie eine Zeite Zahl ein");
            int Zahl2;
            Zahl2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geben sie bitte +, -, *, /, ein");
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine(Zahl1 + Zahl2);
                    break;
                case "-":
                    Console.WriteLine(Zahl1 - Zahl2);
                    break;
                case "*":
                    Console.WriteLine(Zahl1 * Zahl2);
                    break;
                case "/":
                    Console.WriteLine(Zahl1 / Zahl2);
                    break;
                default:
                    Console.WriteLine("Geben sie bitte +, -, *, /, ein");
                    break;
            }
            Console.ReadKey();
        }
       
        
    }
}
