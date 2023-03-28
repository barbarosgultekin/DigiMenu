using AutoMapper;
using BaseCore.Utilities.Results.Abstract;
using BaseCore.Utilities.Results.Concrete;
using Business.Abstract;
using Business.Repositories;
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
    public class ImageService : ServiceRepository<Image, ImageDto>, IImageService
    {
        private readonly IEntityRepository<Image> _repository;
        private readonly IMapper _mapper;
        public ImageService(IEntityRepository<Image> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IDataResult<List<ImagesDto>> GetImageByCategoryId(int id)
        {
            var images = _repository.AsNoTracking
                .Include(c => c.Category)
                .Where(c => c.CategoryId == id);
            var entities = _mapper.Map<List<ImagesDto>>(images);
            return new SuccessDataResult<List<ImagesDto>>(entities);
        }
    }
}
