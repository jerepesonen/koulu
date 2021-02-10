using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_Amplifier
{
    class Amplifier
    {
        // ominaisuudet
        private readonly int MaxVolume = 100;
        private readonly int MinVolume = 0;
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
        }
        //metodit
        public string ChangeVol(int vol)
        {
            //muutetaan äänenvoimakkuutta, mutta vain välillä 0 ja 100
            if (vol > MaxVolume) // jos äänenvoimakkuudeksi yritetään asetaa enemmän kuin 100
            {
                volume = MaxVolume; // volumeksi asetetaan 100
                return "Too much volume - Amplifier volume is set to maximum: " + MaxVolume; // palautus
            }
            else if (vol < MinVolume)// jos äänenvoimakkuudeksi yritetään asetaa vähemmän kuin 0
            {
                volume = MinVolume; // volumeksi asetetaan 0
                return "Too low volume - Amplifier volume is set to minimum: " + MinVolume; // palautus
            }
            else
            {
                volume = vol; // muussa tapauksessa volumeksi asetetaan käyttäjän syöttämän luku
                return null; // palautetaan tyhjä
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // luodaan olio amplifier
            Amplifier amplifier = new Amplifier();
            while (true) // loputon ehile looppi
            {
                Console.WriteLine("Amplifier volume is set to: {0}", amplifier.Volume); // tulostetaan nykyinen äänenvoimakkuus
                Console.WriteLine("Give new volume value (0-100):"); // kysytään käyttäjältä uusi äänenvoimakkuus
                int option = Convert.ToInt32(Console.ReadLine()); // tallennetaan uusi äänenvoimakkuus muuttujaan option
                Console.WriteLine(amplifier.ChangeVol(option)); // kutsutaan ChangeVol metodia option arvolla
            }
        }
    }
}
