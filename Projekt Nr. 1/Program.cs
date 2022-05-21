using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Nr._1
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Geben Sie bitte eine Zahl ein");
            double Zahl1;
            Zahl1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben sie eine Zeite Zahl ein");
            double Zahl2;
            Zahl2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Geben sie bitte +, -, *, /, ein");
            double Ergebnis;
            string Antwort;

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine(Ergebnis = Zahl1 + Zahl2);
                    return (int)Ergebnis;
                case "-":
                    Console.WriteLine(Ergebnis = Zahl1 - Zahl2);
                    return (int)Ergebnis;
                
                case "*":
                    Console.WriteLine(Ergebnis = Zahl1 * Zahl2);
                    return (int)Ergebnis;

                case "/":
                    Console.WriteLine(Ergebnis = Zahl1 / Zahl2);
                    return (int)Ergebnis;

                default:
                    Console.WriteLine("Geben sie bitte +, -, *, /, ein");
                    Antwort = Console.ReadLine();
                    
                    

                    switch (Console.ReadLine())
                    {
                        case "+":
                            Console.WriteLine(Ergebnis = Zahl1 + Zahl2);
                            return (int)Ergebnis;
                        case "-":
                            Console.WriteLine(Ergebnis = Zahl1 - Zahl2);
                            return (int)Ergebnis;

                        case "*":
                            Console.WriteLine(Ergebnis = Zahl1 * Zahl2);
                            return (int)Ergebnis;

                        case "/":
                            Console.WriteLine(Ergebnis = Zahl1 / Zahl2);
                            return (int)Ergebnis;

                        default:
                            Console.WriteLine("Geben sie bitte +, -, *, /, ein");
                            break;


                    }
                    Console.WriteLine("Möchten sie mit dem Ergebniss weiterrechnen?");
            string Weiterrechnen;
            Weiterrechnen = Console.ReadLine();
            double Ergebnis2;

           

            if (Weiterrechnen == "Ja")
            {
                Console.WriteLine("Geben sie bitte +, -, *, /, ein");
                double Zahl3;
                double Zahl4;
                Zahl3 = double.Parse(Console.ReadLine());
                Zahl4 = Ergebnis;
                switch (Console.ReadLine())
                { 

                case "+":
                    Console.WriteLine(Ergebnis2 = Zahl4 + Zahl3);
                    break;
                case "-":
                    Console.WriteLine(Zahl1 - Zahl3);
                    break;
                case "*":
                    Console.WriteLine(Zahl1 * Zahl3);
                    break;
                case "/":
                    Console.WriteLine(Zahl1 / Zahl3);
                    break;
                default:
                    Console.WriteLine("Geben sie bitte +, -, *, /, ein");
                    break;
                }
            }
            
            else
            {

                Console.WriteLine("Dann nicht");
            }
            Console.ReadKey();
        }
       
        
    }
}
