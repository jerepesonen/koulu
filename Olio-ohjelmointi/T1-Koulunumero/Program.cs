using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Koulunumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muuttujat
            int points = 0;
            int grade = 0;
            string input;
            // Kysytään käyttäjältä pistemäärä
            Console.Write("Give points: ");
            input = Console.ReadLine();
            // Muutetaan string intiksi
            points = int.Parse(input);
            // Pistemäärän perusteella lasketaan arvosana
            if (points < 2)
            {
                grade = 0;
            }
            else if (points < 4)
            {
                grade = 1;
            }
            else if (points < 6)
            {
                grade = 2;
            }
            else if (points < 8)
            {
                grade = 3;
            }
            else if (points < 10)
            {
                grade = 4;
            }
            else
            {
                grade = 5;
            }
            // Tulostetaan arvosana
            Console.WriteLine("School number is " + grade.ToString());
            // Loppu
        }
    }
}
