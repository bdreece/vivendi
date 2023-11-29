namespace Vivendi;

public sealed class User : Entity, IAggregateRoot
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;

    public string Email { get; set; } = default!;
    public bool EmailVerified { get; set; } = false;

    public string Hash { get; set; } = default!;

    public User() { }
}
