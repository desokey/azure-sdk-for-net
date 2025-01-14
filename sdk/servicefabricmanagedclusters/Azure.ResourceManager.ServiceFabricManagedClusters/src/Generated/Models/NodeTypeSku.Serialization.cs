// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier);
            }
            writer.WritePropertyName("capacity");
            writer.WriteNumberValue(Capacity);
            writer.WriteEndObject();
        }

        internal static NodeTypeSku DeserializeNodeTypeSku(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> tier = default;
            int capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    capacity = property.Value.GetInt32();
                    continue;
                }
            }
            return new NodeTypeSku(name.Value, tier.Value, capacity);
        }
    }
}
