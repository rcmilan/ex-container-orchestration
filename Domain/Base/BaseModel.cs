namespace Domain.Base
{
    public abstract class BaseModel<T>
    {
        public BaseModel()
        {
            CreatedAt = CreatedAt == DateTime.MinValue ? DateTime.Now : CreatedAt;
        }

        public T ID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
