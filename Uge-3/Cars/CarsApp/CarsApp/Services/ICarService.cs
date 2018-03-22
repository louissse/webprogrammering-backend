using System.Threading.Tasks;
using CarsApp.Models;

namespace CarsApp.Services
{
    public interface ICarService
    {
        Task<bool> RegisterCar(CarModel carModel);
    }
}