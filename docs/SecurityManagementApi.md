# Bess.IO.Rest.Nexus3.Api.SecurityManagementApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserSources**](SecurityManagementApi.md#getusersources) | **GET** /v1/security/user-sources | Retrieve a list of the available user sources.


<a name="getusersources"></a>
# **GetUserSources**
> List<ApiUserSource> GetUserSources ()

Retrieve a list of the available user sources.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetUserSourcesExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementApi();

            try
            {
                // Retrieve a list of the available user sources.
                List&lt;ApiUserSource&gt; result = apiInstance.GetUserSources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementApi.GetUserSources: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ApiUserSource>**](ApiUserSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

