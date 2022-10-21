using AutoMapper;
using CustomDomain.Entities;
using CustomDomain.Models;

namespace CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserModel, UserEntity>()
               .ReverseMap();
        }
    }
}
