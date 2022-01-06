// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A Global SKU Description. </summary>
    public partial class GlobalCsmSkuDescription
    {
        /// <summary> Initializes a new instance of GlobalCsmSkuDescription. </summary>
        internal GlobalCsmSkuDescription()
        {
            Locations = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<SKUCapability>();
        }

        /// <summary> Initializes a new instance of GlobalCsmSkuDescription. </summary>
        /// <param name="name"> Name of the resource SKU. </param>
        /// <param name="tier"> Service Tier of the resource SKU. </param>
        /// <param name="size"> Size specifier of the resource SKU. </param>
        /// <param name="family"> Family code of the resource SKU. </param>
        /// <param name="capacity"> Min, max, and default scale values of the SKU. </param>
        /// <param name="locations"> Locations of the SKU. </param>
        /// <param name="capabilities"> Capabilities of the SKU, e.g., is traffic manager enabled?. </param>
        internal GlobalCsmSkuDescription(string name, string tier, string size, string family, SkuCapacity capacity, IReadOnlyList<string> locations, IReadOnlyList<SKUCapability> capabilities)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            Locations = locations;
            Capabilities = capabilities;
        }

        /// <summary> Name of the resource SKU. </summary>
        public string Name { get; }
        /// <summary> Service Tier of the resource SKU. </summary>
        public string Tier { get; }
        /// <summary> Size specifier of the resource SKU. </summary>
        public string Size { get; }
        /// <summary> Family code of the resource SKU. </summary>
        public string Family { get; }
        /// <summary> Min, max, and default scale values of the SKU. </summary>
        public SkuCapacity Capacity { get; }
        /// <summary> Locations of the SKU. </summary>
        public IReadOnlyList<string> Locations { get; }
        /// <summary> Capabilities of the SKU, e.g., is traffic manager enabled?. </summary>
        public IReadOnlyList<SKUCapability> Capabilities { get; }
    }
}
