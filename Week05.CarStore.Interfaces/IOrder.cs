using System;

namespace Week05.CarStore.Interfaces
{
    public interface IOrder
    {
        int Nr { get; set; }

        DateTime Date { get; set; }

        DateTime EstimatedDeliveryDate { get; set; }

        OrderStatus Status { get; set; }

        ICar Car { get; set; }

        ICustomer Customer { get; set; }

        IStore Store { get; set; }

        // 
    }

    public enum OrderStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        Received,
        Delivered
    }
}