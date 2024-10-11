namespace lr6_2.Models
{
    public class OrderFormModel
    {
        public int Count { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
