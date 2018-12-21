using System;
using System.Collections.Generic;
using Week05.CarStore.Interfaces;

namespace Week05.CarStore.Models
{
    public class Store : IStore
    {
        private readonly List<ICar> _cars = new List<ICar>();

        private readonly List<IOrder> _orders = new List<IOrder>();

        public string Name { get; set; }

        public string Location { get; set; }

        public void AddCar(ICar car)
        {
            _cars.Add(car);
        }

        public void RemoveCar(ICar car)
        {
            throw new NotImplementedException();
        }

        public void Visit(ICustomer customer)
        {
            Console.WriteLine($"{customer.Name} visit {Name} store.");

            // Display Cars
        }

        public IOrder OrderCar(ICustomer customer, string modelName)
        {
            var car = FindCar(modelName);

            IOrder order = new Order
            {
                Car = car,
                Customer = customer,
                Date = DateTime.Now,
                EstimatedDeliveryDate = DateTime.Now.AddDays(28),
                Nr = 0,
                Status = OrderStatus.Pending,
                Store = this
            };

            _orders.Add(order);

            return order;
        }

        public void CancelOrder(int orderNumber)
        {
            throw new NotImplementedException();
        }

        public void ReceiveOrder(int orderNumber)
        {
            throw new NotImplementedException();
        }

        public void DeliverOrder(int orderNumber)
        {
            throw new NotImplementedException();
        }

        public void ReportProblem(int orderNumber, string problem)
        {
            throw new NotImplementedException();
        }

        private ICar FindCar(string modelName)
        {
            foreach (var car in _cars)
                if (car.Name.ToLower() == modelName.ToLower())
                    return car;

            return null;
        }
    }
}