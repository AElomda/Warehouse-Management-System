namespace WarehouseManagement.Models
{
    public class MainModel
    {
        public MainModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; } //Guid is better than Id property because it prevents 
    }
}
