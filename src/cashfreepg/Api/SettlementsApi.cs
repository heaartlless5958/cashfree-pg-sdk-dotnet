/*
 * New Payment Gateway APIs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2022-01-01
 * Contact: nextgenapi@cashfree.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using cashfreepg.Client;
using cashfreepg.Model;
using cashfreepg.Interface;

namespace cashfreepg.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettlementsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Settlements
        /// </summary>
        /// <remarks>
        /// Use this API to view all the settlements of a particular order.
        /// </remarks>
        /// <exception cref="cashfreepg.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xClientId"></param>
        /// <param name="xClientSecret"></param>
        /// <param name="orderId"></param>
        /// <param name="xApiVersion"> (optional, default to &quot;2022-01-01&quot;)</param>
        /// <param name="xIdempotencyReplayed"> (optional, default to false)</param>
        /// <param name="xIdempotencyKey"> (optional)</param>
        /// <param name="xRequestId"> (optional)</param>
        /// <returns>CFSettlementsEntity</returns>
        CFSettlementsResponse Getsettlements(string xClientId, string xClientSecret, string orderId, string xApiVersion,bool? xIdempotencyReplayed = default(bool?), string? xIdempotencyKey = default(string?), string? xRequestId = default(string?));

        /// <summary>
        /// Get Settlements
        /// </summary>
        /// <remarks>
        /// Use this API to view all the settlements of a particular order.
        /// </remarks>
        /// <exception cref="cashfreepg.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xClientId"></param>
        /// <param name="xClientSecret"></param>
        /// <param name="orderId"></param>
        /// <param name="xApiVersion"> (optional, default to &quot;2022-01-01&quot;)</param>
        /// <param name="xIdempotencyReplayed"> (optional, default to false)</param>
        /// <param name="xIdempotencyKey"> (optional)</param>
        /// <param name="xRequestId"> (optional)</param>
        /// <returns>ApiResponse of CFSettlementsEntity</returns>
        ApiResponse<CFSettlementsEntity> GetsettlementsWithHttpInfo(string xClientId, string xClientSecret, string orderId, string xApiVersion, bool? xIdempotencyReplayed = default(bool?), string? xIdempotencyKey = default(string?), string? xRequestId = default(string?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettlementsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Settlements
        /// </summary>
        /// <remarks>
        /// Use this API to view all the settlements of a particular order.
        /// </remarks>
        /// <exception cref="cashfreepg.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xClientId"></param>
        /// <param name="xClientSecret"></param>
        /// <param name="orderId"></param>
        /// <param name="xApiVersion"> (optional, default to &quot;2022-01-01&quot;)</param>
        /// <param name="xIdempotencyReplayed"> (optional, default to false)</param>
        /// <param name="xIdempotencyKey"> (optional)</param>
        /// <param name="xRequestId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CFSettlementsEntity</returns>
        System.Threading.Tasks.Task<CFSettlementsEntity> GetsettlementsAsync(string xClientId, string xClientSecret, string orderId, string xApiVersion, bool? xIdempotencyReplayed = default(bool?), string? xIdempotencyKey = default(string?), string? xRequestId = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Settlements
        /// </summary>
        /// <remarks>
        /// Use this API to view all the settlements of a particular order.
        /// </remarks>
        /// <exception cref="cashfreepg.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xClientId"></param>
        /// <param name="xClientSecret"></param>
        /// <param name="orderId"></param>
        /// <param name="xApiVersion"> (optional, default to &quot;2022-01-01&quot;)</param>
        /// <param name="xIdempotencyReplayed"> (optional, default to false)</param>
        /// <param name="xIdempotencyKey"> (optional)</param>
        /// <param name="xRequestId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CFSettlementsEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<CFSettlementsEntity>> GetsettlementsWithHttpInfoAsync(string xClientId, string xClientSecret, string orderId, string xApiVersion,bool? xIdempotencyReplayed = default(bool?), string? xIdempotencyKey = default(string?), string? xRequestId = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettlementsApi : ISettlementsApiSync, ISettlementsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SettlementsApi : ISettlementsApi
    {
        private cashfreepg.Client.ExceptionFactory? _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettlementsApi() : this((string)"")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettlementsApi(string basePath)
        {
            this.Configuration = cashfreepg.Client.Configuration.MergeConfigurations(
                cashfreepg.Client.GlobalConfiguration.Instance,
                new cashfreepg.Client.Configuration { BasePath = basePath }
            );
            this.Client = new cashfreepg.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new cashfreepg.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = cashfreepg.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SettlementsApi(cashfreepg.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = cashfreepg.Client.Configuration.MergeConfigurations(
                cashfreepg.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new cashfreepg.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new cashfreepg.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = cashfreepg.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SettlementsApi(cashfreepg.Client.ISynchronousClient client, cashfreepg.Client.IAsynchronousClient asyncClient, cashfreepg.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = cashfreepg.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public cashfreepg.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public cashfreepg.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public cashfreepg.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public cashfreepg.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Settlements Use this API to view all the settlements of a particular order.
        /// </summary>
        /// <exception cref="cashfreepg.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xClientId"></param>
        /// <param name="xClientSecret"></param>
        /// <param name="orderId"></param>
        /// <param name="xApiVersion"> (optional, default to &quot;2022-01-01&quot;)</param>
        /// <param name="xIdempotencyReplayed"> (optional, default to false)</param>
        /// <param name="xIdempotencyKey"> (optional)</param>
        /// <param name="xRequestId"> (optional)</param>
        /// <returns>CFSettlementsEntity</returns>
        public CFSettlementsResponse Getsettlements(string xClientId, string xClientSecret, string orderId, string xApiVersion,bool? xIdempotencyReplayed = default(bool?), string? xIdempotencyKey = default(string?), string? xRequestId = default(string?))
        {
            cashfreepg.Client.ApiResponse<CFSettlementsEntity> localVarResponse = GetsettlementsWithHttpInfo(xClientId, xClientSecret, orderId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
            return new CFSettlementsResponse(localVarResponse.Data, localVarResponse.Headers);
        }

        /// <summary>
        /// Get Settlements Use this API to view all the settlements of a particular order.
        /// </summary>
        /// <exception cref="cashfreepg.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xClientId"></param>
        /// <param name="xClientSecret"></param>
        /// <param name="orderId"></param>
        /// <param name="xApiVersion"> (optional, default to &quot;2022-01-01&quot;)</param>
        /// <param name="xIdempotencyReplayed"> (optional, default to false)</param>
        /// <param name="xIdempotencyKey"> (optional)</param>
        /// <param name="xRequestId"> (optional)</param>
        /// <returns>ApiResponse of CFSettlementsEntity</returns>
        public cashfreepg.Client.ApiResponse<CFSettlementsEntity> GetsettlementsWithHttpInfo(string xClientId, string xClientSecret, string orderId, string xApiVersion,bool? xIdempotencyReplayed = default(bool?), string? xIdempotencyKey = default(string?), string? xRequestId = default(string?))
        {
            // verify the required parameter 'xClientId' is set
            if (xClientId == null)
            {
                throw new cashfreepg.Client.ApiException(400, "Missing required parameter 'xClientId' when calling SettlementsApi->Getsettlements");
            }

            // verify the required parameter 'xClientSecret' is set
            if (xClientSecret == null)
            {
                throw new cashfreepg.Client.ApiException(400, "Missing required parameter 'xClientSecret' when calling SettlementsApi->Getsettlements");
            }

            // verify the required parameter 'orderId' is set
            if (orderId == null)
            {
                throw new cashfreepg.Client.ApiException(400, "Missing required parameter 'orderId' when calling SettlementsApi->Getsettlements");
            }

            cashfreepg.Client.RequestOptions localVarRequestOptions = new cashfreepg.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = cashfreepg.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = cashfreepg.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("order_id", cashfreepg.Client.ClientUtils.ParameterToString(orderId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("x-client-id", cashfreepg.Client.ClientUtils.ParameterToString(xClientId)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("x-client-secret", cashfreepg.Client.ClientUtils.ParameterToString(xClientSecret)); // header parameter
            if (xApiVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-version", cashfreepg.Client.ClientUtils.ParameterToString(xApiVersion)); // header parameter
            }
            if (xIdempotencyReplayed != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-idempotency-replayed", cashfreepg.Client.ClientUtils.ParameterToString(xIdempotencyReplayed)); // header parameter
            }
            if (xIdempotencyKey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-idempotency-key", cashfreepg.Client.ClientUtils.ParameterToString(xIdempotencyKey)); // header parameter
            }
            if (xRequestId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-request-id", cashfreepg.Client.ClientUtils.ParameterToString(xRequestId)); // header parameter
            }
            localVarRequestOptions.HeaderParameters.Add("x-platform", Constants.x_platform); // header parameter


            // make the HTTP request
            var link = "/orders" + orderId + "/settlements";
            var localVarResponse = this.Client.Get<CFSettlementsEntity>(link, localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Getsettlements", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Settlements Use this API to view all the settlements of a particular order.
        /// </summary>
        /// <exception cref="cashfreepg.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xClientId"></param>
        /// <param name="xClientSecret"></param>
        /// <param name="orderId"></param>
        /// <param name="xApiVersion"> (optional, default to &quot;2022-01-01&quot;)</param>
        /// <param name="xIdempotencyReplayed"> (optional, default to false)</param>
        /// <param name="xIdempotencyKey"> (optional)</param>
        /// <param name="xRequestId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CFSettlementsEntity</returns>
        public async System.Threading.Tasks.Task<CFSettlementsEntity> GetsettlementsAsync(string xClientId, string xClientSecret, string orderId, string xApiVersion,bool? xIdempotencyReplayed = default(bool?), string? xIdempotencyKey = default(string?), string? xRequestId = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            cashfreepg.Client.ApiResponse<CFSettlementsEntity> localVarResponse = await GetsettlementsWithHttpInfoAsync(xClientId, xClientSecret, orderId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Settlements Use this API to view all the settlements of a particular order.
        /// </summary>
        /// <exception cref="cashfreepg.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xClientId"></param>
        /// <param name="xClientSecret"></param>
        /// <param name="orderId"></param>
        /// <param name="xApiVersion"> (optional, default to &quot;2022-01-01&quot;)</param>
        /// <param name="xIdempotencyReplayed"> (optional, default to false)</param>
        /// <param name="xIdempotencyKey"> (optional)</param>
        /// <param name="xRequestId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CFSettlementsEntity)</returns>
        public async System.Threading.Tasks.Task<cashfreepg.Client.ApiResponse<CFSettlementsEntity>> GetsettlementsWithHttpInfoAsync(string xClientId, string xClientSecret, string orderId, string xApiVersion,bool? xIdempotencyReplayed = default(bool?), string? xIdempotencyKey = default(string?), string? xRequestId = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'xClientId' is set
            if (xClientId == null)
            {
                throw new cashfreepg.Client.ApiException(400, "Missing required parameter 'xClientId' when calling SettlementsApi->Getsettlements");
            }

            // verify the required parameter 'xClientSecret' is set
            if (xClientSecret == null)
            {
                throw new cashfreepg.Client.ApiException(400, "Missing required parameter 'xClientSecret' when calling SettlementsApi->Getsettlements");
            }

            // verify the required parameter 'orderId' is set
            if (orderId == null)
            {
                throw new cashfreepg.Client.ApiException(400, "Missing required parameter 'orderId' when calling SettlementsApi->Getsettlements");
            }


            cashfreepg.Client.RequestOptions localVarRequestOptions = new cashfreepg.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = cashfreepg.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = cashfreepg.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("order_id", cashfreepg.Client.ClientUtils.ParameterToString(orderId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("x-client-id", cashfreepg.Client.ClientUtils.ParameterToString(xClientId)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("x-client-secret", cashfreepg.Client.ClientUtils.ParameterToString(xClientSecret)); // header parameter
            if (xApiVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-version", cashfreepg.Client.ClientUtils.ParameterToString(xApiVersion)); // header parameter
            }
            if (xIdempotencyReplayed != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-idempotency-replayed", cashfreepg.Client.ClientUtils.ParameterToString(xIdempotencyReplayed)); // header parameter
            }
            if (xIdempotencyKey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-idempotency-key", cashfreepg.Client.ClientUtils.ParameterToString(xIdempotencyKey)); // header parameter
            }
            if (xRequestId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-request-id", cashfreepg.Client.ClientUtils.ParameterToString(xRequestId)); // header parameter
            }
            localVarRequestOptions.HeaderParameters.Add("x-platform", Constants.x_platform); // header parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CFSettlementsEntity>("/orders/{order_id}/settlements", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Getsettlements", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
