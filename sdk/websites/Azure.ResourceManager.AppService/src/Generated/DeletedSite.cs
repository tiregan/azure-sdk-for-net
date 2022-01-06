// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a DeletedSite along with the instance operations that can be performed on it. </summary>
    public partial class DeletedSite : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GlobalRestOperations _globalRestClient;
        private readonly DeletedSiteData _data;

        /// <summary> Initializes a new instance of the <see cref="DeletedSite"/> class for mocking. </summary>
        protected DeletedSite()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DeletedSite"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DeletedSite(ArmResource options, DeletedSiteData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _globalRestClient = new GlobalRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedSite"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeletedSite(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _globalRestClient = new GlobalRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedSite"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeletedSite(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _globalRestClient = new GlobalRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/deletedSites";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeletedSiteData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// OperationId: Global_GetDeletedWebApp
        /// <summary> Description for Get deleted app for a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DeletedSite>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedSite.Get");
            scope.Start();
            try
            {
                var response = await _globalRestClient.GetDeletedWebAppAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeletedSite(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// OperationId: Global_GetDeletedWebApp
        /// <summary> Description for Get deleted app for a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedSite> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedSite.Get");
            scope.Start();
            try
            {
                var response = _globalRestClient.GetDeletedWebApp(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedSite(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}/snapshots
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// OperationId: Global_GetDeletedWebAppSnapshots
        /// <summary> Description for Get all deleted apps for a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<AppSnapshot>>> GetDeletedWebAppSnapshotsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedSite.GetDeletedWebAppSnapshots");
            scope.Start();
            try
            {
                var response = await _globalRestClient.GetDeletedWebAppSnapshotsAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}/snapshots
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// OperationId: Global_GetDeletedWebAppSnapshots
        /// <summary> Description for Get all deleted apps for a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<AppSnapshot>> GetDeletedWebAppSnapshots(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedSite.GetDeletedWebAppSnapshots");
            scope.Start();
            try
            {
                var response = _globalRestClient.GetDeletedWebAppSnapshots(Id.SubscriptionId, Id.Name, cancellationToken);
                return Response.FromValue(response.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
