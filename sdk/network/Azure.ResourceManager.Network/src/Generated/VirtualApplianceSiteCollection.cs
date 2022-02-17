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
    /// <summary> A class representing collection of VirtualApplianceSite and their operations over its parent. </summary>
    public partial class VirtualApplianceSiteCollection : ArmCollection, IEnumerable<VirtualApplianceSite>, IAsyncEnumerable<VirtualApplianceSite>
    {
        private readonly ClientDiagnostics _virtualApplianceSiteClientDiagnostics;
        private readonly VirtualApplianceSitesRestOperations _virtualApplianceSiteRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualApplianceSiteCollection"/> class for mocking. </summary>
        protected VirtualApplianceSiteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualApplianceSiteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualApplianceSiteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualApplianceSiteClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualApplianceSite.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VirtualApplianceSite.ResourceType, out string virtualApplianceSiteApiVersion);
            _virtualApplianceSiteRestClient = new VirtualApplianceSitesRestOperations(_virtualApplianceSiteClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualApplianceSiteApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkVirtualAppliance.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkVirtualAppliance.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified Network Virtual Appliance Site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance Site operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<VirtualApplianceSite>> CreateOrUpdateAsync(bool waitForCompletion, string siteName, VirtualApplianceSiteData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualApplianceSiteRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualApplianceSite>(new VirtualApplianceSiteOperationSource(Client), _virtualApplianceSiteClientDiagnostics, Pipeline, _virtualApplianceSiteRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Creates or updates the specified Network Virtual Appliance Site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance Site operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<VirtualApplianceSite> CreateOrUpdate(bool waitForCompletion, string siteName, VirtualApplianceSiteData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualApplianceSiteRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<VirtualApplianceSite>(new VirtualApplianceSiteOperationSource(Client), _virtualApplianceSiteClientDiagnostics, Pipeline, _virtualApplianceSiteRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Gets the specified Virtual Appliance Site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_Get
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public async virtual Task<Response<VirtualApplianceSite>> GetAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualApplianceSiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualApplianceSiteClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualApplianceSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Virtual Appliance Site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_Get
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<VirtualApplianceSite> Get(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualApplianceSiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken);
                if (response.Value == null)
                    throw _virtualApplianceSiteClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplianceSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Network Virtual Appliance Sites in a Network Virtual Appliance resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites
        /// Operation Id: VirtualApplianceSites_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualApplianceSite" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualApplianceSite> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualApplianceSite>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualApplianceSiteRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplianceSite(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualApplianceSite>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualApplianceSiteRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplianceSite(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all Network Virtual Appliance Sites in a Network Virtual Appliance resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites
        /// Operation Id: VirtualApplianceSites_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualApplianceSite" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualApplianceSite> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualApplianceSite> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualApplianceSiteRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplianceSite(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualApplianceSite> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualApplianceSiteRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplianceSite(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_Get
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_Get
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<bool> Exists(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(siteName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_Get
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public async virtual Task<Response<VirtualApplianceSite>> GetIfExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualApplianceSiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualApplianceSite>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualApplianceSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_Get
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<VirtualApplianceSite> GetIfExists(string siteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteName, nameof(siteName));

            using var scope = _virtualApplianceSiteClientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualApplianceSiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualApplianceSite>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualApplianceSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualApplianceSite> IEnumerable<VirtualApplianceSite>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualApplianceSite> IAsyncEnumerable<VirtualApplianceSite>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
