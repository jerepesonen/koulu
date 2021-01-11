using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace T32_Random
{
    class Person
    {
        //ominaisuudet
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }

        //metodi, joka tulostaa olion  ominaisuudet
        public override string ToString()
        {
            return $"{Etunimi} {Sukunimi}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // luodaan muuttujiat
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var enimi = new char[4];
            var snimi = new char[10];
            var random = new Random();
            int kerrat = 0;
            //ajastukseen käytettävät stopwatch oliot
            Stopwatch stopWatch = new Stopwatch();
            Stopwatch stopWatch1 = new Stopwatch();
            Stopwatch stopWatch2 = new Stopwatch();
            Stopwatch stopWatch3 = new Stopwatch();
            //luodaan persons lista
            List<Person> persons = new List<Person>();

            stopWatch.Start();
            //for silmukka, joka luo 10 000 Person oliota
            for (int i = 0; i < 10000; i++)
            {
                //tämä silmukka luo 4 merkkiä pitkän satunnaisen etunimen "chars" merkeistä
                for (int e = 0; e < enimi.Length; e++)
                {
                    enimi[e] = chars[random.Next(chars.Length)]; //luodaan valitaan random merkki chareista, ja asetetaan se enimen muistipaikkaan e
                }
                //tallennetaan etunimi muuttujaan
                string etunimi = new String(enimi);

                //tämä silmukka luo 10 merkkiä pitkän satunnaisen sukunimen "chars" merkeistä
                for (int e = 0; e < snimi.Length; e++)
                {
                    snimi[e] = chars[random.Next(chars.Length)];
                }
                //tallennetaan sukunimi muuttujaan
                string sukunimi = new String(snimi);
                //Luodaan Person olio luoduista nimistä
                Person person = new Person() { Etunimi = etunimi, Sukunimi = sukunimi };
                //lisätään olio listaan person
                persons.Add(person);
            }
            stopWatch.Stop();
            //tulostetaan tiedot
            Console.WriteLine("List Collection");
            Console.WriteLine("- Adding time: " + stopWatch.ElapsedMilliseconds + " ms");
            Console.WriteLine("- Persons count: " + persons.Count());
            int index = random.Next(persons.Count());
            Console.WriteLine("- Random person: " + persons[index].ToString() + "\n");

            Console.WriteLine("Finding persons in List (by firstname):\n");
            stopWatch1.Start();
            //for solmukka, joka luo yksi kerrallaan 1000 random etunimeä, ja tarkistaa, että löytyykö sen nimistä oliota persons listasta
            for (int i = 0; i < 1000; i++)
            {
                //tämä silmukka luo 4 merkkiä pitkän satunnaisen etunimen "chars" merkeistä
                for (int e = 0; e < enimi.Length; e++)
                {
                    enimi[e] = chars[random.Next(chars.Length)]; //luodaan valitaan random merkki chareista, ja asetetaan se enimen muistipaikkaan e
                }
                string etunimi = new String(enimi);
                //Käydään persons lista läpi foreach silmukassa
                foreach (var item in persons)
                {
                    // jos listasta löytyy random nimeä vastaava olio, tulestetaan ilmoitus
                    if (etunimi == item.Etunimi)
                    {
                        Console.WriteLine($"- Found person with {etunimi} firstname: {item.ToString()}");
                        break;
                    }
                }
                kerrat += 1;
            }
            stopWatch1.Stop();
            Console.WriteLine("- Persons tried to find: " + kerrat);
            Console.WriteLine("- Total finding time: " + stopWatch.ElapsedMilliseconds + " ms");

            // luodaan dictionary
            Dictionary<string, Person> personsd = new Dictionary<string, Person>();
            stopWatch2.Start();
            //for silmukka, joka luo 10 000 Person oliota
            for (int i = 0; i < 10000; i++)
            {
                //tämä silmukka luo 4 merkkiä pitkän satunnaisen etunimen "chars" merkeistä
                for (int e = 0; e < enimi.Length; e++)
                {
                    enimi[e] = chars[random.Next(chars.Length)]; //luodaan valitaan random merkki chareista, ja asetetaan se enimen muistipaikkaan e
                }
                //lisätään etunimi muuttujaan
                string etunimi = new String(enimi);

                //tämä silmukka luo 10 merkkiä pitkän satunnaisen sukunimen "chars" merkeistä
                for (int e = 0; e < snimi.Length; e++)
                {
                    snimi[e] = chars[random.Next(chars.Length)];
                }
                //lisätään sukunimi muuttujaan
                string sukunimi = new String(snimi);
                //luodaan olio etunimen ja sukunimen perusteella
                Person person = new Person() { Etunimi = etunimi, Sukunimi = sukunimi };
                // tarkistetaan, että löytyykö dictionarystä personsd, vastaava etunimi
                if (personsd.ContainsKey(person.Etunimi))
                {
                    i--; // jos löytyy, lisätään silmukan pituutta yhdellä, jotta lopputuloksena saadaan sama 10 000 oliota
                }
                else
                {
                    personsd.Add(person.Etunimi, person); // jos etunimi ei ole käytetty, olio lisätään listaan.
                }
            }

            stopWatch2.Stop();
            Console.WriteLine("\nDictionary Collection");
            Console.WriteLine("- Adding time: " + stopWatch2.ElapsedMilliseconds + " ms");
            Console.WriteLine("- Persons count: " + personsd.Count());
            // luodaan avainlista kaikista personsd avaimista
            List<string> keyList = new List<string>(personsd.Keys);
            //haetaan random etunimi avainlistasta
            string randomKey = keyList[random.Next(keyList.Count())];
            Console.WriteLine("- Random person: " + personsd[randomKey] + "\n");
            Console.WriteLine("Finding persons in Dictionary (by firstname):\n");
            stopWatch3.Start();
            kerrat = 0;
            for (int i = 0; i < 1000; i++)
            {
                //tämä silmukka luo 4 merkkiä pitkän satunnaisen etunimen "chars" merkeistä
                for (int e = 0; e < enimi.Length; e++)
                {
                    enimi[e] = chars[random.Next(chars.Length)];//luodaan valitaan random merkki chareista, ja asetetaan se enimen muistipaikkaan e
                }
                string etunimi = new String(enimi);

                //tämä tarkistaa löytyykö etunimeä vastaava key personsd dictionarystä
                if (personsd.ContainsKey(etunimi))
                {
                    Console.WriteLine($"- Found person with {etunimi} firstname: {personsd[etunimi].ToString()}"); // jos löytyy, tulostetaan kyseisen olion tiedot.
                }
                kerrat += 1;
            }
            stopWatch3.Stop();
            Console.WriteLine("- Persons tried to find: " + kerrat);
            Console.WriteLine("- Total finding time: " + stopWatch2.ElapsedMilliseconds + " ms");
            Console.ReadLine();
        }
    }
}
