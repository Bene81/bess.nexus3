# Bess.IO.Rest.Nexus3.Api.BlobStoreApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBlobStore**](BlobStoreApi.md#createblobstore) | **POST** /v1/blobstores/s3 | Create an S3 blob store
[**CreateBlobStore1**](BlobStoreApi.md#createblobstore1) | **POST** /v1/blobstores/azure | Create an Azure blob store
[**CreateFileBlobStore**](BlobStoreApi.md#createfileblobstore) | **POST** /v1/blobstores/file | Create a file blob store
[**DeleteBlobStore**](BlobStoreApi.md#deleteblobstore) | **DELETE** /v1/blobstores/{name} | Delete a blob store by name
[**GetBlobStore**](BlobStoreApi.md#getblobstore) | **GET** /v1/blobstores/s3/{name} | Fetch a S3 blob store configuration
[**GetBlobStore1**](BlobStoreApi.md#getblobstore1) | **GET** /v1/blobstores/azure/{name} | Fetch an Azure blob store configuration
[**GetFileBlobStoreConfiguration**](BlobStoreApi.md#getfileblobstoreconfiguration) | **GET** /v1/blobstores/file/{name} | Get a file blob store configuration by name
[**ListBlobStores**](BlobStoreApi.md#listblobstores) | **GET** /v1/blobstores | List the blob stores
[**QuotaStatus**](BlobStoreApi.md#quotastatus) | **GET** /v1/blobstores/{name}/quota-status | Get quota status for a given blob store
[**UpdateBlobStore**](BlobStoreApi.md#updateblobstore) | **PUT** /v1/blobstores/s3/{name} | Update an S3 blob store configuration
[**UpdateBlobStore1**](BlobStoreApi.md#updateblobstore1) | **PUT** /v1/blobstores/azure/{name} | Update an Azure blob store configuration
[**UpdateFileBlobStore**](BlobStoreApi.md#updatefileblobstore) | **PUT** /v1/blobstores/file/{name} | Update a file blob store configuration by name


<a name="createblobstore"></a>
# **CreateBlobStore**
> void CreateBlobStore (S3BlobStoreApiModel body = null)

Create an S3 blob store

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateBlobStoreExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var body = new S3BlobStoreApiModel(); // S3BlobStoreApiModel |  (optional) 

            try
            {
                // Create an S3 blob store
                apiInstance.CreateBlobStore(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.CreateBlobStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**S3BlobStoreApiModel**](S3BlobStoreApiModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createblobstore1"></a>
# **CreateBlobStore1**
> void CreateBlobStore1 (AzureBlobStoreApiModel body = null)

Create an Azure blob store

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateBlobStore1Example
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var body = new AzureBlobStoreApiModel(); // AzureBlobStoreApiModel |  (optional) 

            try
            {
                // Create an Azure blob store
                apiInstance.CreateBlobStore1(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.CreateBlobStore1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AzureBlobStoreApiModel**](AzureBlobStoreApiModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfileblobstore"></a>
# **CreateFileBlobStore**
> void CreateFileBlobStore (FileBlobStoreApiCreateRequest body = null)

Create a file blob store

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateFileBlobStoreExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var body = new FileBlobStoreApiCreateRequest(); // FileBlobStoreApiCreateRequest |  (optional) 

            try
            {
                // Create a file blob store
                apiInstance.CreateFileBlobStore(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.CreateFileBlobStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FileBlobStoreApiCreateRequest**](FileBlobStoreApiCreateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteblobstore"></a>
# **DeleteBlobStore**
> void DeleteBlobStore (string name)

Delete a blob store by name

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteBlobStoreExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var name = name_example;  // string | The name of the blob store to delete

            try
            {
                // Delete a blob store by name
                apiInstance.DeleteBlobStore(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.DeleteBlobStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the blob store to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblobstore"></a>
# **GetBlobStore**
> void GetBlobStore (string name)

Fetch a S3 blob store configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetBlobStoreExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var name = name_example;  // string | Name of the blob store configuration to fetch

            try
            {
                // Fetch a S3 blob store configuration
                apiInstance.GetBlobStore(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.GetBlobStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the blob store configuration to fetch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblobstore1"></a>
# **GetBlobStore1**
> void GetBlobStore1 (string name)

Fetch an Azure blob store configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetBlobStore1Example
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var name = name_example;  // string | Name of the blob store configuration to fetch

            try
            {
                // Fetch an Azure blob store configuration
                apiInstance.GetBlobStore1(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.GetBlobStore1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the blob store configuration to fetch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfileblobstoreconfiguration"></a>
# **GetFileBlobStoreConfiguration**
> FileBlobStoreApiModel GetFileBlobStoreConfiguration (string name)

Get a file blob store configuration by name

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetFileBlobStoreConfigurationExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var name = name_example;  // string | The name of the file blob store to read

            try
            {
                // Get a file blob store configuration by name
                FileBlobStoreApiModel result = apiInstance.GetFileBlobStoreConfiguration(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.GetFileBlobStoreConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the file blob store to read | 

### Return type

[**FileBlobStoreApiModel**](FileBlobStoreApiModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listblobstores"></a>
# **ListBlobStores**
> List<GenericBlobStoreApiResponse> ListBlobStores ()

List the blob stores

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class ListBlobStoresExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();

            try
            {
                // List the blob stores
                List&lt;GenericBlobStoreApiResponse&gt; result = apiInstance.ListBlobStores();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.ListBlobStores: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<GenericBlobStoreApiResponse>**](GenericBlobStoreApiResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotastatus"></a>
# **QuotaStatus**
> BlobStoreQuotaResultXO QuotaStatus (string name)

Get quota status for a given blob store

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class QuotaStatusExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var name = name_example;  // string | 

            try
            {
                // Get quota status for a given blob store
                BlobStoreQuotaResultXO result = apiInstance.QuotaStatus(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.QuotaStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**BlobStoreQuotaResultXO**](BlobStoreQuotaResultXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateblobstore"></a>
# **UpdateBlobStore**
> void UpdateBlobStore (string name, S3BlobStoreApiModel body = null)

Update an S3 blob store configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateBlobStoreExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var name = name_example;  // string | Name of the blob store to update
            var body = new S3BlobStoreApiModel(); // S3BlobStoreApiModel |  (optional) 

            try
            {
                // Update an S3 blob store configuration
                apiInstance.UpdateBlobStore(name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.UpdateBlobStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the blob store to update | 
 **body** | [**S3BlobStoreApiModel**](S3BlobStoreApiModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateblobstore1"></a>
# **UpdateBlobStore1**
> void UpdateBlobStore1 (string name, AzureBlobStoreApiModel body = null)

Update an Azure blob store configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateBlobStore1Example
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var name = name_example;  // string | Name of the blob store to update
            var body = new AzureBlobStoreApiModel(); // AzureBlobStoreApiModel |  (optional) 

            try
            {
                // Update an Azure blob store configuration
                apiInstance.UpdateBlobStore1(name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.UpdateBlobStore1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the blob store to update | 
 **body** | [**AzureBlobStoreApiModel**](AzureBlobStoreApiModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefileblobstore"></a>
# **UpdateFileBlobStore**
> void UpdateFileBlobStore (string name, FileBlobStoreApiUpdateRequest body = null)

Update a file blob store configuration by name

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateFileBlobStoreExample
    {
        public void main()
        {
            var apiInstance = new BlobStoreApi();
            var name = name_example;  // string | The name of the file blob store to update
            var body = new FileBlobStoreApiUpdateRequest(); // FileBlobStoreApiUpdateRequest |  (optional) 

            try
            {
                // Update a file blob store configuration by name
                apiInstance.UpdateFileBlobStore(name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlobStoreApi.UpdateFileBlobStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the file blob store to update | 
 **body** | [**FileBlobStoreApiUpdateRequest**](FileBlobStoreApiUpdateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

