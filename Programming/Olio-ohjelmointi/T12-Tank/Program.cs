using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_Tank
{
    class Tank
    {
        //ominaisuudet
        private readonly float SpeedMax = 100;
        public string Name { get; set; }
        public string Type { get; set; }
        private int crewnumber = 4;
        public int CrewNumber
        {
            get
            {
                return crewnumber;
            }
            set
            {
                if (value <= 6 & value >= 2)
                    crewnumber = value;
            }
        }
        private float speed;
        public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
                if (value <= SpeedMax & value >= 0)
                    speed = value;
                else
                    speed = 0;
        }
    }


        //konstruktorit
        public Tank(string name, string type, float speed)
        {
            Name = name;
            Type = type;
            Speed = speed;

        }
        // metodit
        public float AccelerateTo(float x) // kiihdytetään
        {
            if (speed + x <= SpeedMax) // jos speed + x on pienempi tai yhtäsuuri kuin max speed, speed = x, jos ei speediin ei muutosta
                speed = speed + x;
            
            return speed; // palautus


        }
        public float SlowTo(float x) // hidastetaan
        {
            if (speed - x > 0) // jos x on isompi kuin 0, speed on x, jos ei speediin ei muutosta
                speed = speed - x;
            else
                speed = 0;
            return speed; // palautus

        }
        public string Showinfo()
        {
            return ("\nName: " + Name + "\nType: " + Type + "\nSpeed: " + Speed + "\nCrew count: " + CrewNumber); //palautetaan kaikki olion ominaisuuksien arvot
        }
    }
    class TestTank
    {
        static void Main(string[] args)
        {
            Tank tank1 = new Tank("Pasi", "Miehistönkuljetusvaunu", -30); // luodaan uusi olio tank1, ja sen alkuominaisuudet
            tank1.CrewNumber = 6;
            for (int i = 0; i < 3; i++)// kiihdytetään kolme kertaa
            {
                tank1.AccelerateTo(10); // 10 km/h kerrallaan
                Console.WriteLine("Tankki kulkee nyt " + tank1.Speed);
            }
            for (int i = 0; i < 5; i++) // jarrutetaan kolme kertaa
            {
                tank1.SlowTo(10); // 10 km/h kerrallaan
                Console.WriteLine("Tankki kulkee nyt " + tank1.Speed);
            }
            Console.WriteLine(tank1.Showinfo());
            Console.ReadLine();
            
        }
    }
}
