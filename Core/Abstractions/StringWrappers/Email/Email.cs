namespace PrimitiveTypeObsession.Core.Abstractions.StringWrappers.Email;

[System.Text.Json.Serialization.JsonConverter(typeof(EmailSystemJsonConverter))]
public readonly record struct Email(string Value) : IStringWrapper<Email>
{
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

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
    
    #endregion
}