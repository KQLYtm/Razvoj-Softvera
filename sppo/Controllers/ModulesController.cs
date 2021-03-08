using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sppo.Controllers
{
    public class ModulesController : Controller
    {
        public IActionResult Module1()
        {
            return View();
        }
        public IActionResult Module2()
        {
            return View();
        }
        public IActionResult Module3()
        {
            return View();
        }
    }
}
