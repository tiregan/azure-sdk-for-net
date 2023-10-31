// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB resource throughput object. Either throughput is required or autoscaleSettings is required, but not both. </summary>
    public partial class ThroughputSettingsResourceInfo
    {
        /// <summary> Initializes a new instance of ThroughputSettingsResourceInfo. </summary>
        public ThroughputSettingsResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of ThroughputSettingsResourceInfo. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput. Either throughput is required or autoscaleSettings is required, but not both. </param>
        /// <param name="autoscaleSettings"> Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is required, but not both. </param>
        /// <param name="minimumThroughput"> The minimum throughput of the resource. </param>
        /// <param name="offerReplacePending"> The throughput replace is pending. </param>
        /// <param name="instantMaximumThroughput"> The offer throughput value to instantly scale up without triggering splits. </param>
        /// <param name="softAllowedMaximumThroughput"> The maximum throughput value or the maximum maxThroughput value (for autoscale) that can be specified. </param>
        internal ThroughputSettingsResourceInfo(int? throughput, AutoscaleSettingsResourceInfo autoscaleSettings, string minimumThroughput, string offerReplacePending, string instantMaximumThroughput, string softAllowedMaximumThroughput)
        {
            Throughput = throughput;
            AutoscaleSettings = autoscaleSettings;
            MinimumThroughput = minimumThroughput;
            OfferReplacePending = offerReplacePending;
            InstantMaximumThroughput = instantMaximumThroughput;
            SoftAllowedMaximumThroughput = softAllowedMaximumThroughput;
        }

        /// <summary> Value of the Cosmos DB resource throughput. Either throughput is required or autoscaleSettings is required, but not both. </summary>
        public int? Throughput { get; set; }
        /// <summary> Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is required, but not both. </summary>
        public AutoscaleSettingsResourceInfo AutoscaleSettings { get; set; }
        /// <summary> The minimum throughput of the resource. </summary>
        public string MinimumThroughput { get; }
        /// <summary> The throughput replace is pending. </summary>
        public string OfferReplacePending { get; }
        /// <summary> The offer throughput value to instantly scale up without triggering splits. </summary>
        public string InstantMaximumThroughput { get; }
        /// <summary> The maximum throughput value or the maximum maxThroughput value (for autoscale) that can be specified. </summary>
        public string SoftAllowedMaximumThroughput { get; }
    }
}
