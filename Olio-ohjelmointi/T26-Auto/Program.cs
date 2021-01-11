using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace T26_Auto
{

    class Rengas
    {
        //ominaisuudet
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string Koko { get; set; }

    }
    class Auto
    {
        // Ominaisuudet
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int MaxRenkaidenLkm { get; set; }
        public int RenkaidenLkm{ get { return Renkaat.Count(); }}
        public List<Rengas> Renkaat { get; set; }
        //konstruktori
        public Auto()
        {
            Renkaat = new List<Rengas>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // luodaan uusi olio auto ja sen tiedot
            Auto auto = new Auto() { Merkki = "Skoda", Malli = "Fabia" };
            // ostetaan 4 rengasta ja lisätään autoon
            for (int i = 0; i < 4; i++)
            {
                Rengas rengas = new Rengas() { Valmistaja = "Nokian", Malli = "Hakka", Koko = "205/55R16" };
                auto.Renkaat.Add(rengas);
            }
            Console.WriteLine($"Arskan autossa {auto.Merkki} {auto.Malli} on seuraavat renkaat"); // tulostus
            // tulostetaan auton renkaat yksi kerrallaan
            foreach (var item in auto.Renkaat)
            {
                Console.WriteLine($"{item.Valmistaja} {item.Malli} {item.Koko}");
            }

            // luodaan uusi olio auto ja sen tiedot
            Auto auto2 = new Auto() { Merkki = "BMW", Malli = "X5" };
            // ostetaan 4 rengasta ja lisätään autoon
            for (int i = 0; i < 4; i++)
            {
                Rengas rengas = new Rengas() { Valmistaja = "Pirelli", Malli = "Scorpion", Koko = "275/45R20" };
                auto2.Renkaat.Add(rengas);
            }

            Console.WriteLine($"\nJaskan autossa {auto2.Merkki} {auto2.Malli} on seuraavat renkaat"); // tulostus
             // tulostetaan auton renkaat yksi kerrallaan
            foreach (var item in auto2.Renkaat)
            {
                Console.WriteLine($"{item.Valmistaja} {item.Malli} {item.Koko}");
            }
            // luodaan uusi olio auto ja sen tiedot
            Auto auto3 = new Auto() { Merkki = "Alfa Romeo", Malli = "8C" };
            // ostetaan 2 rengasta ja lisätään autoon
            for (int i = 0; i < 2; i++)
            {
                Rengas rengas = new Rengas() { Valmistaja = "Bridgestone", Malli = "Potenza", Koko = "245/35R20" };
                auto3.Renkaat.Add(rengas);
            }
            // ostetaan 2 rengasta ja lisätään autoon
            for (int i = 0; i < 2; i++)
            {
                Rengas rengas = new Rengas() { Valmistaja = "Bridgestone", Malli = "Potenza", Koko = "275/35R20" };
                auto3.Renkaat.Add(rengas);
            }

            Console.WriteLine($"\nKimin autossa {auto3.Merkki} {auto3.Malli} on seuraavat renkaat"); // tulostus
             // tulostetaan auton renkaat yksi kerrallaan
            foreach (var item in auto3.Renkaat)
            {
                Console.WriteLine($"{item.Valmistaja} {item.Malli} {item.Koko}");
            }

            Console.ReadLine();
        }
    }
}
