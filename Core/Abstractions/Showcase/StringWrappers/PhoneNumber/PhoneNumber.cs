namespace PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.PhoneNumber;

[System.Text.Json.Serialization.JsonConverter(typeof(PhoneNumberSystemJsonConverter))]
public readonly record struct PhoneNumber(string Value) : IStringWrapper<PhoneNumber>
{
    #region IComparable implementation

    public int CompareTo(PhoneNumber other)
    {
        return string.Compare(Value, other.Value, StringComparison.Ordinal);
    }

    #endregion

    #region IEquatable implementation
    
    public bool Equals(PhoneNumber other)
    {
        return Value == other.Value;
    }
    
    #endregion

    #region Object overrides

    public override string ToString()
    {
        return Value;
    }

    public bool IsValid()
    {
        return true;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
    
    #endregion
}