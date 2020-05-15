// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AzureReachabilityReportLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("country");
            writer.WriteStringValue(Country);
            if (State != null)
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State);
            }
            if (City != null)
            {
                writer.WritePropertyName("city");
                writer.WriteStringValue(City);
            }
            writer.WriteEndObject();
        }

        internal static AzureReachabilityReportLocation DeserializeAzureReachabilityReportLocation(JsonElement element)
        {
            string country = default;
            string state = default;
            string city = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("country"))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    city = property.Value.GetString();
                    continue;
                }
            }
            return new AzureReachabilityReportLocation(country, state, city);
        }
    }
}
