// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AutoscaleSettingResource
        /// <summary> Gets an object representing a AutoscaleSettingResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutoscaleSettingResource" /> object. </returns>
        public static AutoscaleSettingResource GetAutoscaleSettingResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AutoscaleSettingResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AlertRuleResource
        /// <summary> Gets an object representing a AlertRuleResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AlertRuleResource" /> object. </returns>
        public static AlertRuleResource GetAlertRuleResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AlertRuleResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region LogProfileResource
        /// <summary> Gets an object representing a LogProfileResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LogProfileResource" /> object. </returns>
        public static LogProfileResource GetLogProfileResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new LogProfileResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiagnosticSettingsResource
        /// <summary> Gets an object representing a DiagnosticSettingsResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiagnosticSettingsResource" /> object. </returns>
        public static DiagnosticSettingsResource GetDiagnosticSettingsResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiagnosticSettingsResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiagnosticSettingsCategoryResource
        /// <summary> Gets an object representing a DiagnosticSettingsCategoryResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiagnosticSettingsCategoryResource" /> object. </returns>
        public static DiagnosticSettingsCategoryResource GetDiagnosticSettingsCategoryResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiagnosticSettingsCategoryResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ActionGroupResource
        /// <summary> Gets an object representing a ActionGroupResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ActionGroupResource" /> object. </returns>
        public static ActionGroupResource GetActionGroupResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ActionGroupResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region MetricAlertResource
        /// <summary> Gets an object representing a MetricAlertResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MetricAlertResource" /> object. </returns>
        public static MetricAlertResource GetMetricAlertResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new MetricAlertResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region LogSearchRuleResource
        /// <summary> Gets an object representing a LogSearchRuleResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LogSearchRuleResource" /> object. </returns>
        public static LogSearchRuleResource GetLogSearchRuleResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new LogSearchRuleResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VMInsightsOnboardingStatus
        /// <summary> Gets an object representing a VMInsightsOnboardingStatus along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMInsightsOnboardingStatus" /> object. </returns>
        public static VMInsightsOnboardingStatus GetVMInsightsOnboardingStatus(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VMInsightsOnboardingStatus(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AzureMonitorPrivateLinkScope
        /// <summary> Gets an object representing a AzureMonitorPrivateLinkScope along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureMonitorPrivateLinkScope" /> object. </returns>
        public static AzureMonitorPrivateLinkScope GetAzureMonitorPrivateLinkScope(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AzureMonitorPrivateLinkScope(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateLinkResource
        /// <summary> Gets an object representing a PrivateLinkResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateLinkResource" /> object. </returns>
        public static PrivateLinkResource GetPrivateLinkResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateLinkResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ScopedResource
        /// <summary> Gets an object representing a ScopedResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScopedResource" /> object. </returns>
        public static ScopedResource GetScopedResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ScopedResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ActivityLogAlertResource
        /// <summary> Gets an object representing a ActivityLogAlertResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ActivityLogAlertResource" /> object. </returns>
        public static ActivityLogAlertResource GetActivityLogAlertResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ActivityLogAlertResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataCollectionEndpointResource
        /// <summary> Gets an object representing a DataCollectionEndpointResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataCollectionEndpointResource" /> object. </returns>
        public static DataCollectionEndpointResource GetDataCollectionEndpointResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataCollectionEndpointResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataCollectionRuleAssociationProxyOnlyResource
        /// <summary> Gets an object representing a DataCollectionRuleAssociationProxyOnlyResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataCollectionRuleAssociationProxyOnlyResource" /> object. </returns>
        public static DataCollectionRuleAssociationProxyOnlyResource GetDataCollectionRuleAssociationProxyOnlyResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataCollectionRuleAssociationProxyOnlyResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataCollectionRuleResource
        /// <summary> Gets an object representing a DataCollectionRuleResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataCollectionRuleResource" /> object. </returns>
        public static DataCollectionRuleResource GetDataCollectionRuleResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataCollectionRuleResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
