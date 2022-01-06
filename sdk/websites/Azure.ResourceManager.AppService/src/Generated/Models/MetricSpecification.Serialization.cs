// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class MetricSpecification
    {
        internal static MetricSpecification DeserializeMetricSpecification(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> displayDescription = default;
            Optional<string> unit = default;
            Optional<string> aggregationType = default;
            Optional<bool> supportsInstanceLevelAggregation = default;
            Optional<bool> enableRegionalMdmAccount = default;
            Optional<string> sourceMdmAccount = default;
            Optional<string> sourceMdmNamespace = default;
            Optional<string> metricFilterPattern = default;
            Optional<bool> fillGapWithZero = default;
            Optional<bool> isInternal = default;
            Optional<IReadOnlyList<ResourceMetricDimension>> dimensions = default;
            Optional<string> category = default;
            Optional<IReadOnlyList<MetricAvailability>> availabilities = default;
            Optional<IReadOnlyList<string>> supportedTimeGrainTypes = default;
            Optional<IReadOnlyList<string>> supportedAggregationTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayDescription"))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregationType"))
                {
                    aggregationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportsInstanceLevelAggregation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportsInstanceLevelAggregation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableRegionalMdmAccount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableRegionalMdmAccount = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourceMdmAccount"))
                {
                    sourceMdmAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceMdmNamespace"))
                {
                    sourceMdmNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricFilterPattern"))
                {
                    metricFilterPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fillGapWithZero"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fillGapWithZero = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isInternal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isInternal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dimensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceMetricDimension> array = new List<ResourceMetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceMetricDimension.DeserializeResourceMetricDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetricAvailability> array = new List<MetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricAvailability.DeserializeMetricAvailability(item));
                    }
                    availabilities = array;
                    continue;
                }
                if (property.NameEquals("supportedTimeGrainTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedTimeGrainTypes = array;
                    continue;
                }
                if (property.NameEquals("supportedAggregationTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedAggregationTypes = array;
                    continue;
                }
            }
            return new MetricSpecification(name.Value, displayName.Value, displayDescription.Value, unit.Value, aggregationType.Value, Optional.ToNullable(supportsInstanceLevelAggregation), Optional.ToNullable(enableRegionalMdmAccount), sourceMdmAccount.Value, sourceMdmNamespace.Value, metricFilterPattern.Value, Optional.ToNullable(fillGapWithZero), Optional.ToNullable(isInternal), Optional.ToList(dimensions), category.Value, Optional.ToList(availabilities), Optional.ToList(supportedTimeGrainTypes), Optional.ToList(supportedAggregationTypes));
        }
    }
}
