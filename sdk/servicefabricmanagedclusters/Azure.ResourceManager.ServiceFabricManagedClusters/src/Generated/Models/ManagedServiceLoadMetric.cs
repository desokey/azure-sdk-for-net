// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Specifies a metric to load balance a service during runtime. </summary>
    public partial class ManagedServiceLoadMetric
    {
        /// <summary> Initializes a new instance of ManagedServiceLoadMetric. </summary>
        /// <param name="name"> The name of the metric. If the service chooses to report load during runtime, the load metric name should match the name that is specified in Name exactly. Note that metric names are case sensitive. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ManagedServiceLoadMetric(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of ManagedServiceLoadMetric. </summary>
        /// <param name="name"> The name of the metric. If the service chooses to report load during runtime, the load metric name should match the name that is specified in Name exactly. Note that metric names are case sensitive. </param>
        /// <param name="weight"> The service load metric relative weight, compared to other metrics configured for this service, as a number. </param>
        /// <param name="primaryDefaultLoad"> Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when it is a Primary replica. </param>
        /// <param name="secondaryDefaultLoad"> Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when it is a Secondary replica. </param>
        /// <param name="defaultLoad"> Used only for Stateless services. The default amount of load, as a number, that this service creates for this metric. </param>
        internal ManagedServiceLoadMetric(string name, ManagedServiceLoadMetricWeight? weight, int? primaryDefaultLoad, int? secondaryDefaultLoad, int? defaultLoad)
        {
            Name = name;
            Weight = weight;
            PrimaryDefaultLoad = primaryDefaultLoad;
            SecondaryDefaultLoad = secondaryDefaultLoad;
            DefaultLoad = defaultLoad;
        }

        /// <summary> The name of the metric. If the service chooses to report load during runtime, the load metric name should match the name that is specified in Name exactly. Note that metric names are case sensitive. </summary>
        public string Name { get; set; }
        /// <summary> The service load metric relative weight, compared to other metrics configured for this service, as a number. </summary>
        public ManagedServiceLoadMetricWeight? Weight { get; set; }
        /// <summary> Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when it is a Primary replica. </summary>
        public int? PrimaryDefaultLoad { get; set; }
        /// <summary> Used only for Stateful services. The default amount of load, as a number, that this service creates for this metric when it is a Secondary replica. </summary>
        public int? SecondaryDefaultLoad { get; set; }
        /// <summary> Used only for Stateless services. The default amount of load, as a number, that this service creates for this metric. </summary>
        public int? DefaultLoad { get; set; }
    }
}
