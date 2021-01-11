using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16_Vehicles
{
    class Vehicle
    {
        // ominaisuudet
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        //Metodi
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Model Year: {ModelYear}, Color: {Color}"; // palautetaan Vehicle luokan tiedot
        }

    }
    class Bike : Vehicle
    {
        // ominaisuudet
        public bool GearWheels { get; set; }
        public string GearName { get; set; }
        //metodi
        public override string ToString()
        {
            return "Bike info\n- " + base.ToString() + $", Gear Wheels: {GearWheels}, Gear Name: {GearName}"; // palautetaan Bike luokan tiedot
        }
    }
    class Boat : Vehicle
    {
        //ominaisuudet
        public string Type { get; set; }
        public int SeatCount { get; set; }
        // metodi
        public override string ToString()
        {
            return "Boat info\n- " + base.ToString() + $", Boat Type: {Type},Seat Count: {SeatCount}"; // palautetaan Boat luokan tiedot
        }
    }
}
