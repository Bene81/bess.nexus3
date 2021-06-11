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
    public interface IAssetsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a single asset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to delete</param>
        /// <returns></returns>
        void DeleteAsset (string id);

        /// <summary>
        /// Delete a single asset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAssetWithHttpInfo (string id);
        /// <summary>
        /// Get a single asset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to get</param>
        /// <returns>AssetXO</returns>
        AssetXO GetAssetById (string id);

        /// <summary>
        /// Get a single asset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to get</param>
        /// <returns>ApiResponse of AssetXO</returns>
        ApiResponse<AssetXO> GetAssetByIdWithHttpInfo (string id);
        /// <summary>
        /// List assets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repository">Repository from which you would like to retrieve assets.</param>
        /// <param name="continuationToken">A token returned by a prior request. If present, the next page of results are returned (optional)</param>
        /// <returns>PageAssetXO</returns>
        PageAssetXO GetAssets (string repository, string continuationToken = null);

        /// <summary>
        /// List assets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repository">Repository from which you would like to retrieve assets.</param>
        /// <param name="continuationToken">A token returned by a prior request. If present, the next page of results are returned (optional)</param>
        /// <returns>ApiResponse of PageAssetXO</returns>
        ApiResponse<PageAssetXO> GetAssetsWithHttpInfo (string repository, string continuationToken = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a single asset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAssetAsync (string id);

        /// <summary>
        /// Delete a single asset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssetAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get a single asset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to get</param>
        /// <returns>Task of AssetXO</returns>
        System.Threading.Tasks.Task<AssetXO> GetAssetByIdAsync (string id);

        /// <summary>
        /// Get a single asset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to get</param>
        /// <returns>Task of ApiResponse (AssetXO)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetXO>> GetAssetByIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// List assets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repository">Repository from which you would like to retrieve assets.</param>
        /// <param name="continuationToken">A token returned by a prior request. If present, the next page of results are returned (optional)</param>
        /// <returns>Task of PageAssetXO</returns>
        System.Threading.Tasks.Task<PageAssetXO> GetAssetsAsync (string repository, string continuationToken = null);

        /// <summary>
        /// List assets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repository">Repository from which you would like to retrieve assets.</param>
        /// <param name="continuationToken">A token returned by a prior request. If present, the next page of results are returned (optional)</param>
        /// <returns>Task of ApiResponse (PageAssetXO)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAssetXO>> GetAssetsAsyncWithHttpInfo (string repository, string continuationToken = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AssetsApi : IAssetsApi
    {
        private Bess.IO.Rest.Nexus3.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetsApi(String basePath)
        {
            this.Configuration = new Bess.IO.Rest.Nexus3.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Bess.IO.Rest.Nexus3.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AssetsApi(Bess.IO.Rest.Nexus3.Client.Configuration configuration = null)
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
        /// Delete a single asset 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to delete</param>
        /// <returns></returns>
        public void DeleteAsset (string id)
        {
             DeleteAssetWithHttpInfo(id);
        }

        /// <summary>
        /// Delete a single asset 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAssetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetsApi->DeleteAsset");

            var localVarPath = "./v1/assets/{id}";
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

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAsset", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a single asset 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAssetAsync (string id)
        {
             await DeleteAssetAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Delete a single asset 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetsApi->DeleteAsset");

            var localVarPath = "./v1/assets/{id}";
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

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAsset", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a single asset 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to get</param>
        /// <returns>AssetXO</returns>
        public AssetXO GetAssetById (string id)
        {
             ApiResponse<AssetXO> localVarResponse = GetAssetByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single asset 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to get</param>
        /// <returns>ApiResponse of AssetXO</returns>
        public ApiResponse< AssetXO > GetAssetByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetsApi->GetAssetById");

            var localVarPath = "./v1/assets/{id}";
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

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAssetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AssetXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (AssetXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssetXO)));
        }

        /// <summary>
        /// Get a single asset 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to get</param>
        /// <returns>Task of AssetXO</returns>
        public async System.Threading.Tasks.Task<AssetXO> GetAssetByIdAsync (string id)
        {
             ApiResponse<AssetXO> localVarResponse = await GetAssetByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single asset 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the asset to get</param>
        /// <returns>Task of ApiResponse (AssetXO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AssetXO>> GetAssetByIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetsApi->GetAssetById");

            var localVarPath = "./v1/assets/{id}";
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

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAssetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AssetXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (AssetXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssetXO)));
        }

        /// <summary>
        /// List assets 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repository">Repository from which you would like to retrieve assets.</param>
        /// <param name="continuationToken">A token returned by a prior request. If present, the next page of results are returned (optional)</param>
        /// <returns>PageAssetXO</returns>
        public PageAssetXO GetAssets (string repository, string continuationToken = null)
        {
             ApiResponse<PageAssetXO> localVarResponse = GetAssetsWithHttpInfo(repository, continuationToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List assets 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repository">Repository from which you would like to retrieve assets.</param>
        /// <param name="continuationToken">A token returned by a prior request. If present, the next page of results are returned (optional)</param>
        /// <returns>ApiResponse of PageAssetXO</returns>
        public ApiResponse< PageAssetXO > GetAssetsWithHttpInfo (string repository, string continuationToken = null)
        {
            // verify the required parameter 'repository' is set
            if (repository == null)
                throw new ApiException(400, "Missing required parameter 'repository' when calling AssetsApi->GetAssets");

            var localVarPath = "./v1/assets";
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

            if (continuationToken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "continuationToken", continuationToken)); // query parameter
            if (repository != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "repository", repository)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAssets", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageAssetXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (PageAssetXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAssetXO)));
        }

        /// <summary>
        /// List assets 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repository">Repository from which you would like to retrieve assets.</param>
        /// <param name="continuationToken">A token returned by a prior request. If present, the next page of results are returned (optional)</param>
        /// <returns>Task of PageAssetXO</returns>
        public async System.Threading.Tasks.Task<PageAssetXO> GetAssetsAsync (string repository, string continuationToken = null)
        {
             ApiResponse<PageAssetXO> localVarResponse = await GetAssetsAsyncWithHttpInfo(repository, continuationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List assets 
        /// </summary>
        /// <exception cref="Bess.IO.Rest.Nexus3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repository">Repository from which you would like to retrieve assets.</param>
        /// <param name="continuationToken">A token returned by a prior request. If present, the next page of results are returned (optional)</param>
        /// <returns>Task of ApiResponse (PageAssetXO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAssetXO>> GetAssetsAsyncWithHttpInfo (string repository, string continuationToken = null)
        {
            // verify the required parameter 'repository' is set
            if (repository == null)
                throw new ApiException(400, "Missing required parameter 'repository' when calling AssetsApi->GetAssets");

            var localVarPath = "./v1/assets";
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

            if (continuationToken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "continuationToken", continuationToken)); // query parameter
            if (repository != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "repository", repository)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAssets", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageAssetXO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (PageAssetXO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAssetXO)));
        }

    }
}
