using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvalueringAfProdukt.Models
{
    public class EvalueringModel
    {
        public Guid Id { get; set; }
        [Required()]
        public string Name { get; set; }
        [Required()]
        public string ProductName { get; set; }
        [Required()]
        [Range(0,10)]
        public int Rating { get; set; }
    }
}
