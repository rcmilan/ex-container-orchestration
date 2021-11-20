using Domain.Base;

namespace Domain.Models
{
    public class Forum: BaseModel<Guid>
    {
        public string Title { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
