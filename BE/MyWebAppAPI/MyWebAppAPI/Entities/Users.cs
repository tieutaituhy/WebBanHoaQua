using Microsoft.OData.Edm;
using System.ComponentModel.DataAnnotations;

namespace MyWebAppAPI.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string PassWord { get; set; }
        public Date Created { get; set; }
    }
}
