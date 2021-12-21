// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class WebhookReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("serviceUri");
            writer.WriteStringValue(ServiceUri);
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema");
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            if (Optional.IsDefined(UseAadAuth))
            {
                writer.WritePropertyName("useAadAuth");
                writer.WriteBooleanValue(UseAadAuth.Value);
            }
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId");
                writer.WriteStringValue(ObjectId);
            }
            if (Optional.IsDefined(IdentifierUri))
            {
                writer.WritePropertyName("identifierUri");
                writer.WriteStringValue(IdentifierUri);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId);
            }
            writer.WriteEndObject();
        }

        internal static WebhookReceiver DeserializeWebhookReceiver(JsonElement element)
        {
            string name = default;
            string serviceUri = default;
            Optional<bool> useCommonAlertSchema = default;
            Optional<bool> useAadAuth = default;
            Optional<string> objectId = default;
            Optional<string> identifierUri = default;
            Optional<string> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUri"))
                {
                    serviceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("useAadAuth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useAadAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identifierUri"))
                {
                    identifierUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
            }
            return new WebhookReceiver(name, serviceUri, Optional.ToNullable(useCommonAlertSchema), Optional.ToNullable(useAadAuth), objectId.Value, identifierUri.Value, tenantId.Value);
        }
    }
}
