using System.Text.Json;

namespace PrimitiveTypeObsession.Core.UserToken;

public class UserTokenSystemJsonConverter : System.Text.Json.Serialization.JsonConverter<UserToken>
{
    public override UserToken Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var parsed = reader.TryGetGuid(out var userToken);
        if(parsed)
            return new UserToken(userToken);

        throw new JsonException($"Cannot deserialize {nameof(UserToken)} from Json! Value: {reader.GetString()}");
    }

    public override void Write(Utf8JsonWriter writer, UserToken value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}