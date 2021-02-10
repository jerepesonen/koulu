using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T28_Liiga
{
    class Pelaaja
    {
        //pelaaja luokan ominaisuudet
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public int Pelinumero { get; set; }

        //konstruktorit
        public Pelaaja() { }
        public Pelaaja(string etunimi, string sukunimi, string pelipaikka, int numero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Pelinumero = numero;
        }
        //metodit
        public override string ToString()
        {
            return (Etunimi + " " + Sukunimi + ", " + Pelipaikka + ", " + Pelinumero);
        }
    }
    class Joukkue
    {
        //joukkue luokan opimaisuudet
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }
        public Joukkue()
        {
            Pelaajat = new List<Pelaaja>();
        }
        //metodit
        public string HaePelaajat(string joukkue)
        {
            string pelaajalista = $"\n{Nimi}, {Kotikaupunki}\n";
            foreach (var item in Pelaajat)
            {
                pelaajalista = pelaajalista + "\t- " + item.ToString() + "\n";
            }
            //palautta kysytyn joukkueen pelaajat yhtenä stringinä
            return pelaajalista;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // alustetaan muuttujat, ja luodaan joukkue ja pelaaja oliot
            int caseSwitch;
            Joukkue joukkue1 = new Joukkue() { Nimi = "JYP", Kotikaupunki = "Jyväskylä" };
            Joukkue joukkue2 = new Joukkue() { Nimi = "Kalpa", Kotikaupunki = "Kuopio" };
            Joukkue joukkue3 = new Joukkue() { Nimi = "HIFK", Kotikaupunki = "Helsinki" };
            Pelaaja pelaaja1 = new Pelaaja() { Etunimi = "Julius", Sukunimi = "Nättinen", Pelipaikka = "Laitahyökkääjä", Pelinumero = 33 };
            Pelaaja pelaaja2 = new Pelaaja() { Etunimi = "Kalle", Sukunimi = "Kerman", Pelipaikka = "Laitahyökkääjä", Pelinumero = 3 };
            Pelaaja pelaaja3 = new Pelaaja() { Etunimi = "Lennart", Sukunimi = "Petrell", Pelipaikka = "Laitahyökkääjä", Pelinumero = 32 };
            //lisätään pelaajat oikeiden joukkueiden listaan.
            joukkue1.Pelaajat.Add(pelaaja1);
            joukkue2.Pelaajat.Add(pelaaja2);
            joukkue3.Pelaajat.Add(pelaaja3);
            Console.WriteLine("---Liiga---\n\nJYP\nKalpa\nHIFK\n");
            while(true)
            {
                try
                {
                    //case valikko
                    Console.WriteLine("Valikko\n1. Listaa joukkueen pelaajat\n2. Lisää Pelaaja\n3. Poista Pelaaja");
                    caseSwitch = Convert.ToInt32(Console.ReadLine());
                    switch (caseSwitch)
                    {

                        case 1:
                            {
                                //case 1, listataan joukkueen pelaajat
                                Console.WriteLine("Anna joukkue: "); // kyaytään käyttäjältä haluttu joukkue
                                string joukkue = Console.ReadLine();
                                if (joukkue.ToUpper() == "JYP") // jos joukkue on jyp
                                {
                                    Console.WriteLine(joukkue1.HaePelaajat(joukkue1.Nimi)); // kutsutaan haepelaajat metodia joukkueen jyp oliolla
                                    break;
                                }
                                else if (joukkue.Equals("Kalpa", StringComparison.OrdinalIgnoreCase)) // jos joukkue on kalpa
                                {
                                    Console.WriteLine(joukkue2.HaePelaajat(joukkue2.Nimi)); // kutsutaan haepelaajat metodia joukkueen kalpa oliolla
                                    break;
                                }
                                else if (joukkue.Equals("HIFK", StringComparison.OrdinalIgnoreCase)) // jos joukkue on hifk
                                {
                                    Console.WriteLine(joukkue3.HaePelaajat(joukkue3.Nimi)); // kutsutaan haepelaajat metodia hifk oliolla
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Joukkueen syöttäminen epäonnistui"); // jos käyttäjän syöttämää joukkuetta ei löydy, tulostetaan ilmoitus.
                                    break;
                                }
                            }
                        case 2:
                            {
                                // casde 2 lisätään pelaaja, käyttäjältä kysytään pelaajan tiedot, ja joukkue johon lisätään.
                                Console.WriteLine("Anna joukkue, johon pelaaja lisätään: ");
                                string joukkue = Console.ReadLine();
                                Console.WriteLine("Anna pelaajan etunimi: ");
                                string etunimi = Console.ReadLine();
                                Console.WriteLine("Anna pelaajan sukunimi: ");
                                string sukunimi = Console.ReadLine();
                                Console.WriteLine("Anna pelaajan pelinumero: ");
                                int numero = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Anna pelaajan pelipaikka: ");
                                string pelipaikka = Console.ReadLine();
                                // luodaan käyttäjän syöttämistä tiedoista pelaaja olio
                                Pelaaja pelaaja = new Pelaaja() { Etunimi = etunimi, Sukunimi = sukunimi, Pelipaikka = pelipaikka, Pelinumero = numero };

                                //tutkitaan minkä joukkueen käyttäjä on syöttänyt, ja lisätään pelaaja kyseisen olion listaan.
                                if (joukkue.ToUpper() == "JYP")
                                {
                                    joukkue1.Pelaajat.Add(pelaaja);
                                    break;
                                }
                                else if (joukkue.Equals("Kalpa", StringComparison.OrdinalIgnoreCase))
                                {
                                    joukkue2.Pelaajat.Add(pelaaja);
                                    break;
                                }
                                else if (joukkue.Equals("HIFK", StringComparison.OrdinalIgnoreCase))
                                {
                                    joukkue3.Pelaajat.Add(pelaaja);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Joukkueen syöttäminen epäonnistui"); // jos käyttäjän syöttämää joukkuetta ei löydy, tulostetaan ilmoitus.
                                    break;
                                }
                            }
                        case 3:
                            {
                                // kysytän poistettavan pelaajan tiedot ja tallennetaan ne muuttujiin
                                Console.WriteLine("Anna joukkue, jossa pelaaja pelaa: ");
                                string joukkue = Console.ReadLine();
                                Console.WriteLine("Anna poistettavan pelaajan etunimi: ");
                                string etunimi = Console.ReadLine();
                                Console.WriteLine("Anna pelaajan sukunimi: ");
                                string sukunimi = Console.ReadLine();


                                // tutkitaan, että minkä joukkueen käytäjä on syöttänyt, ja etsitään kyseisestä joukkueesta syötettyä pelaajaa
                                if (joukkue.ToUpper() == "JYP")
                                {
                                    foreach (var item in joukkue1.Pelaajat)
                                    {
                                        // käydään joukkueen pelaajat läpi, ja etsitään löytyykö pelaajaa joka vastaa annettuihin etu, sekä sukunimeen.
                                        if (item.Etunimi.ToUpper() == etunimi.ToUpper())
                                        {
                                            if (item.Sukunimi.ToUpper() == sukunimi.ToUpper())
                                            {
                                                joukkue1.Pelaajat.Remove(item);
                                                Console.WriteLine($"Pelaaja {item.Etunimi} {item.Sukunimi} poistettu joukkuuesta {joukkue}");
                                            }
                                        }
                                    }
                                }
                                else if (joukkue.ToUpper() == "KALPA")
                                {
                                    foreach (var item in joukkue2.Pelaajat)
                                    {
                                        // käydään joukkueen pelaajat läpi, ja etsitään löytyykö pelaajaa joka vastaa annettuihin etu, sekä sukunimeen.
                                        if (item.Etunimi.ToUpper() == etunimi.ToUpper())
                                        {
                                            if (item.Sukunimi.ToUpper() == sukunimi.ToUpper())
                                            {
                                                joukkue2.Pelaajat.Remove(item);
                                                Console.WriteLine($"Pelaaja {item.Etunimi} {item.Sukunimi} poistettu joukkuuesta {joukkue}");
                                            }
                                        }
                                    }


                                }
                                else if (joukkue.ToUpper() == "HIFK")
                                {
                                    foreach (var item in joukkue3.Pelaajat)
                                    {
                                        // käydään joukkueen pelaajat läpi, ja etsitään löytyykö pelaajaa joka vastaa annettuihin etu, sekä sukunimeen.
                                        if (item.Etunimi.ToUpper() == etunimi.ToUpper())
                                        {
                                            if (item.Sukunimi.ToUpper() == sukunimi.ToUpper())
                                            {
                                                joukkue3.Pelaajat.Remove(item);
                                                Console.WriteLine($"Pelaaja {item.Etunimi} {item.Sukunimi} poistettu joukkuuesta {joukkue}");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Joukkueen syöttäminen epäonnistui"); // jos käyttäjän syöttämää joukkuetta ei löydy, tulostetaan ilmoitus.
                                    break;
                                }
                                break;
                            }
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
