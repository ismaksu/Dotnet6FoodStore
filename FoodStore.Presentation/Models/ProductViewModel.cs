namespace FoodStore.Presentation.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock {  get; set; }
        public decimal Price { get; set; }
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
