using System;

namespace Week04.HotelApp
{
    public class Room
    {
        public Room(string name, int adults, int children, Rate rate)
        {
            this.Name = name;
            this.Adults = adults;
            this.Children = children;
            this.Rate = rate;
        }

        public string Name { get; set; }

        public Rate Rate { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public decimal GetPrice()
        {
            if (this.Children == 1)
            {
                return this.Rate.Amount * Convert.ToDecimal(1.3);
            }

            return this.Rate.Amount;
        }

        public void Print()
        {
            Console.WriteLine($"\tRoom {Name}:");
            Console.WriteLine($"\t\tAdults: {Adults}, Children: {Children}");
            this.Rate.Print();

            Console.WriteLine($"\t\tAfter calculation: {this.GetPrice()}");
        }
    }
}