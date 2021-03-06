// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SignUpSettingsOperations.
    /// </summary>
    public static partial class SignUpSettingsOperationsExtensions
    {
            /// <summary>
            /// Gets the entity state (Etag) version of the SignUpSettings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static SignUpSettingsGetEntityTagHeaders GetEntityTag(this ISignUpSettingsOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the SignUpSettings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignUpSettingsGetEntityTagHeaders> GetEntityTagAsync(this ISignUpSettingsOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Get Sign-Up settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static PortalSignupSettings Get(this ISignUpSettingsOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.GetAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Sign-Up settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalSignupSettings> GetAsync(this ISignUpSettingsOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update Sign-Up settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Update Sign-Up settings.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Update(this ISignUpSettingsOperations operations, string resourceGroupName, string serviceName, PortalSignupSettings parameters, string ifMatch)
            {
                operations.UpdateAsync(resourceGroupName, serviceName, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update Sign-Up settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Update Sign-Up settings.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this ISignUpSettingsOperations operations, string resourceGroupName, string serviceName, PortalSignupSettings parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or Update Sign-Up settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Create or update parameters.
            /// </param>
            public static PortalSignupSettings CreateOrUpdate(this ISignUpSettingsOperations operations, string resourceGroupName, string serviceName, PortalSignupSettings parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update Sign-Up settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='parameters'>
            /// Create or update parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalSignupSettings> CreateOrUpdateAsync(this ISignUpSettingsOperations operations, string resourceGroupName, string serviceName, PortalSignupSettings parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
