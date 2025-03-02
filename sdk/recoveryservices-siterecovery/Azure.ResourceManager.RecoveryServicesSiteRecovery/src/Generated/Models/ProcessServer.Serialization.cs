// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ProcessServer
    {
        internal static ProcessServer DeserializeProcessServer(JsonElement element)
        {
            Optional<string> friendlyName = default;
            Optional<string> id = default;
            Optional<string> ipAddress = default;
            Optional<string> osType = default;
            Optional<string> agentVersion = default;
            Optional<DateTimeOffset> lastHeartbeat = default;
            Optional<string> versionStatus = default;
            Optional<IReadOnlyList<MobilityServiceUpdate>> mobilityServiceUpdates = default;
            Optional<string> hostId = default;
            Optional<string> machineCount = default;
            Optional<string> replicationPairCount = default;
            Optional<string> systemLoad = default;
            Optional<string> systemLoadStatus = default;
            Optional<string> cpuLoad = default;
            Optional<string> cpuLoadStatus = default;
            Optional<long> totalMemoryInBytes = default;
            Optional<long> availableMemoryInBytes = default;
            Optional<string> memoryUsageStatus = default;
            Optional<long> totalSpaceInBytes = default;
            Optional<long> availableSpaceInBytes = default;
            Optional<string> spaceUsageStatus = default;
            Optional<string> psServiceStatus = default;
            Optional<DateTimeOffset> sslCertExpiryDate = default;
            Optional<int> sslCertExpiryRemainingDays = default;
            Optional<string> osVersion = default;
            Optional<IReadOnlyList<HealthError>> healthErrors = default;
            Optional<DateTimeOffset> agentExpiryDate = default;
            Optional<VersionDetails> agentVersionDetails = default;
            Optional<ProtectionHealth> health = default;
            Optional<DateTimeOffset> psStatsRefreshTime = default;
            Optional<long> throughputUploadPendingDataInBytes = default;
            Optional<long> throughputInMBps = default;
            Optional<long> throughputInBytes = default;
            Optional<string> throughputStatus = default;
            Optional<string> marsCommunicationStatus = default;
            Optional<string> marsRegistrationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersion"))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("versionStatus"))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mobilityServiceUpdates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MobilityServiceUpdate> array = new List<MobilityServiceUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MobilityServiceUpdate.DeserializeMobilityServiceUpdate(item));
                    }
                    mobilityServiceUpdates = array;
                    continue;
                }
                if (property.NameEquals("hostId"))
                {
                    hostId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineCount"))
                {
                    machineCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationPairCount"))
                {
                    replicationPairCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemLoad"))
                {
                    systemLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemLoadStatus"))
                {
                    systemLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuLoad"))
                {
                    cpuLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuLoadStatus"))
                {
                    cpuLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalMemoryInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableMemoryInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availableMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryUsageStatus"))
                {
                    memoryUsageStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalSpaceInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableSpaceInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availableSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spaceUsageStatus"))
                {
                    spaceUsageStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("psServiceStatus"))
                {
                    psServiceStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslCertExpiryDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sslCertExpiryDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sslCertExpiryRemainingDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sslCertExpiryRemainingDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osVersion"))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HealthError> array = new List<HealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthError.DeserializeHealthError(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("agentExpiryDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    agentExpiryDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("agentVersionDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    agentVersionDetails = VersionDetails.DeserializeVersionDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("health"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    health = new ProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("psStatsRefreshTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    psStatsRefreshTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("throughputUploadPendingDataInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    throughputUploadPendingDataInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throughputInMBps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    throughputInMBps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throughputInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    throughputInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throughputStatus"))
                {
                    throughputStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marsCommunicationStatus"))
                {
                    marsCommunicationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marsRegistrationStatus"))
                {
                    marsRegistrationStatus = property.Value.GetString();
                    continue;
                }
            }
            return new ProcessServer(friendlyName.Value, id.Value, ipAddress.Value, osType.Value, agentVersion.Value, Optional.ToNullable(lastHeartbeat), versionStatus.Value, Optional.ToList(mobilityServiceUpdates), hostId.Value, machineCount.Value, replicationPairCount.Value, systemLoad.Value, systemLoadStatus.Value, cpuLoad.Value, cpuLoadStatus.Value, Optional.ToNullable(totalMemoryInBytes), Optional.ToNullable(availableMemoryInBytes), memoryUsageStatus.Value, Optional.ToNullable(totalSpaceInBytes), Optional.ToNullable(availableSpaceInBytes), spaceUsageStatus.Value, psServiceStatus.Value, Optional.ToNullable(sslCertExpiryDate), Optional.ToNullable(sslCertExpiryRemainingDays), osVersion.Value, Optional.ToList(healthErrors), Optional.ToNullable(agentExpiryDate), agentVersionDetails.Value, Optional.ToNullable(health), Optional.ToNullable(psStatsRefreshTime), Optional.ToNullable(throughputUploadPendingDataInBytes), Optional.ToNullable(throughputInMBps), Optional.ToNullable(throughputInBytes), throughputStatus.Value, marsCommunicationStatus.Value, marsRegistrationStatus.Value);
        }
    }
}
