using System.Collections.Generic;
using System.Threading.Tasks;
using DatingAppNew.DTOs;
using DatingAppNew.Entities;
using DatingAppNew.Helpers;

namespace DatingAppNew.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}