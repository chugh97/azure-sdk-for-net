// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AdaptiveApplicationControlsOperations.
    /// </summary>
    public static partial class AdaptiveApplicationControlsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of application control VM/server groups for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='includePathRecommendations'>
            /// Include the policy rules
            /// </param>
            /// <param name='summary'>
            /// Return output in a summarized form
            /// </param>
            public static AppWhitelistingGroups List(this IAdaptiveApplicationControlsOperations operations, bool? includePathRecommendations = default(bool?), bool? summary = default(bool?))
            {
                return operations.ListAsync(includePathRecommendations, summary).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of application control VM/server groups for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='includePathRecommendations'>
            /// Include the policy rules
            /// </param>
            /// <param name='summary'>
            /// Return output in a summarized form
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppWhitelistingGroups> ListAsync(this IAdaptiveApplicationControlsOperations operations, bool? includePathRecommendations = default(bool?), bool? summary = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(includePathRecommendations, summary, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an application control VM/server group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of an application control VM/server group
            /// </param>
            public static AppWhitelistingGroup Get(this IAdaptiveApplicationControlsOperations operations, string groupName)
            {
                return operations.GetAsync(groupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an application control VM/server group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of an application control VM/server group
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppWhitelistingGroup> GetAsync(this IAdaptiveApplicationControlsOperations operations, string groupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(groupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an application control VM/server group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of an application control VM/server group
            /// </param>
            /// <param name='body'>
            /// The updated VM/server group data
            /// </param>
            public static AppWhitelistingGroup Put(this IAdaptiveApplicationControlsOperations operations, string groupName, AppWhitelistingPutGroupData body)
            {
                return operations.PutAsync(groupName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an application control VM/server group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of an application control VM/server group
            /// </param>
            /// <param name='body'>
            /// The updated VM/server group data
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppWhitelistingGroup> PutAsync(this IAdaptiveApplicationControlsOperations operations, string groupName, AppWhitelistingPutGroupData body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutWithHttpMessagesAsync(groupName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}