// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of FrontendIPConfiguration and their operations over its parent. </summary>
    public partial class FrontendIPConfigurationCollection : ArmCollection, IEnumerable<FrontendIPConfiguration>, IAsyncEnumerable<FrontendIPConfiguration>
    {
        private readonly ClientDiagnostics _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics;
        private readonly LoadBalancerFrontendIPConfigurationsRestOperations _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontendIPConfigurationCollection"/> class for mocking. </summary>
        protected FrontendIPConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontendIPConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontendIPConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", FrontendIPConfiguration.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(FrontendIPConfiguration.ResourceType, out string frontendIPConfigurationLoadBalancerFrontendIPConfigurationsApiVersion);
            _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient = new LoadBalancerFrontendIPConfigurationsRestOperations(_frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, frontendIPConfigurationLoadBalancerFrontendIPConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets load balancer frontend IP configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}
        /// Operation Id: LoadBalancerFrontendIPConfigurations_Get
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public async virtual Task<Response<FrontendIPConfiguration>> GetAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FrontendIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets load balancer frontend IP configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}
        /// Operation Id: LoadBalancerFrontendIPConfigurations_Get
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual Response<FrontendIPConfiguration> Get(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the load balancer frontend IP configurations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations
        /// Operation Id: LoadBalancerFrontendIPConfigurations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontendIPConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontendIPConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FrontendIPConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontendIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FrontendIPConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontendIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the load balancer frontend IP configurations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations
        /// Operation Id: LoadBalancerFrontendIPConfigurations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontendIPConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontendIPConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FrontendIPConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontendIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FrontendIPConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontendIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}
        /// Operation Id: LoadBalancerFrontendIPConfigurations_Get
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(frontendIPConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}
        /// Operation Id: LoadBalancerFrontendIPConfigurations_Get
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(frontendIPConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}
        /// Operation Id: LoadBalancerFrontendIPConfigurations_Get
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public async virtual Task<Response<FrontendIPConfiguration>> GetIfExistsAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FrontendIPConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}
        /// Operation Id: LoadBalancerFrontendIPConfigurations_Get
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual Response<FrontendIPConfiguration> GetIfExists(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FrontendIPConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontendIPConfiguration> IEnumerable<FrontendIPConfiguration>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontendIPConfiguration> IAsyncEnumerable<FrontendIPConfiguration>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
