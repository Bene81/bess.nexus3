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
    public interface IProductLicensingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the current license status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiLicenseDetailsXO</returns>
        ApiLicenseDetailsXO GetLicenseStatus ();

        /// <summary>
        /// Get the current license status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiLicenseDetailsXO</returns>
        ApiResponse<ApiLicenseDetailsXO> GetLicenseStatusWithHttpInfo ();
        /// <summary>
        /// Uninstall license if present.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void RemoveLicense ();

        /// <summary>
        /// Uninstall license if present.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveLicenseWithHttpInfo ();
        /// <summary>
        /// Upload a new license file.
        /// </summary>
        /// <remarks>
        /// Server must be restarted to take effect
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiLicenseDetailsXO</returns>
        ApiLicenseDetailsXO SetLicense (InputStream body = null);

        /// <summary>
        /// Upload a new license file.
        /// </summary>
        /// <remarks>
        /// Server must be restarted to take effect
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ApiLicenseDetailsXO</returns>
        ApiResponse<ApiLicenseDetailsXO> SetLicenseWithHttpInfo (InputStream body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get the current license status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiLicenseDetailsXO</returns>
        System.Threading.Tasks.Task<ApiLicenseDetailsXO> GetLicenseStatusAsync ();

        /// <summary>
        /// Get the current license status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiLicenseDetailsXO)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiLicenseDetailsXO>> GetLicenseStatusAsyncWithHttpInfo ();
        /// <summary>
        /// Uninstall license if present.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveLicenseAsync ();

        /// <summary>
        /// Uninstall license if present.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveLicenseAsyncWithHttpInfo ();
        /// <summary>
        /// Upload a new license file.
        /// </summary>
        /// <remarks>
        /// Server must be restarted to take effect
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiLicenseDetailsXO</returns>
        System.Threading.Tasks.Task<ApiLicenseDetailsXO> SetLicenseAsync (InputStream body = null);

        /// <summary>
        /// Upload a new license file.
        /// </summary>
        /// <remarks>
        /// Server must be restarted to take effect
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ApiLicenseDetailsXO)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiLicenseDetailsXO>> SetLicenseAsyncWithHttpInfo (InputStream body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProductLicensingApi : IProductLicensingApi
    {
        private Bess.IO.Rest.Nexus3.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductLicensingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductLicensingApi(String basePath)
        {
            this.Configuration = new Bess.IO.Rest.Nexus3.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Bess.IO.Rest.Nexus3.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductLicensingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductLicensingApi(Bess.IO.Rest.Nexus3.Client.Configuration configuration = null)
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
        /// Get the current license status. 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiLicenseDetailsXO</returns>
        public ApiLicenseDetailsXO GetLicenseStatus ()
        {
             ApiResponse<ApiLicenseDetailsXO> localVarResponse = GetLicenseStatusWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the current license status. 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiLicenseDetailsXO</returns>
        public ApiResponse< ApiLicenseDetailsXO > GetLicenseStatusWithHttpInfo ()
        {

            var localVarPath = "./v1/system/license";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
                Exception exception = ExceptionFactory("GetLicenseStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiLicenseDetailsXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiLicenseDetailsXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiLicenseDetailsXO)));
        }

        /// <summary>
        /// Get the current license status. 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiLicenseDetailsXO</returns>
        public async System.Threading.Tasks.Task<ApiLicenseDetailsXO> GetLicenseStatusAsync ()
        {
             ApiResponse<ApiLicenseDetailsXO> localVarResponse = await GetLicenseStatusAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the current license status. 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiLicenseDetailsXO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiLicenseDetailsXO>> GetLicenseStatusAsyncWithHttpInfo ()
        {

            var localVarPath = "./v1/system/license";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
                Exception exception = ExceptionFactory("GetLicenseStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiLicenseDetailsXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiLicenseDetailsXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiLicenseDetailsXO)));
        }

        /// <summary>
        /// Uninstall license if present. 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void RemoveLicense ()
        {
             RemoveLicenseWithHttpInfo();
        }

        /// <summary>
        /// Uninstall license if present. 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RemoveLicenseWithHttpInfo ()
        {

            var localVarPath = "./v1/system/license";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveLicense", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Uninstall license if present. 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveLicenseAsync ()
        {
             await RemoveLicenseAsyncWithHttpInfo();

        }

        /// <summary>
        /// Uninstall license if present. 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RemoveLicenseAsyncWithHttpInfo ()
        {

            var localVarPath = "./v1/system/license";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveLicense", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Upload a new license file. Server must be restarted to take effect
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiLicenseDetailsXO</returns>
        public ApiLicenseDetailsXO SetLicense (InputStream body = null)
        {
             ApiResponse<ApiLicenseDetailsXO> localVarResponse = SetLicenseWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a new license file. Server must be restarted to take effect
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ApiLicenseDetailsXO</returns>
        public ApiResponse< ApiLicenseDetailsXO > SetLicenseWithHttpInfo (InputStream body = null)
        {

            var localVarPath = "./v1/system/license";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/octet-stream"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetLicense", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiLicenseDetailsXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiLicenseDetailsXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiLicenseDetailsXO)));
        }

        /// <summary>
        /// Upload a new license file. Server must be restarted to take effect
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiLicenseDetailsXO</returns>
        public async System.Threading.Tasks.Task<ApiLicenseDetailsXO> SetLicenseAsync (InputStream body = null)
        {
             ApiResponse<ApiLicenseDetailsXO> localVarResponse = await SetLicenseAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upload a new license file. Server must be restarted to take effect
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ApiLicenseDetailsXO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiLicenseDetailsXO>> SetLicenseAsyncWithHttpInfo (InputStream body = null)
        {

            var localVarPath = "./v1/system/license";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/octet-stream"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetLicense", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiLicenseDetailsXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiLicenseDetailsXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiLicenseDetailsXO)));
        }

    }
}
