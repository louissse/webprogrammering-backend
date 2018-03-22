using CarsApp.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsApp.Middlewares
{
    public class CommunicationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ICarService _carService;

        public CommunicationMiddleware(RequestDelegate next, ICarService carService)
        {
            _next = next;
            _carService = carService;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);
        }
    }
}
