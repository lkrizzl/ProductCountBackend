namespace Domain.Core.PrimitiveTypes;

public class Entity
{
    protected Entity() { }

    protected Entity(Guid id) 
    {
        
        Id = id;
    
    }

    public Guid Id { get; protected set; }

    public bool Equals(Entity? other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other) || Id == other.Id;
    }
}
