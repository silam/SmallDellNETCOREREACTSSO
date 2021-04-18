// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IosMobileAppIdentifier.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosMobileAppIdentifier : MobileAppIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosMobileAppIdentifier"/> class.
        /// </summary>
        public IosMobileAppIdentifier()
        {
            this.ODataType = "microsoft.graph.iosMobileAppIdentifier";
        }

        /// <summary>
        /// Gets or sets bundleId.
        /// The identifier for an app, as specified in the app store.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bundleId", Required = Newtonsoft.Json.Required.Default)]
        public string BundleId { get; set; }
    
    }
}
