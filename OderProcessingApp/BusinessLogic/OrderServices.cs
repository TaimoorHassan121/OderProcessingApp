using OderProcessingApp.Models;

namespace OderProcessingApp.Services
{
    public class OrderServices
    {
        public Order CalculateDiscount(Order order)
        {
            if (order.Amount >= 100 && order.CustomerType == "Loyal")
            {
                order.Discount = 10;
            }
            else
            {
                order.Discount = 0;
            }
            order.FinalAmount = order.Amount - (order.Amount * order.Discount / 100);
            return order;
        }
    }
}
