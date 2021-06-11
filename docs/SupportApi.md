# Bess.IO.Rest.Nexus3.Api.SupportApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Supportzip**](SupportApi.md#supportzip) | **POST** /v1/support/supportzip | Creates and downloads a support zip
[**Supportzippath**](SupportApi.md#supportzippath) | **POST** /v1/support/supportzippath | Creates a support zip and returns the path


<a name="supportzip"></a>
# **Supportzip**
> void Supportzip (Request body = null)

Creates and downloads a support zip

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SupportzipExample
    {
        public void main()
        {
            var apiInstance = new SupportApi();
            var body = new Request(); // Request |  (optional) 

            try
            {
                // Creates and downloads a support zip
                apiInstance.Supportzip(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupportApi.Supportzip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Request**](Request.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="supportzippath"></a>
# **Supportzippath**
> SupportZipXO Supportzippath (Request body = null)

Creates a support zip and returns the path

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SupportzippathExample
    {
        public void main()
        {
            var apiInstance = new SupportApi();
            var body = new Request(); // Request |  (optional) 

            try
            {
                // Creates a support zip and returns the path
                SupportZipXO result = apiInstance.Supportzippath(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupportApi.Supportzippath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Request**](Request.md)|  | [optional] 

### Return type

[**SupportZipXO**](SupportZipXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

