using System.Text.Json;

namespace PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.AccountToken;

public class AccountTokenSystemJsonConverter : System.Text.Json.Serialization.JsonConverter<AccountToken>
{
    public override AccountToken Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var parsed = reader.TryGetGuid(out var parsedGuid);
        if (parsed == false)
            throw new JsonException($"Cannot deserialize {typeToConvert.Name} from Json! Value: {reader.GetString()}");

        return new AccountToken(parsedGuid);
    }

    public override void Write(Utf8JsonWriter writer, AccountToken guidWrapper, JsonSerializerOptions options)
    {
        writer.WriteStringValue(guidWrapper.Value);
    }
}