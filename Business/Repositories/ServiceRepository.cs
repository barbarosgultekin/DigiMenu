using AutoMapper;
using BaseCore.Utilities.Results.Abstract;
using BaseCore.Utilities.Results.Concrete;
using Business.Repositories;
using Core.BaseEntity.Abstract;
using DataAccess.Repositories.Abstract;

namespace BusinessLayer.Repositories.Concrete
{
    public class ServiceRepository<TEntity, TDto> : IServiceRepository<TDto>
        where TEntity : class, IBaseEntity, new()
        where TDto : class, IDto, new()
    {
        private readonly IEntityRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public ServiceRepository(IEntityRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IResult Update(int id, TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity.Id = id;
            _repository.Update(entity);
            return new SuccessResult();
        }

        public IDataResult<TDto> GetById(int id)
        {
            var entity = _repository.Get(entity => entity.Id == id);
            var dto = _mapper.Map<TDto>(entity);
            return new SuccessDataResult<TDto>(dto);
        }

        public IResult Delete(int id)
        {
            var entity = _repository.Get(entity => entity.Id == id);
            _repository.Delete(entity);
            return new SuccessResult();
        }

        public IResult Insert(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _repository.Add(entity);
            return new SuccessResult();
        }


    }
}
