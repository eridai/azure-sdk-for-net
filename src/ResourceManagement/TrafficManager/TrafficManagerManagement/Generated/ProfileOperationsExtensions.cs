// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.TrafficManager;
using Microsoft.Azure.Management.TrafficManager.Models;

namespace Microsoft.Azure.Management.TrafficManager
{
    /// <summary>
    /// Client for creating, updating, listing and deleting Azure Traffic
    /// Manager profiles  (see
    /// http://azure.microsoft.com/en-gb/documentation/articles/traffic-manager-overview/
    /// for more information)
    /// </summary>
    public static partial class ProfileOperationsExtensions
    {
        /// <summary>
        /// Create or update a Traffic Manager endpoint.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. The Traffic Manager name parameters supplied to the
        /// CheckTrafficManagerNameAvailability operation.
        /// </param>
        /// <returns>
        /// The response to a 'CheckTrafficManagerNameAvailability' operation.
        /// </returns>
        public static CheckTrafficManagerRelativeDnsNameAvailabilityResponse CheckTrafficManagerRelativeDnsNameAvailability(this IProfileOperations operations, CheckTrafficManagerRelativeDnsNameAvailabilityParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).CheckTrafficManagerRelativeDnsNameAvailabilityAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a Traffic Manager endpoint.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. The Traffic Manager name parameters supplied to the
        /// CheckTrafficManagerNameAvailability operation.
        /// </param>
        /// <returns>
        /// The response to a 'CheckTrafficManagerNameAvailability' operation.
        /// </returns>
        public static Task<CheckTrafficManagerRelativeDnsNameAvailabilityResponse> CheckTrafficManagerRelativeDnsNameAvailabilityAsync(this IProfileOperations operations, CheckTrafficManagerRelativeDnsNameAvailabilityParameters parameters)
        {
            return operations.CheckTrafficManagerRelativeDnsNameAvailabilityAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update a Traffic Manager profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profile.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the Traffic Manager profile.
        /// </param>
        /// <param name='parameters'>
        /// Required. The Traffic Manager profile parameters supplied to the
        /// CreateOrUpdate operation.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'CreateOrUpdate'
        /// operation.
        /// </returns>
        public static ProfileCreateOrUpdateResponse CreateOrUpdate(this IProfileOperations operations, string resourceGroupName, string profileName, ProfileCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).CreateOrUpdateAsync(resourceGroupName, profileName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a Traffic Manager profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profile.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the Traffic Manager profile.
        /// </param>
        /// <param name='parameters'>
        /// Required. The Traffic Manager profile parameters supplied to the
        /// CreateOrUpdate operation.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'CreateOrUpdate'
        /// operation.
        /// </returns>
        public static Task<ProfileCreateOrUpdateResponse> CreateOrUpdateAsync(this IProfileOperations operations, string resourceGroupName, string profileName, ProfileCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, profileName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a Traffic Manager profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profile to be deleted.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the Traffic Manager profile to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IProfileOperations operations, string resourceGroupName, string profileName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).DeleteAsync(resourceGroupName, profileName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a Traffic Manager profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profile to be deleted.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the Traffic Manager profile to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IProfileOperations operations, string resourceGroupName, string profileName)
        {
            return operations.DeleteAsync(resourceGroupName, profileName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a Traffic Manager profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profile.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the Traffic Manager profile.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'Create' operation.
        /// </returns>
        public static ProfileGetResponse Get(this IProfileOperations operations, string resourceGroupName, string profileName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).GetAsync(resourceGroupName, profileName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a Traffic Manager profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profile.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the Traffic Manager profile.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'Create' operation.
        /// </returns>
        public static Task<ProfileGetResponse> GetAsync(this IProfileOperations operations, string resourceGroupName, string profileName)
        {
            return operations.GetAsync(resourceGroupName, profileName, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists all Traffic Manager profiles within a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'ListAll' or
        /// 'ListAllInResourceGroup' operation.
        /// </returns>
        public static ProfileListResponse ListAll(this IProfileOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).ListAllAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists all Traffic Manager profiles within a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'ListAll' or
        /// 'ListAllInResourceGroup' operation.
        /// </returns>
        public static Task<ProfileListResponse> ListAllAsync(this IProfileOperations operations)
        {
            return operations.ListAllAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Lists all Traffic Manager profiles within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profiles to be listed.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'ListAll' or
        /// 'ListAllInResourceGroup' operation.
        /// </returns>
        public static ProfileListResponse ListAllInResourceGroup(this IProfileOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).ListAllInResourceGroupAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists all Traffic Manager profiles within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profiles to be listed.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'ListAll' or
        /// 'ListAllInResourceGroup' operation.
        /// </returns>
        public static Task<ProfileListResponse> ListAllInResourceGroupAsync(this IProfileOperations operations, string resourceGroupName)
        {
            return operations.ListAllInResourceGroupAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Update a Traffic Manager profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profile.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the Traffic Manager profile.
        /// </param>
        /// <param name='parameters'>
        /// Required. The Traffic Manager profile parameters supplied to the
        /// Update operation.
        /// </param>
        /// <returns>
        /// Parameters supplied to update a Traffic Manager profile.
        /// </returns>
        public static ProfileUpdateResponse Update(this IProfileOperations operations, string resourceGroupName, string profileName, ProfileUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProfileOperations)s).UpdateAsync(resourceGroupName, profileName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update a Traffic Manager profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IProfileOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group containing the Traffic
        /// Manager profile.
        /// </param>
        /// <param name='profileName'>
        /// Required. The name of the Traffic Manager profile.
        /// </param>
        /// <param name='parameters'>
        /// Required. The Traffic Manager profile parameters supplied to the
        /// Update operation.
        /// </param>
        /// <returns>
        /// Parameters supplied to update a Traffic Manager profile.
        /// </returns>
        public static Task<ProfileUpdateResponse> UpdateAsync(this IProfileOperations operations, string resourceGroupName, string profileName, ProfileUpdateParameters parameters)
        {
            return operations.UpdateAsync(resourceGroupName, profileName, parameters, CancellationToken.None);
        }
    }
}
