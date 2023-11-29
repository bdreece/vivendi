using System.Diagnostics.CodeAnalysis;

namespace Foop;

public record struct Result(bool IsSuccess, Exception? Error)
{
    [MemberNotNullWhen(true, nameof(Error))]
    public bool HasError => Error is not null;

    public Result()
        : this(true, default) { }

    public Result(Exception error)
        : this(false, error) { }

    public void EnsureSuccess()
    {
        if (HasError)
        {
            throw Error;
        }
    }
}

public record struct ValueResult<T>
    where T : struct
{
    private readonly T? value;

    public T Value => value!.Value;
    public Exception? Error { get; init; }

    [MemberNotNullWhen(true, nameof(Value))]
    public bool HasValue => value.HasValue;

    [MemberNotNullWhen(true, nameof(Error))]
    public bool HasError => Error is not null;

    public ValueResult(T value)
    {
        this.value = value;
    }

    public ValueResult(Exception error)
    {
        Error = error;
    }

    public void EnsureSuccess()
    {
        if (HasError)
        {
            throw Error;
        }
    }

    public static explicit operator T(ValueResult<T> result)
    {
        if (!result.HasValue)
        {
            throw result.Error ?? new NullReferenceException(nameof(Value));
        }

        return result.Value;
    }
}

public sealed record Result<T>(T? Value, Exception? Error)
{
    [MemberNotNullWhen(true, nameof(Value))]
    public bool HasValue => Value is not null;

    [MemberNotNullWhen(true, nameof(Error))]
    public bool HasError => Error is not null;

    public Result(T value)
        : this(value, default) { }

    public Result(Exception error)
        : this(default, error) { }

    public void EnsureSuccess()
    {
        if (HasError)
        {
            throw Error;
        }
    }

    public static explicit operator T(Result<T> result)
    {
        if (!result.HasValue)
        {
            throw result.Error ?? new NullReferenceException(nameof(Value));
        }

        return result.Value;
    }
}
