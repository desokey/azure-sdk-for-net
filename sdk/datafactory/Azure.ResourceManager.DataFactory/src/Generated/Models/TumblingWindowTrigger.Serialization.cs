// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TumblingWindowTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("pipeline");
            writer.WriteObjectValue(Pipeline);
            writer.WritePropertyName("type");
            writer.WriteStringValue(TriggerType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("frequency");
            writer.WriteStringValue(Frequency.ToString());
            writer.WritePropertyName("interval");
            writer.WriteNumberValue(Interval);
            writer.WritePropertyName("startTime");
            writer.WriteStringValue(StartOn, "O");
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Delay))
            {
                writer.WritePropertyName("delay");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Delay);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Delay.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("maxConcurrency");
            writer.WriteNumberValue(MaxConcurrency);
            if (Optional.IsDefined(RetryPolicy))
            {
                writer.WritePropertyName("retryPolicy");
                writer.WriteObjectValue(RetryPolicy);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static TumblingWindowTrigger DeserializeTumblingWindowTrigger(JsonElement element)
        {
            TriggerPipelineReference pipeline = default;
            string type = default;
            Optional<string> description = default;
            Optional<FactoryTriggerRuntimeState> runtimeState = default;
            Optional<IList<BinaryData>> annotations = default;
            TumblingWindowFrequency frequency = default;
            int interval = default;
            DateTimeOffset startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<BinaryData> delay = default;
            int maxConcurrency = default;
            Optional<RetryPolicy> retryPolicy = default;
            Optional<IList<DependencyReference>> dependsOn = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipeline"))
                {
                    pipeline = TriggerPipelineReference.DeserializeTriggerPipelineReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    runtimeState = new FactoryTriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("frequency"))
                        {
                            frequency = new TumblingWindowFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("interval"))
                        {
                            interval = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("delay"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            delay = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("maxConcurrency"))
                        {
                            maxConcurrency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("retryPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            retryPolicy = RetryPolicy.DeserializeRetryPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dependsOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DependencyReference> array = new List<DependencyReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DependencyReference.DeserializeDependencyReference(item));
                            }
                            dependsOn = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TumblingWindowTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, pipeline, frequency, interval, startTime, Optional.ToNullable(endTime), delay.Value, maxConcurrency, retryPolicy.Value, Optional.ToList(dependsOn));
        }
    }
}
