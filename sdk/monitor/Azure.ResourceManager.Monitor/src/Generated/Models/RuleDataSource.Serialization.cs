// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class RuleDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceUri");
                writer.WriteStringValue(ResourceUri);
            }
            if (Optional.IsDefined(LegacyResourceId))
            {
                writer.WritePropertyName("legacyResourceId");
                writer.WriteStringValue(LegacyResourceId);
            }
            if (Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation");
                writer.WriteStringValue(ResourceLocation);
            }
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace");
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WriteEndObject();
        }

        internal static RuleDataSource DeserializeRuleDataSource(JsonElement element)
        {
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Management.Insights.Models.RuleManagementEventDataSource": return RuleManagementEventDataSource.DeserializeRuleManagementEventDataSource(element);
                    case "Microsoft.Azure.Management.Insights.Models.RuleMetricDataSource": return RuleMetricDataSource.DeserializeRuleMetricDataSource(element);
                }
            }
            string odataType = default;
            Optional<string> resourceUri = default;
            Optional<string> legacyResourceId = default;
            Optional<string> resourceLocation = default;
            Optional<string> metricNamespace = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("legacyResourceId"))
                {
                    legacyResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
            }
            return new RuleDataSource(odataType, resourceUri.Value, legacyResourceId.Value, resourceLocation.Value, metricNamespace.Value);
        }
    }
}
