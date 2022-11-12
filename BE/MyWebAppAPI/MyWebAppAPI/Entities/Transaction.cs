using System.ComponentModel.DataAnnotations;

namespace MyWebAppAPI.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public int UserPhone { get; set; }
        public decimal Amount { get; set; }
        public string Payment { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
    }
}
