using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JpnCardsPokemonSdk.Utils.JsonConverter;

internal class NoneIntJsonConverter : JsonConverter<int>
{
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var valueStr = reader.GetString();

            if (valueStr?.Equals("none", StringComparison.InvariantCultureIgnoreCase) ?? true)
                return -1;

            if (int.TryParse(valueStr, out var number))
                return number;
        }
        else if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetInt32();
        }

        return -1;
    }

    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    {
        if (value >= 0)
            writer.WriteNumberValue(value);
        else
            writer.WriteStringValue("non");
    }
}