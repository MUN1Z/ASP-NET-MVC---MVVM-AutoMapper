using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class CarrinhoComprasViewModel
    {
        public List<Produto> Produtos { get; set; }
        public decimal ValorTotal { get; set; }
        public string Menssagem { get; set; }
    }
}