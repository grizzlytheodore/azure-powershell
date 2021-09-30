namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    public partial class TrackedResourceSystemData :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceSystemData,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceSystemDataInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemData"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemData __systemData = new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.SystemData();

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? CreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedByType; }

        /// <summary>The timestamp of the last modification the resource (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string LastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? LastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedByType; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedAt = value; }

        /// <summary>Internal Acessors for CreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedBy = value; }

        /// <summary>Internal Acessors for CreatedByType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.CreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).CreatedByType = value; }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedAt = value; }

        /// <summary>Internal Acessors for LastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.LastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedBy = value; }

        /// <summary>Internal Acessors for LastModifiedByType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.LastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal)__systemData).LastModifiedByType = value; }

        /// <summary>Creates an new <see cref="TrackedResourceSystemData" /> instance.</summary>
        public TrackedResourceSystemData()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__systemData), __systemData);
            await eventListener.AssertObjectIsValid(nameof(__systemData), __systemData);
        }
    }
    /// Metadata pertaining to creation and last modification of the resource.
    public partial interface ITrackedResourceSystemData :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemData
    {

    }
    /// Metadata pertaining to creation and last modification of the resource.
    internal partial interface ITrackedResourceSystemDataInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal
    {

    }
}