namespace Vivendi;

public sealed class Cuisine : Enumeration
{
    public static readonly Cuisine African = new(1, nameof(African));
    public static readonly Cuisine American = new(2, nameof(American));
    public static readonly Cuisine Belgian = new(3, nameof(Belgian));
    public static readonly Cuisine Cajun = new(4, nameof(Cajun));
    public static readonly Cuisine Canadian = new(5, nameof(Canadian));
    public static readonly Cuisine Chinese = new(6, nameof(Chinese));
    public static readonly Cuisine Hawaiian = new(7, nameof(Hawaiian));
    public static readonly Cuisine Indian = new(8, nameof(Indian));
    public static readonly Cuisine Italian = new(9, nameof(Italian));
    public static readonly Cuisine Japanese = new(10, nameof(Japanese));
    public static readonly Cuisine Korean = new(11, nameof(Korean));
    public static readonly Cuisine Mexican = new(12, nameof(Mexican));
    public static readonly Cuisine Russian = new(13, nameof(Russian));
    public static readonly Cuisine Spanish = new(14, nameof(Spanish));
    public static readonly Cuisine Thai = new(15, nameof(Thai));
    public static readonly Cuisine Vietnamese = new(16, nameof(Vietnamese));

    public User? User { get; set; }

    public Cuisine() { }

    public Cuisine(int id, string name)
        : base(id, name) { }
}
