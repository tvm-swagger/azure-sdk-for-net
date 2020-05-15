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
    /// <summary> The VpnGateways service client. </summary>
    public partial class VpnGatewaysClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VpnGatewaysRestClient RestClient { get; }
        /// <summary> Initializes a new instance of VpnGatewaysClient for mocking. </summary>
        protected VpnGatewaysClient()
        {
        }

        /// <summary> Initializes a new instance of VpnGatewaysClient. </summary>
        public VpnGatewaysClient(string subscriptionId, TokenCredential tokenCredential, NetworkManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }

        /// <summary> Initializes a new instance of VpnGatewaysClient. </summary>
        public VpnGatewaysClient(string subscriptionId, string host, TokenCredential tokenCredential, NetworkManagementClientOptions options = null)
        {
            options ??= new NetworkManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, host, options);
            RestClient = new VpnGatewaysRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId, host: host);
        }

        /// <summary> Retrieves the details of a virtual wan vpn gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnGateway>> GetAsync(string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, gatewayName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a virtual wan vpn gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnGateway> Get(string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, gatewayName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates virtual wan vpn gateway tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="vpnGatewayParameters"> Parameters supplied to update a virtual wan vpn gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnGateway>> UpdateTagsAsync(string resourceGroupName, string gatewayName, TagsObject vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, gatewayName, vpnGatewayParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates virtual wan vpn gateway tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="vpnGatewayParameters"> Parameters supplied to update a virtual wan vpn gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnGateway> UpdateTags(string resourceGroupName, string gatewayName, TagsObject vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, gatewayName, vpnGatewayParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the VpnGateways in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<VpnGateway> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<VpnGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.ListByResourceGroup");
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
            async Task<Page<VpnGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.ListByResourceGroup");
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

        /// <summary> Lists all the VpnGateways in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<VpnGateway> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<VpnGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.ListByResourceGroup");
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
            Page<VpnGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.ListByResourceGroup");
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

        /// <summary> Lists all the VpnGateways in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<VpnGateway> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.List");
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
            async Task<Page<VpnGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.List");
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

        /// <summary> Lists all the VpnGateways in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<VpnGateway> List(CancellationToken cancellationToken = default)
        {
            Page<VpnGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.List");
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
            Page<VpnGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.List");
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

        /// <summary> Creates a virtual wan vpn gateway if it doesn&apos;t exist else updates the existing gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="vpnGatewayParameters"> Parameters supplied to create or Update a virtual wan vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VpnGatewaysCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string gatewayName, VpnGateway vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, gatewayName, vpnGatewayParameters, cancellationToken).ConfigureAwait(false);
                return new VpnGatewaysCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, gatewayName, vpnGatewayParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a virtual wan vpn gateway if it doesn&apos;t exist else updates the existing gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="vpnGatewayParameters"> Parameters supplied to create or Update a virtual wan vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewaysCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string gatewayName, VpnGateway vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, gatewayName, vpnGatewayParameters, cancellationToken);
                return new VpnGatewaysCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, gatewayName, vpnGatewayParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a virtual wan vpn gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VpnGatewaysDeleteOperation> StartDeleteAsync(string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, gatewayName, cancellationToken).ConfigureAwait(false);
                return new VpnGatewaysDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, gatewayName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a virtual wan vpn gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewaysDeleteOperation StartDelete(string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, gatewayName, cancellationToken);
                return new VpnGatewaysDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, gatewayName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the primary of the vpn gateway in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VpnGatewaysResetOperation> StartResetAsync(string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.StartReset");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ResetAsync(resourceGroupName, gatewayName, cancellationToken).ConfigureAwait(false);
                return new VpnGatewaysResetOperation(_clientDiagnostics, _pipeline, RestClient.CreateResetRequest(resourceGroupName, gatewayName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the primary of the vpn gateway in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewaysResetOperation StartReset(string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewaysClient.StartReset");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Reset(resourceGroupName, gatewayName, cancellationToken);
                return new VpnGatewaysResetOperation(_clientDiagnostics, _pipeline, RestClient.CreateResetRequest(resourceGroupName, gatewayName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
