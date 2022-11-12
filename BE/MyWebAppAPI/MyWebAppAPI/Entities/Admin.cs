using System.ComponentModel.DataAnnotations;

namespace MyWebAppAPI.Entities
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
