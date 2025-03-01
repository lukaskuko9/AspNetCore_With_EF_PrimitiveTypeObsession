using System.Text.Json;
using ArgumentException = System.ArgumentException;

namespace PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;

public class MyGuidJsonConverter : System.Text.Json.Serialization.JsonConverter<MyGuid>
{
    public override MyGuid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var isParsed = reader.TryGetGuid(out var parsedGuid);
        if (isParsed == false)
            throw new ArgumentException($"Could not parse {reader.GetString()} to {nameof(MyGuid)}");
        
        return new MyGuid(parsedGuid);
    }

    public override void Write(Utf8JsonWriter writer, MyGuid myGuid, JsonSerializerOptions options)
    {
        writer.WriteStringValue(myGuid.Value);
    }
}