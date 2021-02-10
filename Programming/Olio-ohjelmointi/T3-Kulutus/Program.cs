using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Kulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muuttujat
            string dist;
            //Kysytään käyttäjälätä kuljettu matka
            Console.Write("Give travelled distance: ");
            dist = Console.ReadLine();
            //Muutetaan string doubleksi
            double matka = Convert.ToDouble(dist);
            //Kutsutaan aliohjelmaa, joka palauttaa listan bensan kulutuksesta ja hinnasta
            List<double> result = consuption(matka);
            //Tulostetaan bensan kulutus ja hinta parsimalla ne listasta
            Console.WriteLine("Gas consumption: " + result[0].ToString() + " l\nGas price: " + result[1].ToString()+" euros");
            Console.ReadLine();
        }
        public static List<double> consuption(double dist) 
        {
            //Lasketaan bensan kulutus ja hinta
            double distance = dist*0.075;
            double cost = distance * 1.55;
            //Luodaan lista
            List<double> mylist = new List<double>();
            //Lisätään muuttujat listaan
            mylist.Add(distance);
            mylist.Add(cost);
            //palautetaan lista
            return mylist;
        }

    }


}
