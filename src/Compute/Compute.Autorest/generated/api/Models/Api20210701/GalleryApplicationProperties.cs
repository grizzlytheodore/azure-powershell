// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Describes the properties of a gallery Application Definition.</summary>
    public partial class GalleryApplicationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>
        /// The description of this gallery Application Definition resource. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="EndOfLifeDate" /> property.</summary>
        private global::System.DateTime? _endOfLifeDate;

        /// <summary>
        /// The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This
        /// property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public global::System.DateTime? EndOfLifeDate { get => this._endOfLifeDate; set => this._endOfLifeDate = value; }

        /// <summary>Backing field for <see cref="Eula" /> property.</summary>
        private string _eula;

        /// <summary>The Eula agreement for the gallery Application Definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Eula { get => this._eula; set => this._eula = value; }

        /// <summary>Backing field for <see cref="PrivacyStatementUri" /> property.</summary>
        private string _privacyStatementUri;

        /// <summary>The privacy statement uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string PrivacyStatementUri { get => this._privacyStatementUri; set => this._privacyStatementUri = value; }

        /// <summary>Backing field for <see cref="ReleaseNoteUri" /> property.</summary>
        private string _releaseNoteUri;

        /// <summary>The release note uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string ReleaseNoteUri { get => this._releaseNoteUri; set => this._releaseNoteUri = value; }

        /// <summary>Backing field for <see cref="SupportedOSType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes _supportedOSType;

        /// <summary>
        /// This property allows you to specify the supported type of the OS that application is built for. <br><br> Possible values
        /// are: <br><br> **Windows** <br><br> **Linux**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes SupportedOSType { get => this._supportedOSType; set => this._supportedOSType = value; }

        /// <summary>Creates an new <see cref="GalleryApplicationProperties" /> instance.</summary>
        public GalleryApplicationProperties()
        {

        }
    }
    /// Describes the properties of a gallery Application Definition.
    public partial interface IGalleryApplicationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The description of this gallery Application Definition resource. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of this gallery Application Definition resource. This property is updatable.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This
        /// property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable.",
        SerializedName = @"endOfLifeDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndOfLifeDate { get; set; }
        /// <summary>The Eula agreement for the gallery Application Definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Eula agreement for the gallery Application Definition.",
        SerializedName = @"eula",
        PossibleTypes = new [] { typeof(string) })]
        string Eula { get; set; }
        /// <summary>The privacy statement uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The privacy statement uri.",
        SerializedName = @"privacyStatementUri",
        PossibleTypes = new [] { typeof(string) })]
        string PrivacyStatementUri { get; set; }
        /// <summary>The release note uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The release note uri.",
        SerializedName = @"releaseNoteUri",
        PossibleTypes = new [] { typeof(string) })]
        string ReleaseNoteUri { get; set; }
        /// <summary>
        /// This property allows you to specify the supported type of the OS that application is built for. <br><br> Possible values
        /// are: <br><br> **Windows** <br><br> **Linux**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"This property allows you to specify the supported type of the OS that application is built for. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**",
        SerializedName = @"supportedOSType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes SupportedOSType { get; set; }

    }
    /// Describes the properties of a gallery Application Definition.
    internal partial interface IGalleryApplicationPropertiesInternal

    {
        /// <summary>
        /// The description of this gallery Application Definition resource. This property is updatable.
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This
        /// property is updatable.
        /// </summary>
        global::System.DateTime? EndOfLifeDate { get; set; }
        /// <summary>The Eula agreement for the gallery Application Definition.</summary>
        string Eula { get; set; }
        /// <summary>The privacy statement uri.</summary>
        string PrivacyStatementUri { get; set; }
        /// <summary>The release note uri.</summary>
        string ReleaseNoteUri { get; set; }
        /// <summary>
        /// This property allows you to specify the supported type of the OS that application is built for. <br><br> Possible values
        /// are: <br><br> **Windows** <br><br> **Linux**
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes SupportedOSType { get; set; }

    }
}