using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T35_Laskutoimituksia
{
    public static class ArrayCals //luokka, johon tehään lasku metodit
    {
        //metodit
        public static double Sum(double[] array) // summa metodi
        {
            double e = 0; // alustetaan muuttuja e nollaksi

            for (int i = 0; i < array.Length; i++) //käydään metodille tuotu array läpi for silmukassa
            {
                e += array[i]; // summataan arrayn jokaisen alkion luku e:hen
            }
            return Math.Round(e, 2); // palautetaan lopputulos e kahden desimaalin tarkkuudella.
        }

        public static double Average(double[] array)
        {
            double e = 0; // alustetaan muuttuja e nollaksi

            for (int i = 0; i < array.Length; i++) //käydään metodille tuotu array läpi for silmukassa
            {
                e += array[i]; // summataan arrayn jokaisen alkion luku e:hen
            }
            e = e / array.Length; // jaetaan alkioiden lukujen summa alkioden määrällä ja tallennetaan se e muuttujaan
            return Math.Round(e, 2); // palautetaan lopputulos e kahden desimaalin tarkkuudella.
        }
        public static double Min(double[] array)
        {
            double e = 0; // alustetaan muuttuja e 
            for (int i = 0; i < array.Length - 1; i++)//käydään metodille tuotu array läpi for silmukassa
            {
                if (array[i] < array[i + 1]) // tutkitaan onko arrayn muistipaikan i luku pienempi kuin muistipaikan i+1 luku
                {
                    e = array[i]; // jos on, asetetaan muistipaikan i luku muuttujaan e
                }
            }
            return Math.Round(e, 2); // lopuksi palautetaan muuttuja e kahden desimaalin tarkkuudella
        }
        public static double Max(double[] array)
        {
            double e = 0;// alustetaan muuttuja e 
            for (int i = 0; i < array.Length - 1; i++) //käydään metodille tuotu array läpi for silmukassa
            {
                if (array[i] < array[i + 1])// tutkitaan onko arrayn muistipaikan i luku pienempi kuin muistipaikan i+1 luku
                {
                    e = array[i + 1];// jos on, asetetaan muistipaikan i+1 luku muuttujaan e
                }
            }
            return Math.Round(e, 2);// lopuksi palautetaan muuttuja e kahden desimaalin tarkkuudella

        }
        public class Program
        {
            static void Main(string[] args)
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; // luodaan array: array

                //kutsutaan ArrayCals luokan eri metodeja parametrilla array, ja tulostetaan vastaukset.
                Console.WriteLine("Sum: " + ArrayCals.Sum(array));
                Console.WriteLine("Average: " + ArrayCals.Average(array));
                Console.WriteLine("Min: " + ArrayCals.Min(array));
                Console.WriteLine("Max: " + ArrayCals.Max(array));
                Console.ReadLine();
            }
        }
    }
}
