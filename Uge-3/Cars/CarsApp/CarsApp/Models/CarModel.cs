using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarsApp.Models
{
    public class CarModel
    {

        public Guid Id { get; set; }
        [Required(ErrorMessage = "The brand must be set.")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "The model must be set.")]
        public string Model { get; set; }
        [Required(ErrorMessage = "The year must be set.")]
        public int? Year { get; set; }
        [Required(ErrorMessage = "The milage must be set.")]
        public float? Milage { get; set; }
        [Required(ErrorMessage = "The price must be set.")]
        public float? Price { get; set; }
    }
}
