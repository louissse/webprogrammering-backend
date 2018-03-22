using EvalueringAfProdukt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalueringAfProdukt.Services
{
    public class EvalueringServices
    {
        public Task<bool> RegisterUser(EvalueringModel evalueringModel)
        {
            return Task.FromResult(true);
        }
    }
}
