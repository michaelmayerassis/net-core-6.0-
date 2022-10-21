using CustomDomain.Dto;
using System.Threading.Tasks;

namespace CustomDomain.Intefaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
