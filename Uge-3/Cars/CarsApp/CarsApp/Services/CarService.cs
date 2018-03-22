using CarsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsApp.Services
{
    public class CarService : ICarService
    {
        public Task<bool> RegisterCar(CarModel carModel)
        {
            return Task.FromResult(true);
        }
    }
}
