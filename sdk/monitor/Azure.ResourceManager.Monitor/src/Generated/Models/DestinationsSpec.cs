// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specification of destinations that can be used in data flows. </summary>
    public partial class DestinationsSpec
    {
        /// <summary> Initializes a new instance of DestinationsSpec. </summary>
        public DestinationsSpec()
        {
            LogAnalytics = new ChangeTrackingList<LogAnalyticsDestination>();
        }

        /// <summary> Initializes a new instance of DestinationsSpec. </summary>
        /// <param name="logAnalytics"> List of Log Analytics destinations. </param>
        /// <param name="azureMonitorMetrics"> Azure Monitor Metrics destination. </param>
        internal DestinationsSpec(IList<LogAnalyticsDestination> logAnalytics, DestinationsSpecAzureMonitorMetrics azureMonitorMetrics)
        {
            LogAnalytics = logAnalytics;
            AzureMonitorMetrics = azureMonitorMetrics;
        }

        /// <summary> List of Log Analytics destinations. </summary>
        public IList<LogAnalyticsDestination> LogAnalytics { get; }
        /// <summary> Azure Monitor Metrics destination. </summary>
        public DestinationsSpecAzureMonitorMetrics AzureMonitorMetrics { get; set; }
    }
}
