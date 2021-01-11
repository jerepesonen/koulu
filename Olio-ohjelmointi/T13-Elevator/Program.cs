using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_Elevator
{
    class Elevator
    {
        private readonly int MaxFloor = 5;
        private readonly int MinFloor = 1;
        public int floornumber = 1;
        public int FloorNumber
        {
            get
            {
                return floornumber;
            }
        }
        public string ChooseFloor(int floor)
        {
            if (floor > MaxFloor)
            {
                return "Floor is too big!";
            }
            else if (floor < MinFloor)
            {
                return "Floor is too small!";
            }
            else
            {
                floornumber = floor;
                return ("Going to floor " + floornumber.ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            while (true) 
            {
                Console.WriteLine("Elevator is now in floor:  {0}", elevator.FloorNumber);
                Console.WriteLine("Give a new floor number (1-5):");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(elevator.ChooseFloor(option));
            } 
        }
    }
}
