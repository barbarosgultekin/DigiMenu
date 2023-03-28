using BaseCore.Utilities.Results.Abstract;
using Business.Concrete;
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
    public interface IImageService : IServiceRepository<ImageDto>
    {
        IDataResult<List<ImagesDto>> GetImageByCategoryId(int id);
    }
}
