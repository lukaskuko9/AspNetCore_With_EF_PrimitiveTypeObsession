namespace PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.ProcessingToken;

[System.Text.Json.Serialization.JsonConverter(typeof(ProcessingTokenSystemJsonConverter))]
public readonly record struct ProcessingToken(Guid Value) : IGuidWrapper<ProcessingToken>
{
    #region IComparable implementation

    public int CompareTo(ProcessingToken other)
    {
        return Value.CompareTo(other.Value);
    }

    #endregion

    #region IEquatable implementation
    
    public bool Equals(ProcessingToken other)
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