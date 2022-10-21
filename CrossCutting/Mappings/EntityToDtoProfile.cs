using AutoMapper;
using CustomDomain.Dto.User;
using CustomDomain.Entities;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>()
               .ReverseMap();
        }
    }
}
