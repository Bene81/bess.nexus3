# Bess.IO.Rest.Nexus3.Api.StatusApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSystemStatusChecks**](StatusApi.md#getsystemstatuschecks) | **GET** /v1/status/check | Health check endpoint that returns the results of the system status checks
[**IsAvailable**](StatusApi.md#isavailable) | **GET** /v1/status | Health check endpoint that validates server can respond to read requests
[**IsWritable**](StatusApi.md#iswritable) | **GET** /v1/status/writable | Health check endpoint that validates server can respond to read and write requests


<a name="getsystemstatuschecks"></a>
# **GetSystemStatusChecks**
> Dictionary<string, Result> GetSystemStatusChecks ()

Health check endpoint that returns the results of the system status checks

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetSystemStatusChecksExample
    {
        public void main()
        {
            var apiInstance = new StatusApi();

            try
            {
                // Health check endpoint that returns the results of the system status checks
                Dictionary&lt;string, Result&gt; result = apiInstance.GetSystemStatusChecks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusApi.GetSystemStatusChecks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Dictionary<string, Result>**](Result.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="isavailable"></a>
# **IsAvailable**
> void IsAvailable ()

Health check endpoint that validates server can respond to read requests

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class IsAvailableExample
    {
        public void main()
        {
            var apiInstance = new StatusApi();

            try
            {
                // Health check endpoint that validates server can respond to read requests
                apiInstance.IsAvailable();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusApi.IsAvailable: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iswritable"></a>
# **IsWritable**
> void IsWritable ()

Health check endpoint that validates server can respond to read and write requests

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class IsWritableExample
    {
        public void main()
        {
            var apiInstance = new StatusApi();

            try
            {
                // Health check endpoint that validates server can respond to read and write requests
                apiInstance.IsWritable();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusApi.IsWritable: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

