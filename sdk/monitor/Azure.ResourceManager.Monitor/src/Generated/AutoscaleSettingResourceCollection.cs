// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of AutoscaleSettingResource and their operations over its parent. </summary>
    public partial class AutoscaleSettingResourceCollection : ArmCollection, IEnumerable<AutoscaleSettingResource>, IAsyncEnumerable<AutoscaleSettingResource>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AutoscaleSettingsRestOperations _autoscaleSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutoscaleSettingResourceCollection"/> class for mocking. </summary>
        protected AutoscaleSettingResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of AutoscaleSettingResourceCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AutoscaleSettingResourceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _autoscaleSettingsRestClient = new AutoscaleSettingsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AutoscaleSettings_CreateOrUpdate
        /// <summary> Creates or updates an autoscale setting. </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual AutoscaleSettingCreateOrUpdateOperation CreateOrUpdate(string autoscaleSettingName, AutoscaleSettingResourceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (autoscaleSettingName == null)
            {
                throw new ArgumentNullException(nameof(autoscaleSettingName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _autoscaleSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, parameters, cancellationToken);
                var operation = new AutoscaleSettingCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AutoscaleSettings_CreateOrUpdate
        /// <summary> Creates or updates an autoscale setting. </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<AutoscaleSettingCreateOrUpdateOperation> CreateOrUpdateAsync(string autoscaleSettingName, AutoscaleSettingResourceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (autoscaleSettingName == null)
            {
                throw new ArgumentNullException(nameof(autoscaleSettingName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _autoscaleSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new AutoscaleSettingCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AutoscaleSettings_Get
        /// <summary> Gets an autoscale setting. </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual Response<AutoscaleSettingResource> Get(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            if (autoscaleSettingName == null)
            {
                throw new ArgumentNullException(nameof(autoscaleSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _autoscaleSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoscaleSettingResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AutoscaleSettings_Get
        /// <summary> Gets an autoscale setting. </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public async virtual Task<Response<AutoscaleSettingResource>> GetAsync(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            if (autoscaleSettingName == null)
            {
                throw new ArgumentNullException(nameof(autoscaleSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _autoscaleSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AutoscaleSettingResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual Response<AutoscaleSettingResource> GetIfExists(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            if (autoscaleSettingName == null)
            {
                throw new ArgumentNullException(nameof(autoscaleSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _autoscaleSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AutoscaleSettingResource>(null, response.GetRawResponse())
                    : Response.FromValue(new AutoscaleSettingResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public async virtual Task<Response<AutoscaleSettingResource>> GetIfExistsAsync(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            if (autoscaleSettingName == null)
            {
                throw new ArgumentNullException(nameof(autoscaleSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _autoscaleSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AutoscaleSettingResource>(null, response.GetRawResponse())
                    : Response.FromValue(new AutoscaleSettingResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            if (autoscaleSettingName == null)
            {
                throw new ArgumentNullException(nameof(autoscaleSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(autoscaleSettingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            if (autoscaleSettingName == null)
            {
                throw new ArgumentNullException(nameof(autoscaleSettingName));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(autoscaleSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AutoscaleSettings_ListByResourceGroup
        /// <summary> Lists the autoscale settings for a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutoscaleSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutoscaleSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AutoscaleSettingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _autoscaleSettingsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AutoscaleSettingResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AutoscaleSettingResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _autoscaleSettingsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AutoscaleSettingResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AutoscaleSettings_ListByResourceGroup
        /// <summary> Lists the autoscale settings for a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutoscaleSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutoscaleSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AutoscaleSettingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _autoscaleSettingsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AutoscaleSettingResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AutoscaleSettingResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _autoscaleSettingsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AutoscaleSettingResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AutoscaleSettingResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AutoscaleSettingResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AutoscaleSettingResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingResourceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AutoscaleSettingResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutoscaleSettingResource> IEnumerable<AutoscaleSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutoscaleSettingResource> IAsyncEnumerable<AutoscaleSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AutoscaleSettingResource, AutoscaleSettingResourceData> Construct() { }
    }
}
