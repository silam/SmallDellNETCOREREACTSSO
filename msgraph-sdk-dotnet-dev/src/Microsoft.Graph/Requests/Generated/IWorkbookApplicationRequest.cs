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
    /// The interface IWorkbookApplicationRequest.
    /// </summary>
    public partial interface IWorkbookApplicationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookApplication using POST.
        /// </summary>
        /// <param name="workbookApplicationToCreate">The WorkbookApplication to create.</param>
        /// <returns>The created WorkbookApplication.</returns>
        System.Threading.Tasks.Task<WorkbookApplication> CreateAsync(WorkbookApplication workbookApplicationToCreate);        /// <summary>
        /// Creates the specified WorkbookApplication using POST.
        /// </summary>
        /// <param name="workbookApplicationToCreate">The WorkbookApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookApplication.</returns>
        System.Threading.Tasks.Task<WorkbookApplication> CreateAsync(WorkbookApplication workbookApplicationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookApplication.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookApplication.
        /// </summary>
        /// <returns>The WorkbookApplication.</returns>
        System.Threading.Tasks.Task<WorkbookApplication> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookApplication.</returns>
        System.Threading.Tasks.Task<WorkbookApplication> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookApplication using PATCH.
        /// </summary>
        /// <param name="workbookApplicationToUpdate">The WorkbookApplication to update.</param>
        /// <returns>The updated WorkbookApplication.</returns>
        System.Threading.Tasks.Task<WorkbookApplication> UpdateAsync(WorkbookApplication workbookApplicationToUpdate);

        /// <summary>
        /// Updates the specified WorkbookApplication using PATCH.
        /// </summary>
        /// <param name="workbookApplicationToUpdate">The WorkbookApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookApplication.</returns>
        System.Threading.Tasks.Task<WorkbookApplication> UpdateAsync(WorkbookApplication workbookApplicationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookApplicationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookApplicationRequest Expand(Expression<Func<WorkbookApplication, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookApplicationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookApplicationRequest Select(Expression<Func<WorkbookApplication, object>> selectExpression);

    }
}
