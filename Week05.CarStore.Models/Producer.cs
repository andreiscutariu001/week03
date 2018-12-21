using Week05.CarStore.Interfaces;

namespace Week05.CarStore.Models
{
    public class Producer : IProducer
    {
        public string Name { get; set; }

        public string Address { get; set; }
    }
}