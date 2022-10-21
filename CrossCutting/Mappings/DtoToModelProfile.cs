
using AutoMapper;
using CustomDomain.Dto.User;
using CustomDomain.Models;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<UserModel, UserDto>()
                .ReverseMap();
            //CreateMap<UserModel, UserDtoCreate>()
            //    .ReverseMap();
            //CreateMap<UserModel, UserDtoUpdate>()
            //    .ReverseMap();
            #endregion
        }

    }
}
