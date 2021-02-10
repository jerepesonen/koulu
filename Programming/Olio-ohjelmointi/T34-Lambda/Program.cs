using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization; 
using System.Runtime.Serialization.Formatters.Binary;


namespace T34_Lambda
{
    class Friend // friend luokka
    {
        // ominaisuudet
        public string Name { get; set; }
        public string Email { get; set; }
        //konstruktorit
        public Friend() { }
        public Friend(string name, string email)
        {
            Name = name;
            Email = email;
        }
        //Metodit
        public override string ToString()
        {
            return $"{Name}, {Email}"; // palauttaa ystävän nimen ja sähköpostiosoitteen
        }

    }
    static class MailBook
    {
        //ominaisuudet
        public static List<Friend> frendit { get; set; }
        //konstruktori
        static MailBook()
        {
            frendit = new List<Friend>();
        }

        public static string GetMailBook() // metodi hakee nimet tiedostosta, ja tallentaa ne oliohoin.
        {
            string erotin = ";"; //CSV:ssä sanat on eroteltu toisistaan puolipisteellä
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Mailbook.csv"; //tallennetaan tiedoston nimi ja sijainti muuttujaan filename
            string[] lines = File.ReadAllLines(filename); // tallennetaan tiedoston tiedot arrayhyn
            foreach (string item in lines)
            {
                string[] words = item.Split(erotin.ToCharArray()); // splitataan tiedoston stringit erotin merkilä
                Friend friend = new Friend(words[0], words[1]); // luodaan uusi olio, tiedoston tiedoista
                frendit.Add(friend); // lisätään olio listaan
            }
            return $"Osoitekirjassa on {frendit.Count()} nimeä";// palautetaan osoitekirjan nimien määrä
        }
        public static string AddFriend(string etunimi, string sukunimi)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Mailbook.csv"; //tallennetaan tiedoston nimi ja sijainti muuttujaan filename
            string nimi = etunimi + " " + sukunimi + ";" + etunimi + "@" + sukunimi + ".com"; // tehdään stringi, jossa splitataan erottimella nimi ja sposti
            File.AppendAllText(filename, nimi.ToString()); // lisätään uusi nimi fileen append metodilla.
            return $"{etunimi} {sukunimi} lisätty onnistuneesti osoitekirjaan"; // palautus
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(MailBook.GetMailBook()); // kutsutaan GetMailBook metodia

                MailBook.frendit.ForEach(x => Console.WriteLine(x.Name)); // tulostetaan ystävien nimet lambda funktiolla

                Console.WriteLine("\nAnna haettavan tutun nimi tai sen osa: "); // kysytään käyttäjältä  ystävän nimi, tai sen osa ja tallennetaan se muuttujaan
                string nimi = Console.ReadLine();
                var nimet = MailBook.frendit.Where(x => x.Name.ToUpper().Contains(nimi.ToUpper())).ToList(); // verrataan lambda funktiolla, että löytyykö haettua ystävää, tai sen nimen osaa mailbook listasta.
                nimet.ForEach(x => Console.WriteLine(x.Name)); //tulostetaan löydetyt nimet

                Console.WriteLine("\nLisää kaveri!"); // kysytään käyttäjältä lisättävän kaverin etu ja sukunimi, ja tallennetaan ne muuttujiin
                Console.WriteLine("Anna kaverin etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna kaverin sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine(MailBook.AddFriend(etunimi, sukunimi)); // kutsutaan AddFriend Metodia nimi parametreilla
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löytynyt");
            }
            catch (IOException)
                {
                Console.WriteLine("Tiedosto on auki jossain toisessa ohjelmassa");
                }
            finally
            {
                Console.ReadLine();
            }

        }
    }

}