using Domain.Models;

namespace Repository.Services
{
    public interface ICommunityService
    {
        Task<ICollection<Community>> Get();
        Task<Community> Add(Community community);
    }
}
