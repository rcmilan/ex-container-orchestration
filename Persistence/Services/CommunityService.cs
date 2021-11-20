using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class CommunityService : ICommunityService
    {
        private DbContext _context;

        public CommunityService(DbContext context)
        {
            _context = context;
        }

        public async Task<Community> Add(Community community)
        {
            await _context.Set<Community>().AddAsync(community);
            await _context.SaveChangesAsync();

            return community;
        }

        public async Task<ICollection<Community>> Get()
        {
            var communities = await _context.Set<Community>()
                .Include(c => c.Forums)
                    .ThenInclude(f => f.Posts)
                .ToListAsync();

            return communities;
        }
    }
}
