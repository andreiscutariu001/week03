using System;
using System.Collections.Generic;
using PizzaModels;

namespace PizzaApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //regularPizzaBase.Print();
            //italianPizzaBase.Print();
            //thickPizzaBase.Print();

            //var list = new List<PizzaTopping>();

            //list.Add(new PizzaTopping("Meat", 10));
            //list.Add(new PizzaTopping("Meat", 15));
            //list.Add(new PizzaTopping("Cheese", 15));

            //var pizza = new Pizza("P1", thickPizzaBase, list);

            //pizza.Print();

            //list.Add(new PizzaTopping("Vegetables", 20));

            var regularPizzaBase = new PizzaBase("Regular", 10);
            var italianPizzaBase = new PizzaBase("Italian", 10);
            var thickPizzaBase = new PizzaBase("Thick", 10);

            var pizza1 = new Pizza("Pizza 1", regularPizzaBase);
            pizza1.AddTopping(new PizzaTopping("Meat", 10));
            pizza1.AddTopping(new PizzaTopping("Cheese", 5));

            var pizza2 = new Pizza("Pizza 2", italianPizzaBase);
            pizza2.AddTopping(new PizzaTopping("Meat", 10));
            pizza2.AddTopping(new PizzaTopping("Cheese", 5));

            pizza1.Print();
            pizza2.Print();

            Console.ReadLine();
        }
    }
}