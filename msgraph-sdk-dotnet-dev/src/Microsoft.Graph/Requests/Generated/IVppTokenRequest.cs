// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IVppTokenRequest.
    /// </summary>
    public partial interface IVppTokenRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified VppToken using POST.
        /// </summary>
        /// <param name="vppTokenToCreate">The VppToken to create.</param>
        /// <returns>The created VppToken.</returns>
        System.Threading.Tasks.Task<VppToken> CreateAsync(VppToken vppTokenToCreate);        /// <summary>
        /// Creates the specified VppToken using POST.
        /// </summary>
        /// <param name="vppTokenToCreate">The VppToken to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created VppToken.</returns>
        System.Threading.Tasks.Task<VppToken> CreateAsync(VppToken vppTokenToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified VppToken.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified VppToken.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified VppToken.
        /// </summary>
        /// <returns>The VppToken.</returns>
        System.Threading.Tasks.Task<VppToken> GetAsync();

        /// <summary>
        /// Gets the specified VppToken.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The VppToken.</returns>
        System.Threading.Tasks.Task<VppToken> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified VppToken using PATCH.
        /// </summary>
        /// <param name="vppTokenToUpdate">The VppToken to update.</param>
        /// <returns>The updated VppToken.</returns>
        System.Threading.Tasks.Task<VppToken> UpdateAsync(VppToken vppTokenToUpdate);

        /// <summary>
        /// Updates the specified VppToken using PATCH.
        /// </summary>
        /// <param name="vppTokenToUpdate">The VppToken to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated VppToken.</returns>
        System.Threading.Tasks.Task<VppToken> UpdateAsync(VppToken vppTokenToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IVppTokenRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IVppTokenRequest Expand(Expression<Func<VppToken, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IVppTokenRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IVppTokenRequest Select(Expression<Func<VppToken, object>> selectExpression);

    }
}
