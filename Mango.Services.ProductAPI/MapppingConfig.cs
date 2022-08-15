using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI
{
    public class MapppingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            return new MapperConfiguration(config =>
            {
                //config.CreateMap<Product, ProductDto>().ReverseMap();
                config.CreateMap<Product, ProductDto>().ReverseMap();
                config.CreateMap<ProductDto, Product>();
            });
        }
    }
}
