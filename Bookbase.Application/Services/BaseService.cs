using AutoMapper;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Services
{
    public class BaseService<TEntity, TResponseDto, TResponseDetail, TCreateDto, TUpdateDto> where TEntity : BaseModel
    {
        protected readonly IBaseRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public virtual async Task<TResponseDetail?> GetOne(int Id)
        {
            var result = await _repository.GetOne(Id);

            if (result == null)
            {
                throw new NotFoundException("Record not found")
                {
                    ErrorCode = "004"
                };
            }

            return _mapper.Map<TResponseDetail>(result);
        }

        public async Task<IEnumerable<TResponseDto>> GetAll()
        {
            var result = await _repository.GetAll();
            return _mapper.Map<IEnumerable<TResponseDto>>(result);
        }

        public async Task<GenericListResponse<TResponseDto>> GetList(int page, int pageSize, string? query)
        {
            //var events = await _repository.GetList(page, pageSize, query);

            //return _mapper.Map<GenericListResponse<TResponseDto>>(events);
            throw new NotImplementedException();
        }

        public virtual async Task<TResponseDto> Create(TCreateDto body)
        {
            var entity = _mapper.Map<TEntity>(body);
            var res = await _repository.Create(entity);
            return _mapper.Map<TResponseDto>(res);
        }

        public async Task<GenericResponseDto> Delete(int id)
        {
            var entity = await _repository.GetOne(id);
            if (entity == null)
            {
                throw new NotFoundException($"Entity of id {id} does not exist")
                {
                    ErrorCode = "005"
                };
            }

            if (!(entity is ISoftDeletable softDeletableEntity))
            {
                await _repository.Delete(entity);
            }

            else
            {

                softDeletableEntity.Deleted = true;

                await _repository.Update(entity);
            }

            return new GenericResponseDto { Success = true };
        }

        public virtual async Task<TResponseDto> Update(int id, TUpdateDto body)
        {
            var item = await _repository.GetOne(id);

            if (item == null)
            {
                throw new NotFoundException($"Record of id {id} does not exist")
                {
                    ErrorCode = "005"
                };
            }

            var entity = _mapper.Map(body, item);

            if (entity is ITimestampedModel timestampedEntity)
            {
                timestampedEntity.UpdatedAt = DateTime.UtcNow;
            }

            var response = await _repository.Update(entity);

            return _mapper.Map<TResponseDto>(response);
        }

    }
}
