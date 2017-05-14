using System.Collections.Generic;
using System.Web.Mvc;
using MVC.Models;
using MVC.ViewModels;
using Service.Implementations;

namespace MVC.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Menssagem = "Minha view";
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PessoaViewModel pessoaVM)
        {
            ModelState.Remove("Codigo");
            List<Pessoa> lista = new List<Pessoa>();

            if(ModelState.IsValid)
            {
                if (pessoaVM.Captha.Equals("123"))
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Codigo = pessoaVM.Codigo;
                    pessoa.Cpf = pessoaVM.Cpf;
                    pessoa.DataNascimento = pessoaVM.DataNascimento;
                    pessoa.Nome = pessoaVM.Nome;
                    pessoa.Sobrenome = pessoaVM.Sobrenome;
                    pessoa.Email = pessoaVM.Email;
                    pessoa.Telefone = pessoaVM.Telefone;

                    PessoaService.Salvar(pessoa);
                    return View("List", PessoaService.Listar());
                }
                return View(pessoaVM);
            }
            else
                return View(pessoaVM);

        }

        public ActionResult List()
        {
            return View(PessoaService.Listar());
        }

        public ActionResult Edit(int id)
        {
            return View("Create", PessoaService.Obter(id));
        }

        [HttpPost]
        public ActionResult Edit(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                PessoaService.Salvar(pessoa);
                return View("List", PessoaService.Listar());
            }
            else
                return View("Create", pessoa);
        }

        public ActionResult Delete(int id)
        {
            PessoaService.Deletar(id);
            return View("List", PessoaService.Listar());
        }
    }
}