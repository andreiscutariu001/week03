using System;
using Week05.CarStore.Interfaces;

namespace Week05.CarStore.Models
{
    public class Car : ICar
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime Year { get; set; }

        public IProducer Producer { get; set; }
    }
}