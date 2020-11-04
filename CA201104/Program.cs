using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201104
{
    public struct Ember
    {
        public string Nev { get; set; }
        public DateTime Szul { get; set; }
    }


    class Program
    {
        static void Main()
        {
            Feldolgozas();
        }
        static void MaualisRogzitesPL()
        {
            var sw = new StreamWriter(@"valami.txt", true);
            ConsoleKey ck;
            do
            {
                Console.Write("Név: ");
                var nev = Console.ReadLine();
                sw.WriteLine(nev);
                Console.WriteLine("Folytatás: ENTER\nKilépés:ESC");
                ck = Console.ReadKey(true).Key;
            } while (ck != ConsoleKey.Escape);
            sw.Close();
        }
        static void Feldolgozas()
        {
            var emberek = new Ember[]
            {
                new Ember() { Nev = "Zolika", Szul = new DateTime(1990, 07, 11) },
                new Ember() { Nev = "Ticián", Szul = new DateTime(2002, 10, 18) },
                new Ember() { Nev = "Karcsi", Szul = new DateTime(1960, 09, 07) },
            };

            var sw = new StreamWriter("mindenkiKora.txt");
            foreach (var e in emberek)
            {
                sw.WriteLine($"{e.Nev} {2020 - e.Szul.Year} éves");
            }
            sw.Close();
        }
    }
}
