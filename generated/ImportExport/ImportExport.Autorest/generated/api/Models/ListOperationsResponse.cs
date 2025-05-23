// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Extensions;

    /// <summary>List operations response</summary>
    public partial class ListOperationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.IListOperationsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.IListOperationsResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.IOperation> _value;

        /// <summary>operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.IOperation> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ListOperationsResponse" /> instance.</summary>
        public ListOperationsResponse()
        {

        }
    }
    /// List operations response
    public partial interface IListOperationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.IJsonSerializable
    {
        /// <summary>operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"operations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.IOperation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.IOperation> Value { get; set; }

    }
    /// List operations response
    internal partial interface IListOperationsResponseInternal

    {
        /// <summary>operations</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.IOperation> Value { get; set; }

    }
}