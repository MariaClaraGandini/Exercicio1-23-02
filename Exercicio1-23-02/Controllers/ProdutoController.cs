using Exercicio1_23_02.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1_23_02.Controllers
{
    public class ProdutoController : Controller
    {
        public static List<Produto> lsProduto = new List<Produto>();
        public IActionResult Index()
        {
            return View(lsProduto);
        }
        public IActionResult cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult salvar(Produto item)
        {
            lsProduto.Add(item);
            return RedirectToAction("Index");
        }

    }
}
