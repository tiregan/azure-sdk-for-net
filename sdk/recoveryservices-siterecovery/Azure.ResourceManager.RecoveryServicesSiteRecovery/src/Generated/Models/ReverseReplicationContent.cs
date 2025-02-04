// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Reverse replication input. </summary>
    public partial class ReverseReplicationContent
    {
        /// <summary> Initializes a new instance of <see cref="ReverseReplicationContent"/>. </summary>
        public ReverseReplicationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReverseReplicationContent"/>. </summary>
        /// <param name="properties"> Reverse replication properties. </param>
        internal ReverseReplicationContent(ReverseReplicationProperties properties)
        {
            Properties = properties;
        }

        /// <summary> Reverse replication properties. </summary>
        public ReverseReplicationProperties Properties { get; set; }
    }
}
