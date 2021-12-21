// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Describes the list of Azure Monitor PrivateLinkScope resources. </summary>
    internal partial class AzureMonitorPrivateLinkScopeListResult
    {
        /// <summary> Initializes a new instance of AzureMonitorPrivateLinkScopeListResult. </summary>
        /// <param name="value"> List of Azure Monitor PrivateLinkScope definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AzureMonitorPrivateLinkScopeListResult(IEnumerable<AzureMonitorPrivateLinkScopeData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of AzureMonitorPrivateLinkScopeListResult. </summary>
        /// <param name="value"> List of Azure Monitor PrivateLinkScope definitions. </param>
        /// <param name="nextLink"> The URI to get the next set of Azure Monitor PrivateLinkScope definitions if too many PrivateLinkScopes where returned in the result set. </param>
        internal AzureMonitorPrivateLinkScopeListResult(IReadOnlyList<AzureMonitorPrivateLinkScopeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Azure Monitor PrivateLinkScope definitions. </summary>
        public IReadOnlyList<AzureMonitorPrivateLinkScopeData> Value { get; }
        /// <summary> The URI to get the next set of Azure Monitor PrivateLinkScope definitions if too many PrivateLinkScopes where returned in the result set. </summary>
        public string NextLink { get; }
    }
}
