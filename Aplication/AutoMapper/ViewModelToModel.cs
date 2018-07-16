using Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.ViewModels;

namespace Aplication.AutoMapper
{
    public class ViewModelToModel : Profile
    {
        public ViewModelToModel()
        {
            CreateMap<ContatoViewModel, Contato>().ReverseMap();
            CreateMap<TelefoneViewModel, Telefone>().ReverseMap();
        }
    }
}
