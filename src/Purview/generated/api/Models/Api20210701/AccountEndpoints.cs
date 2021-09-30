namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The account endpoints</summary>
    public partial class AccountEndpoints :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal
    {

        /// <summary>Backing field for <see cref="Catalog" /> property.</summary>
        private string _catalog;

        /// <summary>Gets the catalog endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Catalog { get => this._catalog; }

        /// <summary>Backing field for <see cref="Guardian" /> property.</summary>
        private string _guardian;

        /// <summary>Gets the guardian endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Guardian { get => this._guardian; }

        /// <summary>Internal Acessors for Catalog</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal.Catalog { get => this._catalog; set { {_catalog = value;} } }

        /// <summary>Internal Acessors for Guardian</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal.Guardian { get => this._guardian; set { {_guardian = value;} } }

        /// <summary>Internal Acessors for Scan</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpointsInternal.Scan { get => this._scan; set { {_scan = value;} } }

        /// <summary>Backing field for <see cref="Scan" /> property.</summary>
        private string _scan;

        /// <summary>Gets the scan endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Scan { get => this._scan; }

        /// <summary>Creates an new <see cref="AccountEndpoints" /> instance.</summary>
        public AccountEndpoints()
        {

        }
    }
    /// The account endpoints
    public partial interface IAccountEndpoints :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Gets the catalog endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the catalog endpoint.",
        SerializedName = @"catalog",
        PossibleTypes = new [] { typeof(string) })]
        string Catalog { get;  }
        /// <summary>Gets the guardian endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the guardian endpoint.",
        SerializedName = @"guardian",
        PossibleTypes = new [] { typeof(string) })]
        string Guardian { get;  }
        /// <summary>Gets the scan endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the scan endpoint.",
        SerializedName = @"scan",
        PossibleTypes = new [] { typeof(string) })]
        string Scan { get;  }

    }
    /// The account endpoints
    internal partial interface IAccountEndpointsInternal

    {
        /// <summary>Gets the catalog endpoint.</summary>
        string Catalog { get; set; }
        /// <summary>Gets the guardian endpoint.</summary>
        string Guardian { get; set; }
        /// <summary>Gets the scan endpoint.</summary>
        string Scan { get; set; }

    }
}