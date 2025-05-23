// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.4, generator: @autorest/powershell@4.0.737)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using System.Linq;

    /// <summary>
    /// One or more actions that will execute, modifying the request and/or
    /// response.
    /// </summary>
    public partial class RulesEngineAction
    {
        /// <summary>
        /// Initializes a new instance of the RulesEngineAction class.
        /// </summary>
        public RulesEngineAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RulesEngineAction class.
        /// </summary>

        /// <param name="requestHeaderActions">A list of header actions to apply from the request from AFD to the origin.
        /// </param>

        /// <param name="responseHeaderActions">A list of header actions to apply from the response from AFD to the client.
        /// </param>

        /// <param name="routeConfigurationOverride">Override the route configuration.
        /// </param>
        public RulesEngineAction(System.Collections.Generic.IList<HeaderAction> requestHeaderActions = default(System.Collections.Generic.IList<HeaderAction>), System.Collections.Generic.IList<HeaderAction> responseHeaderActions = default(System.Collections.Generic.IList<HeaderAction>), RouteConfiguration routeConfigurationOverride = default(RouteConfiguration))

        {
            this.RequestHeaderActions = requestHeaderActions;
            this.ResponseHeaderActions = responseHeaderActions;
            this.RouteConfigurationOverride = routeConfigurationOverride;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets a list of header actions to apply from the request from AFD to
        /// the origin.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "requestHeaderActions")]
        public System.Collections.Generic.IList<HeaderAction> RequestHeaderActions {get; set; }

        /// <summary>
        /// Gets or sets a list of header actions to apply from the response from AFD
        /// to the client.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "responseHeaderActions")]
        public System.Collections.Generic.IList<HeaderAction> ResponseHeaderActions {get; set; }

        /// <summary>
        /// Gets or sets override the route configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "routeConfigurationOverride")]
        public RouteConfiguration RouteConfigurationOverride {get; set; }
    }
}