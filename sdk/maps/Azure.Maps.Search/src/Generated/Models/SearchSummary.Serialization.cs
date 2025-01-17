// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    internal partial class SearchSummary
    {
        internal static SearchSummary DeserializeSearchSummary(JsonElement element)
        {
            Optional<string> query = default;
            Optional<MapsQueryType> queryType = default;
            Optional<int> queryTime = default;
            Optional<int> numResults = default;
            Optional<int> limit = default;
            Optional<int> offset = default;
            Optional<int> totalResults = default;
            Optional<int> fuzzyLevel = default;
            Optional<LatLongPairAbbreviated> geoBias = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queryType = new MapsQueryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queryTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numResults = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalResults = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fuzzyLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fuzzyLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("geoBias"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    geoBias = LatLongPairAbbreviated.DeserializeLatLongPairAbbreviated(property.Value);
                    continue;
                }
            }
            return new SearchSummary(query.Value, Optional.ToNullable(queryType), Optional.ToNullable(queryTime), numResults, Optional.ToNullable(limit), Optional.ToNullable(offset), Optional.ToNullable(totalResults), Optional.ToNullable(fuzzyLevel), geoBias.Value);
        }
    }
}
