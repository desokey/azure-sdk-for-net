// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    internal static partial class DataBoxValidationInputDiscriminatorExtensions
    {
        public static string ToSerialString(this DataBoxValidationInputDiscriminator value) => value switch
        {
            DataBoxValidationInputDiscriminator.ValidateAddress => "ValidateAddress",
            DataBoxValidationInputDiscriminator.ValidateSubscriptionIsAllowedToCreateJob => "ValidateSubscriptionIsAllowedToCreateJob",
            DataBoxValidationInputDiscriminator.ValidatePreferences => "ValidatePreferences",
            DataBoxValidationInputDiscriminator.ValidateCreateOrderLimit => "ValidateCreateOrderLimit",
            DataBoxValidationInputDiscriminator.ValidateSkuAvailability => "ValidateSkuAvailability",
            DataBoxValidationInputDiscriminator.ValidateDataTransferDetails => "ValidateDataTransferDetails",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataBoxValidationInputDiscriminator value.")
        };

        public static DataBoxValidationInputDiscriminator ToDataBoxValidationInputDiscriminator(this string value)
        {
            if (string.Equals(value, "ValidateAddress", StringComparison.InvariantCultureIgnoreCase)) return DataBoxValidationInputDiscriminator.ValidateAddress;
            if (string.Equals(value, "ValidateSubscriptionIsAllowedToCreateJob", StringComparison.InvariantCultureIgnoreCase)) return DataBoxValidationInputDiscriminator.ValidateSubscriptionIsAllowedToCreateJob;
            if (string.Equals(value, "ValidatePreferences", StringComparison.InvariantCultureIgnoreCase)) return DataBoxValidationInputDiscriminator.ValidatePreferences;
            if (string.Equals(value, "ValidateCreateOrderLimit", StringComparison.InvariantCultureIgnoreCase)) return DataBoxValidationInputDiscriminator.ValidateCreateOrderLimit;
            if (string.Equals(value, "ValidateSkuAvailability", StringComparison.InvariantCultureIgnoreCase)) return DataBoxValidationInputDiscriminator.ValidateSkuAvailability;
            if (string.Equals(value, "ValidateDataTransferDetails", StringComparison.InvariantCultureIgnoreCase)) return DataBoxValidationInputDiscriminator.ValidateDataTransferDetails;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataBoxValidationInputDiscriminator value.");
        }
    }
}
