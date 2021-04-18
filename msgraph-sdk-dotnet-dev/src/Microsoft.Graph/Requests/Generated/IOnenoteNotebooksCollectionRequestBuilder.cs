// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IOnenoteNotebooksCollectionRequestBuilder.
    /// </summary>
    public partial interface IOnenoteNotebooksCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IOnenoteNotebooksCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IOnenoteNotebooksCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="INotebookRequestBuilder"/> for the specified Notebook.
        /// </summary>
        /// <param name="id">The ID for the Notebook.</param>
        /// <returns>The <see cref="INotebookRequestBuilder"/>.</returns>
        INotebookRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for NotebookGetNotebookFromWebUrl.
        /// </summary>
        /// <returns>The <see cref="INotebookGetNotebookFromWebUrlRequestBuilder"/>.</returns>
        INotebookGetNotebookFromWebUrlRequestBuilder GetNotebookFromWebUrl(
            string webUrl = null);

        /// <summary>
        /// Gets the request builder for NotebookGetRecentNotebooks.
        /// </summary>
        /// <returns>The <see cref="INotebookGetRecentNotebooksRequestBuilder"/>.</returns>
        INotebookGetRecentNotebooksRequestBuilder GetRecentNotebooks(
            bool includePersonalNotebooks);
    }
}
