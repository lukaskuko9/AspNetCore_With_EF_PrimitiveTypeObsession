namespace PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.Email;

[System.Text.Json.Serialization.JsonConverter(typeof(EmailSystemJsonConverter))]
public readonly record struct Email : IStringWrapper<Email>
{
    public Email(string Value)
    {
        if(IsValid(Value))
            throw new EmailInvalidException(Value);
        
        this.Value = Value;
    }

    #region IComparable implementation

    public int CompareTo(Email other)
    {
        return string.Compare(Value, other.Value, StringComparison.Ordinal);
    }

    #endregion

    #region IEquatable implementation
    
    public bool Equals(Email other)
    {
        return Value == other.Value;
    }
    
    #endregion

    #region Object overrides

    public override string ToString()
    {
        return Value;
    }

    public bool IsValid() => IsValid(Value);
    private static bool IsValid(string value) => value.Contains('@');

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
    
    #endregion

    public string Value { get; init; }

    public void Deconstruct(out string value)
    {
        value = Value;
    }
}

public class EmailInvalidException(string value) : ArgumentException($"Invalid email format. Value: {value}");