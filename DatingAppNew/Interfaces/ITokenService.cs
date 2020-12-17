using DatingAppNew.Entities;

namespace DatingAppNew.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}