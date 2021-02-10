using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Mäkihyppy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muuttujat
            int points1 = 0;
            int points2 = 0;
            int points3 = 0;
            int points4 = 0;
            int points5 = 0;
            int lowest = 0;
            int highest = 0;
            int result = 0;
            string input;

            // Kysytään käyttäjältä pistemäärä
            Console.Write("Give points: ");
            input = Console.ReadLine();
            // Muutetaan string intiksi
            points1 = int.Parse(input);

            // Kysytään käyttäjältä pistemäärä
            Console.Write("Give points: ");
            input = Console.ReadLine();
            // Muutetaan string intiksi
            points2 = int.Parse(input);

            // Vertaillaan kahta ensimmäistä numeroa
            if (points1 <= points2)
            {
                lowest = points1;
                highest = points2;
            }
            else
            {
                lowest = points2;
                highest = points1;
            }

            // Kysytään käyttäjältä pistemäärä
            Console.Write("Give points: ");
            input = Console.ReadLine();
            // Muutetaan string intiksi
            points3 = int.Parse(input);

            // Vertaillaan seuraavaa numeroa isoimpaan ja pienimpään
            if (points3 < lowest)
            {
                lowest = points3;
            }
            else if (points3 > highest)
            {
                highest = points3;
            }

            // Kysytään käyttäjältä pistemäärä
            Console.Write("Give points: ");
            input = Console.ReadLine();
            // Muutetaan string intiksi
            points4 = int.Parse(input);

            // Vertaillaan seuraavaa numeroa isoimpaan ja pienimpään
            if (points4 < lowest)
            {
                lowest = points4;
            }
            else if (points4 > highest)
            {
                highest = points4;
            }

            // Kysytään käyttäjältä pistemäärä
            Console.Write("Give points: ");
            input = Console.ReadLine();
            // Muutetaan string intiksi
            points5 = int.Parse(input);

            // Vertaillaan seuraavaa numeroa isoimpaan ja pienimpään
            if (points5 < lowest)
            {
                lowest = points5;
            }
            else if (points5 > highest)
            {
                highest = points5;
            }

            //Tehdään laskutoimitus
            result = points1 + points2 + points3 + points4 + points5 - highest - lowest;
            
            //Tulostetaan lopputulos
            Console.Write("Total points: " + result.ToString() + "\n");
        }
    }
}
