// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ActivityLogAlertActionList : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ActionGroups))
            {
                writer.WritePropertyName("actionGroups");
                writer.WriteStartArray();
                foreach (var item in ActionGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ActivityLogAlertActionList DeserializeActivityLogAlertActionList(JsonElement element)
        {
            Optional<IList<ActivityLogAlertActionGroup>> actionGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ActivityLogAlertActionGroup> array = new List<ActivityLogAlertActionGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityLogAlertActionGroup.DeserializeActivityLogAlertActionGroup(item));
                    }
                    actionGroups = array;
                    continue;
                }
            }
            return new ActivityLogAlertActionList(Optional.ToList(actionGroups));
        }
    }
}
