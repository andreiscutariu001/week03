using Week05.CarStore.Interfaces;

namespace Week05.CarStore.Models
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}