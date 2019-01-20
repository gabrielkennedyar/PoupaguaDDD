using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoupaguaDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() : base("ViewModelToDomainProfile")
        {
            //CreateMap<>(); TODO mapear aqui as views models para domain
        }
    }
}