// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MetricAlertCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType.ToString());
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static MetricAlertCriteria DeserializeMetricAlertCriteria(JsonElement element)
        {
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Monitor.MultipleResourceMultipleMetricCriteria": return MetricAlertMultipleResourceMultipleMetricCriteria.DeserializeMetricAlertMultipleResourceMultipleMetricCriteria(element);
                    case "Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria": return MetricAlertSingleResourceMultipleMetricCriteria.DeserializeMetricAlertSingleResourceMultipleMetricCriteria(element);
                    case "Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria": return WebtestLocationAvailabilityCriteria.DeserializeWebtestLocationAvailabilityCriteria(element);
                }
            }
            Odatatype odataType = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.type"))
                {
                    odataType = new Odatatype(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MetricAlertCriteria(odataType, additionalProperties);
        }
    }
}
