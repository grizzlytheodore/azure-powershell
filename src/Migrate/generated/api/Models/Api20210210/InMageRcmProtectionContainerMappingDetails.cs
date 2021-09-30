// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm provider specific container mapping details.</summary>
    public partial class InMageRcmProtectionContainerMappingDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectionContainerMappingDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectionContainerMappingDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionContainerMappingProviderSpecificDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionContainerMappingProviderSpecificDetails __protectionContainerMappingProviderSpecificDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProtectionContainerMappingProviderSpecificDetails();

        /// <summary>Backing field for <see cref="EnableAgentAutoUpgrade" /> property.</summary>
        private string _enableAgentAutoUpgrade;

        /// <summary>A value indicating whether the flag for enable agent auto upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string EnableAgentAutoUpgrade { get => this._enableAgentAutoUpgrade; }

        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionContainerMappingProviderSpecificDetailsInternal)__protectionContainerMappingProviderSpecificDetails).InstanceType; }

        /// <summary>Internal Acessors for EnableAgentAutoUpgrade</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectionContainerMappingDetailsInternal.EnableAgentAutoUpgrade { get => this._enableAgentAutoUpgrade; set { {_enableAgentAutoUpgrade = value;} } }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionContainerMappingProviderSpecificDetailsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionContainerMappingProviderSpecificDetailsInternal)__protectionContainerMappingProviderSpecificDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionContainerMappingProviderSpecificDetailsInternal)__protectionContainerMappingProviderSpecificDetails).InstanceType = value; }

        /// <summary>
        /// Creates an new <see cref="InMageRcmProtectionContainerMappingDetails" /> instance.
        /// </summary>
        public InMageRcmProtectionContainerMappingDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__protectionContainerMappingProviderSpecificDetails), __protectionContainerMappingProviderSpecificDetails);
            await eventListener.AssertObjectIsValid(nameof(__protectionContainerMappingProviderSpecificDetails), __protectionContainerMappingProviderSpecificDetails);
        }
    }
    /// InMageRcm provider specific container mapping details.
    public partial interface IInMageRcmProtectionContainerMappingDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionContainerMappingProviderSpecificDetails
    {
        /// <summary>A value indicating whether the flag for enable agent auto upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether the flag for enable agent auto upgrade.",
        SerializedName = @"enableAgentAutoUpgrade",
        PossibleTypes = new [] { typeof(string) })]
        string EnableAgentAutoUpgrade { get;  }

    }
    /// InMageRcm provider specific container mapping details.
    internal partial interface IInMageRcmProtectionContainerMappingDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionContainerMappingProviderSpecificDetailsInternal
    {
        /// <summary>A value indicating whether the flag for enable agent auto upgrade.</summary>
        string EnableAgentAutoUpgrade { get; set; }

    }
}