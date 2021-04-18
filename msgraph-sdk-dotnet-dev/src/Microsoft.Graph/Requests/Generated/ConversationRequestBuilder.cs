// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ConversationRequestBuilder.
    /// </summary>
    public partial class ConversationRequestBuilder : EntityRequestBuilder, IConversationRequestBuilder
    {

        /// <summary>
        /// Constructs a new ConversationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ConversationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IConversationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IConversationRequest Request(IEnumerable<Option> options)
        {
            return new ConversationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Threads.
        /// </summary>
        /// <returns>The <see cref="IConversationThreadsCollectionRequestBuilder"/>.</returns>
        public IConversationThreadsCollectionRequestBuilder Threads
        {
            get
            {
                return new ConversationThreadsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("threads"), this.Client);
            }
        }
    
    }
}
