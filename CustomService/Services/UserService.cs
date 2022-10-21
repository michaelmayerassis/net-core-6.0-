using AutoMapper;
using CustomDomain.Dto.User;
using CustomDomain.Entities;
using CustomDomain.Intefaces;
using CustomDomain.Intefaces.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomService.Services
{
    public class UserService : IUserService
    {
        private IApiRepository<UserEntity> _repository;
        private readonly IMapper _mapper;

        public UserService(IApiRepository<UserEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UserDto>(entity);
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UserDto>>(listEntity);
        }

        //public async Task<UserDtoCreateResult> Post(UserDtoCreate user)
        //{
        //    var model = _mapper.Map<UserModel>(user);
        //    var entity = _mapper.Map<UserEntity>(model);
        //    var result = await _repository.InsertAsync(entity);

        //    return _mapper.Map<UserDtoCreateResult>(result);
        //}

        //public async Task<UserDtoUpdateResult> Put(UserDtoUpdate user)
        //{
        //    var model = _mapper.Map<UserModel>(user);
        //    var entity = _mapper.Map<UserEntity>(model);

        //    var result = await _repository.UpdateAsync(entity);
        //    return _mapper.Map<UserDtoUpdateResult>(result);
        //}
    }
}
