using AutoMapper;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.DTOs.BaseDtos;
using DataAccess.Entities.DTOs.BaseListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoriesDto>()
                .ForMember(category => category.ParentCategory,
                name => name.MapFrom(category => category.ParentCategory.Name));


            CreateMap<Image, ImageDto>().ReverseMap();
            CreateMap<Image, ImagesDto>()
                .ForMember(image => image.Category,
                path => path.MapFrom(image => image.Category.Name));


        }
    }
}
