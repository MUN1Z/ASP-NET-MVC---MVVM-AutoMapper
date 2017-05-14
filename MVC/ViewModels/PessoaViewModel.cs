using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.ViewModels
{
    public class PessoaViewModel
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }

        [MaxLength(20)]
        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefone { get; set; }
        
        [Required]
        public string Captha { get; set; }
    }
}