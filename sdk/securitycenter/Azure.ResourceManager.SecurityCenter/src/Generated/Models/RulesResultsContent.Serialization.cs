// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class RulesResultsContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LatestScan))
            {
                writer.WritePropertyName("latestScan");
                writer.WriteBooleanValue(LatestScan.Value);
            }
            if (Optional.IsCollectionDefined(Results))
            {
                writer.WritePropertyName("results");
                writer.WriteStartObject();
                foreach (var item in Results)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStartArray();
                        foreach (var item1 in item0)
                        {
                            writer.WriteStringValue(item1);
                        }
                        writer.WriteEndArray();
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }
    }
}
