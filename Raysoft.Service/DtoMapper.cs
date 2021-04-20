using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using Raysoft.Core.DTOs;
using Raysoft.Core.Models;

namespace Raysoft.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<CryptoNewDto, CryptoNew>().ReverseMap();
            CreateMap<EconomistDto, Economist>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}
