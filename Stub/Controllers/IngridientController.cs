using Ingirgidient.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stub.Controllers
{
    public class IngridientController : Controller
    {
        IIngidientService ingidientService;

        public IngridientController(IIngidientService ingidientService)
        {
            this.ingidientService = ingidientService;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
