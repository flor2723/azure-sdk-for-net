// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesMySqlTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("connectionInfo");
            writer.WriteObjectValue(ConnectionInfo);
            writer.WritePropertyName("selectedDatabases");
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GetUserTablesMySqlTaskInput DeserializeGetUserTablesMySqlTaskInput(JsonElement element)
        {
            MySqlConnectionInfo connectionInfo = default;
            IList<string> selectedDatabases = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionInfo"))
                {
                    connectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("selectedDatabases"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    selectedDatabases = array;
                    continue;
                }
            }
            return new GetUserTablesMySqlTaskInput(connectionInfo, selectedDatabases);
        }
    }
}
