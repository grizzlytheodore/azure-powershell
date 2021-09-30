// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The progress health.</summary>
    public partial struct DiskReplicationProgressHealth :
        System.IEquatable<DiskReplicationProgressHealth>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth InProgress = @"InProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth NoProgress = @"NoProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth Queued = @"Queued";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth SlowProgress = @"SlowProgress";

        /// <summary>
        /// the value for an instance of the <see cref="DiskReplicationProgressHealth" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DiskReplicationProgressHealth</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DiskReplicationProgressHealth" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DiskReplicationProgressHealth(global::System.Convert.ToString(value));
        }

        /// <summary>
        /// Creates an instance of the <see cref="DiskReplicationProgressHealth" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DiskReplicationProgressHealth(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DiskReplicationProgressHealth</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type DiskReplicationProgressHealth (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DiskReplicationProgressHealth && Equals((DiskReplicationProgressHealth)obj);
        }

        /// <summary>Returns hashCode for enum DiskReplicationProgressHealth</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DiskReplicationProgressHealth</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DiskReplicationProgressHealth</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DiskReplicationProgressHealth" />.</param>

        public static implicit operator DiskReplicationProgressHealth(string value)
        {
            return new DiskReplicationProgressHealth(value);
        }

        /// <summary>Implicit operator to convert DiskReplicationProgressHealth to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DiskReplicationProgressHealth" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DiskReplicationProgressHealth</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DiskReplicationProgressHealth</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth e2)
        {
            return e2.Equals(e1);
        }
    }
}