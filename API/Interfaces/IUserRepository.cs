using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOS;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<IEnumerable<memberDto>> GetMembersAsync();
        Task<memberDto> GetMemberAsync(string username);  
    }
}