using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvalueringAfProdukt.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvalueringAfProdukt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Index(EvalueringModel evalueringModel)
        {
            if (ModelState.IsValid)
            {
                return Content($"Product {evalueringModel.ProductName} has been evaluated sucessfully");
            } else
            {
                return View(evalueringModel);
            }
        }
    }
}