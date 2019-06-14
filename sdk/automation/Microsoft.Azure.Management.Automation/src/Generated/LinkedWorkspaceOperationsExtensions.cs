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
    /// Extension methods for LinkedWorkspaceOperations.
    /// </summary>
    public static partial class LinkedWorkspaceOperationsExtensions
    {
            /// <summary>
            /// Retrieve the linked workspace for the account id.
            /// <see href="http://aka.ms/azureautomationsdk/linkedworkspaceoperations" />
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
            public static LinkedWorkspace Get(this ILinkedWorkspaceOperations operations, string resourceGroupName, string automationAccountName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the linked workspace for the account id.
            /// <see href="http://aka.ms/azureautomationsdk/linkedworkspaceoperations" />
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LinkedWorkspace> GetAsync(this ILinkedWorkspaceOperations operations, string resourceGroupName, string automationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}