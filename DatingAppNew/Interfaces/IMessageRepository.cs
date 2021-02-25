using System.Collections.Generic;
using System.Threading.Tasks;
using DatingAppNew.DTOs;
using DatingAppNew.Entities;
using DatingAppNew.Helpers;

namespace DatingAppNew.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUsername, string recipientUsername);
        Task<bool> SaveAllAsync();
        
    }
}