// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> State of the Spring Cloud Gateway. </summary>
    public readonly partial struct GatewayProvisioningState : IEquatable<GatewayProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GatewayProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GatewayProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static GatewayProvisioningState Creating { get; } = new GatewayProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static GatewayProvisioningState Updating { get; } = new GatewayProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static GatewayProvisioningState Succeeded { get; } = new GatewayProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static GatewayProvisioningState Failed { get; } = new GatewayProvisioningState(FailedValue);
        /// <summary> Deleting. </summary>
        public static GatewayProvisioningState Deleting { get; } = new GatewayProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="GatewayProvisioningState"/> values are the same. </summary>
        public static bool operator ==(GatewayProvisioningState left, GatewayProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GatewayProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(GatewayProvisioningState left, GatewayProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GatewayProvisioningState"/>. </summary>
        public static implicit operator GatewayProvisioningState(string value) => new GatewayProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GatewayProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GatewayProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
