namespace PrimitiveTypeObsession.Core.Abstractions;

public interface IGuidWrapper<TWrapperType> : IEquatable<TWrapperType>, IComparable<TWrapperType>
{
    Guid Value { get; init; }
}
