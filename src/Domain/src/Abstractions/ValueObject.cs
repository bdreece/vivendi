namespace Vivendi;

public abstract class ValueObject
{
    protected abstract IEnumerable<object> EqualityComponents { get; }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not ValueObject other)
        {
            return false;
        }

        return EqualityComponents
            .SequenceEqual(other.EqualityComponents);
    }

    public override int GetHashCode()
    {
        return EqualityComponents
            .Select(x => x != null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }

    protected static bool EqualOperator(ValueObject? left, ValueObject? right)
    {
        if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
        {
            return false;
        }

        return ReferenceEquals(left, right) || left!.Equals(right!);
    }

    protected static bool NotEqualOperator(ValueObject left, ValueObject right)
    {
        return !(EqualOperator(left, right));
    }
}
