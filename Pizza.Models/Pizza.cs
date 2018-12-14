using System;
using System.Collections.Generic;
using PizzaModels;

namespace PizzaModels
{
    public class Pizza
    {
        //// gresit ca implementare 
        //public Pizza(string name, PizzaBase pizzaBase, List<PizzaTopping> pizzaToppings)
        //{
        //    Name = name;
        //    PizzaBase = pizzaBase;

        //    PizzaToppings = new List<PizzaTopping>();

        //    // foreach pe pizzaToppings ca params
        //}

        public Pizza(string name, PizzaBase pizzaBase)
        {
            Name = name;
            PizzaBase = pizzaBase;
            PizzaToppings = new List<PizzaTopping>();
        }

        public string Name { get; }

        public PizzaBase PizzaBase { get; }

        // private pt a nu putea face add exterior
        private List<PizzaTopping> PizzaToppings { get; } 

        public void AddTopping(PizzaTopping topping)
        {
            this.PizzaToppings.Add(topping);
        }

        public double Cost()
        {
            double totalCost = this.PizzaBase.Cost;

            foreach (var pizzaTopping in PizzaToppings)
            {
                totalCost = totalCost + pizzaTopping.Cost;
            }

            return totalCost;
        }

        public void Print()
        {
            Console.WriteLine($"Pizza {Name}");
            this.PizzaBase.Print();
            Console.WriteLine("Toppings:");
            foreach (var pizzaTopping in PizzaToppings)
            {
                pizzaTopping.Print();
            }

            Console.WriteLine($"Total cost: (${this.Cost()})");
            Console.WriteLine();
        }
    }
}