// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Deletes a classic metric alert rule. </summary>
    public partial class AlertRuleDeleteOperation : Operation
    {
        private readonly OperationOrResponseInternals _operation;

        /// <summary> Initializes a new instance of AlertRuleDeleteOperation for mocking. </summary>
        protected AlertRuleDeleteOperation()
        {
        }

        internal AlertRuleDeleteOperation(Azure.Response response)
        {
            _operation = new OperationOrResponseInternals(response);
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Azure.Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Azure.Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Azure.Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Azure.Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Azure.Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}
