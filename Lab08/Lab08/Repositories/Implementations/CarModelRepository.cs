using Lab08.Models;
using Lab08.ViewModel; 
using Lab08.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab08.Repositories.Implementations
{
    public class CarModelRepository : ICarModelRepository
    {
        private readonly ApplicationDbContext _context;
        public CarModelRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        // JOIN 2 bảng: CarModels + Brands
        public List<CarModelVm> GetAll()
        {
            return _context.CarModels
                .Include(cm => cm.Brand)
                 .Select(cm => new CarModelVm
                 {
                     CarModelId = cm.CarModelId,
                     Name = cm.Name,
                     BrandId = cm.BrandId,
                     BrandName = cm.Brand.Name
                 })
                 .ToList();
        }
        public CarModel? GetById(int id)
        {
            return _context.CarModels.Find(id);
        }
        public void Add(CarModel carModel)
        {
            _context.CarModels.Add(carModel);
            _context.SaveChanges();
        }
        public void Update(CarModel carModel)
        {
            _context.CarModels.Update(carModel);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var carModel = _context.CarModels.Find(id);
            if (carModel != null)
            {
                _context.CarModels.Remove(carModel);
                _context.SaveChanges();
            }
        }
    }
}
