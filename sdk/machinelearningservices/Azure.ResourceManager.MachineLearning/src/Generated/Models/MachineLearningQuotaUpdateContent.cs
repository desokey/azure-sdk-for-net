// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Quota update parameters.
    /// Serialized Name: QuotaUpdateParameters
    /// </summary>
    public partial class MachineLearningQuotaUpdateContent
    {
        /// <summary> Initializes a new instance of MachineLearningQuotaUpdateContent. </summary>
        public MachineLearningQuotaUpdateContent()
        {
            Value = new ChangeTrackingList<MachineLearningQuotaProperties>();
        }

        /// <summary>
        /// The list for update quota.
        /// Serialized Name: QuotaUpdateParameters.value
        /// </summary>
        public IList<MachineLearningQuotaProperties> Value { get; }
        /// <summary>
        /// Region of workspace quota to be updated.
        /// Serialized Name: QuotaUpdateParameters.location
        /// </summary>
        public AzureLocation? Location { get; set; }
    }
}
