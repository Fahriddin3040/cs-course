namespace Storage.Utils.Abstractions.Models;

public abstract class BaseEntity: Auditable
{
    public Guid Id { get; set; }
    public bool IsActive { get; set; }

        public BaseEntity()
    {
        Id = Guid.NewGuid();
    }

    public override string ToString()
    {
        return $"UID: {this.Id} ({GetType().Name})";
    }
}