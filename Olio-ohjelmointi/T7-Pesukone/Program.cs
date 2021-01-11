using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_Pesukone
{
    class Pesukone // kiuas luokka
    {
        // ominaisuudet
        public bool Power { get; set; }
        public int Temp { get; set; }
        public bool Color { get; set; }
        public int Len { get; set; }

        //konstruktori
        public Pesukone(bool PowerStatus, int Temperature, bool ChangeColor, int Length)
        {
            Power = PowerStatus;
            Temp = Temperature;
            Color = ChangeColor;
            Len = Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan uusi olio
            Pesukone kone = new Pesukone(false, 40, false, 60);

            //muuttujat
            int caseSwitch = 2;
            int loppu = 0;
            Console.WriteLine("--- Pesukone ---\n");

            while (loppu != 1)
            {
                // tulostetaan koneen nykytila.
                Console.WriteLine("\nVirta: {0}\n" + "Väri pesu: {1}\n" + "Veden lämpötila on: {2}\n" + "Ohjelman pituus: {3} min\n", kone.Power, kone.Color, kone.Temp, kone.Len);

                // tulostetaan valikko ja kysytään käyttäjältä valinta
                Console.WriteLine("Valikko\n1. Käynnistä pesukone\n2. Sammuta pesukone\n3. Väripesu\n4. Pesu lämpötila\n5. Ohjelman pituus\n6. Lopeta\n");
                caseSwitch = Convert.ToInt32(Console.ReadLine());


                switch (caseSwitch)
                {
                    case 1:
                        kone.Power = true; // kytketään pesukone "päälle" boolean arvolla
                        break;
                    case 2:
                        kone.Power = false;// kytketään pesukone " pois päältä" boolean arvolla
                        break;
                    case 3:
                        // kysytään switch metodilla haluaako käyttäjä väripesun vai ei
                        int caseSwitch2 = 0;
                        Console.WriteLine("\n1. Kyllä\n2. Ei\n ");
                        caseSwitch2 = Convert.ToInt32(Console.ReadLine());
                        switch (caseSwitch2)
                        {
                            case 1:
                                kone.Color = true; // kyllä väripesu
                                break;
                            case 2:
                                kone.Color = false;// ei väripesua
                                break;

                        }
                        break;
                    case 4:
                        Console.WriteLine("Syötä Pesun lämpötila: "); // kysytään haluttu pesulämpötila
                        kone.Temp = Convert.ToInt32(Console.ReadLine()); // asetetaan pesulämpötila
                        break;
                    case 5:
                        Console.WriteLine("Syötä ohjelman pituus: "); // kysytään haluttu ohjelman pituus
                        kone.Len = Convert.ToInt32(Console.ReadLine()); // asetetaan ohjelman pituus
                        break;
                    case 6:
                        loppu = 1; // while looppi loppuu jos loppu == 1
                        break;
                }
            }
        }
    }
}
