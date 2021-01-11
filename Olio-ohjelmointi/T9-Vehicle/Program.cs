using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_Vehicle
{
    class Vehicle
    {
        //ominaisuudet
        public string Branch { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //konstruktorit
        public Vehicle(string branchname, string modelname, int speednum, int tyrecount)
        {
            Branch = branchname;
            Model = modelname;
            Speed = speednum;
            Tyres = tyrecount;
        }
        // metodit
        public string Showinfo()
        {
            return ("\nBranch: " + Branch + "\nModel: " + Model + "\nSpeed: " + Speed + "\nTyres: " + Tyres); //palautetaan kaikki olion ominaisuuksien arvot
        }
        public string ToString()
        {
            return ("\nBranch: " + Branch + "\nModel: " + Model); // palautetaan olion branch ja model
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle("Car", "Volvo", 140, 4); // luodaan uusi olio car1, ja sen alkuominaisuudet
            Vehicle bike1 = new Vehicle("Bicycle", "Trek", 40, 2); // luodaan uusi olio bike1, ja sen alkuominaisuudet
            car1.Speed = 150; // muutetaan car1 olion nopeutta
            bike1.Model = "Helkama"; // muutetaan bike1 olion mallia
            Console.WriteLine(car1.Showinfo()); // tulostetaan car1 olion Showinfo metodin palauttama merkkijono
            Console.WriteLine(car1.ToString()); // tulostetaan car1 olion ToString metodin palauttama merkkijono
            Console.WriteLine(bike1.Showinfo()); // tulostetaan bike1 olion Showinfo metodin palauttama merkkijono
            Console.WriteLine(bike1.ToString()); // tulostetaan bike1 olion ToString metodin palauttama merkkijono
            Console.ReadLine();
        }
    }
}
