namespace Todo.Infrastructure.Persistance.Entities
{
    public class BaseAuditableEntity:BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }

    }
}
