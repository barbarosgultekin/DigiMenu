using DataAccess.Entities.Concrete;
using DataAccess.Entities.DTOs.BaseDtos;
using DataAccess.Entities.DTOs.BaseListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Business.DependencyResolvers.Profiles
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoriesDto>();
            CreateMap<Category, CategoryDto>().ReverseMap();

        }
    }
}
