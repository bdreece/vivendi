namespace Vivendi;

public sealed class FoodType : Enumeration
{
    public static readonly FoodType Raw = new(1, nameof(Raw));
    public static readonly FoodType Dish = new(1, nameof(Dish));

    public FoodType() { }

    public FoodType(int id, string name)
        : base(id, name) { }
}
