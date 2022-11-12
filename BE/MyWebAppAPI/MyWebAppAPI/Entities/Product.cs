using System.ComponentModel.DataAnnotations;

namespace MyWebAppAPI.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Content { get; set; }
        public int Discount { get; set; }
        public DateTime Created { get; set; }
        

    }
}
