// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigurationServiceGitReposValidationMessages
    {
        internal static AppPlatformConfigurationServiceGitReposValidationMessages DeserializeAppPlatformConfigurationServiceGitReposValidationMessages(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<string>> messages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    messages = array;
                    continue;
                }
            }
            return new AppPlatformConfigurationServiceGitReposValidationMessages(name.Value, Optional.ToList(messages));
        }
    }
}
