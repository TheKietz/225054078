namespace Lab08.ViewModel
{
    public class CarModelVm
    {
        public int CarModelId { get; set; }

        public string Name { get; set; } = null!;

        public int Year { get; set; }

        public string BrandName { get; set; } = null!;

        public int BrandId { get; set; }

        public int NumberOfCars { get; set; }
    }
}