using System.ComponentModel.DataAnnotations;

namespace MyWebAppAPI.Entities
{
    public class Catalog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

    }
}
