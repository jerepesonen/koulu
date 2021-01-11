using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_Opiskelija
{
    class Student
    {
        //ominaisuudet
        public string Name { get; set; }
        public string Class { get; set; }
        public int Credits { get; set; }

        //konstruktorit
        public Student(string name, string class1, int credits)
        {
            Name = name;
            Class = class1;
            Credits = credits;
        }
        // metodit
        public string Showinfo()
        {
            return ("\nName: " + Name + "\nClass: " + Class + "\nCredits: " + Credits); //palautetaan kaikki olion ominaisuuksien arvot
        }
        public int Morecredits(int x)
        {
            Credits = Credits + x; // lisätään oliolle x määrä opintopisteitä´.
            return Credits; // palautetaan uusi opintopistemäärä
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Matti Meikäläinen", "TTV18S1", 90); // luodaan uusi olio student1, ja asetetaan sille alkuominaisuudet
            Student student2 = new Student("Teppo Teikäläinen", "TTV18S4", 74); // luodaan uusi olio student2, ja asetetaan sille alkuominaisuudet
            Student student3 = new Student("Teemu Pukki", "TTV17S1", 150); // luodaan uusi olio student3, ja asetetaan sille alkuominaisuudet
            Student student4 = new Student("Joona Penttinen", "TTV15S5", 0); // luodaan uusi olio student4, ja asetetaan sille alkuominaisuudet
            Student student5 = new Student("Matti Korhonen", "TTV19S3", 28); // luodaan uusi olio student5, ja asetetaan sille alkuominaisuudet

            Student[] students = new Student[5]; //Luodaan students lista
            // lisätään opiskelijat students listaan
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            students[3] = student4;
            students[4] = student5;

            students[0].Morecredits(5); // kutsuu Morecredits metodia parametrilla

            student2.Morecredits(10); // kutsuu Morecredits metodia parametrilla

            foreach (Student x in students) // selaa läpi kaikki muistipaikat students listasta
            {
                Console.WriteLine(x.Showinfo());// tulostetaan students listan olioiden tiedot foreach loopilla kutsumalla showinfo metodia.
            }

            Console.ReadLine();
        }
    }
}
