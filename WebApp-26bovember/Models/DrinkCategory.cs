namespace WebApp_26bovember.Models
{
    public class DrinkCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
