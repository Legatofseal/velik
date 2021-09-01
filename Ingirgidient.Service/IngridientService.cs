using Ingridients.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingirgidient.Service
{
    public class IngridientService : IIngidientService
    {

        private readonly ILogger<IngridientService> _logger;
        IngridientDTO ingridientDTO;
        public int GetDensity()
        {
            throw new NotImplementedException();
        }

        public string GetListOfDishes()
        {
            throw new NotImplementedException();
        }
    }
}
