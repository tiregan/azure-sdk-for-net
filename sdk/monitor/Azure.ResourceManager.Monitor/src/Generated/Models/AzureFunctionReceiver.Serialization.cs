// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AzureFunctionReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("functionAppResourceId");
            writer.WriteStringValue(FunctionAppResourceId);
            writer.WritePropertyName("functionName");
            writer.WriteStringValue(FunctionName);
            writer.WritePropertyName("httpTriggerUrl");
            writer.WriteStringValue(HttpTriggerUrl);
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema");
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureFunctionReceiver DeserializeAzureFunctionReceiver(JsonElement element)
        {
            string name = default;
            string functionAppResourceId = default;
            string functionName = default;
            string httpTriggerUrl = default;
            Optional<bool> useCommonAlertSchema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionAppResourceId"))
                {
                    functionAppResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionName"))
                {
                    functionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpTriggerUrl"))
                {
                    httpTriggerUrl = property.Value.GetString();
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
            }
            return new AzureFunctionReceiver(name, functionAppResourceId, functionName, httpTriggerUrl, Optional.ToNullable(useCommonAlertSchema));
        }
    }
}
