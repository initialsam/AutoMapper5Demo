using AutoMapper;
using AutoMapper5Demo.Models;
using AutoMapper5Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper5Demo.Infrastructure.AutoMapperProfile
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}