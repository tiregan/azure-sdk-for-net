// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    internal partial class DiagnosticSettingsCategoryRestOperations
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of DiagnosticSettingsCategoryRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        public DiagnosticSettingsCategoryRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string resourceUri, string name)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.Insights/diagnosticSettingsCategories/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", "2017-05-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the diagnostic settings category for the specified resource. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="name"/> is null. </exception>
        public async Task<Response<DiagnosticSettingsCategoryResourceData>> GetAsync(string resourceUri, string name, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGetRequest(resourceUri, name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiagnosticSettingsCategoryResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DiagnosticSettingsCategoryResourceData.DeserializeDiagnosticSettingsCategoryResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DiagnosticSettingsCategoryResourceData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the diagnostic settings category for the specified resource. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="name"/> is null. </exception>
        public Response<DiagnosticSettingsCategoryResourceData> Get(string resourceUri, string name, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var message = CreateGetRequest(resourceUri, name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiagnosticSettingsCategoryResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DiagnosticSettingsCategoryResourceData.DeserializeDiagnosticSettingsCategoryResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DiagnosticSettingsCategoryResourceData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string resourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.Insights/diagnosticSettingsCategories", false);
            uri.AppendQuery("api-version", "2017-05-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists the diagnostic settings categories for the specified resource. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<Models.DiagnosticSettingsCategoryResourceCollection>> ListAsync(string resourceUri, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateListRequest(resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.DiagnosticSettingsCategoryResourceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.DiagnosticSettingsCategoryResourceCollection.DeserializeDiagnosticSettingsCategoryResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists the diagnostic settings categories for the specified resource. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<Models.DiagnosticSettingsCategoryResourceCollection> List(string resourceUri, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateListRequest(resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.DiagnosticSettingsCategoryResourceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.DiagnosticSettingsCategoryResourceCollection.DeserializeDiagnosticSettingsCategoryResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
