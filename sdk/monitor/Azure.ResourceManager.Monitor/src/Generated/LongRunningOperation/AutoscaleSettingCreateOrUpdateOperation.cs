// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Creates or updates an autoscale setting. </summary>
    public partial class AutoscaleSettingCreateOrUpdateOperation : Operation<AutoscaleSettingResource>
    {
        private readonly OperationOrResponseInternals<AutoscaleSettingResource> _operation;

        /// <summary> Initializes a new instance of AutoscaleSettingCreateOrUpdateOperation for mocking. </summary>
        protected AutoscaleSettingCreateOrUpdateOperation()
        {
        }

        internal AutoscaleSettingCreateOrUpdateOperation(ArmResource operationsBase, Response<AutoscaleSettingResourceData> response)
        {
            _operation = new OperationOrResponseInternals<AutoscaleSettingResource>(Azure.Response.FromValue(new AutoscaleSettingResource(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AutoscaleSettingResource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Azure.Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Azure.Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Azure.Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AutoscaleSettingResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AutoscaleSettingResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
