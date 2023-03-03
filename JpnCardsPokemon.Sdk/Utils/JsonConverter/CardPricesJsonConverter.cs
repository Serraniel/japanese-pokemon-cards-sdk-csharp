using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using JpnCardsPokemon.Sdk.Api;

namespace JpnCardsPokemon.Sdk.Utils.JsonConverter;

internal class CardPricesJsonConverter : JsonConverter<IEnumerable<CardPrice>>
{
    public override IEnumerable<CardPrice>? Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        var resultBucket = new List<CardPrice>();

        // read sellers
        while (reader.Read())
        {
            // Finished parsing?
            if (reader.TokenType == JsonTokenType.EndArray)
                break;


            if (reader.TokenType != JsonTokenType.PropertyName) continue;
            var sellerName = reader.GetString();

            // Versions
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    break;

                // Version, usually "Regular"
                if (reader.TokenType != JsonTokenType.PropertyName) continue;
                var cardVersion = reader.GetString();

                // Conditions
                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndObject) break;

                    if (reader.TokenType != JsonTokenType.PropertyName) continue;
                    var condition = reader.GetString();

                    var cardPrice = new CardPrice
                    {
                        Seller = sellerName,
                        Version = cardVersion,
                        Condition = condition
                    };

                    var propertyName = string.Empty;
                    // Final price properties
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndObject) break;


                        if (reader.TokenType == JsonTokenType.PropertyName)
                        {
                            propertyName = reader.GetString();
                        }
                        else
                        {
                            // search correct property in object
                            if (string.IsNullOrEmpty(propertyName)) continue;

                            var property = cardPrice.GetType().GetProperty(propertyName) ?? cardPrice
                                .GetType().GetProperties().FirstOrDefault(p =>
                                    p.GetCustomAttributes(typeof(JsonPropertyNameAttribute), true)
                                        .Cast<JsonPropertyNameAttribute>()
                                        .Any(a => a.Name.Equals(propertyName,
                                            StringComparison.InvariantCultureIgnoreCase)));
                            if (property != null)
                            {
                                object? value = null;
                                var propertyType = property.PropertyType;

                                if (propertyType == typeof(string))
                                    value = reader.GetString();
                                else if (propertyType == typeof(decimal))
                                    value = reader.GetDecimal();
                                else if (propertyType == typeof(DateTime?))
                                    if (DateTime.TryParseExact(reader.GetString(), "MM/dd/yyyy",
                                            CultureInfo.InvariantCulture, DateTimeStyles.None, out var dt))
                                        value = dt;

                                property.SetValue(cardPrice, value);
                            }

                            propertyName = string.Empty;
                        }
                    }

                    // add card to bucket
                    resultBucket.Add(cardPrice);
                }
            }
        }


        return resultBucket;
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<CardPrice> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}