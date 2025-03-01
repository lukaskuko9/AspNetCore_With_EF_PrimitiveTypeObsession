namespace PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;

[System.Text.Json.Serialization.JsonConverter(typeof(MyGuidJsonConverter))]
public readonly record struct MyGuid(Guid Value) : IGuidWrapper<MyGuid>
{
    #region IComparable implementation

    public int CompareTo(MyGuid other)
    {
        return Value.CompareTo(other.Value);
    }

    #endregion

    #region IEquatable implementation
    
    public bool Equals(MyGuid other)
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