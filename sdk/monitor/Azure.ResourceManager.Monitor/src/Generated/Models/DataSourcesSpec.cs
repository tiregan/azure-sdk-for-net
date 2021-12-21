// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specification of data sources that will be collected. </summary>
    public partial class DataSourcesSpec
    {
        /// <summary> Initializes a new instance of DataSourcesSpec. </summary>
        public DataSourcesSpec()
        {
            PerformanceCounters = new ChangeTrackingList<PerfCounterDataSource>();
            WindowsEventLogs = new ChangeTrackingList<WindowsEventLogDataSource>();
            Syslog = new ChangeTrackingList<SyslogDataSource>();
            Extensions = new ChangeTrackingList<ExtensionDataSource>();
        }

        /// <summary> Initializes a new instance of DataSourcesSpec. </summary>
        /// <param name="performanceCounters"> The list of performance counter data source configurations. </param>
        /// <param name="windowsEventLogs"> The list of Windows Event Log data source configurations. </param>
        /// <param name="syslog"> The list of Syslog data source configurations. </param>
        /// <param name="extensions"> The list of Azure VM extension data source configurations. </param>
        internal DataSourcesSpec(IList<PerfCounterDataSource> performanceCounters, IList<WindowsEventLogDataSource> windowsEventLogs, IList<SyslogDataSource> syslog, IList<ExtensionDataSource> extensions)
        {
            PerformanceCounters = performanceCounters;
            WindowsEventLogs = windowsEventLogs;
            Syslog = syslog;
            Extensions = extensions;
        }

        /// <summary> The list of performance counter data source configurations. </summary>
        public IList<PerfCounterDataSource> PerformanceCounters { get; }
        /// <summary> The list of Windows Event Log data source configurations. </summary>
        public IList<WindowsEventLogDataSource> WindowsEventLogs { get; }
        /// <summary> The list of Syslog data source configurations. </summary>
        public IList<SyslogDataSource> Syslog { get; }
        /// <summary> The list of Azure VM extension data source configurations. </summary>
        public IList<ExtensionDataSource> Extensions { get; }
    }
}
