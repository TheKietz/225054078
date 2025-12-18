using Lab08.Models;
using Lab08.ViewModel;
namespace Lab08.Repositories.Interfaces
{
    public interface ICarModelRepository
    {
        List<CarModelVm> GetAll();
        CarModel? GetById(int id);
        void Add(CarModel carModel);
        void Update(CarModel carModel);
        void Delete(int id);
    }
}
