using System.Reflection;

namespace Vivendi;

public abstract class Enumeration : IComparable
{
    private int id;
    private string name = default!;

    public int Id => id;
    public string Name => name;

    protected Enumeration() { }

    protected Enumeration(int id, string name) =>
        (this.id, this.name) = (id, name);

    public override string ToString() => name;

    public static IEnumerable<T> GetAll<T>()
        where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>();

    public override bool Equals(object? obj)
    {
        if (obj is not Enumeration otherValue)
        {
            return false;
        }

        var typeMatches = GetType().Equals(obj.GetType());
        var valueMatches = id.Equals(otherValue.id);

        return typeMatches && valueMatches;
    }

    public override int GetHashCode() => id ^ 31;

    public int CompareTo(object? other) =>
        Id.CompareTo((other as Enumeration)?.id);
}
