using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_Televisio
{
    class Tv
    {
        // ominaisuudet
        public bool Power { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
        public int Brightness { get; set; }

        //konstruktori
        public Tv(bool PowerStatus, int ChannelStatus, int VolumeStatus, int BrigthStatus)
        {
            Power = PowerStatus;
            Channel = ChannelStatus;
            Volume = VolumeStatus;
            Brightness = BrigthStatus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan olio ja sille alku muuttujat
            Tv tv = new Tv(true, 1, 10, 25);

            //muuttujat
            int caseSwitch = 0;
            int loppu = 0;
            Console.WriteLine("---Televisio---");

            while (loppu != 1)
            {
                //tulostetaan valikko ja kysytään käyttäjältä valinta
                Console.WriteLine("\nValikko\n1. Sammuta Televisio\n2. Vaihda kanavaa\n3. Säädä äänenvoimakkuutta\n4. Säädä näytönkirkkautta\n5. Tiedot");
                caseSwitch = Convert.ToInt32(Console.ReadLine());


                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("\nTelevisio sammuu. ");
                        System.Threading.Thread.Sleep(2000); // odottaa 2 sekuntia
                        System.Environment.Exit(1); // ohjelma keskeytetään
                        break;
                    case 2:
                        Console.WriteLine("\nSyötä haluamasi kanava: ");
                        tv.Channel = Convert.ToInt32(Console.ReadLine());// asetetaan käyttäjän valitsema kanava
                        break;
                    case 3:
                        Console.WriteLine("\nSyötä haluamasi äänenvoimakkuus: ");
                        tv.Volume = Convert.ToInt32(Console.ReadLine()); // Asetetaan käyttäjän valitseman äänenvoimakkuus
                        break;
                    case 4:
                        Console.WriteLine("\nSyötä haluamasi näytönkirkkaus: ");
                        tv.Brightness = Convert.ToInt32(Console.ReadLine());// asetetaan käyttäjän valitsema näytönkirkkaus
                        break;
                    case 5:
                        Console.WriteLine("\nVirta: {0}\n" + "Kanava: {1}\n" + "Äänenvoimakkuus: {2}\n" + "Kirkkaus: {3}", tv.Power, tv.Channel, tv.Volume, tv.Brightness); // tulostetaan tvn nykytila
                        break;
                }
            }
        }
    }
}