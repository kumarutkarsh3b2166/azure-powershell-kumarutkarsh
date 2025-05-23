// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// The properties of a elastic pool operation.
    /// </summary>
    public partial class ElasticPoolOperationProperties
    {
        /// <summary>
        /// Initializes a new instance of the ElasticPoolOperationProperties class.
        /// </summary>
        public ElasticPoolOperationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ElasticPoolOperationProperties class.
        /// </summary>

        /// <param name="elasticPoolName">The name of the elastic pool the operation is being performed on.
        /// </param>

        /// <param name="operation">The name of operation.
        /// </param>

        /// <param name="operationFriendlyName">The friendly name of operation.
        /// </param>

        /// <param name="percentComplete">The percentage of the operation completed.
        /// </param>

        /// <param name="serverName">The name of the server.
        /// </param>

        /// <param name="startTime">The operation start time.
        /// </param>

        /// <param name="state">The operation state.
        /// </param>

        /// <param name="errorCode">The operation error code.
        /// </param>

        /// <param name="errorDescription">The operation error description.
        /// </param>

        /// <param name="errorSeverity">The operation error severity.
        /// </param>

        /// <param name="isUserError">Whether or not the error is a user error.
        /// </param>

        /// <param name="estimatedCompletionTime">The estimated completion time of the operation.
        /// </param>

        /// <param name="description">The operation description.
        /// </param>

        /// <param name="isCancellable">Whether the operation can be cancelled.
        /// </param>
        public ElasticPoolOperationProperties(string elasticPoolName = default(string), string operation = default(string), string operationFriendlyName = default(string), int? percentComplete = default(int?), string serverName = default(string), System.DateTime? startTime = default(System.DateTime?), string state = default(string), int? errorCode = default(int?), string errorDescription = default(string), int? errorSeverity = default(int?), bool? isUserError = default(bool?), System.DateTime? estimatedCompletionTime = default(System.DateTime?), string description = default(string), bool? isCancellable = default(bool?))

        {
            this.ElasticPoolName = elasticPoolName;
            this.Operation = operation;
            this.OperationFriendlyName = operationFriendlyName;
            this.PercentComplete = percentComplete;
            this.ServerName = serverName;
            this.StartTime = startTime;
            this.State = state;
            this.ErrorCode = errorCode;
            this.ErrorDescription = errorDescription;
            this.ErrorSeverity = errorSeverity;
            this.IsUserError = isUserError;
            this.EstimatedCompletionTime = estimatedCompletionTime;
            this.Description = description;
            this.IsCancellable = isCancellable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the name of the elastic pool the operation is being performed on.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "elasticPoolName")]
        public string ElasticPoolName {get; private set; }

        /// <summary>
        /// Gets the name of operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operation")]
        public string Operation {get; private set; }

        /// <summary>
        /// Gets the friendly name of operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operationFriendlyName")]
        public string OperationFriendlyName {get; private set; }

        /// <summary>
        /// Gets the percentage of the operation completed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "percentComplete")]
        public int? PercentComplete {get; private set; }

        /// <summary>
        /// Gets the name of the server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serverName")]
        public string ServerName {get; private set; }

        /// <summary>
        /// Gets the operation start time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime {get; private set; }

        /// <summary>
        /// Gets the operation state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public string State {get; private set; }

        /// <summary>
        /// Gets the operation error code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode {get; private set; }

        /// <summary>
        /// Gets the operation error description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorDescription")]
        public string ErrorDescription {get; private set; }

        /// <summary>
        /// Gets the operation error severity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorSeverity")]
        public int? ErrorSeverity {get; private set; }

        /// <summary>
        /// Gets whether or not the error is a user error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isUserError")]
        public bool? IsUserError {get; private set; }

        /// <summary>
        /// Gets the estimated completion time of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "estimatedCompletionTime")]
        public System.DateTime? EstimatedCompletionTime {get; private set; }

        /// <summary>
        /// Gets the operation description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; private set; }

        /// <summary>
        /// Gets whether the operation can be cancelled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isCancellable")]
        public bool? IsCancellable {get; private set; }
    }
}