# Bess.IO.Rest.Nexus3.Api.AzureBlobStoreApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VerifyConnection1**](AzureBlobStoreApi.md#verifyconnection1) | **POST** /v1/azureblobstore/test-connection | Verify connection using supplied Azure Blob Store settings


<a name="verifyconnection1"></a>
# **VerifyConnection1**
> void VerifyConnection1 (AzureConnectionXO body = null)

Verify connection using supplied Azure Blob Store settings

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class VerifyConnection1Example
    {
        public void main()
        {
            var apiInstance = new AzureBlobStoreApi();
            var body = new AzureConnectionXO(); // AzureConnectionXO |  (optional) 

            try
            {
                // Verify connection using supplied Azure Blob Store settings
                apiInstance.VerifyConnection1(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AzureBlobStoreApi.VerifyConnection1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AzureConnectionXO**](AzureConnectionXO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

