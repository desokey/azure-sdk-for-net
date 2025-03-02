// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> SQL Vulnerability Assessment baseline Details. </summary>
    public partial class Baseline
    {
        /// <summary> Initializes a new instance of Baseline. </summary>
        internal Baseline()
        {
            ExpectedResults = new ChangeTrackingList<IList<string>>();
        }

        /// <summary> Initializes a new instance of Baseline. </summary>
        /// <param name="expectedResults"> SQL Vulnerability Assessment baseline expected results. </param>
        /// <param name="updatedOn"> SQL Vulnerability Assessment baseline update time (UTC). </param>
        internal Baseline(IReadOnlyList<IList<string>> expectedResults, DateTimeOffset? updatedOn)
        {
            ExpectedResults = expectedResults;
            UpdatedOn = updatedOn;
        }

        /// <summary> SQL Vulnerability Assessment baseline expected results. </summary>
        public IReadOnlyList<IList<string>> ExpectedResults { get; }
        /// <summary> SQL Vulnerability Assessment baseline update time (UTC). </summary>
        public DateTimeOffset? UpdatedOn { get; }
    }
}
