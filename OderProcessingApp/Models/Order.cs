using System.ComponentModel.DataAnnotations;

namespace OderProcessingApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? CustomerType { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalAmount { get; set; }
    }
}
