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
    public interface IFormatsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get upload field requirements for each supported format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;UploadDefinitionXO&gt;</returns>
        List<UploadDefinitionXO> Get1 ();

        /// <summary>
        /// Get upload field requirements for each supported format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;UploadDefinitionXO&gt;</returns>
        ApiResponse<List<UploadDefinitionXO>> Get1WithHttpInfo ();
        /// <summary>
        /// Get upload field requirements for the desired format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The desired repository format</param>
        /// <returns>UploadDefinitionXO</returns>
        UploadDefinitionXO Get2 (string format);

        /// <summary>
        /// Get upload field requirements for the desired format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The desired repository format</param>
        /// <returns>ApiResponse of UploadDefinitionXO</returns>
        ApiResponse<UploadDefinitionXO> Get2WithHttpInfo (string format);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get upload field requirements for each supported format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;UploadDefinitionXO&gt;</returns>
        System.Threading.Tasks.Task<List<UploadDefinitionXO>> Get1Async ();

        /// <summary>
        /// Get upload field requirements for each supported format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;UploadDefinitionXO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UploadDefinitionXO>>> Get1AsyncWithHttpInfo ();
        /// <summary>
        /// Get upload field requirements for the desired format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The desired repository format</param>
        /// <returns>Task of UploadDefinitionXO</returns>
        System.Threading.Tasks.Task<UploadDefinitionXO> Get2Async (string format);

        /// <summary>
        /// Get upload field requirements for the desired format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The desired repository format</param>
        /// <returns>Task of ApiResponse (UploadDefinitionXO)</returns>
        System.Threading.Tasks.Task<ApiResponse<UploadDefinitionXO>> Get2AsyncWithHttpInfo (string format);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FormatsApi : IFormatsApi
    {
        private Bess.IO.Rest.Nexus3.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FormatsApi(String basePath)
        {
            this.Configuration = new Bess.IO.Rest.Nexus3.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Bess.IO.Rest.Nexus3.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FormatsApi(Bess.IO.Rest.Nexus3.Client.Configuration configuration = null)
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
        /// Get upload field requirements for each supported format 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;UploadDefinitionXO&gt;</returns>
        public List<UploadDefinitionXO> Get1 ()
        {
             ApiResponse<List<UploadDefinitionXO>> localVarResponse = Get1WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get upload field requirements for each supported format 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;UploadDefinitionXO&gt;</returns>
        public ApiResponse< List<UploadDefinitionXO> > Get1WithHttpInfo ()
        {

            var localVarPath = "./v1/formats/upload-specs";
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
                Exception exception = ExceptionFactory("Get1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UploadDefinitionXO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<UploadDefinitionXO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UploadDefinitionXO>)));
        }

        /// <summary>
        /// Get upload field requirements for each supported format 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;UploadDefinitionXO&gt;</returns>
        public async System.Threading.Tasks.Task<List<UploadDefinitionXO>> Get1Async ()
        {
             ApiResponse<List<UploadDefinitionXO>> localVarResponse = await Get1AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get upload field requirements for each supported format 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;UploadDefinitionXO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UploadDefinitionXO>>> Get1AsyncWithHttpInfo ()
        {

            var localVarPath = "./v1/formats/upload-specs";
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
                Exception exception = ExceptionFactory("Get1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UploadDefinitionXO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<UploadDefinitionXO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UploadDefinitionXO>)));
        }

        /// <summary>
        /// Get upload field requirements for the desired format 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The desired repository format</param>
        /// <returns>UploadDefinitionXO</returns>
        public UploadDefinitionXO Get2 (string format)
        {
             ApiResponse<UploadDefinitionXO> localVarResponse = Get2WithHttpInfo(format);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get upload field requirements for the desired format 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The desired repository format</param>
        /// <returns>ApiResponse of UploadDefinitionXO</returns>
        public ApiResponse< UploadDefinitionXO > Get2WithHttpInfo (string format)
        {
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling FormatsApi->Get2");

            var localVarPath = "./v1/formats/{format}/upload-specs";
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

            if (format != null) localVarPathParams.Add("format", this.Configuration.ApiClient.ParameterToString(format)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UploadDefinitionXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (UploadDefinitionXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadDefinitionXO)));
        }

        /// <summary>
        /// Get upload field requirements for the desired format 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The desired repository format</param>
        /// <returns>Task of UploadDefinitionXO</returns>
        public async System.Threading.Tasks.Task<UploadDefinitionXO> Get2Async (string format)
        {
             ApiResponse<UploadDefinitionXO> localVarResponse = await Get2AsyncWithHttpInfo(format);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get upload field requirements for the desired format 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The desired repository format</param>
        /// <returns>Task of ApiResponse (UploadDefinitionXO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UploadDefinitionXO>> Get2AsyncWithHttpInfo (string format)
        {
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling FormatsApi->Get2");

            var localVarPath = "./v1/formats/{format}/upload-specs";
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

            if (format != null) localVarPathParams.Add("format", this.Configuration.ApiClient.ParameterToString(format)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UploadDefinitionXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (UploadDefinitionXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadDefinitionXO)));
        }

    }
}
