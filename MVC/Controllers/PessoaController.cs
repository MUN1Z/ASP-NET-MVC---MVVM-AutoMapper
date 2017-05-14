using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
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

            if(ModelState.IsValid)
            {
                if (pessoaVM.Captha.Equals("123"))
                {
                    var pessoa = Mapper.Map<PessoaViewModel, Pessoa>(pessoaVM);

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
            var pessoa = PessoaService.Obter(id);
            
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel> (pessoa);

            return View("Create", pessoaViewModel);
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