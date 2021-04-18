// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IStreamRequest.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IApplicationLogoRequest.
    /// </summary>
    public partial interface IApplicationLogoRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <returns>The stream.</returns>
        System.Threading.Tasks.Task<Stream> GetAsync();

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The stream.</returns>
        System.Threading.Tasks.Task<Stream> GetAsync(CancellationToken cancellationToken, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead);


        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <typeparam name="T">The type returned by the PUT call.</typeparam>
        /// <param name="logo">The stream to PUT.</param>
        /// <returns>The object returned by the PUT call.</returns>
        System.Threading.Tasks.Task<T> PutAsync<T>(Stream logo) where T : Application;

        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <typeparam name="T">The type returned by the PUT call.</typeparam>
        /// <param name="logo">The stream to PUT.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The object returned by the PUT call.</returns>
        System.Threading.Tasks.Task<T> PutAsync<T>(Stream logo, CancellationToken cancellationToken, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead) where T : Application;
    
    }
}
