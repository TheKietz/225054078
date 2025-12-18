using Lab08.Models;
using Lab08.ViewModel;

namespace Lab08.Services.Interfaces
{
    public interface ICarModelService
    {
        List<CarModelVm> GetCarModels();
        CarModel? GetCarModelById(int id);
        void CreateCarModel(CarModel carModel);
        void UpdateCarModel(CarModel carModel);
        void DeleteCarModel(int id);
    }

}
