// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Managed Identity Sql Control Settings
    /// </summary>
    /// <remarks>
    /// Sql Control Settings for workspace managed identity
    /// </remarks>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedIdentitySqlControlSettingsModel : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedIdentitySqlControlSettingsModel class.
        /// </summary>
        public ManagedIdentitySqlControlSettingsModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedIdentitySqlControlSettingsModel class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="grantSqlControlToManagedIdentity">Grant sql control to
        /// managed identity</param>
        public ManagedIdentitySqlControlSettingsModel(string id = default(string), string name = default(string), string type = default(string), ManagedIdentitySqlControlSettingsModelPropertiesGrantSqlControlToManagedIdentity grantSqlControlToManagedIdentity = default(ManagedIdentitySqlControlSettingsModelPropertiesGrantSqlControlToManagedIdentity))
            : base(id, name, type)
        {
            GrantSqlControlToManagedIdentity = grantSqlControlToManagedIdentity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets grant sql control to managed identity
        /// </summary>
        [JsonProperty(PropertyName = "properties.grantSqlControlToManagedIdentity")]
        public ManagedIdentitySqlControlSettingsModelPropertiesGrantSqlControlToManagedIdentity GrantSqlControlToManagedIdentity { get; set; }

    }
}
