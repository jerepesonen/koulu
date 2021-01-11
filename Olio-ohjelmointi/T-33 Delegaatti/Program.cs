using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_33_Delegaatti
{
    class TestDelegate // delegaatti luokka
    {
        //metodit
        public static string Upper(string merkkijono)
        {
            return merkkijono.ToUpper(); // muuttaa merkkijonon merkit isoiksi kijaimiksi
        }
        public static string Lower(string merkkijono)
        {
            return merkkijono.ToLower();// muuttaa merkkijonon merkit pieniksi kijaimiksi
        }
        public static string Head(string merkkijono)
        {
            return char.ToUpper(merkkijono[0]) + merkkijono.Substring(1); // muuttaa merkkijonon ensimmäisen merkin isoksi, ja loput pieniksi kirjaimiksi
        }
        public static string Flip(string merkkijono)
        {
            char[] arr = merkkijono.ToCharArray(); // tehdään merkkijonosta array
            Array.Reverse(arr); // käännetään array päibvastoin
            return new string(arr); // palautetaan käännety array stringinä
        }
        class Program
        {
            //delegaatin määrittely
            delegate string Toiminto(string merkkijono);
            //delegaatti muuttujat ja kiinnitetään tähän muuttujaan TestDelegaten:n antama metodi
            static Toiminto Upper = TestDelegate.Upper;
            static Toiminto Lower = TestDelegate.Lower;
            static Toiminto Head = TestDelegate.Head;
            static Toiminto Flip = TestDelegate.Flip;

            static void Main(string[] args)
            {
                Console.WriteLine("Anna käsiteltävä merkkijono"); // pyydetään käyttäjältä merkkijono
                string merkkijono = Console.ReadLine();
                int end = 0; // alustetaan end muuttuja nollaksi
                while (end == 0) // while silmukka pyörii niin kauan, kun end on 0
                {
                    Console.WriteLine("\nValitse haluamasi käsittely, voit antaa useamman käsittelyn kerralla\nyhtenä merkkijonona esim '123'\n1. Isoiksi kirjaimiksi\n2. Pieniksi kirjaimiksi \n3. Otsikoksi\n4. Palindromiksi\n5. Lopetus"); // valikko
                    string num = Console.ReadLine(); // tallennetaan käyttäjän valinta
                    if (num.Contains("1")) // jos valinta sisältää numeron 1
                    {
                        Console.WriteLine(Upper.Invoke(merkkijono)); // kutsutaan Delegaatin Upper metodia
                    }
                    if (num.Contains("2"))// jos valinta sisältää numeron 2
                    {
                        Console.WriteLine(Lower.Invoke(merkkijono)); // kutsutaan Delegaatin Lower metodia
                    }
                    if (num.Contains("3"))// jos valinta sisältää numeron 3
                    {
                        Console.WriteLine(Head.Invoke(merkkijono)); // kutsutaan Delegaatin Head metodia
                    }
                    if (num.Contains("4"))// jos valinta sisältää numeron 4
                    {
                        Console.WriteLine(Flip.Invoke(merkkijono)); // kutsutaan Delegaatin Flip metodia
                    }
                    if (num.Contains("5"))// jos valinta sisältää numeron 5
                    {
                        end = 1; // asetetaan end muuttujaksi 1, jolloin while silmukka pysähtyy
                        Console.WriteLine("Ohjelma keskeytetään");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
