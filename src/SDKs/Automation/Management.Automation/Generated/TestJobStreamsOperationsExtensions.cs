// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TestJobStreamsOperations.
    /// </summary>
    public static partial class TestJobStreamsOperationsExtensions
    {
            /// <summary>
            /// Retrieve a test job stream of the test job identified by runbook name and
            /// stream id.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='jobStreamId'>
            /// The job stream id.
            /// </param>
            public static JobStream Get(this ITestJobStreamsOperations operations, string resourceGroupName, string automationAccountName, string runbookName, string jobStreamId)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, runbookName, jobStreamId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a test job stream of the test job identified by runbook name and
            /// stream id.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='jobStreamId'>
            /// The job stream id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobStream> GetAsync(this ITestJobStreamsOperations operations, string resourceGroupName, string automationAccountName, string runbookName, string jobStreamId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, jobStreamId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of test job streams identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<JobStream> ListByTestJob(this ITestJobStreamsOperations operations, string resourceGroupName, string automationAccountName, string runbookName, string filter = default(string))
            {
                return operations.ListByTestJobAsync(resourceGroupName, automationAccountName, runbookName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of test job streams identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobStream>> ListByTestJobAsync(this ITestJobStreamsOperations operations, string resourceGroupName, string automationAccountName, string runbookName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTestJobWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of test job streams identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobStream> ListByTestJobNext(this ITestJobStreamsOperations operations, string nextPageLink)
            {
                return operations.ListByTestJobNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of test job streams identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobStream>> ListByTestJobNextAsync(this ITestJobStreamsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTestJobNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
