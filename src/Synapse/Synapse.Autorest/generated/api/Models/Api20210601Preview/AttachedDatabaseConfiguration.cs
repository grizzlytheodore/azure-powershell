// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Extensions;

    /// <summary>Class representing an attached database configuration.</summary>
    public partial class AttachedDatabaseConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.Resource();

        /// <summary>
        /// The list of databases from the clusterResourceId which are currently attached to the kusto pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string[] AttachedDatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).AttachedDatabaseName; }

        /// <summary>
        /// The resource id of the kusto pool where the databases you would like to attach reside.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string ClusterResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).ClusterResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).ClusterResourceId = value ?? null; }

        /// <summary>
        /// The name of the database which you would like to attach, use * if you want to follow all current and future databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string DatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).DatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).DatabaseName = value ?? null; }

        /// <summary>The default principals modification kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DefaultPrincipalsModificationKind? DefaultPrincipalsModificationKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).DefaultPrincipalsModificationKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).DefaultPrincipalsModificationKind = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DefaultPrincipalsModificationKind)""); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for AttachedDatabaseName</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationInternal.AttachedDatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).AttachedDatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).AttachedDatabaseName = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.AttachedDatabaseConfigurationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for TableLevelSharingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ITableLevelSharingProperties Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationInternal.TableLevelSharingProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingProperty = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationProperties _property;

        /// <summary>The properties of the attached database configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.AttachedDatabaseConfigurationProperties()); set => this._property = value; }

        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemData _systemData;

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType)""); }

        /// <summary>List of external tables exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyExternalTablesToExclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyExternalTablesToExclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyExternalTablesToExclude = value ?? null /* arrayOf */; }

        /// <summary>List of external tables to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyExternalTablesToInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyExternalTablesToInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyExternalTablesToInclude = value ?? null /* arrayOf */; }

        /// <summary>List of materialized views exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyMaterializedViewsToExclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyMaterializedViewsToExclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyMaterializedViewsToExclude = value ?? null /* arrayOf */; }

        /// <summary>List of materialized views to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyMaterializedViewsToInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyMaterializedViewsToInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyMaterializedViewsToInclude = value ?? null /* arrayOf */; }

        /// <summary>List of tables to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyTablesToExclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyTablesToExclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyTablesToExclude = value ?? null /* arrayOf */; }

        /// <summary>List of tables to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyTablesToInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyTablesToInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationPropertiesInternal)Property).TableLevelSharingPropertyTablesToInclude = value ?? null /* arrayOf */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="AttachedDatabaseConfiguration" /> instance.</summary>
        public AttachedDatabaseConfiguration()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Class representing an attached database configuration.
    public partial interface IAttachedDatabaseConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResource
    {
        /// <summary>
        /// The list of databases from the clusterResourceId which are currently attached to the kusto pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of databases from the clusterResourceId which are currently attached to the kusto pool.",
        SerializedName = @"attachedDatabaseNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] AttachedDatabaseName { get;  }
        /// <summary>
        /// The resource id of the kusto pool where the databases you would like to attach reside.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the kusto pool where the databases you would like to attach reside.",
        SerializedName = @"clusterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterResourceId { get; set; }
        /// <summary>
        /// The name of the database which you would like to attach, use * if you want to follow all current and future databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the database which you would like to attach, use * if you want to follow all current and future databases.",
        SerializedName = @"databaseName",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseName { get; set; }
        /// <summary>The default principals modification kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default principals modification kind",
        SerializedName = @"defaultPrincipalsModificationKind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DefaultPrincipalsModificationKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DefaultPrincipalsModificationKind? DefaultPrincipalsModificationKind { get; set; }
        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioned state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState? ProvisioningState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>List of external tables exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of external tables exclude from the follower database",
        SerializedName = @"externalTablesToExclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyExternalTablesToExclude { get; set; }
        /// <summary>List of external tables to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of external tables to include in the follower database",
        SerializedName = @"externalTablesToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyExternalTablesToInclude { get; set; }
        /// <summary>List of materialized views exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of materialized views exclude from the follower database",
        SerializedName = @"materializedViewsToExclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyMaterializedViewsToExclude { get; set; }
        /// <summary>List of materialized views to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of materialized views to include in the follower database",
        SerializedName = @"materializedViewsToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyMaterializedViewsToInclude { get; set; }
        /// <summary>List of tables to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of tables to exclude from the follower database",
        SerializedName = @"tablesToExclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyTablesToExclude { get; set; }
        /// <summary>List of tables to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of tables to include in the follower database",
        SerializedName = @"tablesToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyTablesToInclude { get; set; }

    }
    /// Class representing an attached database configuration.
    internal partial interface IAttachedDatabaseConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal
    {
        /// <summary>
        /// The list of databases from the clusterResourceId which are currently attached to the kusto pool.
        /// </summary>
        string[] AttachedDatabaseName { get; set; }
        /// <summary>
        /// The resource id of the kusto pool where the databases you would like to attach reside.
        /// </summary>
        string ClusterResourceId { get; set; }
        /// <summary>
        /// The name of the database which you would like to attach, use * if you want to follow all current and future databases.
        /// </summary>
        string DatabaseName { get; set; }
        /// <summary>The default principals modification kind</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DefaultPrincipalsModificationKind? DefaultPrincipalsModificationKind { get; set; }
        /// <summary>Resource location.</summary>
        string Location { get; set; }
        /// <summary>The properties of the attached database configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAttachedDatabaseConfigurationProperties Property { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>Table level sharing specifications</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ITableLevelSharingProperties TableLevelSharingProperty { get; set; }
        /// <summary>List of external tables exclude from the follower database</summary>
        string[] TableLevelSharingPropertyExternalTablesToExclude { get; set; }
        /// <summary>List of external tables to include in the follower database</summary>
        string[] TableLevelSharingPropertyExternalTablesToInclude { get; set; }
        /// <summary>List of materialized views exclude from the follower database</summary>
        string[] TableLevelSharingPropertyMaterializedViewsToExclude { get; set; }
        /// <summary>List of materialized views to include in the follower database</summary>
        string[] TableLevelSharingPropertyMaterializedViewsToInclude { get; set; }
        /// <summary>List of tables to exclude from the follower database</summary>
        string[] TableLevelSharingPropertyTablesToExclude { get; set; }
        /// <summary>List of tables to include in the follower database</summary>
        string[] TableLevelSharingPropertyTablesToInclude { get; set; }

    }
}