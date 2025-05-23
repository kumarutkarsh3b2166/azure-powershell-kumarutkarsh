// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Private endpoint connection proxy object property bag.</summary>
    public partial class PrivateEndpointConnectionProxyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateEndpointConnectionProxyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateEndpointConnectionProxyPropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateEndpointConnectionProxyPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the private endpoint connection proxy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>
        /// Creates an new <see cref="PrivateEndpointConnectionProxyProperties" /> instance.
        /// </summary>
        public PrivateEndpointConnectionProxyProperties()
        {

        }
    }
    /// Private endpoint connection proxy object property bag.
    public partial interface IPrivateEndpointConnectionProxyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IJsonSerializable
    {
        /// <summary>The provisioning state of the private endpoint connection proxy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the private endpoint connection proxy resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get;  }

    }
    /// Private endpoint connection proxy object property bag.
    internal partial interface IPrivateEndpointConnectionProxyPropertiesInternal

    {
        /// <summary>The provisioning state of the private endpoint connection proxy resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get; set; }

    }
}