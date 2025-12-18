namespace Lab08.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; } = null!;
        public string? Country { get; set; }   

        public ICollection<CarModel> CarModels { get; set; } = new List<CarModel>();
    }
}
