using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Employee employee1 = new Employee(); // luodaan uusi olio Employee luokkaat, ja sille tiedot
            employee1.Name = "Kirsi Kernel";
            employee1.Profession = "Teacher";
            employee1.Salary = 2500F;

            Employee employee2 = new Employee();// luodaan uusi olio Employee luokkaat, ja sille tiedot
            employee2.Name = "Kimmo Koodari";
            employee2.Profession = "Programmer";
            employee2.Salary = 2800F;

            Boss boss = new Boss(){ Name = "Jussi Jurkka", Profession = "Head of Institute", Salary = 3900F, Bonus = 100F, Car = "Volvo"};// luodaan uusi olio Boss luokkaat, ja sille tiedot
            List<Employee> staff = new List<Employee>();

            staff.Add(employee1); //Lisätään listaan employee1
            staff.Add(employee2);//Lisätään listaan employee2
            staff.Add(boss); //Lisätään listaan boss

            float palkat = 0;

            foreach (var item in staff) // käydään foreach loopilla kaikki listan muistipaikat läpi
            {
                Console.WriteLine(item.ToString()); // kutsutaan kaikilla listan olioila ToString metodia
                palkat = palkat + item.Salary;
                // jos boss olio, niin lasketaan myös bonus
                if (item is Boss)
                {
                    Boss b = (Boss)item;
                    palkat += b.Bonus;
                }
            }

            Console.WriteLine(palkat + "€");

            Console.ReadLine();


            
        }
    }
}
