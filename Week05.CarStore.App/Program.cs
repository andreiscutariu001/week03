using System;
using Week05.CarStore.Interfaces;
using Week05.CarStore.Models;

namespace Week05.CarStore.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICustomer alex = new Customer
            {
                Name = "Alex",
                Email = "alex@yahoo.com",
                Phone = "0712 121 212"
            };

            IStore fordStore = CreateFordStore();
            IStore skodaStore = CreateSkodaStore();

            fordStore.Visit(alex);

            IOrder fordOrderForAlex = fordStore.OrderCar(alex, "Focus");

            skodaStore.Visit(alex);

            IOrder skodaOrderForAlex = skodaStore.OrderCar(alex, "Fabia");

            fordStore.CancelOrder(fordOrderForAlex.Nr);

            skodaStore.ReceiveOrder(skodaOrderForAlex.Nr);
            skodaStore.DeliverOrder(skodaOrderForAlex.Nr);
        }

        private static IStore CreateSkodaStore()
        {
            return new Store();
        }

        private static IStore CreateFordStore()
        {
            IProducer ford = new Producer
            {
                Name = "Ford",
                Address = "Ford address"
            };

            ICar fordFocus = new Car
            {
                Name = "Focus",
                Price = 15000,
                Producer = ford,
                Year = new DateTime(2015, 1, 1)
            };

            IStore store = new Store
            {
                Name = "Ford Store",
                Location = "Iasi"
            };

            store.AddCar(fordFocus);

            return store;
        }
    }
}