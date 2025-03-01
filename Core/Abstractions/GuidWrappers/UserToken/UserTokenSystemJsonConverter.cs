using System.Text.Json;

namespace PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.UserToken;

public class UserTokenSystemJsonConverter : System.Text.Json.Serialization.JsonConverter<UserToken>
{
    public override UserToken Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var parsed = reader.TryGetGuid(out var parsedGuid);
        if (parsed == false)
            throw new JsonException($"Cannot deserialize {typeToConvert.Name} from Json! Value: {reader.GetString()}");

        return new UserToken(parsedGuid);
    }

    public override void Write(Utf8JsonWriter writer, UserToken guidWrapper, JsonSerializerOptions options)
    {
        writer.WriteStringValue(guidWrapper.Value);
    }
}