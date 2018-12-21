using System;

namespace Week05.CarStore.Interfaces
{
    public interface ICar
    {
        string Name { get; set; }

        decimal Price { get; set; }

        DateTime Year { get; set; }

        IProducer Producer { get; set; }
    }
}