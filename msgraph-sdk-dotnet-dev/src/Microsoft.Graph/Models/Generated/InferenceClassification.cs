// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Inference Classification.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class InferenceClassification : Entity
    {
    
		///<summary>
		/// The InferenceClassification constructor
		///</summary>
        public InferenceClassification()
        {
            this.ODataType = "microsoft.graph.inferenceClassification";
        }
	
        /// <summary>
        /// Gets or sets overrides.
        /// A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "overrides", Required = Newtonsoft.Json.Required.Default)]
        public IInferenceClassificationOverridesCollectionPage Overrides { get; set; }
    
    }
}

