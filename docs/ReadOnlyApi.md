# Bess.IO.Rest.Nexus3.Api.ReadOnlyApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ForceRelease**](ReadOnlyApi.md#forcerelease) | **POST** /v1/read-only/force-release | Forcibly release read-only
[**Freeze**](ReadOnlyApi.md#freeze) | **POST** /v1/read-only/freeze | Enable read-only
[**Get**](ReadOnlyApi.md#get) | **GET** /v1/read-only | Get read-only state
[**Release**](ReadOnlyApi.md#release) | **POST** /v1/read-only/release | Release read-only


<a name="forcerelease"></a>
# **ForceRelease**
> void ForceRelease ()

Forcibly release read-only

Forcibly release read-only status, including System initiated tasks. Warning: may result in data loss.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class ForceReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReadOnlyApi();

            try
            {
                // Forcibly release read-only
                apiInstance.ForceRelease();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReadOnlyApi.ForceRelease: " + e.Message );
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

<a name="freeze"></a>
# **Freeze**
> void Freeze ()

Enable read-only

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class FreezeExample
    {
        public void main()
        {
            var apiInstance = new ReadOnlyApi();

            try
            {
                // Enable read-only
                apiInstance.Freeze();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReadOnlyApi.Freeze: " + e.Message );
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

<a name="get"></a>
# **Get**
> ReadOnlyState Get ()

Get read-only state

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            var apiInstance = new ReadOnlyApi();

            try
            {
                // Get read-only state
                ReadOnlyState result = apiInstance.Get();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReadOnlyApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ReadOnlyState**](ReadOnlyState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="release"></a>
# **Release**
> void Release ()

Release read-only

Release administrator initiated read-only status. Will not release read-only caused by system tasks.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class ReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReadOnlyApi();

            try
            {
                // Release read-only
                apiInstance.Release();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReadOnlyApi.Release: " + e.Message );
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

