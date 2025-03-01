namespace PrimitiveTypeObsession.Core.UserToken;

public interface IIdWrapper
{
    //empty interface for determining wrappers without needing to specify generic type
}

public interface IIdWrapper<TWrapperType> : IIdWrapper, IEquatable<TWrapperType>, IComparable<TWrapperType>
{
}