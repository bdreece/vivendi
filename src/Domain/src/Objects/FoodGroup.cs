namespace Vivendi;

public sealed class FoodGroup : Enumeration
{
    public static readonly FoodGroup Grain = new(1, nameof(Grain));
    public static readonly FoodGroup Dairy = new(2, nameof(Dairy));
    public static readonly FoodGroup Fruit = new(3, nameof(Fruit));
    public static readonly FoodGroup Vegetable = new(4, nameof(Vegetable));
    public static readonly FoodGroup Meat = new(5, nameof(Meat));
    public static readonly FoodGroup Confection = new(6, nameof(Confection));

    private List<Food> foods = new();

    public ICollection<Food> Foods => foods;

    public FoodGroup() { }

    public FoodGroup(int id, string name)
        : base(id, name) { }
}
