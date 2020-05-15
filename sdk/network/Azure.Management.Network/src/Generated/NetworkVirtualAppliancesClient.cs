// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The NetworkVirtualAppliances service client. </summary>
    public partial class NetworkVirtualAppliancesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NetworkVirtualAppliancesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of NetworkVirtualAppliancesClient for mocking. </summary>
        protected NetworkVirtualAppliancesClient()
        {
        }

        /// <summary> Initializes a new instance of NetworkVirtualAppliancesClient. </summary>
        public NetworkVirtualAppliancesClient(string subscriptionId, TokenCredential tokenCredential, NetworkManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }

        /// <summary> Initializes a new instance of NetworkVirtualAppliancesClient. </summary>
        public NetworkVirtualAppliancesClient(string subscriptionId, string host, TokenCredential tokenCredential, NetworkManagementClientOptions options = null)
        {
            options ??= new NetworkManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, host, options);
            RestClient = new NetworkVirtualAppliancesRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId, host: host);
        }

        /// <summary> Gets the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkVirtualAppliance>> GetAsync(string resourceGroupName, string networkVirtualApplianceName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, networkVirtualApplianceName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkVirtualAppliance> Get(string resourceGroupName, string networkVirtualApplianceName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, networkVirtualApplianceName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The resource group name of Network Virtual Appliance. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance being updated. </param>
        /// <param name="parameters"> Parameters supplied to Update Network Virtual Appliance Tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkVirtualAppliance>> UpdateTagsAsync(string resourceGroupName, string networkVirtualApplianceName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, networkVirtualApplianceName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The resource group name of Network Virtual Appliance. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance being updated. </param>
        /// <param name="parameters"> Parameters supplied to Update Network Virtual Appliance Tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkVirtualAppliance> UpdateTags(string resourceGroupName, string networkVirtualApplianceName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, networkVirtualApplianceName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Network Virtual Appliances in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkVirtualAppliance> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<NetworkVirtualAppliance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkVirtualAppliance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Network Virtual Appliances in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkVirtualAppliance> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<NetworkVirtualAppliance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkVirtualAppliance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all Network Virtual Appliances in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkVirtualAppliance> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkVirtualAppliance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkVirtualAppliance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all Network Virtual Appliances in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkVirtualAppliance> List(CancellationToken cancellationToken = default)
        {
            Page<NetworkVirtualAppliance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkVirtualAppliance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<NetworkVirtualAppliancesDeleteOperation> StartDeleteAsync(string resourceGroupName, string networkVirtualApplianceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, networkVirtualApplianceName, cancellationToken).ConfigureAwait(false);
                return new NetworkVirtualAppliancesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkVirtualApplianceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NetworkVirtualAppliancesDeleteOperation StartDelete(string resourceGroupName, string networkVirtualApplianceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, networkVirtualApplianceName, cancellationToken);
                return new NetworkVirtualAppliancesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkVirtualApplianceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<NetworkVirtualAppliancesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, networkVirtualApplianceName, parameters, cancellationToken).ConfigureAwait(false);
                return new NetworkVirtualAppliancesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkVirtualApplianceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NetworkVirtualAppliancesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, networkVirtualApplianceName, parameters, cancellationToken);
                return new NetworkVirtualAppliancesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkVirtualApplianceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
