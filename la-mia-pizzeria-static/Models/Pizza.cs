﻿using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il nome non può avere più di 50 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(200, ErrorMessage = "Gli ingredienti non possono avere più di 200 caratteri")]
        [IngredientsMin3Words(ErrorMessage = "Gli ingredienti devono contenere almeno 3 parole.")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(0.01, 25.00, ErrorMessage = "Il prezzo deve essere positivo e minore di 25.")]
        public decimal? Price { get; set; }

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
