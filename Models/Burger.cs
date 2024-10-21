using System.ComponentModel.DataAnnotations;

namespace ReveloBurger.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        
        [Range(0.1,99.99)]
        public decimal Price { get; set; }

        public List<Promo>? Promos {  get; set; } 
    }
}
