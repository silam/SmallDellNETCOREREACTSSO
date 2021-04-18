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
    /// The type OrgContactRequestBuilder.
    /// </summary>
    public partial class OrgContactRequestBuilder : DirectoryObjectRequestBuilder, IOrgContactRequestBuilder
    {

        /// <summary>
        /// Constructs a new OrgContactRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OrgContactRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOrgContactRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOrgContactRequest Request(IEnumerable<Option> options)
        {
            return new OrgContactRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Manager.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder Manager
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("manager"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DirectReports.
        /// </summary>
        /// <returns>The <see cref="IOrgContactDirectReportsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IOrgContactDirectReportsCollectionWithReferencesRequestBuilder DirectReports
        {
            get
            {
                return new OrgContactDirectReportsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("directReports"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IOrgContactMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        public IOrgContactMemberOfCollectionWithReferencesRequestBuilder MemberOf
        {
            get
            {
                return new OrgContactMemberOfCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("memberOf"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TransitiveMemberOf.
        /// </summary>
        /// <returns>The <see cref="IOrgContactTransitiveMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        public IOrgContactTransitiveMemberOfCollectionWithReferencesRequestBuilder TransitiveMemberOf
        {
            get
            {
                return new OrgContactTransitiveMemberOfCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("transitiveMemberOf"), this.Client);
            }
        }
    
        
    
    }
}
