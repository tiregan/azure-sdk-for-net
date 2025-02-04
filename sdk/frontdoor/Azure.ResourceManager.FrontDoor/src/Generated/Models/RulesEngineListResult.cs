// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Result of the request to list Rules Engine Configurations. It contains a list of RulesEngine objects and a URL link to get the next set of results. </summary>
    internal partial class RulesEngineListResult
    {
        /// <summary> Initializes a new instance of <see cref="RulesEngineListResult"/>. </summary>
        internal RulesEngineListResult()
        {
            Value = new ChangeTrackingList<FrontDoorRulesEngineData>();
        }

        /// <summary> Initializes a new instance of <see cref="RulesEngineListResult"/>. </summary>
        /// <param name="value"> List of rulesEngines within a Front Door. </param>
        /// <param name="nextLink"> URL to get the next set of RulesEngine objects if there are any. </param>
        internal RulesEngineListResult(IReadOnlyList<FrontDoorRulesEngineData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of rulesEngines within a Front Door. </summary>
        public IReadOnlyList<FrontDoorRulesEngineData> Value { get; }
        /// <summary> URL to get the next set of RulesEngine objects if there are any. </summary>
        public string NextLink { get; }
    }
}
