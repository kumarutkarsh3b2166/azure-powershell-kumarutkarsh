// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Extensions;

    /// <summary>Role assignment entity</summary>
    public partial class RoleAssignmentEntity :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntity,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Role assignment entity id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 0)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.RoleAssignmentEntityProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Role assignment entity name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 1)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Principal Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 2)]
        public string PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityPropertiesInternal)Property).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityPropertiesInternal)Property).PrincipalId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityProperties _property;

        /// <summary>Role assignment entity properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.RoleAssignmentEntityProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Role definition id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 3)]
        public string RoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityPropertiesInternal)Property).RoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityPropertiesInternal)Property).RoleDefinitionId = value ?? null; }

        /// <summary>Scope of the role assignment entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.FormatTable(Index = 4)]
        public string Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityPropertiesInternal)Property).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityPropertiesInternal)Property).Scope = value ?? null; }

        /// <summary>Creates an new <see cref="RoleAssignmentEntity" /> instance.</summary>
        public RoleAssignmentEntity()
        {

        }
    }
    /// Role assignment entity
    public partial interface IRoleAssignmentEntity :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IJsonSerializable
    {
        /// <summary>Role assignment entity id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Role assignment entity id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Role assignment entity name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Role assignment entity name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Principal Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Principal Id",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>Role definition id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Role definition id",
        SerializedName = @"roleDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionId { get; set; }
        /// <summary>Scope of the role assignment entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Scope of the role assignment entity",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }

    }
    /// Role assignment entity
    internal partial interface IRoleAssignmentEntityInternal

    {
        /// <summary>Role assignment entity id</summary>
        string Id { get; set; }
        /// <summary>Role assignment entity name</summary>
        string Name { get; set; }
        /// <summary>Principal Id</summary>
        string PrincipalId { get; set; }
        /// <summary>Role assignment entity properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IRoleAssignmentEntityProperties Property { get; set; }
        /// <summary>Role definition id</summary>
        string RoleDefinitionId { get; set; }
        /// <summary>Scope of the role assignment entity</summary>
        string Scope { get; set; }

    }
}