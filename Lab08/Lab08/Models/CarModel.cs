namespace Lab08.Models
{
    public class CarModel
    {
        public int CarModelId { get; set; }
        public int Year { get; set; }
        public string Name { get; set; } = null!;
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
