using CustomDomain.Entities;
using CustomDomain.Intefaces;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace CustomDomain.Repository
{
    public interface IUserRepository : IApiRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string email);
    }
}
