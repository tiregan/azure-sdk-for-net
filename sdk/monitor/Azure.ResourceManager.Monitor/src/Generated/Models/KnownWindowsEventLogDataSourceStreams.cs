// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The KnownWindowsEventLogDataSourceStreams. </summary>
    public readonly partial struct KnownWindowsEventLogDataSourceStreams : IEquatable<KnownWindowsEventLogDataSourceStreams>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KnownWindowsEventLogDataSourceStreams"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KnownWindowsEventLogDataSourceStreams(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftWindowsEventValue = "Microsoft-WindowsEvent";
        private const string MicrosoftEventValue = "Microsoft-Event";

        /// <summary> Microsoft-WindowsEvent. </summary>
        public static KnownWindowsEventLogDataSourceStreams MicrosoftWindowsEvent { get; } = new KnownWindowsEventLogDataSourceStreams(MicrosoftWindowsEventValue);
        /// <summary> Microsoft-Event. </summary>
        public static KnownWindowsEventLogDataSourceStreams MicrosoftEvent { get; } = new KnownWindowsEventLogDataSourceStreams(MicrosoftEventValue);
        /// <summary> Determines if two <see cref="KnownWindowsEventLogDataSourceStreams"/> values are the same. </summary>
        public static bool operator ==(KnownWindowsEventLogDataSourceStreams left, KnownWindowsEventLogDataSourceStreams right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KnownWindowsEventLogDataSourceStreams"/> values are not the same. </summary>
        public static bool operator !=(KnownWindowsEventLogDataSourceStreams left, KnownWindowsEventLogDataSourceStreams right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KnownWindowsEventLogDataSourceStreams"/>. </summary>
        public static implicit operator KnownWindowsEventLogDataSourceStreams(string value) => new KnownWindowsEventLogDataSourceStreams(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KnownWindowsEventLogDataSourceStreams other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KnownWindowsEventLogDataSourceStreams other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
