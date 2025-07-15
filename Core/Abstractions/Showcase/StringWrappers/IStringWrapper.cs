namespace PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers;

public interface IValidatableWrapper
{
    bool IsValid();
}

public interface IValidatableStringWrapper : IValidatableWrapper
{
    string Value { get; init; }
}

public interface IStringWrapper<TWrapperType> : IValidatableStringWrapper, IEquatable<TWrapperType>, IComparable<TWrapperType>;