# Bess.IO.Rest.Nexus3.Api.LifecycleApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Bounce**](LifecycleApi.md#bounce) | **PUT** /v1/lifecycle/bounce | Bounce lifecycle phase
[**GetPhase**](LifecycleApi.md#getphase) | **GET** /v1/lifecycle/phase | Get current lifecycle phase
[**SetPhase**](LifecycleApi.md#setphase) | **PUT** /v1/lifecycle/phase | Move to new lifecycle phase


<a name="bounce"></a>
# **Bounce**
> void Bounce (string body = null)

Bounce lifecycle phase

Re-runs all phases from the given phase to the current phase

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class BounceExample
    {
        public void main()
        {
            var apiInstance = new LifecycleApi();
            var body = body_example;  // string | The phase to bounce (optional) 

            try
            {
                // Bounce lifecycle phase
                apiInstance.Bounce(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LifecycleApi.Bounce: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| The phase to bounce | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphase"></a>
# **GetPhase**
> string GetPhase ()

Get current lifecycle phase

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetPhaseExample
    {
        public void main()
        {
            var apiInstance = new LifecycleApi();

            try
            {
                // Get current lifecycle phase
                string result = apiInstance.GetPhase();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LifecycleApi.GetPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setphase"></a>
# **SetPhase**
> void SetPhase (string body = null)

Move to new lifecycle phase

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SetPhaseExample
    {
        public void main()
        {
            var apiInstance = new LifecycleApi();
            var body = body_example;  // string | The phase to move to (optional) 

            try
            {
                // Move to new lifecycle phase
                apiInstance.SetPhase(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LifecycleApi.SetPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| The phase to move to | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

