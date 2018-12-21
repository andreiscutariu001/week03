using System.ComponentModel;

namespace Week05.CarStore.Interfaces
{
    public interface IStore
    {
        string Name { get; set; }

        string Location { get; set; }

        void AddCar(ICar car);

        void RemoveCar(ICar car);

        void Visit(ICustomer customer);

        IOrder OrderCar(ICustomer customer, string modelName);

        void CancelOrder(int orderNumber);

        void ReceiveOrder(int orderNumber);

        void DeliverOrder(int orderNumber);

        void ReportProblem(int orderNumber, string problem);
    }
}