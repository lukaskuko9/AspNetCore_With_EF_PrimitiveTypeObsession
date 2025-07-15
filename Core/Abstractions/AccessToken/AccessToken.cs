namespace PrimitiveTypeObsession.Core.Abstractions.AccessToken;

[System.Text.Json.Serialization.JsonConverter(typeof(AccessTokenJsonConverter))]
public readonly record struct AccessToken(Guid Value) : IGuidWrapper<AccessToken>
{
    #region IComparable implementation

    public int CompareTo(AccessToken other)
    {
        return Value.CompareTo(other.Value);
    }

    #endregion

    #region IEquatable implementation
    
    public bool Equals(AccessToken other)
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