using AutoMapper;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Mappers
{
    public class ModelToViewModelProfile: Profile
    {
        public ModelToViewModelProfile()
        {
            CreateMap<Pessoa, PessoaViewModel>();
        }
    }
}