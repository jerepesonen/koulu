using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T23_NewCD
{
    class CD
    {
        //albumin ominaisuudet
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        //lista
        public List<Kappale> Kappaleet { get; set; }
        public int Kappalemäärä
        {
            get { return Kappaleet.Count; }
        }
        //laskee albumin kokonaispituuden ja palauttaa sen min ja sec muodossa
        public string KokonaisPituus
        {
            get
            {
                int pituus = 0;
                foreach (var item in Kappaleet)
                {
                    pituus += item.Pituus;
                }
                string koko = "0m0sec";
                koko = string.Format($"{pituus / 60} min {pituus % 60} sec");
                return koko;


            }
        }

        // metodi palauttaa albumin tiedot
        public override string ToString()
        {
            return ($"Albumin nimi: {Nimi}\nArtisti: {Artisti}\nKappaleiden määrä: {Kappalemäärä}\nKokonaispituus: {KokonaisPituus}");
        }

    }
    class Kappale
    {
        //Kappaleen ominaisuudet
        public string Nimi { get; set; }
        public int Pituus { get; set; }
        //laskee kappaleen kokonaispituuden ja palauttaa sen min ja sec muodossa
        public string PituusMinSec
        {
            get
            {
                int pituus = Pituus;
                string koko = "0m0sec";
                koko = string.Format($"{pituus / 60} min {pituus % 60} sec");
                return koko;
            }
        }

        // metodi palauttaa kappaleen tiedot
        public override string ToString()
        {
            return ($"\t{Nimi}, {PituusMinSec}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD() { Artisti = "Nightwish", Nimi = "Endless Forms Most Beautiful"}; // luodaan uusi olio cd1, ja asetetaan sille alkuominaisuudet
            
            //luodaan kolme eri kappale oliota
            Kappale kappale1 = new Kappale() { Nimi = "eka biisi", Pituus = 375 };
            Kappale kappale2 = new Kappale() { Nimi = "toka biisi", Pituus = 475 };
            Kappale kappale3 = new Kappale() { Nimi = "kolkki biisi", Pituus = 325 };

            //luodaat kappaleet1 lista, johon lisätään edellä luodut kappale oliot
            List<Kappale> kappaleet1 = new List<Kappale>() { kappale1, kappale2, kappale3 };
            //asetetaan kappaleet1 lista oikean cdn kappaleiksi
            cd1.Kappaleet = kappaleet1;

            Console.WriteLine(cd1.ToString()); // tulostetaan cdn tiedot
            foreach (var item in kappaleet1)
            {
                Console.WriteLine(item.ToString()); // tulostetaan kappaleiden tiedot yksi kerrallaan silmukassa
            } 
            Console.ReadLine();
        }
    }
}
