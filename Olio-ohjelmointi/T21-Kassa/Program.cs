using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Kassa
{
    public interface ITransaction
    {
        // interface members 
        string ShowTransaction();
        float GetAmount();
    }
    public class PaidWithCash : ITransaction
    {
        public float Cash { get; set; }
        public float GetAmount()
        {
            return Cash;
        }

        public string ShowTransaction()
        {
            return $"Paid with Cash, billnumber: {0}, Date = {1}, Amount: {2}";
        }
 /*       public float ShowCash()
        {
            
        }
 */   }
    public class PaidWithCard : ITransaction
    {
        public float Credit { get; set; }
        public float GetAmount()
        {
            return Credit;
        }

        public string ShowTransaction(summa)
        {
            DateTime now = DateTime.Now;
            return $"Transaction to bank, Cardnumber: {0}, Date = {now}, Amount: {summa}";
            //return ($"Date: {now}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float summa;
            Console.WriteLine("kassa\n");
            PaidWithCard kortti = new PaidWithCard();
            Console.WriteLine("Give the amount of transaction");
            summa = float.Parse(Console.ReadLine());
            Console.WriteLine("Valikko\n1. Maksa Kortilla\n2. Maksa Käteisellä");
            int valinta = Convert.ToInt32(Console.ReadLine());
            switch(valinta)
            {
                case 1:
                    Console.WriteLine(kortti.ShowTransaction(summa));
                    break;
                case 2:
                    Console.WriteLine(kortti.ShowTransaction(summa));
                    break;
            }

            Console.ReadLine();
        }
    }
}
