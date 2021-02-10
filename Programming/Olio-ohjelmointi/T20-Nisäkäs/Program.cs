using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T20_Nisäkäs
{
    abstract class Nisakas
    {
        // abstractit ominaisuudet
        public abstract int Age { get; set; }

        // abstracti metodi
        public abstract string Liiku();

    }
    class Ihminen : Nisakas
    {
        // ominaisuudet
        public string Name { get; set; }
        public override int Age { get; set; }
        public int Height { get; set; }
        public float Weight { get; set; }
        //metodit

        public void Kasva()
        {
            Age++; // kasvatetään ikää yhdellä
        }
        public override string Liiku()
        {
            return "Liikun"; // palautus
        }
        public override string ToString()
        {
            return $"\nIhminen nimeltä {Name}, Ikä: {Age}, Pituus: {Height}"; //Palautetaan ihmisen tiedot
        }
    }
    class Aikuinen : Ihminen
    {
        //ominaisuudet
        public string Car { get; set; }

        //metodit
        public override string Liiku()
        {
            return "Kävelee"; //Palautus
        }
        public override string ToString()
        {
            return base.ToString() + $" Auto: {Car}"; // palautetaan aikuisen tiedot
        }
    }
    class Vauva : Ihminen
    {
        //ominaisuudet
        public string Diaper;
        public override string Liiku()
        {
            return "Konttaa";// palautus
        }
        public override string ToString()
        {
            return base.ToString() + $" Vaippa: {Diaper}"; // palautetaan vauvan tiedot
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan olio ihminen
            Ihminen ihminen = new Ihminen();
            ihminen.Name = "Jack";
            ihminen.Age = 20;
            ihminen.Height = 190;
            // testantaan ihmisen ominaisuuksia
            ihminen.Kasva();
            Console.WriteLine(ihminen.ToString());
            Console.WriteLine(ihminen.Liiku());

            //luodaan olio aikuinen
            Aikuinen aikuinen = new Aikuinen() { Name = "Arska", Height = 175, Age = 30, Car = "Volvo" };
            // testataan aikuisen ominaisuuksia
            aikuinen.Kasva();

            Console.WriteLine(aikuinen.ToString());
            Console.WriteLine(aikuinen.Liiku());

            //luodaan olio vauva
            Vauva vauva = new Vauva() { Name = "Jaska", Height = 40, Age = 0, Diaper = "Pampers" };
            //Testataan vauvan ominaisuuksia
            vauva.Kasva();
            Console.WriteLine(vauva.ToString());
            Console.WriteLine(vauva.Liiku());

            List<Ihminen> ihmiset = new List<Ihminen>();
            ihmiset.Add(ihminen);
            ihmiset.Add(aikuinen);
            ihmiset.Add(vauva);

            Console.WriteLine("\n");

            foreach (var y in ihmiset)
            {
                Console.WriteLine($"{y.Name}, {y.Liiku()}");
                if (y is Aikuinen)
                {
                    Aikuinen apu = (Aikuinen)y;
                    Console.WriteLine($"ja välillä ajaa {apu.Car}lla");
                
                }
            }

            Console.ReadLine();
        }
    }
}
