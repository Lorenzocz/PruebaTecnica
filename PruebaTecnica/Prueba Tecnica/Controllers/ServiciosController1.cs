using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Tecnica.Controllers
{
    public class ServiciosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
