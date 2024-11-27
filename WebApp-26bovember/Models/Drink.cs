namespace WebApp_26bovember.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public int DrinkCategoryId { get; set; }
        public DrinkCategory DrinkCategory { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }    
    }
}
