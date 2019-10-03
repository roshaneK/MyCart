using AutoMapper;
using MyCart.Repository.Models;
using MyCart.Service.Models;

namespace MyCart.Service.MappingProfiles
{
    public class CartMapperProfile : Profile
    {
        public CartMapperProfile()
        {
            CreateMap<ItemDTO, Item>();
            CreateMap<CartDTO, Cart>();
        }
    }
}
