// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>
    /// See [disable AAD Pod Identity for a specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/)
    /// for more details.
    /// </summary>
    public partial class ManagedClusterPodIdentityException :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPodIdentityException,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPodIdentityExceptionInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the pod identity exception.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Namespace" /> property.</summary>
        private string _namespace;

        /// <summary>The namespace of the pod identity exception.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string Namespace { get => this._namespace; set => this._namespace = value; }

        /// <summary>Backing field for <see cref="PodLabel" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPodIdentityExceptionPodLabels _podLabel;

        /// <summary>The pod labels to match.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPodIdentityExceptionPodLabels PodLabel { get => (this._podLabel = this._podLabel ?? new Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterPodIdentityExceptionPodLabels()); set => this._podLabel = value; }

        /// <summary>Creates an new <see cref="ManagedClusterPodIdentityException" /> instance.</summary>
        public ManagedClusterPodIdentityException()
        {

        }
    }
    /// See [disable AAD Pod Identity for a specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/)
    /// for more details.
    public partial interface IManagedClusterPodIdentityException :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>The name of the pod identity exception.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the pod identity exception.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The namespace of the pod identity exception.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The namespace of the pod identity exception.",
        SerializedName = @"namespace",
        PossibleTypes = new [] { typeof(string) })]
        string Namespace { get; set; }
        /// <summary>The pod labels to match.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The pod labels to match.",
        SerializedName = @"podLabels",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPodIdentityExceptionPodLabels) })]
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPodIdentityExceptionPodLabels PodLabel { get; set; }

    }
    /// See [disable AAD Pod Identity for a specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/)
    /// for more details.
    internal partial interface IManagedClusterPodIdentityExceptionInternal

    {
        /// <summary>The name of the pod identity exception.</summary>
        string Name { get; set; }
        /// <summary>The namespace of the pod identity exception.</summary>
        string Namespace { get; set; }
        /// <summary>The pod labels to match.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPodIdentityExceptionPodLabels PodLabel { get; set; }

    }
}