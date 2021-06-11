# Bess.IO.Rest.Nexus3.Api.AssetsApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAsset**](AssetsApi.md#deleteasset) | **DELETE** /v1/assets/{id} | Delete a single asset
[**GetAssetById**](AssetsApi.md#getassetbyid) | **GET** /v1/assets/{id} | Get a single asset
[**GetAssets**](AssetsApi.md#getassets) | **GET** /v1/assets | List assets


<a name="deleteasset"></a>
# **DeleteAsset**
> void DeleteAsset (string id)

Delete a single asset

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteAssetExample
    {
        public void main()
        {
            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Id of the asset to delete

            try
            {
                // Delete a single asset
                apiInstance.DeleteAsset(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.DeleteAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the asset to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetbyid"></a>
# **GetAssetById**
> AssetXO GetAssetById (string id)

Get a single asset

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetAssetByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetsApi();
            var id = id_example;  // string | Id of the asset to get

            try
            {
                // Get a single asset
                AssetXO result = apiInstance.GetAssetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAssetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the asset to get | 

### Return type

[**AssetXO**](AssetXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassets"></a>
# **GetAssets**
> PageAssetXO GetAssets (string repository, string continuationToken = null)

List assets

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetAssetsExample
    {
        public void main()
        {
            var apiInstance = new AssetsApi();
            var repository = repository_example;  // string | Repository from which you would like to retrieve assets.
            var continuationToken = continuationToken_example;  // string | A token returned by a prior request. If present, the next page of results are returned (optional) 

            try
            {
                // List assets
                PageAssetXO result = apiInstance.GetAssets(repository, continuationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repository** | **string**| Repository from which you would like to retrieve assets. | 
 **continuationToken** | **string**| A token returned by a prior request. If present, the next page of results are returned | [optional] 

### Return type

[**PageAssetXO**](PageAssetXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

