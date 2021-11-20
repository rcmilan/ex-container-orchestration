using Domain.Base;

namespace Domain.Models
{
    public class Post : BaseModel<Guid>
    {
        public string Content { get; set; }
    }
}
