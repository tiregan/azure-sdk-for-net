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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A Class representing a VMInsightsOnboardingStatus along with the instance operations that can be performed on it. </summary>
    public partial class VMInsightsOnboardingStatus : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VMInsightsRestOperations _vMInsightsRestClient;
        private readonly VMInsightsOnboardingStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="VMInsightsOnboardingStatus"/> class for mocking. </summary>
        protected VMInsightsOnboardingStatus()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VMInsightsOnboardingStatus"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VMInsightsOnboardingStatus(ArmResource options, VMInsightsOnboardingStatusData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vMInsightsRestClient = new VMInsightsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VMInsightsOnboardingStatus"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VMInsightsOnboardingStatus(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vMInsightsRestClient = new VMInsightsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VMInsightsOnboardingStatus"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VMInsightsOnboardingStatus(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vMInsightsRestClient = new VMInsightsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/vmInsightsOnboardingStatuses";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VMInsightsOnboardingStatusData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/vmInsightsOnboardingStatuses/default
        /// ContextualPath: /{resourceUri}/providers/Microsoft.Insights/vmInsightsOnboardingStatuses/default
        /// OperationId: VMInsights_GetOnboardingStatus
        /// <summary> Retrieves the VM Insights onboarding status for the specified resource or resource scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VMInsightsOnboardingStatus>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VMInsightsOnboardingStatus.Get");
            scope.Start();
            try
            {
                var response = await _vMInsightsRestClient.GetOnboardingStatusAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VMInsightsOnboardingStatus(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/vmInsightsOnboardingStatuses/default
        /// ContextualPath: /{resourceUri}/providers/Microsoft.Insights/vmInsightsOnboardingStatuses/default
        /// OperationId: VMInsights_GetOnboardingStatus
        /// <summary> Retrieves the VM Insights onboarding status for the specified resource or resource scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VMInsightsOnboardingStatus> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VMInsightsOnboardingStatus.Get");
            scope.Start();
            try
            {
                var response = _vMInsightsRestClient.GetOnboardingStatus(Id.Parent, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMInsightsOnboardingStatus(this, response.Value), response.GetRawResponse());
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
    }
}
