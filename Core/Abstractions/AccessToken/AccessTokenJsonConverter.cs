using System.Text.Json;

namespace PrimitiveTypeObsession.Core.Abstractions.AccessToken;

public class AccessTokenJsonConverter : System.Text.Json.Serialization.JsonConverter<AccessToken>
{
    public override AccessToken Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var isParsed = reader.TryGetGuid(out var parsedGuid);
        if (isParsed == false)
            throw new ArgumentException($"Could not parse {reader.GetString()} to {nameof(AccessToken)}");
        
        return new AccessToken(parsedGuid);
    }

    public override void Write(Utf8JsonWriter writer, AccessToken myGuid, JsonSerializerOptions options)
    {
        writer.WriteStringValue(myGuid.Value);
    }
}