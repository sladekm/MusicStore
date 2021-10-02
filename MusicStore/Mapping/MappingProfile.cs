using AutoMapper;
using MusicStore.Areas.Administration.ViewModels.Album;
using MusicStore.Models;
using MusicStore.ViewModels.Account;
using MusicStore.ViewModels.Album;
using MusicStore.ViewModels.Artist;
using MusicStore.ViewModels.Checkout;
using MusicStore.ViewModels.Genre;
using MusicStore.ViewModels.Manage;
using MusicStore.ViewModels.Order;
using MusicStore.ViewModels.OrderDetail;
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
            CreateMap<ApplicationUser, CheckoutBillingInformationVM>().ReverseMap();
            CreateMap<Album, AlbumVM>().ReverseMap();
            CreateMap<Album, AlbumEditVM>().ReverseMap();
            CreateMap<Album, AlbumCreateVM>().ReverseMap();
            CreateMap<Genre, GenreVM>().ReverseMap();
            CreateMap<Artist, ArtistVM>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailVM>().ReverseMap();
            CreateMap<Order, OrderVM>().ReverseMap();
            CreateMap<Order, CheckoutBillingInformationVM>().ReverseMap();
            CreateMap<OrderListVM, Order>().ReverseMap();
        }
    }
}
