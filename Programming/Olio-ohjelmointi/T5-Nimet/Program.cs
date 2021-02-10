using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Nimet
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan nimi-muuttuja, ja lista johon nimet lisätään.
            string nimi;
            List<string> nimet = new List<string>();
        
            while(true)
            {
                Console.Write("Give name: "); //Kysytään käyttäjältä nimi
                nimi = Console.ReadLine();
                if (nimi != "") // Tutkitaan onko syöte tyhjä
                    {
                    nimet.Add(nimi); // Jos syöte ei ole tyhjä, se lisätään nimet listaan
                    }
                else // Jos syöte on tyhjä, while looppi keskeytetään
                {
                    break;
                }
            }
            foreach (var y in nimet) // Tulostetaan listan nimet yksi kerrallaan
            {
                Console.WriteLine(y);
                
            }
            Console.WriteLine("Name count: " + nimet.Count.ToString()); //Tulostetaan nimien lukumäärä
            Console.ReadLine();
        }
    }
}
