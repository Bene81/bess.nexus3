# Bess.IO.Rest.Nexus3.Api.FormatsApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get1**](FormatsApi.md#get1) | **GET** /v1/formats/upload-specs | Get upload field requirements for each supported format
[**Get2**](FormatsApi.md#get2) | **GET** /v1/formats/{format}/upload-specs | Get upload field requirements for the desired format


<a name="get1"></a>
# **Get1**
> List<UploadDefinitionXO> Get1 ()

Get upload field requirements for each supported format

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class Get1Example
    {
        public void main()
        {
            var apiInstance = new FormatsApi();

            try
            {
                // Get upload field requirements for each supported format
                List&lt;UploadDefinitionXO&gt; result = apiInstance.Get1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormatsApi.Get1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UploadDefinitionXO>**](UploadDefinitionXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get2"></a>
# **Get2**
> UploadDefinitionXO Get2 (string format)

Get upload field requirements for the desired format

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class Get2Example
    {
        public void main()
        {
            var apiInstance = new FormatsApi();
            var format = format_example;  // string | The desired repository format

            try
            {
                // Get upload field requirements for the desired format
                UploadDefinitionXO result = apiInstance.Get2(format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormatsApi.Get2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| The desired repository format | 

### Return type

[**UploadDefinitionXO**](UploadDefinitionXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

