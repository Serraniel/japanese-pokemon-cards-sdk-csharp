using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JpnCardsPokemon.Sdk.Utils.JsonConverter
{
    internal class CustomDateTimeConverter : JsonConverter<DateTime?>
    {
        private readonly string _dateTimeFormat = "MM/dd/yyyy";

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.Null:
                    return null;
                case JsonTokenType.String:
                {
                    var dateString = reader.GetString();
                    if (DateTime.TryParseExact(dateString, _dateTimeFormat, null, System.Globalization.DateTimeStyles.None, out var dateTime))
                    {
                        return dateTime;
                    }

                    break;
                }
                default:
                    throw new JsonException($"Cannot convert {reader.GetString()} to DateTime.");
            }

            throw new JsonException($"Cannot convert {reader.GetString()} to DateTime.");
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString(_dateTimeFormat));
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
