// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Replication eligibility results response model.</summary>
    public partial class ReplicationEligibilityResults :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResults,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsInternal
    {

        /// <summary>The client request Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ClientRequestId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsPropertiesInternal)Property).ClientRequestId; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsErrorInfo[] Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsPropertiesInternal)Property).Error = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Gets Unique ARM identifier for this object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for ClientRequestId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsInternal.ClientRequestId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsPropertiesInternal)Property).ClientRequestId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsPropertiesInternal)Property).ClientRequestId = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ReplicationEligibilityResultsProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Gets the name of this object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsProperties _property;

        /// <summary>Gets properties model for replication eligibility results API.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ReplicationEligibilityResultsProperties()); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Gets the object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ReplicationEligibilityResults" /> instance.</summary>
        public ReplicationEligibilityResults()
        {

        }
    }
    /// Replication eligibility results response model.
    public partial interface IReplicationEligibilityResults :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The client request Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The client request Id.",
        SerializedName = @"clientRequestId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientRequestId { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error details.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsErrorInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsErrorInfo[] Error { get; set; }
        /// <summary>Gets Unique ARM identifier for this object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets Unique ARM identifier for this object.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Gets the name of this object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the name of this object.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Gets the object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the object type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Replication eligibility results response model.
    internal partial interface IReplicationEligibilityResultsInternal

    {
        /// <summary>The client request Id.</summary>
        string ClientRequestId { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsErrorInfo[] Error { get; set; }
        /// <summary>Gets Unique ARM identifier for this object.</summary>
        string Id { get; set; }
        /// <summary>Gets the name of this object.</summary>
        string Name { get; set; }
        /// <summary>Gets properties model for replication eligibility results API.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationEligibilityResultsProperties Property { get; set; }
        /// <summary>Gets the object type.</summary>
        string Type { get; set; }

    }
}