// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Replication extension model collection.</summary>
    public partial class ReplicationExtensionModelCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IReplicationExtensionModelCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IReplicationExtensionModelCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Gets or sets the value of next link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IReplicationExtensionModel[] _value;

        /// <summary>Gets or sets the list of replication extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IReplicationExtensionModel[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ReplicationExtensionModelCollection" /> instance.</summary>
        public ReplicationExtensionModelCollection()
        {

        }
    }
    /// Replication extension model collection.
    public partial interface IReplicationExtensionModelCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the value of next link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the value of next link.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Gets or sets the list of replication extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the list of replication extensions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IReplicationExtensionModel) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IReplicationExtensionModel[] Value { get; set; }

    }
    /// Replication extension model collection.
    internal partial interface IReplicationExtensionModelCollectionInternal

    {
        /// <summary>Gets or sets the value of next link.</summary>
        string NextLink { get; set; }
        /// <summary>Gets or sets the list of replication extensions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IReplicationExtensionModel[] Value { get; set; }

    }
}