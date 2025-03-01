using System.Text.Json;

namespace PrimitiveTypeObsession.Core.Abstractions.StringWrappers.Email;

public class EmailSystemJsonConverter : System.Text.Json.Serialization.JsonConverter<Email>
{
    public override Email Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();
        if(str is null)
            throw new ArgumentException($"Could not parse null value to {nameof(Email)}");
        
        return new Email(str);
    }

    public override void Write(Utf8JsonWriter writer, Email email, JsonSerializerOptions options)
    {
            writer.WriteStringValue(email.Value);
    }
}