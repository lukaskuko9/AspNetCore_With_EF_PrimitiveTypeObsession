namespace PrimitiveTypeObsession.Core.Abstractions.StringWrappers.UserAddress;

[System.Text.Json.Serialization.JsonConverter(typeof(UserAddressSystemJsonConverter))]
public readonly record struct UserAddress(string Value) : IStringWrapper<UserAddress>
{
    #region IComparable implementation

    public int CompareTo(UserAddress other)
    {
        return string.Compare(Value, other.Value, StringComparison.Ordinal);
    }

    #endregion

    #region IEquatable implementation
    
    public bool Equals(UserAddress other)
    {
        return Value == other.Value;
    }
    
    #endregion

    #region Object overrides

    public override string ToString()
    {
        return Value.ToString();
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
    
    #endregion
}