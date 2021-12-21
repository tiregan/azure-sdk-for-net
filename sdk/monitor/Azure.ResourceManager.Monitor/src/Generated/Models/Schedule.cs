// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Defines how often to run the search and the time interval. </summary>
    public partial class Schedule
    {
        /// <summary> Initializes a new instance of Schedule. </summary>
        /// <param name="frequencyInMinutes"> frequency (in minutes) at which rule condition should be evaluated. </param>
        /// <param name="timeWindowInMinutes"> Time window for which data needs to be fetched for query (should be greater than or equal to frequencyInMinutes). </param>
        public Schedule(int frequencyInMinutes, int timeWindowInMinutes)
        {
            FrequencyInMinutes = frequencyInMinutes;
            TimeWindowInMinutes = timeWindowInMinutes;
        }

        /// <summary> frequency (in minutes) at which rule condition should be evaluated. </summary>
        public int FrequencyInMinutes { get; set; }
        /// <summary> Time window for which data needs to be fetched for query (should be greater than or equal to frequencyInMinutes). </summary>
        public int TimeWindowInMinutes { get; set; }
    }
}
