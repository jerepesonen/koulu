using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Kortit
{
    class Card
    {
        //ominaisuudet
        public string CardValue { get; set; }
        public string CardSuit  { get; set; }
    }
    class CardDeck
    {
        //ominaisuudet mm.lista korteista
        public List<Card> kortit { get; set; }
        //konstruktori
        public CardDeck()
        {
            kortit = new List<Card>();
        }
        //Metodit
        public void ShuffleDeck()
        {
            //sekoitetaan kortit satunnaiseen järjestykseen
            kortit = kortit.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan korttipakka olio
            CardDeck korttipakka = new CardDeck();
            //luodaan array jossa kaikki kuva-arvot
            string[] kuvat = { "J", "Q", "K", "A" };

            //tehdään kortti oliot 2-10 ja lisätään ne korttipakka olion listaan
            for (int i = 2; i < 11; i++)
            {
                Card newcard = new Card() { CardValue = i.ToString(), CardSuit = "Club" };
                korttipakka.kortit.Add(newcard);
                Card newcard1 = new Card() { CardValue = i.ToString(), CardSuit = "Spade" };
                korttipakka.kortit.Add(newcard1);
                Card newcard2 = new Card() { CardValue = i.ToString(), CardSuit = "Heart" };
                korttipakka.kortit.Add(newcard2);
                Card newcard3 = new Card() { CardValue = i.ToString(), CardSuit = "Diamond" };
                korttipakka.kortit.Add(newcard3);
            }
            //tehdään kortti oliot J-A ja lisätään ne korttipakka olion listaan
            foreach (string var in kuvat)
            {
                Card newcard = new Card() { CardValue = var, CardSuit = "Club" };
                korttipakka.kortit.Add(newcard);
                Card newcard1 = new Card() { CardValue = var, CardSuit = "Spade" };
                korttipakka.kortit.Add(newcard1);
                Card newcard2 = new Card() { CardValue = var, CardSuit = "Heart" };
                korttipakka.kortit.Add(newcard2);
                Card newcard3 = new Card() { CardValue = var, CardSuit = "Diamond" };
                korttipakka.kortit.Add(newcard3);
            }
            //kutsutaan korttipakan sekoitus methodia
            korttipakka.ShuffleDeck();

            // tulostetaan kortit foreachloopilla
            foreach (var item in korttipakka.kortit)
            {
                Console.WriteLine(item.CardValue + " of " + item.CardSuit + "'s"); 
            }
            Console.WriteLine(korttipakka.kortit.Count());
            Console.ReadLine();


        }
    }
}
