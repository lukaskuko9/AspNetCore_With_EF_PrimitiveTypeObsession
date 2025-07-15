using System.Text.Json;

namespace PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.PhoneNumber;

public class PhoneNumberSystemJsonConverter : System.Text.Json.Serialization.JsonConverter<PhoneNumber>
{
    public override PhoneNumber Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();
        if(str is null)
            throw new ArgumentException($"Could not parse null value to {nameof(PhoneNumber)}");
        
        return new PhoneNumber(str);
    }

    public override void Write(Utf8JsonWriter writer, PhoneNumber phoneNumber, JsonSerializerOptions options)
    {
        writer.WriteStringValue(phoneNumber.Value);
    }
}