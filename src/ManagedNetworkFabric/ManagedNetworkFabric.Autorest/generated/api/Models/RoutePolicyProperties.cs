// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>RoutePolicyProperties defines the resource properties.</summary>
    public partial class RoutePolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource __annotationResource = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.AnnotationResource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPatchableProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPatchableProperties __routePolicyPatchableProperties = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.RoutePolicyPatchableProperties();

        /// <summary>Backing field for <see cref="AddressFamilyType" /> property.</summary>
        private string _addressFamilyType;

        /// <summary>
        /// AddressFamilyType. This parameter decides whether the given ipv4 or ipv6 route policy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string AddressFamilyType { get => this._addressFamilyType; set => this._addressFamilyType = value; }

        /// <summary>Backing field for <see cref="AdministrativeState" /> property.</summary>
        private string _administrativeState;

        /// <summary>Administrative state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string AdministrativeState { get => this._administrativeState; }

        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string Annotation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation = value ?? null; }

        /// <summary>Backing field for <see cref="ConfigurationState" /> property.</summary>
        private string _configurationState;

        /// <summary>Configuration state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ConfigurationState { get => this._configurationState; }

        /// <summary>
        /// Default action that needs to be applied when no condition is matched. Example: Permit | Deny.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string DefaultAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPatchablePropertiesInternal)__routePolicyPatchableProperties).DefaultAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPatchablePropertiesInternal)__routePolicyPatchableProperties).DefaultAction = value ?? null; }

        /// <summary>Internal Acessors for AdministrativeState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPropertiesInternal.AdministrativeState { get => this._administrativeState; set { {_administrativeState = value;} } }

        /// <summary>Internal Acessors for ConfigurationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPropertiesInternal.ConfigurationState { get => this._configurationState; set { {_configurationState = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NetworkFabricId" /> property.</summary>
        private string _networkFabricId;

        /// <summary>Arm Resource ID of Network Fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string NetworkFabricId { get => this._networkFabricId; set => this._networkFabricId = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Route Policy statements.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyStatementProperties> Statement { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPatchablePropertiesInternal)__routePolicyPatchableProperties).Statement; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPatchablePropertiesInternal)__routePolicyPatchableProperties).Statement = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="RoutePolicyProperties" /> instance.</summary>
        public RoutePolicyProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertObjectIsValid(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertNotNull(nameof(__routePolicyPatchableProperties), __routePolicyPatchableProperties);
            await eventListener.AssertObjectIsValid(nameof(__routePolicyPatchableProperties), __routePolicyPatchableProperties);
        }
    }
    /// RoutePolicyProperties defines the resource properties.
    public partial interface IRoutePolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPatchableProperties
    {
        /// <summary>
        /// AddressFamilyType. This parameter decides whether the given ipv4 or ipv6 route policy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"AddressFamilyType. This parameter decides whether the given ipv4 or ipv6 route policy.",
        SerializedName = @"addressFamilyType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string AddressFamilyType { get; set; }
        /// <summary>Administrative state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Administrative state of the resource.",
        SerializedName = @"administrativeState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Enabled", "Disabled", "MAT", "RMA")]
        string AdministrativeState { get;  }
        /// <summary>Configuration state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Configuration state of the resource.",
        SerializedName = @"configurationState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Succeeded", "Failed", "Rejected", "Accepted", "Provisioned", "ErrorProvisioning", "Deprovisioning", "Deprovisioned", "ErrorDeprovisioning", "DeferredControl")]
        string ConfigurationState { get;  }
        /// <summary>Arm Resource ID of Network Fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Arm Resource ID of Network Fabric.",
        SerializedName = @"networkFabricId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkFabricId { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Accepted", "Succeeded", "Updating", "Deleting", "Failed", "Canceled")]
        string ProvisioningState { get;  }

    }
    /// RoutePolicyProperties defines the resource properties.
    internal partial interface IRoutePolicyPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRoutePolicyPatchablePropertiesInternal
    {
        /// <summary>
        /// AddressFamilyType. This parameter decides whether the given ipv4 or ipv6 route policy.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string AddressFamilyType { get; set; }
        /// <summary>Administrative state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Enabled", "Disabled", "MAT", "RMA")]
        string AdministrativeState { get; set; }
        /// <summary>Configuration state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Succeeded", "Failed", "Rejected", "Accepted", "Provisioned", "ErrorProvisioning", "Deprovisioning", "Deprovisioned", "ErrorDeprovisioning", "DeferredControl")]
        string ConfigurationState { get; set; }
        /// <summary>Arm Resource ID of Network Fabric.</summary>
        string NetworkFabricId { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Accepted", "Succeeded", "Updating", "Deleting", "Failed", "Canceled")]
        string ProvisioningState { get; set; }

    }
}