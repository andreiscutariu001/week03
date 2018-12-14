using System;

namespace PizzaModels
{
    public class PizzaBase
    {
        public PizzaBase(string name, double cost)
        {
            switch (name)
            {
                case "Italian":
                    this.Name = name;
                    this.Cost = 1.5 * cost;
                    break;
                case "Regular":
                case "Thick":
                    this.Name = name;
                    this.Cost = cost;
                    break;
                default:
                    Console.WriteLine($"{name} is an invalid pizza base.");
                    break;
            }
            
        }

        public string Name { get; }

        public double Cost{ get; }

        public void Print()
        {
            Console.WriteLine($"Base {this.Name} (${this.Cost})");
        }
    }
}