/* 
 * Easy Blockchain API
 *
 * The Easy Blockchain API is an easy to use API to store related entries within chains. Currently it stores entries using a Factom, Ethereum or Multichain blockchain.   For full API documentation please visit: https://docs.sphereon.com/api/easy-blockchain/0.10/html   Interactive testing: A web based test console is available in the Sphereon API store at: https://store.sphereon.com
 *
 * OpenAPI spec version: 0.10
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Sphereon.SDK.Blockchain.Easy.Client;
using Sphereon.SDK.Blockchain.Easy.Model;

namespace Sphereon.SDK.Blockchain.Easy.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContextApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create context
        /// </summary>
        /// <remarks>
        /// Create a new context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Context</returns>
        Context CreateContext (Context context);

        /// <summary>
        /// Create context
        /// </summary>
        /// <remarks>
        /// Create a new context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>ApiResponse of Context</returns>
        ApiResponse<Context> CreateContextWithHttpInfo (Context context);
        /// <summary>
        /// Delete context
        /// </summary>
        /// <remarks>
        /// Delete an existing context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Context</returns>
        Context DeleteContext (string context);

        /// <summary>
        /// Delete context
        /// </summary>
        /// <remarks>
        /// Delete an existing context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>ApiResponse of Context</returns>
        ApiResponse<Context> DeleteContextWithHttpInfo (string context);
        /// <summary>
        /// Get context
        /// </summary>
        /// <remarks>
        /// Get an existing context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Context</returns>
        Context GetContext (string context);

        /// <summary>
        /// Get context
        /// </summary>
        /// <remarks>
        /// Get an existing context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>ApiResponse of Context</returns>
        ApiResponse<Context> GetContextWithHttpInfo (string context);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create context
        /// </summary>
        /// <remarks>
        /// Create a new context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of Context</returns>
        System.Threading.Tasks.Task<Context> CreateContextAsync (Context context);

        /// <summary>
        /// Create context
        /// </summary>
        /// <remarks>
        /// Create a new context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of ApiResponse (Context)</returns>
        System.Threading.Tasks.Task<ApiResponse<Context>> CreateContextAsyncWithHttpInfo (Context context);
        /// <summary>
        /// Delete context
        /// </summary>
        /// <remarks>
        /// Delete an existing context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of Context</returns>
        System.Threading.Tasks.Task<Context> DeleteContextAsync (string context);

        /// <summary>
        /// Delete context
        /// </summary>
        /// <remarks>
        /// Delete an existing context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of ApiResponse (Context)</returns>
        System.Threading.Tasks.Task<ApiResponse<Context>> DeleteContextAsyncWithHttpInfo (string context);
        /// <summary>
        /// Get context
        /// </summary>
        /// <remarks>
        /// Get an existing context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of Context</returns>
        System.Threading.Tasks.Task<Context> GetContextAsync (string context);

        /// <summary>
        /// Get context
        /// </summary>
        /// <remarks>
        /// Get an existing context
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of ApiResponse (Context)</returns>
        System.Threading.Tasks.Task<ApiResponse<Context>> GetContextAsyncWithHttpInfo (string context);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ContextApi : IContextApi
    {
        private Sphereon.SDK.Blockchain.Easy.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContextApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Sphereon.SDK.Blockchain.Easy.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContextApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Sphereon.SDK.Blockchain.Easy.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Sphereon.SDK.Blockchain.Easy.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create context Create a new context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Context</returns>
        public Context CreateContext (Context context)
        {
             ApiResponse<Context> localVarResponse = CreateContextWithHttpInfo(context);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create context Create a new context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>ApiResponse of Context</returns>
        public ApiResponse< Context > CreateContextWithHttpInfo (Context context)
        {
            // verify the required parameter 'context' is set
            if (context == null)
                throw new ApiException(400, "Missing required parameter 'context' when calling ContextApi->CreateContext");

            var localVarPath = "/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (context != null && context.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(context); // http body (model) parameter
            }
            else
            {
                localVarPostBody = context; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateContext", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Context>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Context) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Context)));
        }

        /// <summary>
        /// Create context Create a new context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of Context</returns>
        public async System.Threading.Tasks.Task<Context> CreateContextAsync (Context context)
        {
             ApiResponse<Context> localVarResponse = await CreateContextAsyncWithHttpInfo(context);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create context Create a new context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of ApiResponse (Context)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Context>> CreateContextAsyncWithHttpInfo (Context context)
        {
            // verify the required parameter 'context' is set
            if (context == null)
                throw new ApiException(400, "Missing required parameter 'context' when calling ContextApi->CreateContext");

            var localVarPath = "/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (context != null && context.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(context); // http body (model) parameter
            }
            else
            {
                localVarPostBody = context; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateContext", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Context>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Context) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Context)));
        }

        /// <summary>
        /// Delete context Delete an existing context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Context</returns>
        public Context DeleteContext (string context)
        {
             ApiResponse<Context> localVarResponse = DeleteContextWithHttpInfo(context);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete context Delete an existing context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>ApiResponse of Context</returns>
        public ApiResponse< Context > DeleteContextWithHttpInfo (string context)
        {
            // verify the required parameter 'context' is set
            if (context == null)
                throw new ApiException(400, "Missing required parameter 'context' when calling ContextApi->DeleteContext");

            var localVarPath = "/{context}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (context != null) localVarPathParams.Add("context", Configuration.ApiClient.ParameterToString(context)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteContext", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Context>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Context) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Context)));
        }

        /// <summary>
        /// Delete context Delete an existing context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of Context</returns>
        public async System.Threading.Tasks.Task<Context> DeleteContextAsync (string context)
        {
             ApiResponse<Context> localVarResponse = await DeleteContextAsyncWithHttpInfo(context);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete context Delete an existing context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of ApiResponse (Context)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Context>> DeleteContextAsyncWithHttpInfo (string context)
        {
            // verify the required parameter 'context' is set
            if (context == null)
                throw new ApiException(400, "Missing required parameter 'context' when calling ContextApi->DeleteContext");

            var localVarPath = "/{context}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (context != null) localVarPathParams.Add("context", Configuration.ApiClient.ParameterToString(context)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteContext", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Context>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Context) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Context)));
        }

        /// <summary>
        /// Get context Get an existing context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Context</returns>
        public Context GetContext (string context)
        {
             ApiResponse<Context> localVarResponse = GetContextWithHttpInfo(context);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get context Get an existing context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>ApiResponse of Context</returns>
        public ApiResponse< Context > GetContextWithHttpInfo (string context)
        {
            // verify the required parameter 'context' is set
            if (context == null)
                throw new ApiException(400, "Missing required parameter 'context' when calling ContextApi->GetContext");

            var localVarPath = "/{context}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (context != null) localVarPathParams.Add("context", Configuration.ApiClient.ParameterToString(context)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetContext", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Context>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Context) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Context)));
        }

        /// <summary>
        /// Get context Get an existing context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of Context</returns>
        public async System.Threading.Tasks.Task<Context> GetContextAsync (string context)
        {
             ApiResponse<Context> localVarResponse = await GetContextAsyncWithHttpInfo(context);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get context Get an existing context
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Easy.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">context</param>
        /// <returns>Task of ApiResponse (Context)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Context>> GetContextAsyncWithHttpInfo (string context)
        {
            // verify the required parameter 'context' is set
            if (context == null)
                throw new ApiException(400, "Missing required parameter 'context' when calling ContextApi->GetContext");

            var localVarPath = "/{context}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (context != null) localVarPathParams.Add("context", Configuration.ApiClient.ParameterToString(context)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetContext", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Context>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Context) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Context)));
        }

    }
}
