// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the PrivateEndpointConnection data model. </summary>
    public partial class PrivateEndpointConnectionData : Resource
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionData. </summary>
        public PrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="privateLinkServiceConnectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        internal PrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType type, WritableSubResource privateEndpoint, PrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState, string provisioningState) : base(id, name, type)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Private endpoint which the connection belongs to. </summary>
        public WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Connection state of the private endpoint connection. </summary>
        public PrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; set; }
        /// <summary> State of the private endpoint connection. </summary>
        public string ProvisioningState { get; }
    }
}
