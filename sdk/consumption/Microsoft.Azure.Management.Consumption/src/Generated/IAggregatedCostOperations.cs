// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AggregatedCostOperations operations.
    /// </summary>
    public partial interface IAggregatedCostOperations
    {
        /// <summary>
        /// Provides the aggregate cost of a management group and all child
        /// management groups by current billing period.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
        /// </summary>
        /// <param name='managementGroupId'>
        /// Azure Management Group ID.
        /// </param>
        /// <param name='filter'>
        /// May be used to filter aggregated cost by properties/usageStart (Utc
        /// time), properties/usageEnd (Utc time). The filter supports 'eq',
        /// 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support
        /// 'ne', 'or', or 'not'. Tag filter is a key value pair string where
        /// key and value is separated by a colon (:).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManagementGroupAggregatedCostResult>> GetByManagementGroupWithHttpMessagesAsync(string managementGroupId, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Provides the aggregate cost of a management group and all child
        /// management groups by specified billing period
        /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
        /// </summary>
        /// <param name='managementGroupId'>
        /// Azure Management Group ID.
        /// </param>
        /// <param name='billingPeriodName'>
        /// Billing Period Name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManagementGroupAggregatedCostResult>> GetForBillingPeriodByManagementGroupWithHttpMessagesAsync(string managementGroupId, string billingPeriodName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}