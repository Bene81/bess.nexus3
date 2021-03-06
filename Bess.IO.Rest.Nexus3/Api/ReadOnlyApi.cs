/* 
 * Nexus Repository Manager REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.30.1-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Bess.IO.Rest.Nexus3.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReadOnlyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Forcibly release read-only
        /// </summary>
        /// <remarks>
        /// Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void ForceRelease ();

        /// <summary>
        /// Forcibly release read-only
        /// </summary>
        /// <remarks>
        /// Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ForceReleaseWithHttpInfo ();
        /// <summary>
        /// Enable read-only
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void Freeze ();

        /// <summary>
        /// Enable read-only
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FreezeWithHttpInfo ();
        /// <summary>
        /// Get read-only state
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ReadOnlyState</returns>
        ReadOnlyState Get ();

        /// <summary>
        /// Get read-only state
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ReadOnlyState</returns>
        ApiResponse<ReadOnlyState> GetWithHttpInfo ();
        /// <summary>
        /// Release read-only
        /// </summary>
        /// <remarks>
        /// Release administrator initiated read-only status. Will not release read-only caused by system tasks.
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void Release ();

        /// <summary>
        /// Release read-only
        /// </summary>
        /// <remarks>
        /// Release administrator initiated read-only status. Will not release read-only caused by system tasks.
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ReleaseWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Forcibly release read-only
        /// </summary>
        /// <remarks>
        /// Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ForceReleaseAsync ();

        /// <summary>
        /// Forcibly release read-only
        /// </summary>
        /// <remarks>
        /// Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ForceReleaseAsyncWithHttpInfo ();
        /// <summary>
        /// Enable read-only
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task FreezeAsync ();

        /// <summary>
        /// Enable read-only
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> FreezeAsyncWithHttpInfo ();
        /// <summary>
        /// Get read-only state
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ReadOnlyState</returns>
        System.Threading.Tasks.Task<ReadOnlyState> GetAsync ();

        /// <summary>
        /// Get read-only state
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ReadOnlyState)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReadOnlyState>> GetAsyncWithHttpInfo ();
        /// <summary>
        /// Release read-only
        /// </summary>
        /// <remarks>
        /// Release administrator initiated read-only status. Will not release read-only caused by system tasks.
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ReleaseAsync ();

        /// <summary>
        /// Release read-only
        /// </summary>
        /// <remarks>
        /// Release administrator initiated read-only status. Will not release read-only caused by system tasks.
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReleaseAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReadOnlyApi : IReadOnlyApi
    {
        private Bess.IO.Rest.Nexus3.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReadOnlyApi(String basePath)
        {
            this.Configuration = new Bess.IO.Rest.Nexus3.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Bess.IO.Rest.Nexus3.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReadOnlyApi(Bess.IO.Rest.Nexus3.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Bess.IO.Rest.Nexus3.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Bess.IO.Rest.Nexus3.Client.Configuration.DefaultExceptionFactory;
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
        public Bess.IO.Rest.Nexus3.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Bess.IO.Rest.Nexus3.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Forcibly release read-only Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void ForceRelease ()
        {
             ForceReleaseWithHttpInfo();
        }

        /// <summary>
        /// Forcibly release read-only Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ForceReleaseWithHttpInfo ()
        {

            var localVarPath = "./v1/read-only/force-release";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ForceRelease", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Forcibly release read-only Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ForceReleaseAsync ()
        {
             await ForceReleaseAsyncWithHttpInfo();

        }

        /// <summary>
        /// Forcibly release read-only Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ForceReleaseAsyncWithHttpInfo ()
        {

            var localVarPath = "./v1/read-only/force-release";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ForceRelease", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Enable read-only 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void Freeze ()
        {
             FreezeWithHttpInfo();
        }

        /// <summary>
        /// Enable read-only 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> FreezeWithHttpInfo ()
        {

            var localVarPath = "./v1/read-only/freeze";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Freeze", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Enable read-only 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task FreezeAsync ()
        {
             await FreezeAsyncWithHttpInfo();

        }

        /// <summary>
        /// Enable read-only 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> FreezeAsyncWithHttpInfo ()
        {

            var localVarPath = "./v1/read-only/freeze";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Freeze", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get read-only state 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ReadOnlyState</returns>
        public ReadOnlyState Get ()
        {
             ApiResponse<ReadOnlyState> localVarResponse = GetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get read-only state 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ReadOnlyState</returns>
        public ApiResponse< ReadOnlyState > GetWithHttpInfo ()
        {

            var localVarPath = "./v1/read-only";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReadOnlyState>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ReadOnlyState) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadOnlyState)));
        }

        /// <summary>
        /// Get read-only state 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ReadOnlyState</returns>
        public async System.Threading.Tasks.Task<ReadOnlyState> GetAsync ()
        {
             ApiResponse<ReadOnlyState> localVarResponse = await GetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get read-only state 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ReadOnlyState)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReadOnlyState>> GetAsyncWithHttpInfo ()
        {

            var localVarPath = "./v1/read-only";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReadOnlyState>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ReadOnlyState) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadOnlyState)));
        }

        /// <summary>
        /// Release read-only Release administrator initiated read-only status. Will not release read-only caused by system tasks.
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void Release ()
        {
             ReleaseWithHttpInfo();
        }

        /// <summary>
        /// Release read-only Release administrator initiated read-only status. Will not release read-only caused by system tasks.
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ReleaseWithHttpInfo ()
        {

            var localVarPath = "./v1/read-only/release";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Release", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Release read-only Release administrator initiated read-only status. Will not release read-only caused by system tasks.
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ReleaseAsync ()
        {
             await ReleaseAsyncWithHttpInfo();

        }

        /// <summary>
        /// Release read-only Release administrator initiated read-only status. Will not release read-only caused by system tasks.
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReleaseAsyncWithHttpInfo ()
        {

            var localVarPath = "./v1/read-only/release";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Release", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

    }
}
