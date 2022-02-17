// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of InstanceFailoverGroups in the InstanceFailoverGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> An object representing collection of InstanceFailoverGroups and their operations over a InstanceFailoverGroup. </returns>
        public static InstanceFailoverGroupCollection GetInstanceFailoverGroups(this ResourceGroup resourceGroup, string locationName)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(resourceGroup).GetInstanceFailoverGroups(locationName);
        }

        /// <summary> Gets a collection of InstancePools in the InstancePool. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of InstancePools and their operations over a InstancePool. </returns>
        public static InstancePoolCollection GetInstancePools(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetInstancePools();
        }

        /// <summary> Gets a collection of ResourceGroupLongTermRetentionBackups in the ResourceGroupLongTermRetentionBackup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/> or <paramref name="longTermRetentionDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/> or <paramref name="longTermRetentionDatabaseName"/> is null. </exception>
        /// <returns> An object representing collection of ResourceGroupLongTermRetentionBackups and their operations over a ResourceGroupLongTermRetentionBackup. </returns>
        public static ResourceGroupLongTermRetentionBackupCollection GetResourceGroupLongTermRetentionBackups(this ResourceGroup resourceGroup, string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(longTermRetentionServerName, nameof(longTermRetentionServerName));
            Argument.AssertNotNullOrEmpty(longTermRetentionDatabaseName, nameof(longTermRetentionDatabaseName));

            return GetExtensionClient(resourceGroup).GetResourceGroupLongTermRetentionBackups(locationName, longTermRetentionServerName, longTermRetentionDatabaseName);
        }

        /// <summary> Gets a collection of ResourceGroupLongTermRetentionManagedInstanceBackups in the ResourceGroupLongTermRetentionManagedInstanceBackup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <returns> An object representing collection of ResourceGroupLongTermRetentionManagedInstanceBackups and their operations over a ResourceGroupLongTermRetentionManagedInstanceBackup. </returns>
        public static ResourceGroupLongTermRetentionManagedInstanceBackupCollection GetResourceGroupLongTermRetentionManagedInstanceBackups(this ResourceGroup resourceGroup, string locationName, string managedInstanceName, string databaseName)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            return GetExtensionClient(resourceGroup).GetResourceGroupLongTermRetentionManagedInstanceBackups(locationName, managedInstanceName, databaseName);
        }

        /// <summary> Gets a collection of ManagedInstances in the ManagedInstance. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ManagedInstances and their operations over a ManagedInstance. </returns>
        public static ManagedInstanceCollection GetManagedInstances(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetManagedInstances();
        }

        /// <summary> Gets a collection of ServerTrustGroups in the ServerTrustGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> An object representing collection of ServerTrustGroups and their operations over a ServerTrustGroup. </returns>
        public static ServerTrustGroupCollection GetServerTrustGroups(this ResourceGroup resourceGroup, string locationName)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(resourceGroup).GetServerTrustGroups(locationName);
        }

        /// <summary> Gets a collection of VirtualClusters in the VirtualCluster. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualClusters and their operations over a VirtualCluster. </returns>
        public static VirtualClusterCollection GetVirtualClusters(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVirtualClusters();
        }

        /// <summary> Gets a collection of SqlServers in the SqlServer. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SqlServers and their operations over a SqlServer. </returns>
        public static SqlServerCollection GetSqlServers(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetSqlServers();
        }

        /// <summary>
        /// Lists the long term retention backups for a given location.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionBackups
        /// Operation Id: LongTermRetentionBackups_ListByResourceGroupLocation
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionBackup" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SubscriptionLongTermRetentionBackup> GetLongTermRetentionBackupsByResourceGroupLocationAsync(this ResourceGroup resourceGroup, string locationName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(resourceGroup).GetLongTermRetentionBackupsByResourceGroupLocationAsync(locationName, onlyLatestPerDatabase, databaseState, cancellationToken);
        }

        /// <summary>
        /// Lists the long term retention backups for a given location.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionBackups
        /// Operation Id: LongTermRetentionBackups_ListByResourceGroupLocation
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionBackup" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SubscriptionLongTermRetentionBackup> GetLongTermRetentionBackupsByResourceGroupLocation(this ResourceGroup resourceGroup, string locationName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(resourceGroup).GetLongTermRetentionBackupsByResourceGroupLocation(locationName, onlyLatestPerDatabase, databaseState, cancellationToken);
        }

        /// <summary>
        /// Lists the long term retention backups for a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionBackups
        /// Operation Id: LongTermRetentionBackups_ListByResourceGroupServer
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="longTermRetentionServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="longTermRetentionServerName"/> is null. </exception>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionBackup" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SubscriptionLongTermRetentionBackup> GetLongTermRetentionBackupsByResourceGroupServerAsync(this ResourceGroup resourceGroup, string locationName, string longTermRetentionServerName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(longTermRetentionServerName, nameof(longTermRetentionServerName));

            return GetExtensionClient(resourceGroup).GetLongTermRetentionBackupsByResourceGroupServerAsync(locationName, longTermRetentionServerName, onlyLatestPerDatabase, databaseState, cancellationToken);
        }

        /// <summary>
        /// Lists the long term retention backups for a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionBackups
        /// Operation Id: LongTermRetentionBackups_ListByResourceGroupServer
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="longTermRetentionServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="longTermRetentionServerName"/> is null. </exception>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionBackup" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SubscriptionLongTermRetentionBackup> GetLongTermRetentionBackupsByResourceGroupServer(this ResourceGroup resourceGroup, string locationName, string longTermRetentionServerName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(longTermRetentionServerName, nameof(longTermRetentionServerName));

            return GetExtensionClient(resourceGroup).GetLongTermRetentionBackupsByResourceGroupServer(locationName, longTermRetentionServerName, onlyLatestPerDatabase, databaseState, cancellationToken);
        }

        /// <summary>
        /// Lists the long term retention backups for a given managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionManagedInstanceBackups
        /// Operation Id: LongTermRetentionManagedInstanceBackups_ListByResourceGroupInstance
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SubscriptionLongTermRetentionManagedInstanceBackup> GetLongTermRetentionManagedInstanceBackupsByResourceGroupInstanceAsync(this ResourceGroup resourceGroup, string locationName, string managedInstanceName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));

            return GetExtensionClient(resourceGroup).GetLongTermRetentionManagedInstanceBackupsByResourceGroupInstanceAsync(locationName, managedInstanceName, onlyLatestPerDatabase, databaseState, cancellationToken);
        }

        /// <summary>
        /// Lists the long term retention backups for a given managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionManagedInstanceBackups
        /// Operation Id: LongTermRetentionManagedInstanceBackups_ListByResourceGroupInstance
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SubscriptionLongTermRetentionManagedInstanceBackup> GetLongTermRetentionManagedInstanceBackupsByResourceGroupInstance(this ResourceGroup resourceGroup, string locationName, string managedInstanceName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));

            return GetExtensionClient(resourceGroup).GetLongTermRetentionManagedInstanceBackupsByResourceGroupInstance(locationName, managedInstanceName, onlyLatestPerDatabase, databaseState, cancellationToken);
        }

        /// <summary>
        /// Lists the long term retention backups for managed databases in a given location.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstanceBackups
        /// Operation Id: LongTermRetentionManagedInstanceBackups_ListByResourceGroupLocation
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SubscriptionLongTermRetentionManagedInstanceBackup> GetLongTermRetentionManagedInstanceBackupsByResourceGroupLocationAsync(this ResourceGroup resourceGroup, string locationName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(resourceGroup).GetLongTermRetentionManagedInstanceBackupsByResourceGroupLocationAsync(locationName, onlyLatestPerDatabase, databaseState, cancellationToken);
        }

        /// <summary>
        /// Lists the long term retention backups for managed databases in a given location.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstanceBackups
        /// Operation Id: LongTermRetentionManagedInstanceBackups_ListByResourceGroupLocation
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SubscriptionLongTermRetentionManagedInstanceBackup> GetLongTermRetentionManagedInstanceBackupsByResourceGroupLocation(this ResourceGroup resourceGroup, string locationName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(resourceGroup).GetLongTermRetentionManagedInstanceBackupsByResourceGroupLocation(locationName, onlyLatestPerDatabase, databaseState, cancellationToken);
        }
    }
}
