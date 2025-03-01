namespace PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.AccountToken;

[System.Text.Json.Serialization.JsonConverter(typeof(AccountTokenSystemJsonConverter))]
public readonly record struct AccountToken(Guid Value) : IGuidWrapper<AccountToken>
{
    #region IComparable implementation

    public int CompareTo(AccountToken other)
    {
        return Value.CompareTo(other.Value);
    }

    #endregion

    #region IEquatable implementation
    
    public bool Equals(AccountToken other)
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