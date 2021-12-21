// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class WindowsEventLogDataSource : IUtf8JsonSerializable
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
            if (Optional.IsCollectionDefined(XPathQueries))
            {
                writer.WritePropertyName("xPathQueries");
                writer.WriteStartArray();
                foreach (var item in XPathQueries)
                {
                    writer.WriteStringValue(item);
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

        internal static WindowsEventLogDataSource DeserializeWindowsEventLogDataSource(JsonElement element)
        {
            Optional<IList<KnownWindowsEventLogDataSourceStreams>> streams = default;
            Optional<IList<string>> xPathQueries = default;
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
                    List<KnownWindowsEventLogDataSourceStreams> array = new List<KnownWindowsEventLogDataSourceStreams>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new KnownWindowsEventLogDataSourceStreams(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("xPathQueries"))
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
                    xPathQueries = array;
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new WindowsEventLogDataSource(Optional.ToList(streams), Optional.ToList(xPathQueries), name.Value);
        }
    }
}
