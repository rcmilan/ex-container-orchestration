using Domain.Base;

namespace Domain.Models
{
    public class Community : BaseModel<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Forum> Forums { get; set; }
    }
}
