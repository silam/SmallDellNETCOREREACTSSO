// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PlannerBucketsCollectionRequestBuilder.
    /// </summary>
    public partial class PlannerBucketsCollectionRequestBuilder : BaseRequestBuilder, IPlannerBucketsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PlannerBucketsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerBucketsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPlannerBucketsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPlannerBucketsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PlannerBucketsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPlannerBucketRequestBuilder"/> for the specified PlannerPlannerBucket.
        /// </summary>
        /// <param name="id">The ID for the PlannerPlannerBucket.</param>
        /// <returns>The <see cref="IPlannerBucketRequestBuilder"/>.</returns>
        public IPlannerBucketRequestBuilder this[string id]
        {
            get
            {
                return new PlannerBucketRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
