using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T31_MiniAsio
{
    class Student
    {
        //ominaisuudet
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string AsioID { get; set; }
        public string Ryhmä { get; set; }

        //metodi joka palauttaa olion ominaisuudet stringinä
        public override string ToString()
        {
            return $"{Etunimi} {Sukunimi} {AsioID}, {Ryhmä}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // alustetaan muuttujat
            int luku = 0;
            int testi = 0;
            int caseSwitch;
            // luodaan olio lista oppilaat
            List<Student> oppilaat = new List<Student>();

            Console.WriteLine("Mini Asio!");
            while (true)
            {
                try
                {
                    //luodaan switch rakenne, ja tulostetaan sen valinnat
                    Console.WriteLine("\nValikko\n1. Listaa opiskelijat\n2. Lisää opiskelija\n3. Poista opiskelija");
                    caseSwitch = Convert.ToInt32(Console.ReadLine());
                    switch (caseSwitch)
                    {
                        case 1:
                            //foreach silmukka jossa käydään läpi kaikki oppilaat listan oppilaat
                            foreach (var item in oppilaat)
                            {
                                Console.WriteLine(item.ToString()); // tulostetaan kyseisen oppilaan tostring metodia
                            }
                            break;
                        case 2:
                            //kysytään käyttäjältä lisättävän oppilaan tiedot, ja tallennetaan ne muuttujiin
                            Console.WriteLine("Anna opiskelijan etunimi: ");
                            string enimi = Console.ReadLine();
                            Console.WriteLine("Anna opiskelijan sukunimi: ");
                            string snimi = Console.ReadLine();
                            Console.WriteLine("Anna opiskelijan ryhmätunnus: ");
                            string ryhmät = Console.ReadLine();
                            luku += 1;
                            //ohjelma luo automaattisesti opiskelijatunnuksen nimen ja järjestysluvun perusteella.
                            string id = enimi[0].ToString() + snimi[0].ToString() + luku.ToString("000");

                            //foreach silmukka jossa käydään läpi kaikki oppilaat listan oppilaat
                            foreach (var item in oppilaat)
                            {
                                // tarkistetaan, että kyseistä opiskelijatunnusta käytössä (ei pitäisi koskaan olla tässä ohjelmassa)
                                if (item.AsioID == id)
                                {
                                    // jos kuitenkin opiskelijatunnus on käytössä, ei uutta opiskelijaa lisätä järjestelmään
                                    Console.WriteLine("Opiskelijan lisääminen epäonnistui, kyseinen AsioId on jo käytössä");
                                    testi = 1;
                                    break;
                                }
                            }
                            // jo opiskelijatunnus on vapaana, kyseinen opiskelija lisätään järjestelmään
                            if (testi == 0)
                            {
                                //luodaan Student olio käyttäjän syöttämillä tiedoilla ja lisätään se oppilaat listaan.
                                Student student = new Student() { Etunimi = enimi, Sukunimi = snimi, AsioID = id, Ryhmä = ryhmät };
                                oppilaat.Add(student);
                            }
                            testi = 0;
                            Console.WriteLine($"{enimi} {snimi} lisätty järjestelmään onnistuneesti. Miniasiossa on nyt {oppilaat.Count()} opiskelijaa");
                            break;
                        case 3:
                            //kysytään käyttäjältä poistettavan oppilaan asioid, ja tallennetaan se muuttujaan
                            Console.WriteLine("Anna opiskelijan AsioID: ");
                            string asioid = Console.ReadLine();
                            int luku2 = 1;
                            //käydään oppilaat lista läpi foreach silmukassa
                            foreach (var item in oppilaat)
                            {
                                if (item.AsioID == asioid)
                                {
                                    //jos asioid löytyy, kyseinen oppilas poistetaan järjestelmästä.
                                    oppilaat.Remove(item);
                                    Console.WriteLine($"{item.Etunimi} {item.Sukunimi} poistettu järjestelmästä onnistuneesti. Miniasiossa on nyt {oppilaat.Count()} opiskelijaa");
                                    break;
                                }
                                else if(luku2 == oppilaat.Count())
                                {
                                    //jos asioidtä ei löydy, tulostetaan käyttäjälle ilmoitus.
                                    Console.WriteLine("Kyseisellä Opiskelijatunnuksella ei löytynyt opiskelijaa");
                                }
                                luku2 += 1;
                            }

                            break;

                    }
                }
                //käsitellään poikkeus, jos käyttäjä lisää valintarakenteeseen jonkun muun, kuin vaihtoehtoihin on annettu
                catch (FormatException)
                {
                    Console.WriteLine("Syötä sopiva valinta!");
                }
            }
        }
    }
}

