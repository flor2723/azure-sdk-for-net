// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Allow or Deny rules to determine for incoming IP. Note: Rules can only consist of ALL Allow or ALL Deny. </summary>
    public readonly partial struct Action : IEquatable<Action>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Action"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Action(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static Action Allow { get; } = new Action(AllowValue);
        /// <summary> Deny. </summary>
        public static Action Deny { get; } = new Action(DenyValue);
        /// <summary> Determines if two <see cref="Action"/> values are the same. </summary>
        public static bool operator ==(Action left, Action right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Action"/> values are not the same. </summary>
        public static bool operator !=(Action left, Action right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Action"/>. </summary>
        public static implicit operator Action(string value) => new Action(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Action other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Action other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
