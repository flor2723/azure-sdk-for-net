// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The type of source for the import pipeline. </summary>
    public readonly partial struct PipelineSourceType : IEquatable<PipelineSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PipelineSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PipelineSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureStorageBlobContainerValue = "AzureStorageBlobContainer";

        /// <summary> AzureStorageBlobContainer. </summary>
        public static PipelineSourceType AzureStorageBlobContainer { get; } = new PipelineSourceType(AzureStorageBlobContainerValue);
        /// <summary> Determines if two <see cref="PipelineSourceType"/> values are the same. </summary>
        public static bool operator ==(PipelineSourceType left, PipelineSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PipelineSourceType"/> values are not the same. </summary>
        public static bool operator !=(PipelineSourceType left, PipelineSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PipelineSourceType"/>. </summary>
        public static implicit operator PipelineSourceType(string value) => new PipelineSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PipelineSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PipelineSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
