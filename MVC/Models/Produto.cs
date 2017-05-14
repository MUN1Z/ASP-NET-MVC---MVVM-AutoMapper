using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal valor { get; set; }
    }
}