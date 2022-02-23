using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1_23_02.Controllers
{
    public class _ : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult cadastrar()
        {
            return View();
        }
    }
}
