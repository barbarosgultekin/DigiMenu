using AutoMapper;
using BaseCore.Utilities.Results.Abstract;
using BaseCore.Utilities.Results.Concrete;
using Business.Abstract;
using BusinessLayer.Repositories.Concrete;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.DTOs.BaseDtos;
using DataAccess.Entities.DTOs.BaseListDto;
using DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryService : ServiceRepository<Category, CategoryDto>, ICategoryService
    {
        private readonly IEntityRepository<Category> _repository;
        private readonly IMapper _mapper;
        public CategoryService(IEntityRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IDataResult<List<CategoriesDto>> GetByParentId(int id)
        {
            var categories = _repository.AsNoTracking
                .Include(c => c.ParentCategory)
                .Where(c => c.ParentCategoryId == id);
            var entities = _mapper.Map<List<CategoriesDto>>(categories);
            return new SuccessDataResult<List<CategoriesDto>>(entities);
        }

        public IDataResult<List<CategoriesDto>> GetAll()
        {
            var entities = _repository.GetAll();
            var categories = _mapper.Map<List<CategoriesDto>>(entities);
            return new SuccessDataResult<List<CategoriesDto>>(categories);
        }
    }
}
