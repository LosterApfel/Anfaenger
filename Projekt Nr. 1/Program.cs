using System;
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
            double Ergebnis;
            string Eingabe;

            do
            {
                Console.WriteLine("Geben Sie bitte eine Zahl ein");
                double Zahl1;
                Zahl1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben sie eine Zeite Zahl ein");
                double Zahl2;
                Zahl2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Geben sie bitte +, -, *, /, ein");
              

                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine("Das ist dein Ergebnis =" + (Ergebnis = Zahl1 + Zahl2));
                        break;
                    case "-":
                        Console.WriteLine("Das ist dein Ergebnis =" + (Ergebnis = Zahl1 - Zahl2));
                        break;

                    case "*":
                        Console.WriteLine("Das ist dein Ergebnis =" + (Ergebnis = Zahl1 * Zahl2));
                        break;

                    case "/":
                        Console.WriteLine("Das ist dein Ergebnis =" + (Ergebnis = Zahl1 / Zahl2));
                        break;

                    default:
                        Console.WriteLine("Geben sie bitte +, -, *, /, ein");
                        break;


                }
                Console.WriteLine("Mit Ja weitermachen");
                Eingabe = Console.ReadLine();
            } while (Eingabe == "Ja");

            
            


            Console.ReadKey();
        }
        
     
  }
}
