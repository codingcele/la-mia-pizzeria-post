using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static
{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }

    }
}
