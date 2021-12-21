// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The KnownSyslogDataSourceFacilityNames. </summary>
    public readonly partial struct KnownSyslogDataSourceFacilityNames : IEquatable<KnownSyslogDataSourceFacilityNames>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KnownSyslogDataSourceFacilityNames"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KnownSyslogDataSourceFacilityNames(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuthValue = "auth";
        private const string AuthprivValue = "authpriv";
        private const string CronValue = "cron";
        private const string DaemonValue = "daemon";
        private const string KernValue = "kern";
        private const string LprValue = "lpr";
        private const string MailValue = "mail";
        private const string MarkValue = "mark";
        private const string NewsValue = "news";
        private const string SyslogValue = "syslog";
        private const string UserValue = "user";
        private const string UucpValue = "uucp";
        private const string Local0Value = "local0";
        private const string Local1Value = "local1";
        private const string Local2Value = "local2";
        private const string Local3Value = "local3";
        private const string Local4Value = "local4";
        private const string Local5Value = "local5";
        private const string Local6Value = "local6";
        private const string Local7Value = "local7";
        private const string AsteriskValue = "*";

        /// <summary> auth. </summary>
        public static KnownSyslogDataSourceFacilityNames Auth { get; } = new KnownSyslogDataSourceFacilityNames(AuthValue);
        /// <summary> authpriv. </summary>
        public static KnownSyslogDataSourceFacilityNames Authpriv { get; } = new KnownSyslogDataSourceFacilityNames(AuthprivValue);
        /// <summary> cron. </summary>
        public static KnownSyslogDataSourceFacilityNames Cron { get; } = new KnownSyslogDataSourceFacilityNames(CronValue);
        /// <summary> daemon. </summary>
        public static KnownSyslogDataSourceFacilityNames Daemon { get; } = new KnownSyslogDataSourceFacilityNames(DaemonValue);
        /// <summary> kern. </summary>
        public static KnownSyslogDataSourceFacilityNames Kern { get; } = new KnownSyslogDataSourceFacilityNames(KernValue);
        /// <summary> lpr. </summary>
        public static KnownSyslogDataSourceFacilityNames Lpr { get; } = new KnownSyslogDataSourceFacilityNames(LprValue);
        /// <summary> mail. </summary>
        public static KnownSyslogDataSourceFacilityNames Mail { get; } = new KnownSyslogDataSourceFacilityNames(MailValue);
        /// <summary> mark. </summary>
        public static KnownSyslogDataSourceFacilityNames Mark { get; } = new KnownSyslogDataSourceFacilityNames(MarkValue);
        /// <summary> news. </summary>
        public static KnownSyslogDataSourceFacilityNames News { get; } = new KnownSyslogDataSourceFacilityNames(NewsValue);
        /// <summary> syslog. </summary>
        public static KnownSyslogDataSourceFacilityNames Syslog { get; } = new KnownSyslogDataSourceFacilityNames(SyslogValue);
        /// <summary> user. </summary>
        public static KnownSyslogDataSourceFacilityNames User { get; } = new KnownSyslogDataSourceFacilityNames(UserValue);
        /// <summary> uucp. </summary>
        public static KnownSyslogDataSourceFacilityNames Uucp { get; } = new KnownSyslogDataSourceFacilityNames(UucpValue);
        /// <summary> local0. </summary>
        public static KnownSyslogDataSourceFacilityNames Local0 { get; } = new KnownSyslogDataSourceFacilityNames(Local0Value);
        /// <summary> local1. </summary>
        public static KnownSyslogDataSourceFacilityNames Local1 { get; } = new KnownSyslogDataSourceFacilityNames(Local1Value);
        /// <summary> local2. </summary>
        public static KnownSyslogDataSourceFacilityNames Local2 { get; } = new KnownSyslogDataSourceFacilityNames(Local2Value);
        /// <summary> local3. </summary>
        public static KnownSyslogDataSourceFacilityNames Local3 { get; } = new KnownSyslogDataSourceFacilityNames(Local3Value);
        /// <summary> local4. </summary>
        public static KnownSyslogDataSourceFacilityNames Local4 { get; } = new KnownSyslogDataSourceFacilityNames(Local4Value);
        /// <summary> local5. </summary>
        public static KnownSyslogDataSourceFacilityNames Local5 { get; } = new KnownSyslogDataSourceFacilityNames(Local5Value);
        /// <summary> local6. </summary>
        public static KnownSyslogDataSourceFacilityNames Local6 { get; } = new KnownSyslogDataSourceFacilityNames(Local6Value);
        /// <summary> local7. </summary>
        public static KnownSyslogDataSourceFacilityNames Local7 { get; } = new KnownSyslogDataSourceFacilityNames(Local7Value);
        /// <summary> *. </summary>
        public static KnownSyslogDataSourceFacilityNames Asterisk { get; } = new KnownSyslogDataSourceFacilityNames(AsteriskValue);
        /// <summary> Determines if two <see cref="KnownSyslogDataSourceFacilityNames"/> values are the same. </summary>
        public static bool operator ==(KnownSyslogDataSourceFacilityNames left, KnownSyslogDataSourceFacilityNames right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KnownSyslogDataSourceFacilityNames"/> values are not the same. </summary>
        public static bool operator !=(KnownSyslogDataSourceFacilityNames left, KnownSyslogDataSourceFacilityNames right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KnownSyslogDataSourceFacilityNames"/>. </summary>
        public static implicit operator KnownSyslogDataSourceFacilityNames(string value) => new KnownSyslogDataSourceFacilityNames(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KnownSyslogDataSourceFacilityNames other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KnownSyslogDataSourceFacilityNames other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
