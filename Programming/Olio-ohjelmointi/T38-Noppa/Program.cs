using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T38_Noppa
{
    class Dice
    {
        // ominaisuudet
        private Random random = new Random();
        // metodi
        public int Throw()
        {
            return random.Next(1, 7); // palautetaan random arvo väliltä 1-7
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(); // luodaan noppa olio
            List<int> results = new List<int>(); // luodaan tulos lista
            // alustetaan tarpeelliset muuttujat
            int e = 0;
            int result;

            try
            {

                Console.WriteLine("--Dice--\n");
                Console.WriteLine("One test throw value is: " + dice.Throw());
                Console.WriteLine("How many times you want to throw dice: ");
                int kerrat = Convert.ToInt32(Console.ReadLine()); // käyttäjä syöttää luvun, että kuinka monta kertaa noppaa heitetään

                for (int i = 0; i < kerrat; i++) // for silmukka pyörii käyttäjän syöttämän luvun määrän
                {
                    result = dice.Throw(); // kutsutaan Throw metodia, jonka palautus tallennetaan muuttujaan result
                    results.Add(result); // result arvo lisätään listaan results
                }
                Console.WriteLine($"Dice is now thrown {kerrat} times, Average is {results.Average()}"); // tulotetaan noppien heittojen lukumäärä, ja tulosten keskiarvo

                for (int i = 1; i < 7; i++) // for silmukka pyörii 6 kertaa
                {
                    e = 0;
                    foreach (var item in results) // foreach silmukka käy läpi listan results 
                    {
                        // tutkitaan löytyykö kyseisen listan alkiosta i muuttujan arvo.
                        if (item == i) // jos löytyy, niin kasvatetaan e muuttujaa yhdellä.
                        {
                            e += 1;
                        }
                    }
                    Console.WriteLine($"{i} count is {e}"); // kun koko lista on käyty läpi, tulostetaan e:n arvo, joka kertoo kuinka monta kyseistä silmälukua on heitetty
                }
            }

            // käsitellään poikkeus jos käyttäjä syöttää jotain muuta, kuin kokonaisluvun.
            catch(FormatException)
            {
                Console.WriteLine("You must input a number!");
            }

            Console.ReadLine();
        }
    }
}
