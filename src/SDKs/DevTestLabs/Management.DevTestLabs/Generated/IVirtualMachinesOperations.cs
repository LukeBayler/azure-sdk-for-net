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
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// VirtualMachinesOperations operations.
    /// </summary>
    public partial interface IVirtualMachinesOperations
    {
        /// <summary>
        /// List virtual machines in a given lab.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<LabVirtualMachine>>> ListWithHttpMessagesAsync(string labName, ODataQuery<LabVirtualMachine> odataQuery = default(ODataQuery<LabVirtualMachine>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get virtual machine.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='expand'>
        /// Specify the $expand query. Example:
        /// 'properties($expand=artifacts,computeVm,networkInterface,applicableSchedule)'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<LabVirtualMachine>> GetWithHttpMessagesAsync(string labName, string name, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or replace an existing Virtual machine. This operation can
        /// take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='labVirtualMachine'>
        /// A virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<LabVirtualMachine>> CreateOrUpdateWithHttpMessagesAsync(string labName, string name, LabVirtualMachine labVirtualMachine, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or replace an existing Virtual machine. This operation can
        /// take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='labVirtualMachine'>
        /// A virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<LabVirtualMachine>> BeginCreateOrUpdateWithHttpMessagesAsync(string labName, string name, LabVirtualMachine labVirtualMachine, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete virtual machine. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete virtual machine. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modify properties of virtual machines.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='labVirtualMachine'>
        /// A virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<LabVirtualMachine>> UpdateWithHttpMessagesAsync(string labName, string name, LabVirtualMachineFragment labVirtualMachine, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Attach a new or existing data disk to virtual machine. This
        /// operation can take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='dataDiskProperties'>
        /// Request body for adding a new or existing data disk to a virtual
        /// machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> AddDataDiskWithHttpMessagesAsync(string labName, string name, DataDiskProperties dataDiskProperties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Attach a new or existing data disk to virtual machine. This
        /// operation can take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='dataDiskProperties'>
        /// Request body for adding a new or existing data disk to a virtual
        /// machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginAddDataDiskWithHttpMessagesAsync(string labName, string name, DataDiskProperties dataDiskProperties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Apply artifacts to virtual machine. This operation can take a
        /// while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='applyArtifactsRequest'>
        /// Request body for applying artifacts to a virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> ApplyArtifactsWithHttpMessagesAsync(string labName, string name, ApplyArtifactsRequest applyArtifactsRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Apply artifacts to virtual machine. This operation can take a
        /// while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='applyArtifactsRequest'>
        /// Request body for applying artifacts to a virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginApplyArtifactsWithHttpMessagesAsync(string labName, string name, ApplyArtifactsRequest applyArtifactsRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Take ownership of an existing virtual machine This operation can
        /// take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> ClaimWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Take ownership of an existing virtual machine This operation can
        /// take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginClaimWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Detach the specified disk from the virtual machine. This operation
        /// can take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='detachDataDiskProperties'>
        /// Request body for detaching data disk from a virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DetachDataDiskWithHttpMessagesAsync(string labName, string name, DetachDataDiskProperties detachDataDiskProperties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Detach the specified disk from the virtual machine. This operation
        /// can take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='detachDataDiskProperties'>
        /// Request body for detaching data disk from a virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDetachDataDiskWithHttpMessagesAsync(string labName, string name, DetachDataDiskProperties detachDataDiskProperties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all applicable schedules
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ApplicableSchedule>> ListApplicableSchedulesWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start a virtual machine. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start a virtual machine. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop a virtual machine This operation can take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> StopWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop a virtual machine This operation can take a while to complete.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginStopWithHttpMessagesAsync(string labName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List virtual machines in a given lab.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<LabVirtualMachine>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
