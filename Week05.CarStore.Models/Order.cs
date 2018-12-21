using System;
using Week05.CarStore.Interfaces;

namespace Week05.CarStore.Models
{
    public class Order : IOrder
    {
        public int Nr { get; set; }

        public DateTime Date { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        public OrderStatus Status { get; set; }

        public ICar Car { get; set; }

        public ICustomer Customer { get; set; }

        public IStore Store { get; set; }
    }
}