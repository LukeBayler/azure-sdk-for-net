// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for CostsOperations.
    /// </summary>
    public static partial class CostsOperationsExtensions
    {
            /// <summary>
            /// Get cost.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the cost.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($expand=labCostDetails)'
            /// </param>
            public static LabCost Get(this ICostsOperations operations, string labName, string name, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((ICostsOperations)s).GetAsync(labName, name, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get cost.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the cost.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($expand=labCostDetails)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabCost> GetAsync(this ICostsOperations operations, string labName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(labName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing cost.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the cost.
            /// </param>
            /// <param name='labCost'>
            /// A cost item.
            /// </param>
            public static LabCost CreateOrUpdate(this ICostsOperations operations, string labName, string name, LabCost labCost)
            {
                return Task.Factory.StartNew(s => ((ICostsOperations)s).CreateOrUpdateAsync(labName, name, labCost), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing cost.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the cost.
            /// </param>
            /// <param name='labCost'>
            /// A cost item.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabCost> CreateOrUpdateAsync(this ICostsOperations operations, string labName, string name, LabCost labCost, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(labName, name, labCost, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
