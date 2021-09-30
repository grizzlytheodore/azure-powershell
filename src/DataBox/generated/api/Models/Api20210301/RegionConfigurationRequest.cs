// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request body to get the configuration for the region.</summary>
    public partial class RegionConfigurationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IRegionConfigurationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IRegionConfigurationRequestInternal
    {

        /// <summary>Internal Acessors for ScheduleAvailabilityRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequest Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IRegionConfigurationRequestInternal.ScheduleAvailabilityRequest { get => (this._scheduleAvailabilityRequest = this._scheduleAvailabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ScheduleAvailabilityRequest()); set { {_scheduleAvailabilityRequest = value;} } }

        /// <summary>Internal Acessors for TransportAvailabilityRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransportAvailabilityRequest Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IRegionConfigurationRequestInternal.TransportAvailabilityRequest { get => (this._transportAvailabilityRequest = this._transportAvailabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransportAvailabilityRequest()); set { {_transportAvailabilityRequest = value;} } }

        /// <summary>Backing field for <see cref="ScheduleAvailabilityRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequest _scheduleAvailabilityRequest;

        /// <summary>Request body to get the availability for scheduling orders.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequest ScheduleAvailabilityRequest { get => (this._scheduleAvailabilityRequest = this._scheduleAvailabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ScheduleAvailabilityRequest()); set => this._scheduleAvailabilityRequest = value; }

        /// <summary>Country in which storage location should be supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ScheduleAvailabilityRequestCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).Country = value ?? null; }

        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName? ScheduleAvailabilityRequestSkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).SkuName = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName)""); }

        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ScheduleAvailabilityRequestStorageLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).StorageLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).StorageLocation = value ?? null; }

        /// <summary>Backing field for <see cref="TransportAvailabilityRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransportAvailabilityRequest _transportAvailabilityRequest;

        /// <summary>Request body to get the transport availability for given sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransportAvailabilityRequest TransportAvailabilityRequest { get => (this._transportAvailabilityRequest = this._transportAvailabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransportAvailabilityRequest()); set => this._transportAvailabilityRequest = value; }

        /// <summary>Type of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName? TransportAvailabilityRequestSkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransportAvailabilityRequestInternal)TransportAvailabilityRequest).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransportAvailabilityRequestInternal)TransportAvailabilityRequest).SkuName = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName)""); }

        /// <summary>Creates an new <see cref="RegionConfigurationRequest" /> instance.</summary>
        public RegionConfigurationRequest()
        {

        }
    }
    /// Request body to get the configuration for the region.
    public partial interface IRegionConfigurationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Country in which storage location should be supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Country in which storage location should be supported.",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleAvailabilityRequestCountry { get; set; }
        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sku Name for which the order is to be scheduled.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName? ScheduleAvailabilityRequestSkuName { get; set; }
        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01",
        SerializedName = @"storageLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleAvailabilityRequestStorageLocation { get; set; }
        /// <summary>Type of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the device.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName? TransportAvailabilityRequestSkuName { get; set; }

    }
    /// Request body to get the configuration for the region.
    internal partial interface IRegionConfigurationRequestInternal

    {
        /// <summary>Request body to get the availability for scheduling orders.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequest ScheduleAvailabilityRequest { get; set; }
        /// <summary>Country in which storage location should be supported.</summary>
        string ScheduleAvailabilityRequestCountry { get; set; }
        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName? ScheduleAvailabilityRequestSkuName { get; set; }
        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        string ScheduleAvailabilityRequestStorageLocation { get; set; }
        /// <summary>Request body to get the transport availability for given sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransportAvailabilityRequest TransportAvailabilityRequest { get; set; }
        /// <summary>Type of the device.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName? TransportAvailabilityRequestSkuName { get; set; }

    }
}