using AutoMapper;
using MusicStore.Models;
using MusicStore.ViewModels.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, ManageAccountInformationVM>().ReverseMap();
        }
    }
}
