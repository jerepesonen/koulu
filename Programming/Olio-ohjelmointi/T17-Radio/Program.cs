using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17_Radio
{
    class Radio
    {
        private readonly int MaxVolume = 10;
        private readonly int MinVolume = 0;
        private readonly float MaxFreq = 26000;
        private readonly float MinFreq = 2000;
        public float frequency = 20000;
        public bool Power { get; set; }
        public int Volume { get; set; }
        public float Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
            }
        }

        public string ChangeVol(int vol)
        {
            if (Power == false)
            {
                return "Kytke radio päälle ensin";  // palautus jos radio on pois päältä
            }
            else if (vol < MinVolume)
            {
                Volume = MinVolume; // jos käyttäjä asettaa äänen pienemmäksi, kuin sallittu, asetetaan äänenvoimakkuudeksi 0
                return "Liian pieni äänenvoimakkuus\nÄänenvoimakkuudeksi asetettu: " + Volume; // palautus
            }
            else if (vol > MaxVolume)
            {
                Volume = MaxVolume;// jos käyttäjä asettaa äänen suuremmaksi, kuin sallittu, asetetaan äänenvoimakkuudeksi 10
                return "Liian suuri äänenvoimakkuus\nÄänenvoimakkuudeksi asetettu: " + Volume;
            }
            else
            {
                Volume = vol;
                return null;
            }
        }
        public string ChangeFreq(float freq)
        {
            if (Power == false)
            {
                return "Kytke radio päälle ensin";  // palautus jos radio on pois päältä
            }
            else if (freq < MinFreq)
            {
                Frequency = MinFreq; // jos käyttäjä asettaa taajuuden pienemmäksi, kuin sallittu, asetetaan taajuudeksi 2000
                return "Liian pieni taajuus\nTaajuudeksi asetettu: " + Frequency;
            }
            else if (freq > MaxFreq)
            {
                Frequency = MaxFreq; // jos käyttäjä asettaa taajuuden pienemmäksi, kuin sallittu, asetetaan taajuudeksi 26000
                return "Liian suuri taajuus\nTaajuudeksi asetettu: " + Frequency;
            }
            else
            {
                Frequency = freq;
                return null;
            }
        }
        public override string ToString()
        {
            if (Power == false)
            {
                return "Kytke radio päälle ensin"; // palautus jos radio on pois päältä
            }
            else
                return $"\nÄänenvoimakkuus: {Volume}\nTaajuus: {Frequency}\n"; // palautetaan Radio luokan tiedot
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(); // luodaan uusi olio
            int option = 0;
            Console.WriteLine("--Radio--");
            while (true)
            {
            Console.WriteLine("\n1. Virtanäppäin\n2. Äänenvoimakkuus\n3. Taajuus\n4. Tiedot\n"); // valikko
            int caseSwitch = Convert.ToInt32(Console.ReadLine()); // 

                switch (caseSwitch)
                {
                    case 1:
                        radio.Power ^= true; //vaihdetaan radion boolean arvoa
                        Console.WriteLine("Radion virta: " + radio.Power); // tulostetaan radion tila
                        break;
                    case 2:
                        Console.WriteLine("Syötä äänenvoimakkuus (0-10): ");
                        option = Convert.ToInt32(Console.ReadLine()); // Käyttäjä syöttää haluamansa taajuuden
                        Console.WriteLine(radio.ChangeVol(option)); // kutsutaan ChangeVol metodia
                        break;
                    case 3:
                        Console.WriteLine("Syötä taajuus (2000.0 - 26000.0): ");
                        option = Convert.ToInt32(Console.ReadLine()); // Käyttäjä syöttää haluamansa taajuuden
                        Console.WriteLine(radio.ChangeFreq(option)); // kutsutaan ChangeFreq metodia
                        break;
                    case 4:
                        Console.WriteLine(radio.ToString());
                        break;
                }
            }
        }
    }
}
