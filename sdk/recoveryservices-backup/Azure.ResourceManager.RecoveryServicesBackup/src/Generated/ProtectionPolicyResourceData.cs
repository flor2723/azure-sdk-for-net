// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary> A class representing the ProtectionPolicyResource data model. </summary>
    public partial class ProtectionPolicyResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ProtectionPolicyResourceData. </summary>
        /// <param name="location"> The location. </param>
        public ProtectionPolicyResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ProtectionPolicyResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// ProtectionPolicyResource properties
        /// Please note <see cref="ProtectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureIaasVmProtectionPolicy"/>, <see cref="AzureSqlProtectionPolicy"/>, <see cref="AzureFileShareProtectionPolicy"/>, <see cref="AzureVmWorkloadProtectionPolicy"/>, <see cref="GenericProtectionPolicy"/> and <see cref="MabProtectionPolicy"/>.
        /// </param>
        /// <param name="eTag"> Optional ETag. </param>
        internal ProtectionPolicyResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProtectionPolicy properties, ETag? eTag) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary>
        /// ProtectionPolicyResource properties
        /// Please note <see cref="ProtectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureIaasVmProtectionPolicy"/>, <see cref="AzureSqlProtectionPolicy"/>, <see cref="AzureFileShareProtectionPolicy"/>, <see cref="AzureVmWorkloadProtectionPolicy"/>, <see cref="GenericProtectionPolicy"/> and <see cref="MabProtectionPolicy"/>.
        /// </summary>
        public ProtectionPolicy Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
