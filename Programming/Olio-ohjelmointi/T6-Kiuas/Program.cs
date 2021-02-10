using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Kiuas
{

    class Kiuas // kiuas luokka
    {
        // ominaisuudet
        public int Humidity { get; set; }
        public int Temperature { get; set; }
        public bool Power { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //luodaan olio, ja asetetaan arvot
            Kiuas kiuas = new Kiuas();
            kiuas.Power = false;
            kiuas.Temperature = 0;
            kiuas.Humidity = 0;

            //muuttujat
            int caseSwitch = 2;
            int loppu = 0;

            while (loppu != 1)
            {
                if (kiuas.Power == false)
                {
                    Console.WriteLine("\nKiuas on pois päältä!\n");
                }
                else
                {
                    Console.WriteLine("\nKiuas on päällä\n" + "Lämpötila on: {0}\n" + "Ilman kosteus on: {1}\n", kiuas.Temperature, kiuas.Humidity);
                }
                //tulostetaan valikko
                Console.WriteLine("Valikko\n1. Käynnistä kiuas\n2. Sulje kiuas\n3. Säädä lämpötilaa\n4. Säädä ilman kosteutta\n5. Lopeta\n");
                caseSwitch = Convert.ToInt32(Console.ReadLine());


                switch (caseSwitch)
                {
                    case 1:
                        kiuas.Power = true; // kytketään kiuas "päälle" boolean arvolla
                        break;
                    case 2:
                        kiuas.Power = false;// kytketään kiuas " pois päältä" boolean arvolla
                        break;
                    case 3:
                        Console.WriteLine("Syötä lämpötila: ");
                        kiuas.Temperature = Convert.ToInt32(Console.ReadLine()); // muutetaan olion Temperature arvoa
                        break;
                    case 4:
                        Console.WriteLine("Syötä kosteus;: ");
                        kiuas.Humidity = Convert.ToInt32(Console.ReadLine()); // muutetaan olion humidity arvoa
                        break;
                    case 5:
                        loppu = 1; // while looppi loppuu jos loppu == 1
                        break;
                }
            }
        }
    }
}
   

