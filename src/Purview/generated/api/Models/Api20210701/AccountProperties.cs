namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The account properties</summary>
    public partial class AccountProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CloudConnector" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors _cloudConnector;

        /// <summary>
        /// Cloud connectors.
        /// External cloud identifier used as part of scanning configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors CloudConnector { get => (this._cloudConnector = this._cloudConnector ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.CloudConnectors()); set => this._cloudConnector = value; }

        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string CloudConnectorAwsExternalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectorsInternal)CloudConnector).AwsExternalId; }

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        /// <summary>Gets the time at which the entity was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; }

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private string _createdBy;

        /// <summary>Gets the creator of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string CreatedBy { get => this._createdBy; }

        /// <summary>Backing field for <see cref="CreatedByObjectId" /> property.</summary>
        private string _createdByObjectId;

        /// <summary>Gets the creators of the entity's object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string CreatedByObjectId { get => this._createdByObjectId; }

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints _endpoint;

        /// <summary>The URIs that are the public endpoints of the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints Endpoint { get => (this._endpoint = this._endpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountEndpoints()); }

        /// <summary>Gets the catalog endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointCatalog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Catalog; }

        /// <summary>Gets the guardian endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointGuardian { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Guardian; }

        /// <summary>Gets the scan endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointScan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Scan; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Gets or sets the friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; }

        /// <summary>Backing field for <see cref="ManagedResource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources _managedResource;

        /// <summary>Gets the resource identifiers of the managed resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources ManagedResource { get => (this._managedResource = this._managedResource ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ManagedResources()); }

        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceEventHubNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).EventHubNamespace; }

        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).ResourceGroup; }

        /// <summary>Backing field for <see cref="ManagedResourceGroupName" /> property.</summary>
        private string _managedResourceGroupName;

        /// <summary>Gets or sets the managed resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ManagedResourceGroupName { get => this._managedResourceGroupName; set => this._managedResourceGroupName = value; }

        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).StorageAccount; }

        /// <summary>Internal Acessors for CloudConnector</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.CloudConnector { get => (this._cloudConnector = this._cloudConnector ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.CloudConnectors()); set { {_cloudConnector = value;} } }

        /// <summary>Internal Acessors for CloudConnectorAwsExternalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.CloudConnectorAwsExternalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectorsInternal)CloudConnector).AwsExternalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectorsInternal)CloudConnector).AwsExternalId = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for CreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.CreatedBy { get => this._createdBy; set { {_createdBy = value;} } }

        /// <summary>Internal Acessors for CreatedByObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.CreatedByObjectId { get => this._createdByObjectId; set { {_createdByObjectId = value;} } }

        /// <summary>Internal Acessors for Endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.Endpoint { get => (this._endpoint = this._endpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountEndpoints()); set { {_endpoint = value;} } }

        /// <summary>Internal Acessors for EndpointCatalog</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.EndpointCatalog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Catalog; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Catalog = value; }

        /// <summary>Internal Acessors for EndpointGuardian</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.EndpointGuardian { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Guardian; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Guardian = value; }

        /// <summary>Internal Acessors for EndpointScan</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.EndpointScan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Scan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal)Endpoint).Scan = value; }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.FriendlyName { get => this._friendlyName; set { {_friendlyName = value;} } }

        /// <summary>Internal Acessors for ManagedResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.ManagedResource { get => (this._managedResource = this._managedResource ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ManagedResources()); set { {_managedResource = value;} } }

        /// <summary>Internal Acessors for ManagedResourceEventHubNamespace</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.ManagedResourceEventHubNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).EventHubNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).EventHubNamespace = value; }

        /// <summary>Internal Acessors for ManagedResourceGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.ManagedResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).ResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).ResourceGroup = value; }

        /// <summary>Internal Acessors for ManagedResourceStorageAccount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.ManagedResourceStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).StorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal)ManagedResource).StorageAccount = value; }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.PrivateEndpointConnection { get => this._privateEndpointConnection; set { {_privateEndpointConnection = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateEndpointConnection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] _privateEndpointConnection;

        /// <summary>Gets the private endpoint connections information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get => this._privateEndpointConnection; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? _provisioningState;

        /// <summary>Gets or sets the state of the provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? _publicNetworkAccess;

        /// <summary>Gets or sets the public network access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Creates an new <see cref="AccountProperties" /> instance.</summary>
        public AccountProperties()
        {

        }
    }
    /// The account properties
    public partial interface IAccountProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"AWS external identifier.
        Configured in AWS to allow use of the role arn used for scanning",
        SerializedName = @"awsExternalId",
        PossibleTypes = new [] { typeof(string) })]
        string CloudConnectorAwsExternalId { get;  }
        /// <summary>Gets the time at which the entity was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the time at which the entity was created.",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }
        /// <summary>Gets the creator of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the creator of the entity.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedBy { get;  }
        /// <summary>Gets the creators of the entity's object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the creators of the entity's object id.",
        SerializedName = @"createdByObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedByObjectId { get;  }
        /// <summary>Gets the catalog endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the catalog endpoint.",
        SerializedName = @"catalog",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointCatalog { get;  }
        /// <summary>Gets the guardian endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the guardian endpoint.",
        SerializedName = @"guardian",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointGuardian { get;  }
        /// <summary>Gets the scan endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the scan endpoint.",
        SerializedName = @"scan",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointScan { get;  }
        /// <summary>Gets or sets the friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the friendly name.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get;  }
        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed event hub namespace resource identifier.",
        SerializedName = @"eventHubNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceEventHubNamespace { get;  }
        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroup { get;  }
        /// <summary>Gets or sets the managed resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the managed resource group name",
        SerializedName = @"managedResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupName { get; set; }
        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed storage account resource identifier.",
        SerializedName = @"storageAccount",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceStorageAccount { get;  }
        /// <summary>Gets the private endpoint connections information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the private endpoint connections information.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get;  }
        /// <summary>Gets or sets the state of the provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the state of the provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Gets or sets the public network access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the public network access.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }

    }
    /// The account properties
    internal partial interface IAccountPropertiesInternal

    {
        /// <summary>
        /// Cloud connectors.
        /// External cloud identifier used as part of scanning configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors CloudConnector { get; set; }
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        string CloudConnectorAwsExternalId { get; set; }
        /// <summary>Gets the time at which the entity was created.</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>Gets the creator of the entity.</summary>
        string CreatedBy { get; set; }
        /// <summary>Gets the creators of the entity's object id.</summary>
        string CreatedByObjectId { get; set; }
        /// <summary>The URIs that are the public endpoints of the account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints Endpoint { get; set; }
        /// <summary>Gets the catalog endpoint.</summary>
        string EndpointCatalog { get; set; }
        /// <summary>Gets the guardian endpoint.</summary>
        string EndpointGuardian { get; set; }
        /// <summary>Gets the scan endpoint.</summary>
        string EndpointScan { get; set; }
        /// <summary>Gets or sets the friendly name.</summary>
        string FriendlyName { get; set; }
        /// <summary>Gets the resource identifiers of the managed resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources ManagedResource { get; set; }
        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        string ManagedResourceEventHubNamespace { get; set; }
        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        string ManagedResourceGroup { get; set; }
        /// <summary>Gets or sets the managed resource group name</summary>
        string ManagedResourceGroupName { get; set; }
        /// <summary>Gets the managed storage account resource identifier.</summary>
        string ManagedResourceStorageAccount { get; set; }
        /// <summary>Gets the private endpoint connections information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>Gets or sets the state of the provisioning.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Gets or sets the public network access.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }

    }
}