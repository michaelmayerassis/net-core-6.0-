using ApiData.Repositories;
using CustomData.Context;
using CustomDomain.Entities;
using CustomDomain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ApiData.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;
        public UserImplementation(ApiContext context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }
        public async Task<UserEntity> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}
