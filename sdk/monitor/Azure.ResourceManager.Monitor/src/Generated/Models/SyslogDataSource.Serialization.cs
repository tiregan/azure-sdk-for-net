// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class SyslogDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Streams))
            {
                writer.WritePropertyName("streams");
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FacilityNames))
            {
                writer.WritePropertyName("facilityNames");
                writer.WriteStartArray();
                foreach (var item in FacilityNames)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LogLevels))
            {
                writer.WritePropertyName("logLevels");
                writer.WriteStartArray();
                foreach (var item in LogLevels)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WriteEndObject();
        }

        internal static SyslogDataSource DeserializeSyslogDataSource(JsonElement element)
        {
            Optional<IList<KnownSyslogDataSourceStreams>> streams = default;
            Optional<IList<KnownSyslogDataSourceFacilityNames>> facilityNames = default;
            Optional<IList<KnownSyslogDataSourceLogLevels>> logLevels = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnownSyslogDataSourceStreams> array = new List<KnownSyslogDataSourceStreams>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new KnownSyslogDataSourceStreams(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("facilityNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnownSyslogDataSourceFacilityNames> array = new List<KnownSyslogDataSourceFacilityNames>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new KnownSyslogDataSourceFacilityNames(item.GetString()));
                    }
                    facilityNames = array;
                    continue;
                }
                if (property.NameEquals("logLevels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnownSyslogDataSourceLogLevels> array = new List<KnownSyslogDataSourceLogLevels>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new KnownSyslogDataSourceLogLevels(item.GetString()));
                    }
                    logLevels = array;
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new SyslogDataSource(Optional.ToList(streams), Optional.ToList(facilityNames), Optional.ToList(logLevels), name.Value);
        }
    }
}
