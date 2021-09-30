
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update a Kusto pool.
.Description
Create or update a Kusto pool.
.Example
PS C:\> New-AzSynapseKustoPool -ResourceGroupName testrg -WorkspaceName testws -Name testnewkustopool -Location 'East US' -SkuName "Storage optimized" -SkuSize Medium

Location  Name                    Type                                    Etag
--------  ----                    ----                                    ----
East US 2 testws/testnewkustopool Microsoft.Synapse/workspaces/kustoPools 

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPool
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPool
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PARAMETER <IKustoPool>: Class representing a Kusto kusto pool.
  Location <String>: The geo-location where the resource lives
  SkuName <SkuName>: SKU name.
  SkuSize <SkuSize>: SKU size.
  [Tag <ITrackedResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [EnablePurge <Boolean?>]: A boolean value that indicates if the purge operations are enabled.
  [EnableStreamingIngest <Boolean?>]: A boolean value that indicates if the streaming ingest is enabled.
  [LanguageExtensionValue <ILanguageExtension[]>]: The list of language extensions.
    [Name <LanguageExtensionName?>]: The language extension name.
  [OptimizedAutoscaleIsEnabled <Boolean?>]: A boolean value that indicate if the optimized autoscale feature is enabled or not.
  [OptimizedAutoscaleMaximum <Int32?>]: Maximum allowed instances count.
  [OptimizedAutoscaleMinimum <Int32?>]: Minimum allowed instances count.
  [OptimizedAutoscaleVersion <Int32?>]: The version of the template defined, for instance 1.
  [SkuCapacity <Int32?>]: The number of instances of the cluster.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
  [WorkspaceUid <String>]: The workspace unique identifier.
.Link
https://docs.microsoft.com/powershell/module/az.synapse/new-azsynapsekustopool
#>
function New-AzSynapseKustoPool {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPool])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('KustoPoolName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Path')]
    [System.String]
    # The name of the Kusto pool.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Path')]
    [System.String]
    # The name of the workspace
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Header')]
    [System.String]
    # The ETag of the Kusto Pool.
    # Omit this value to always overwrite the current Kusto Pool.
    # Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes.
    ${IfMatch},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Header')]
    [System.String]
    # Set to '*' to allow a new Kusto Pool to be created, but to prevent updating an existing Kusto Pool.
    # Other values will result in a 412 Pre-condition Failed response.
    ${IfNoneMatch},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPool]
    # Class representing a Kusto kusto pool.
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuName])]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuName]
    # SKU name.
    ${SkuName},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuSize])]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuSize]
    # SKU size.
    ${SkuSize},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A boolean value that indicates if the purge operations are enabled.
    ${EnablePurge},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A boolean value that indicates if the streaming ingest is enabled.
    ${EnableStreamingIngest},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A boolean value that indicate if the optimized autoscale feature is enabled or not.
    ${OptimizedAutoscaleIsEnabled},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.Int32]
    # Maximum allowed instances count.
    ${OptimizedAutoscaleMaximum},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.Int32]
    # Minimum allowed instances count.
    ${OptimizedAutoscaleMinimum},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.Int32]
    # The version of the template defined, for instance 1.
    ${OptimizedAutoscaleVersion},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.Int32]
    # The number of instances of the cluster.
    ${SkuCapacity},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Body')]
    [System.String]
    # The workspace unique identifier.
    ${WorkspaceUid},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Create = 'Az.Synapse.private\New-AzSynapseKustoPool_Create';
            CreateExpanded = 'Az.Synapse.private\New-AzSynapseKustoPool_CreateExpanded';
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
