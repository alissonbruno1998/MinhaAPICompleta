using AutoMapper;
using DevIO.Business.Models;
using DevIOApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIOApi.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig() 
        { 
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
