namespace PrimitiveTypeObsession.Core.UserToken;

[System.Text.Json.Serialization.JsonConverter(typeof(UserTokenSystemJsonConverter))]
public readonly record struct UserToken(Guid Value) : IIdWrapper<UserToken>
{
    #region IComparable implementation

    public int CompareTo(UserToken other)
    {
        return Value.CompareTo(other.Value);
    }

    #endregion

    #region IEquatable implementation
    
    public bool Equals(UserToken other)
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