// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The claims for a rule management event data source. </summary>
    public partial class RuleManagementEventClaimsDataSource
    {
        /// <summary> Initializes a new instance of RuleManagementEventClaimsDataSource. </summary>
        public RuleManagementEventClaimsDataSource()
        {
        }

        /// <summary> Initializes a new instance of RuleManagementEventClaimsDataSource. </summary>
        /// <param name="emailAddress"> the email address. </param>
        internal RuleManagementEventClaimsDataSource(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        /// <summary> the email address. </summary>
        public string EmailAddress { get; set; }
    }
}
