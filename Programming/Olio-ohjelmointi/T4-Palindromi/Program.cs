using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Palindromi
{
    class Program
    {
        static void Main(string[] args)
        {
            // muuttujat
            string pal;
            // kysytään käyttäjältä merkkijono
            Console.Write("Give string: ");
            pal = Console.ReadLine();
            //Kutsutaan aliohjelmaa joka tutkii onko merkkijono palindromi ja palauttaa boolenanin
            Boolean palind = ali(pal);
            //jos boolean palind = true, tulostetaan että merkkijono on palindromi
            if (palind == true)
            {
                Console.WriteLine("Is palindrom");
                Console.ReadLine();
            }
            else
            { 
                Console.WriteLine("Is not palindrom");
                Console.ReadLine();
            }
        }
        public static Boolean ali(string pal)
        {
            //muuttujat
            Boolean maybe = true;
            string pal2 = pal;
            int luku = pal.Length-1;
            int x = 0;

            while(luku != 0)
                {
                //tutkitaan vastaako merkkijonon x-paikan merkki luku-paikan merkkiä
                if (pal[x] != pal2[luku])
                    {
                    // jos ei vastaa, niin pääohjelmalle palautetaan boolean false  
                    return (false);
                    }
                //muuttuja x kasvaa, ja muuttuja 1 pienenee yhdellä. merkkijonon tutkiminen jatkuu kunnes luku = 0
                luku = luku - 1;
                x = x + 1;
                }
            //jos luku pääsee nollaan, on merkkijono palindromi, ja palautetaan boolean true
            return maybe;
        }
    }
}
