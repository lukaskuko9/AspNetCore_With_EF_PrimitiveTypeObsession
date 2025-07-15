using PrimitiveTypeObsession.Core.Abstractions.UserToken;

namespace PrimitiveTypeObsession.Infrastructure.Entities;

public class User
{
    public long Id { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required UserToken UserToken { get; init; }
    public required UserToken? NullableUserToken { get; init; }
}
    
