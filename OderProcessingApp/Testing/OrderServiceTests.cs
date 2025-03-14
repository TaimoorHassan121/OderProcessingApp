using OderProcessingApp.Models;
using OderProcessingApp.Services;
using Xunit;

namespace OderProcessingApp.Testing
{
    public class OrderServiceTests
    {
        [Fact]
        public void CalculateDiscount_LoyalCustomerAbove100_ShouldApplyDiscount()
        {
            var service = new OrderServices();
            var order = new Order { Amount = 150, CustomerType = "Loyal" };

            var result = service.CalculateDiscount(order);

            Assert.Equal(15, result.Discount);
            Assert.Equal(135, result.FinalAmount);
        }

        [Fact]
        public void CalculateDiscount_NewCustomerAbove100_ShouldNotApplyDiscount()
        {
            var service = new OrderServices();
            var order = new Order { Amount = 150, CustomerType = "New" };

            var result = service.CalculateDiscount(order);

            Assert.Equal(0, result.Discount);
            Assert.Equal(150, result.FinalAmount);
        }
    }
}
