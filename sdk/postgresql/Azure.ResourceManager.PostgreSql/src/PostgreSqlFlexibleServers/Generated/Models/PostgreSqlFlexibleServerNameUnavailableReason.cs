// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The name availability reason. </summary>
    public readonly partial struct PostgreSqlFlexibleServerNameUnavailableReason : IEquatable<PostgreSqlFlexibleServerNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static PostgreSqlFlexibleServerNameUnavailableReason Invalid { get; } = new PostgreSqlFlexibleServerNameUnavailableReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static PostgreSqlFlexibleServerNameUnavailableReason AlreadyExists { get; } = new PostgreSqlFlexibleServerNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerNameUnavailableReason left, PostgreSqlFlexibleServerNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerNameUnavailableReason left, PostgreSqlFlexibleServerNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlFlexibleServerNameUnavailableReason"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerNameUnavailableReason(string value) => new PostgreSqlFlexibleServerNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
