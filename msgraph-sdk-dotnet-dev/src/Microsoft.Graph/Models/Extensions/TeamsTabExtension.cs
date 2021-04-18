using Newtonsoft.Json;

namespace Microsoft.Graph
{
    public partial class TeamsTab 
    {
        /// <summary>
        /// Gets or sets an associated existing app with a teams tab.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsApp@odata.bind", Required = Newtonsoft.Json.Required.Default)]
        public string ODataBind { get; set; }

    }
}
