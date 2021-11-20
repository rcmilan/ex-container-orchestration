using Domain.Models;

namespace Persistence.Services
{
    public interface ICommunityService
    {
        Task<ICollection<Community>> Get();
        Task<Community> Add(Community community);
    }
}
