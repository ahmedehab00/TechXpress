using System.ComponentModel.DataAnnotations;

namespace TechXpress.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is InValid")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}