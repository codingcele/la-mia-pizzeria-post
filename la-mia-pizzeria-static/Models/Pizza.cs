using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static
{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }

        public Pizza()
        {

        }

        public Pizza(string image, string name, string ingredients, decimal price)
        {
            Image = image;
            Name = name;
            Ingredients = ingredients;
            Price = price;
        }

    }
}
