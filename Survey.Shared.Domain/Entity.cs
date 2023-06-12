namespace Surveys.Shared.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = null;
        public DateTime? DeletedAt { get; set; } = null;
        public Guid CreatedBy { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Entity(Guid createdBy)
        {
            Id = Guid.NewGuid();
            CreatedBy = createdBy;
        }

        public Entity(Guid id, Guid createdBy)
        {
            Id = id;
            CreatedBy = createdBy;
        }

        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public void Delete() {
            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
        }
    }
}