using System;

namespace Week04.HotelApp
{
    public class Rate
    {
        public Rate(decimal amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t\tPrice is {Amount} {Currency}.");
        }
    }
}
