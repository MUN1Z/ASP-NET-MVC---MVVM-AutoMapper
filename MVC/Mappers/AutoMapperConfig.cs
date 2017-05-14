using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappers()
        {
            Mapper.Initialize(x =>
                {
                    x.AddProfile<ModelToViewModelProfile>();
                    x.AddProfile<ViewModelToModelProfile>();
                }
            );
        }


    }
}