using System.Text.Json;

namespace PrimitiveTypeObsession.Core.Abstractions.StringWrappers.UserAddress;

public class UserAddressSystemJsonConverter : System.Text.Json.Serialization.JsonConverter<UserAddress>
{
    public override UserAddress Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();
        if (str is null)
            throw new ArgumentException($"Could not parse null value to {nameof(UserAddress)}");

        return new UserAddress(str);
    }

    public override void Write(Utf8JsonWriter writer, UserAddress userAddress, JsonSerializerOptions options)
    {
        writer.WriteStringValue(userAddress.Value);
    }
}