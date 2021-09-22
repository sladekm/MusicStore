using AutoMapper;
using MusicStore.Models;
using MusicStore.ViewModels.Account;
using MusicStore.ViewModels.Album;
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
            CreateMap<ApplicationUser, AccountRegisterVM>().ReverseMap().ForMember(dst => dst.UserName, o => o.MapFrom(src => src.Email));
            CreateMap<ApplicationUser, ManageAccountInformationVM>().ReverseMap();
            CreateMap<ApplicationUser, ManageChangeBillingInformationVM>().ReverseMap();
            CreateMap<Album, AlbumVM>().ReverseMap();
        }
    }
}
