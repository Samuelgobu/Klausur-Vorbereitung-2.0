using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur_Vorbereitung_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string nochmal = "";
            do
            {
                Console.WriteLine("Menü:");
                Console.WriteLine("1: Kräfte addieren.");
                Console.WriteLine("2. Vielfache einer Zahl bestimmen");
                Console.WriteLine("3. Gleichung linearer Funktion aus zwei Punkten bestimmen");
                Console.WriteLine("4. Ziffern zählen");

                string auswahl;
                auswahl = Console.ReadLine();
                switch (auswahl)
                {
                    case "1":
                        double f1, f2, winkel, GKraft;
                        Console.WriteLine("Betrag von F_1 in Newton:");
                        //f1 = dEingabe(Console.ReadLine());
                        f1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Betrag von F_2 ind Newton:");
                        //f2 = dEingabe(Console.ReadLine());
                        f2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Betraf vom Winkel:");
                        winkel = Convert.ToDouble(Console.ReadLine());
                        GKraft = Math.Sqrt(Math.Pow(f1, 2) + Math.Pow(f2, 2) + 2 * f1 * f2 * Math.Cos(winkel * (Math.PI / 180)));
                        Console.WriteLine($"Der Betrag der Gesamtkraft, die die resultierende Kraft aus 2 Kräfte ist, ist { Math.Round(GKraft, 2)}");

                        break;

                    case "2":
                        double zahl;
                        Console.WriteLine("Schreiben Sie den Betrag der Zahl");
                        zahl = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i<11; i++)
                        {
                            Console.WriteLine(zahl + " mal " + i + " ist " + zahl * i);
                        }                 

                        break;
                    case "3":
                        double x1, x2, y1, y2, m, b;
                        Console.WriteLine("Zwei Punkte angeben. P1:");
                        Console.WriteLine("x1=");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("y1=");
                        y1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("x2=");
                        x2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("y2=");
                        y2 = Convert.ToDouble(Console.ReadLine());
                        m = (y2 - y1) / (x2 - x1);



                        break;

                }
                Console.WriteLine("Neue Auswahl? j/n");
                nochmal = Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");

            


        }
    }
}
