// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class TestNotificationDetailsResponse
    {
        internal static TestNotificationDetailsResponse DeserializeTestNotificationDetailsResponse(JsonElement element)
        {
            Optional<Context> context = default;
            string state = default;
            Optional<string> completedTime = default;
            Optional<string> createdTime = default;
            Optional<IReadOnlyList<ActionDetail>> actionDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Context"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    context = Context.DeserializeContext(property.Value);
                    continue;
                }
                if (property.NameEquals("State"))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("CompletedTime"))
                {
                    completedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("CreatedTime"))
                {
                    createdTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ActionDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ActionDetail> array = new List<ActionDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActionDetail.DeserializeActionDetail(item));
                    }
                    actionDetails = array;
                    continue;
                }
            }
            return new TestNotificationDetailsResponse(context.Value, state, completedTime.Value, createdTime.Value, Optional.ToList(actionDetails));
        }
    }
}
