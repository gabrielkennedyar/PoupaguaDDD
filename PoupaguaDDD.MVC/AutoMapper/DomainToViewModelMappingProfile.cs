using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoupaguaDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() : base("DomainToViewModelMappingProfile")
        {
            //CreateMap<>(); TODO mapear aqui as domains para views models
        }
    }
}