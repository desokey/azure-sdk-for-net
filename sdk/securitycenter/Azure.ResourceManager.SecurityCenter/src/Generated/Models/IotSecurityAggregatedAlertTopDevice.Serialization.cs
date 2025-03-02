// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class IotSecurityAggregatedAlertTopDevice
    {
        internal static IotSecurityAggregatedAlertTopDevice DeserializeIotSecurityAggregatedAlertTopDevice(JsonElement element)
        {
            Optional<string> deviceId = default;
            Optional<long> alertsCount = default;
            Optional<string> lastOccurrence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alertsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastOccurrence"))
                {
                    lastOccurrence = property.Value.GetString();
                    continue;
                }
            }
            return new IotSecurityAggregatedAlertTopDevice(deviceId.Value, Optional.ToNullable(alertsCount), lastOccurrence.Value);
        }
    }
}
