using CustomData.Context;
using Microsoft.EntityFrameworkCore;
namespace ApiData.Context
{
    public class MySqlApiContext : ApiContext
    {
        public MySqlApiContext(DbContextOptions<ApiContext> options)
            : base(options) { }
    }
}
