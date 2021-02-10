using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike() { Name = "Jopo", Model = "Street", ModelYear = 2020, Color = "Pink", GearWheels = false, GearName = null};// luodaan uusi olio Bike luokkaat, ja sille tiedot
            Bike bike2 = new Bike() { Name = "Tunturi", Model = "StreetPower", ModelYear = 2001, Color = "Black", GearWheels = true, GearName = "Shimano" };// luodaan uusi olio Bike luokkaat, ja sille tiedot
            Boat boat1 = new Boat() { Name = "Suvi", Model = "5900", ModelYear = 1995, Color = "White", SeatCount = 4, Type = "Rowboat" };// luodaan uusi olio Boat luokkaat, ja sille tiedot
            Boat boat2 = new Boat() { Name = "Silja Line", Model = "Europa", ModelYear = 1990, Color = "White", SeatCount = 500, Type = "Cruiseship" };// luodaan uusi olio Boat luokkaat, ja sille tiedot

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(bike1); //Lisätään listaan employee1
            vehicles.Add(bike2);//Lisätään listaan employee2
            vehicles.Add(boat1); //Lisätään listaan boss
            vehicles.Add(boat2); //Lisätään listaan boss

            foreach (var item in vehicles) // käydään foreach loopilla kaikki listan muistipaikat läpi
            {
                Console.WriteLine(item.ToString()); // kutsutaan kaikilla listan olioila ToString metodia
            }
            Console.ReadLine();
        }
    }
}
