// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Recovery plan provider specific failover input.
    /// Please note <see cref="RecoveryPlanProviderSpecificFailoverInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RecoveryPlanA2AFailoverInput"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailoverInput"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailbackInput"/>, <see cref="RecoveryPlanInMageFailoverInput"/>, <see cref="RecoveryPlanInMageAzureV2FailoverInput"/>, <see cref="RecoveryPlanInMageRcmFailoverInput"/> and <see cref="RecoveryPlanInMageRcmFailbackFailoverInput"/>.
    /// </summary>
    public abstract partial class RecoveryPlanProviderSpecificFailoverInput
    {
        /// <summary> Initializes a new instance of RecoveryPlanProviderSpecificFailoverInput. </summary>
        protected RecoveryPlanProviderSpecificFailoverInput()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
