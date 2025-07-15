using System.Text.Json;

namespace PrimitiveTypeObsession.Core.Abstractions.UserToken;

public class UserTokenJsonConverter : System.Text.Json.Serialization.JsonConverter<UserToken>
{
    public override UserToken Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var isParsed = reader.TryGetGuid(out var parsedGuid);
        if (isParsed == false)
            throw new ArgumentException($"Could not parse {reader.GetString()} to {nameof(UserToken)}");
        
        return new UserToken(parsedGuid);
    }

    public override void Write(Utf8JsonWriter writer, UserToken myGuid, JsonSerializerOptions options)
    {
        writer.WriteStringValue(myGuid.Value);
    }
}