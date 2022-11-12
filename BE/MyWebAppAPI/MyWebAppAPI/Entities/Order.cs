using System.ComponentModel.DataAnnotations;

namespace MyWebAppAPI.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }

    }
}
