using System;
using System.Collections.Generic;

namespace PizzaModels
{
    public class PizzaTopping
    {
        private static List<string> _toppingTypes = new List<string>
        {
            "cheese", "meat", "vegetables"
        };

        public PizzaTopping(string name, double cost)
        {
            if (_toppingTypes.Contains(name.ToLower()))
            {
                this.Name = name;
                this.Cost = cost;
            }
            else
            {
                Console.WriteLine($"{name} is an invalid topping!");
            }
        }

        public string Name { get; }

        public double Cost { get; }

        public void Print()
        {
            if (Name.ToLower() == "meat")
            {
                Console.WriteLine($"\t{Name.ToUpper()} (${Cost})");
                return;
            }

            Console.WriteLine($"\t{Name} (${Cost})");
        }
    }
}