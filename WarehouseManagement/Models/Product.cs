using System.ComponentModel.DataAnnotations;

namespace WarehouseManagement.Models
{
    public class Product: MainModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Cost { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Count { get; set; }

        public string? ImageURL { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
