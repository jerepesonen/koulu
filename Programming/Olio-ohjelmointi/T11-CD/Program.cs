using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_CD
{
    class CD
    {
        //ominaisuudet
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        //konstruktorit
        public CD(string artist, string album, string genre, double price)
        {
            Artist = artist;
            Album = album;
            Genre = genre;
            Price = price;
            
        }

        // metodit
        public string Showinfo()
        {
            return ("\nArtist: " + Artist + "\nAlbum: " + Album + "\nGenre: " + Genre + "\nPrice: " + Price); //palautetaan kaikki olion ominaisuuksien arvot
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD("Nightwish", "Endless Forms Most Beautiful", "Symphonic metal", 19.9); // luodaan uusi olio cd1, ja asetetaan sille alkuominaisuudet
            CD cd2 = new CD("HIM", "Razorblade Romance", "Alternative Rock", 29.9); // luodaan uusi olio cd2, ja asetetaan sille alkuominaisuudet
            CD cd3 = new CD("Flume", "Hi this is Flume", "Future Bass", 39.9); // luodaan uusi olio cd3, ja asetetaan sille alkuominaisuudet


            CD[] cds = new CD[3]; //Luodaan cd:t lista
            cds[0] = cd1;
            cds[1] = cd2;
            cds[2] = cd3;

            foreach (CD y in cds) // selaa läpi kaikki muistipaikat cd  listasta
            {
            Console.WriteLine(y.Showinfo()); // tulostetaan cds listan olioiden tiedot foreach loopilla kutsumalla showinfo metodia.
            }

            Console.ReadLine();
        }
    }
}
