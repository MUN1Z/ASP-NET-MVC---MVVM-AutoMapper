using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class CarrinhoComprasController : Controller
    {
        // GET: CarrinhoCompras
        public ActionResult Index()
        {
            var produtos = new List<Produto>();

            for (int i = 1; i < 6; i++)
            {
                produtos.Add(new Produto(){ID = i, Nome = "Produto "+i, valor = i*2});
            }

            var model = new CarrinhoComprasViewModel()
            {
                ValorTotal = produtos.Sum(p => p.valor),
                Menssagem = "Boas compras",
                Produtos = produtos
            };
            
            return View(model);
        }
    }
}