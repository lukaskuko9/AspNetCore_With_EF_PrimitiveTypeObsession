namespace PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;

public interface IGuidWrapper
{
    Guid Value { get; init; }
}

public interface IGuidWrapper<TWrapperType> : IGuidWrapper, IEquatable<TWrapperType>, IComparable<TWrapperType>;