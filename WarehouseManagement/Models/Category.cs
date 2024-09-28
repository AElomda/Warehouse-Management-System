using System.ComponentModel.DataAnnotations;

namespace WarehouseManagement.Models
{
    public class Category: MainModel
    {
        public Category()    //for less memory consumption
        {
            this.Products = new HashSet<Product>();
        }

        [Required]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
