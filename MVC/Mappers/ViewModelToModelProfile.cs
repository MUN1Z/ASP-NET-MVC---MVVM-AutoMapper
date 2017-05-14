using AutoMapper;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Mappers
{
    public class ViewModelToModelProfile: Profile
    {
        public ViewModelToModelProfile()
        {
            CreateMap<PessoaViewModel, Pessoa>();
        }
    }
}