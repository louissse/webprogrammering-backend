using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsApp.Models;
using CarsApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarsApp.Controllers
{
    public class CarRegistrationController : Controller
    {
        private ICarService _carService;

        public CarRegistrationController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CarModel carModel)
        {
            if (ModelState.IsValid)
            {
                await _carService.RegisterCar(carModel);
                return Content($"The car {carModel.Brand} {carModel.Model} has been registered sucessfully.");
            } else
            {
                return View();
            }
        }
    }
}