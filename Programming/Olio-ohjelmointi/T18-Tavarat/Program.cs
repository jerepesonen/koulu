using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18_Tavarat
{
    class Tavarat
    {
        public string Nimi { get; set; }
        public string Valmistaja { get; set; }
        public string Genre { get; set; }
        public override string ToString()
        {
            return $"\nNimi: {Nimi}, Valmistaja: {Valmistaja}, Genre: {Genre}"; //Palautetaan tavaran tiedot
        }
    }
    class Kirjat : Tavarat
    {
        public int Sivut { get; set; }
        public  string Kirjailija { get; set; }
        public override string ToString()
        {
            return "Kirja:" + base.ToString() + $", Sivumäärä: {Sivut}, Kirjailija: {Kirjailija}"; //Palautetaan Kirjan tiedot
        }
    }
    class Pelit : Tavarat
    {
        public string Konsoli { get; set; }
        public bool Moninpeli { get; set; }
        public override string ToString()
        {
            return "Peli:" + base.ToString() + $", Konsoli: {Konsoli}, Moninpeli: {Moninpeli}"; //Palautetaan Kirjan tiedot
        }
    }
    class Elokuvat : Tavarat
    {
        public string Ohjaaja { get; set; }
        public int Kesto { get; set; }
        public override string ToString()
        {
            return "Elokuva:" + base.ToString() + $", Ohjaaja: {Ohjaaja}, Kesto: {Kesto}"; //Palautetaan Kirjan tiedot
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan kirja oliot
            Kirjat kirja1 = new Kirjat() { Nimi = "Harry Potter", Valmistaja = "Tammi", Genre = "Fantasia", Kirjailija = "J.K.Rowling", Sivut = 900 };
            Kirjat kirja2 = new Kirjat() { Nimi = "Enkelit ja Demonit", Valmistaja = "WSOY", Genre = "Jännitys", Kirjailija = "Dan Brown", Sivut = 518 };
            // luodaan peli oliot
            Pelit peli1 = new Pelit() { Nimi = "Counter Strike", Valmistaja = "Valve", Genre = "Räiskintä", Konsoli = "PC", Moninpeli = true};
            Pelit peli2 = new Pelit() { Nimi = "Red Dead Redemption", Valmistaja = "Rockstar", Genre = "Seikkailu", Konsoli = "Xbox", Moninpeli = true};
            // luodaan elokuva oliot
            Elokuvat elokuva1 = new Elokuvat() { Nimi = "Inception", Valmistaja = "Warner Bros", Genre = "Scifi", Ohjaaja = "Christopher Nolan", Kesto = 120 };
            Elokuvat elokuva2 = new Elokuvat() { Nimi = "Forrest Gump", Valmistaja = "Paramount", Genre = "Draama", Ohjaaja = "Robert Zemeckis", Kesto = 140};

            // tulostetaan oliot

            List<Tavarat> tavarat = new List<Tavarat>();
            tavarat.Add(kirja1);
            tavarat.Add(kirja2);
            tavarat.Add(peli1);
            tavarat.Add(peli2);
            tavarat.Add(elokuva1);
            tavarat.Add(elokuva2);

            foreach (var item in tavarat)
            {
                Console.WriteLine(item.ToString());
            }
            //Console.WriteLine(kirja1.ToString());
            Console.ReadLine();

        }
    }
}
