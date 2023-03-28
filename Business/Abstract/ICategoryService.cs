using BaseCore.Utilities.Results.Abstract;
using Business.Repositories;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.DTOs.BaseDtos;
using DataAccess.Entities.DTOs.BaseListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService:IServiceRepository<CategoryDto>
    {
        IDataResult<List<CategoriesDto>> GetByParentId(int id);
        IDataResult<List<CategoriesDto>> GetAll();

    }
}
