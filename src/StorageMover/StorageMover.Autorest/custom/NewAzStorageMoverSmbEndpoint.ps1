
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates an SMB endpoint resource, which represents a data transfer source or destination.
.Description
Creates an SMB endpoint resource, which represents a data transfer source or destination.
.Example
New-AzStorageMoverSmbEndpoint -Name $endpointName -ResourceGroupName $rgname -StorageMoverName $storagemovername -Host $host -ShareName $shareName -CredentialsUsernameUri "https://examples-azureKeyVault.vault.azure.net/secrets/examples-username" -CredentialsPasswordUri "https://examples-azureKeyVault.vault.azure.net/secrets/examples-password" -Description "Description"
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IEndpoint
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IStorageMoverIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IEndpoint
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

.Link
https://learn.microsoft.com/powershell/module/az.storagemover/new-azstoragemoversmbendpoint
#>
function New-AzStorageMoverSmbEndpoint {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IEndpoint])]
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded', PositionalBinding =$false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
    param(
        [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
        [Alias('EndpointName')]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Path')]
        [System.String]
        # The name of the endpoint resource.
        ${Name},

        [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},

        [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Path')]
        [System.String]
        # The name of the Storage Mover resource.
        ${StorageMoverName},

        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(Mandatory, HelpMessage="The host name or IP address of the server exporting the file system.")]
        [string]
        ${Host},

        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(Mandatory, HelpMessage="The name of the SMB share being exported from the server")]
        [string]
        ${ShareName},

        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(HelpMessage="The secret URI which stores the username. Use empty string to clean-up existing value.")]
        [string]
        ${CredentialsUsernameUri},

        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(HelpMessage="The secret URI which stores the password. Use empty string to clean-up existing value.")]
        [string]
        ${CredentialsPasswordUri},

        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(HelpMessage="A description for the endpoint.")]
        [string]
        ${Description},

        [Parameter(ParameterSetName='CreateExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        $Properties = [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.SmbMountEndpointProperties]::New()

        if ($PSBoundParameters.ContainsKey('Host')) {
            $Properties.Host = $Host
            $null = $PSBoundParameters.Remove("Host")
        }
        if ($PSBoundParameters.ContainsKey('ShareName')) {
            $Properties.ShareName = $ShareName
            $null = $PSBoundParameters.Remove("ShareName")
        }
        if ($PSBoundParameters.ContainsKey('CredentialsUsernameUri')) {
            $Properties.CredentialsUsernameUri = $CredentialsUsernameUri
            $null = $PSBoundParameters.Remove("CredentialsUsernameUri")
        }
        if ($PSBoundParameters.ContainsKey('CredentialsPasswordUri')) {
            $Properties.CredentialsPasswordUri = $CredentialsPasswordUri
            $null = $PSBoundParameters.Remove("CredentialsPasswordUri")
        }
        if ($PSBoundParameters.ContainsKey('Description')) {
            $Properties.Description = $Description
            $null = $PSBoundParameters.Remove("Description")
        }

        $Properties.EndpointType = "SmbMount"
        $PSBoundParameters.Add("Property", $Properties)

        Az.StorageMover.internal\New-AzStorageMoverEndpoint @PSBoundParameters
    }
}
