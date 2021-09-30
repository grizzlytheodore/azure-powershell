// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Create network mappings input.</summary>
    public partial class CreateNetworkMappingInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputInternal
    {

        /// <summary>The instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string FabricSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputPropertiesInternal)Property).FabricSpecificDetailInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputPropertiesInternal)Property).FabricSpecificDetailInstanceType = value ?? null; }

        /// <summary>Internal Acessors for FabricSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreateNetworkMappingInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputInternal.FabricSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputPropertiesInternal)Property).FabricSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputPropertiesInternal)Property).FabricSpecificDetail = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreateNetworkMappingInputProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputProperties _property;

        /// <summary>Input properties for creating network mapping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreateNetworkMappingInputProperties()); set => this._property = value; }

        /// <summary>Recovery fabric Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryFabricName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputPropertiesInternal)Property).RecoveryFabricName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputPropertiesInternal)Property).RecoveryFabricName = value ?? null; }

        /// <summary>Recovery network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryNetworkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputPropertiesInternal)Property).RecoveryNetworkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputPropertiesInternal)Property).RecoveryNetworkId = value ; }

        /// <summary>Creates an new <see cref="CreateNetworkMappingInput" /> instance.</summary>
        public CreateNetworkMappingInput()
        {

        }
    }
    /// Create network mappings input.
    public partial interface ICreateNetworkMappingInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The instance type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string FabricSpecificDetailInstanceType { get; set; }
        /// <summary>Recovery fabric Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Recovery fabric Name.",
        SerializedName = @"recoveryFabricName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryFabricName { get; set; }
        /// <summary>Recovery network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Recovery network Id.",
        SerializedName = @"recoveryNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryNetworkId { get; set; }

    }
    /// Create network mappings input.
    internal partial interface ICreateNetworkMappingInputInternal

    {
        /// <summary>Fabric specific input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreateNetworkMappingInput FabricSpecificDetail { get; set; }
        /// <summary>The instance type.</summary>
        string FabricSpecificDetailInstanceType { get; set; }
        /// <summary>Input properties for creating network mapping.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateNetworkMappingInputProperties Property { get; set; }
        /// <summary>Recovery fabric Name.</summary>
        string RecoveryFabricName { get; set; }
        /// <summary>Recovery network Id.</summary>
        string RecoveryNetworkId { get; set; }

    }
}