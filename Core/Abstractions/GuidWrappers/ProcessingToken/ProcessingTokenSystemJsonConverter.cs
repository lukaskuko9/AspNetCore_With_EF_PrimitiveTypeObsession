using System.Text.Json;

namespace PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.ProcessingToken;

public class ProcessingTokenSystemJsonConverter : System.Text.Json.Serialization.JsonConverter<ProcessingToken>
{
    public override ProcessingToken Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var parsed = reader.TryGetGuid(out var parsedGuid);
        if (parsed == false)
            throw new JsonException($"Cannot deserialize {typeToConvert.Name} from Json! Value: {reader.GetString()}");
        
        return new ProcessingToken(parsedGuid);
    }

    public override void Write(Utf8JsonWriter writer, ProcessingToken guidWrapper, JsonSerializerOptions options)
    {
        writer.WriteStringValue(guidWrapper.Value);
    }
}