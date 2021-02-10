using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_Employees
{
    class Employee
    {
        // Kantaluokan ominaisuudet
        public string Name { get; set; }
        public string Profession { get; set; }
        public float Salary { get; set; }


        //korvataan ToString-metodi omalla toteutuksella
        public override string ToString()
        {
            return $"Työntekijä: {Name}, {Profession}, {Salary}€"; // palautetaan emplyee luokan tiedot
        }



    }
    class Boss : Employee
    {
        //Perintäluokan ominaisuudet
        public string Car { get; set; }
        public float Bonus { get; set; }

        // korvataan ToString-metodi omalla toteutuksella
        public override string ToString()
        {
            return base.ToString() + $", {Bonus}€, {Car}"; // palautetaan base luokan tiedot + Bonus + Car
        }
    }

}
