namespace Vivendi;

public abstract class Entity
{
    int? hashCode;
    private Guid id = Guid.NewGuid();
    private DateTimeOffset createdAt = DateTimeOffset.UtcNow;

    public Guid Id => id;
    public DateTimeOffset CreatedAt => createdAt;
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Entity item))
            return false;
        if (Object.ReferenceEquals(this, obj))
            return true;
        if (this.GetType() != obj.GetType())
            return false;
        else
            return item.Id == Id;
    }

    public override int GetHashCode()
    {
        if (!hashCode.HasValue)
            hashCode = id.GetHashCode() ^ 31;

        return hashCode.Value;
    }

    public static bool operator ==(Entity left, Entity right)
    {
        if (Object.Equals(left, null))
            return Object.Equals(right, null);
        else
            return left.Equals(right);
    }

    public static bool operator !=(Entity left, Entity right)
    {
        return !(left == right);
    }
}

