using System.ComponentModel.DataAnnotations;

namespace WarehouseManagement.Models
{
    public class Product: MainModel
    {
        [Required]
        [MaxLength(60, ErrorMessage = "Max Length should not be more than 60 characters")]
        [MinLength(3, ErrorMessage = "Product name should be at least 3 characters ")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Description should not be more than 60 characters")]
        public string Description { get; set; }

        [Required]
        [Range(0,999999,ErrorMessage ="can not be less than 0 and more than 999999")]
        public decimal Cost { get; set; }

        [Required]
        [Range(0, 999999, ErrorMessage = "can not be less than 0 and more than 999999")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "can not be less than 0 and more than 1000")]
        public int Count { get; set; }

        public string? ImageURL { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
