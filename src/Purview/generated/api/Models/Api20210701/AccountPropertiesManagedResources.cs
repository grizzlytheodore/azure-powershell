namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Gets the resource identifiers of the managed resources.</summary>
    public partial class AccountPropertiesManagedResources :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesManagedResources,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesManagedResourcesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources __managedResources = new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ManagedResources();

        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string EventHubNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).EventHubNamespace; }

        /// <summary>Internal Acessors for EventHubNamespace</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal.EventHubNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).EventHubNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).EventHubNamespace = value; }

        /// <summary>Internal Acessors for ResourceGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal.ResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).ResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).ResourceGroup = value; }

        /// <summary>Internal Acessors for StorageAccount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal.StorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).StorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).StorageAccount = value; }

        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string ResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).ResourceGroup; }

        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string StorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)__managedResources).StorageAccount; }

        /// <summary>Creates an new <see cref="AccountPropertiesManagedResources" /> instance.</summary>
        public AccountPropertiesManagedResources()
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
            await eventListener.AssertNotNull(nameof(__managedResources), __managedResources);
            await eventListener.AssertObjectIsValid(nameof(__managedResources), __managedResources);
        }
    }
    /// Gets the resource identifiers of the managed resources.
    public partial interface IAccountPropertiesManagedResources :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources
    {

    }
    /// Gets the resource identifiers of the managed resources.
    internal partial interface IAccountPropertiesManagedResourcesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal
    {

    }
}