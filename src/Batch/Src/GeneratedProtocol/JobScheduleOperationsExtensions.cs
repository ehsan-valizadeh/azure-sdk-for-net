// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
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
    /// Extension methods for JobScheduleOperations.
    /// </summary>
    public static partial class JobScheduleOperationsExtensions
    {
            /// <summary>
            /// Checks the specified job schedule exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule which you want to check.
            /// </param>
            /// <param name='jobScheduleExistsOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static bool Exists(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleExistsOptions jobScheduleExistsOptions = default(JobScheduleExistsOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).ExistsAsync(jobScheduleId, jobScheduleExistsOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the specified job schedule exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule which you want to check.
            /// </param>
            /// <param name='jobScheduleExistsOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool> ExistsAsync(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleExistsOptions jobScheduleExistsOptions = default(JobScheduleExistsOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExistsWithHttpMessagesAsync(jobScheduleId, jobScheduleExistsOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a job schedule from the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to delete.
            /// </param>
            /// <param name='jobScheduleDeleteOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static JobScheduleDeleteHeaders Delete(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleDeleteOptions jobScheduleDeleteOptions = default(JobScheduleDeleteOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).DeleteAsync(jobScheduleId, jobScheduleDeleteOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a job schedule from the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to delete.
            /// </param>
            /// <param name='jobScheduleDeleteOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobScheduleDeleteHeaders> DeleteAsync(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleDeleteOptions jobScheduleDeleteOptions = default(JobScheduleDeleteOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(jobScheduleId, jobScheduleDeleteOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets information about the specified job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to get.
            /// </param>
            /// <param name='jobScheduleGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CloudJobSchedule Get(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleGetOptions jobScheduleGetOptions = default(JobScheduleGetOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).GetAsync(jobScheduleId, jobScheduleGetOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to get.
            /// </param>
            /// <param name='jobScheduleGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CloudJobSchedule> GetAsync(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleGetOptions jobScheduleGetOptions = default(JobScheduleGetOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(jobScheduleId, jobScheduleGetOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the properties of the specified job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to update.
            /// </param>
            /// <param name='jobSchedulePatchParameter'>
            /// The parameters for the request.
            /// </param>
            /// <param name='jobSchedulePatchOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static JobSchedulePatchHeaders Patch(this IJobScheduleOperations operations, string jobScheduleId, JobSchedulePatchParameter jobSchedulePatchParameter, JobSchedulePatchOptions jobSchedulePatchOptions = default(JobSchedulePatchOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).PatchAsync(jobScheduleId, jobSchedulePatchParameter, jobSchedulePatchOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of the specified job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to update.
            /// </param>
            /// <param name='jobSchedulePatchParameter'>
            /// The parameters for the request.
            /// </param>
            /// <param name='jobSchedulePatchOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobSchedulePatchHeaders> PatchAsync(this IJobScheduleOperations operations, string jobScheduleId, JobSchedulePatchParameter jobSchedulePatchParameter, JobSchedulePatchOptions jobSchedulePatchOptions = default(JobSchedulePatchOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(jobScheduleId, jobSchedulePatchParameter, jobSchedulePatchOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Updates the properties of the specified job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to update.
            /// </param>
            /// <param name='jobScheduleUpdateParameter'>
            /// The parameters for the request.
            /// </param>
            /// <param name='jobScheduleUpdateOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static JobScheduleUpdateHeaders Update(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleUpdateParameter jobScheduleUpdateParameter, JobScheduleUpdateOptions jobScheduleUpdateOptions = default(JobScheduleUpdateOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).UpdateAsync(jobScheduleId, jobScheduleUpdateParameter, jobScheduleUpdateOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of the specified job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to update.
            /// </param>
            /// <param name='jobScheduleUpdateParameter'>
            /// The parameters for the request.
            /// </param>
            /// <param name='jobScheduleUpdateOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobScheduleUpdateHeaders> UpdateAsync(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleUpdateParameter jobScheduleUpdateParameter, JobScheduleUpdateOptions jobScheduleUpdateOptions = default(JobScheduleUpdateOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(jobScheduleId, jobScheduleUpdateParameter, jobScheduleUpdateOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Disables a job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to disable.
            /// </param>
            /// <param name='jobScheduleDisableOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static JobScheduleDisableHeaders Disable(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleDisableOptions jobScheduleDisableOptions = default(JobScheduleDisableOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).DisableAsync(jobScheduleId, jobScheduleDisableOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disables a job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to disable.
            /// </param>
            /// <param name='jobScheduleDisableOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobScheduleDisableHeaders> DisableAsync(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleDisableOptions jobScheduleDisableOptions = default(JobScheduleDisableOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DisableWithHttpMessagesAsync(jobScheduleId, jobScheduleDisableOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Enables a job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to enable.
            /// </param>
            /// <param name='jobScheduleEnableOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static JobScheduleEnableHeaders Enable(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleEnableOptions jobScheduleEnableOptions = default(JobScheduleEnableOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).EnableAsync(jobScheduleId, jobScheduleEnableOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables a job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to enable.
            /// </param>
            /// <param name='jobScheduleEnableOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobScheduleEnableHeaders> EnableAsync(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleEnableOptions jobScheduleEnableOptions = default(JobScheduleEnableOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnableWithHttpMessagesAsync(jobScheduleId, jobScheduleEnableOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Terminates a job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to terminates.
            /// </param>
            /// <param name='jobScheduleTerminateOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static JobScheduleTerminateHeaders Terminate(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleTerminateOptions jobScheduleTerminateOptions = default(JobScheduleTerminateOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).TerminateAsync(jobScheduleId, jobScheduleTerminateOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Terminates a job schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The id of the job schedule to terminates.
            /// </param>
            /// <param name='jobScheduleTerminateOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobScheduleTerminateHeaders> TerminateAsync(this IJobScheduleOperations operations, string jobScheduleId, JobScheduleTerminateOptions jobScheduleTerminateOptions = default(JobScheduleTerminateOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TerminateWithHttpMessagesAsync(jobScheduleId, jobScheduleTerminateOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Adds a job schedule to the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cloudJobSchedule'>
            /// Specifies the job schedule to be added.
            /// </param>
            /// <param name='jobScheduleAddOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static JobScheduleAddHeaders Add(this IJobScheduleOperations operations, JobScheduleAddParameter cloudJobSchedule, JobScheduleAddOptions jobScheduleAddOptions = default(JobScheduleAddOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).AddAsync(cloudJobSchedule, jobScheduleAddOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a job schedule to the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cloudJobSchedule'>
            /// Specifies the job schedule to be added.
            /// </param>
            /// <param name='jobScheduleAddOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobScheduleAddHeaders> AddAsync(this IJobScheduleOperations operations, JobScheduleAddParameter cloudJobSchedule, JobScheduleAddOptions jobScheduleAddOptions = default(JobScheduleAddOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(cloudJobSchedule, jobScheduleAddOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the job schedules in the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleListOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<CloudJobSchedule> List(this IJobScheduleOperations operations, JobScheduleListOptions jobScheduleListOptions = default(JobScheduleListOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).ListAsync(jobScheduleListOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the job schedules in the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobScheduleListOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CloudJobSchedule>> ListAsync(this IJobScheduleOperations operations, JobScheduleListOptions jobScheduleListOptions = default(JobScheduleListOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(jobScheduleListOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the job schedules in the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='jobScheduleListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<CloudJobSchedule> ListNext(this IJobScheduleOperations operations, string nextPageLink, JobScheduleListNextOptions jobScheduleListNextOptions = default(JobScheduleListNextOptions))
            {
                return Task.Factory.StartNew(s => ((IJobScheduleOperations)s).ListNextAsync(nextPageLink, jobScheduleListNextOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the job schedules in the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='jobScheduleListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CloudJobSchedule>> ListNextAsync(this IJobScheduleOperations operations, string nextPageLink, JobScheduleListNextOptions jobScheduleListNextOptions = default(JobScheduleListNextOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, jobScheduleListNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
