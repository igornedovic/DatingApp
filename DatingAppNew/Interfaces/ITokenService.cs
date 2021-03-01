using System.Threading.Tasks;
using DatingAppNew.Entities;

namespace DatingAppNew.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}